using System.Text.Json;

namespace Tippytappy;

public class Tippytappy
{
    private readonly Dictionary<string, ITiptapExtension> extensions = [];
    
    public Tippytappy(TippytappyConfiguration configuration)
    {
        foreach(var extensionType in configuration.Extensions)
        {
            if (Activator.CreateInstance(extensionType) is not ITiptapExtension extension)
            {
                throw new InvalidOperationException("Invalid extension type");
            }
            extensions.Add(extension.Name, extension);
        }
    }
    
    public string Render(TiptapJsonNode node)
    {
        var context = new RenderContext(this);
        RenderInternal(node, context);
        return context.ToString();
    }

    public string Render(string json)
    {
        var node = JsonSerializer.Deserialize<TiptapJsonNode>(json);
        if (node == null)
        {
            throw new InvalidOperationException("No tiptap node found");
        }
        return Render(node);
    }
    
    internal ITiptapExtension ExtensionFor(string type)
    {
        if (!extensions.TryGetValue(type, out var extension))
        {
            throw new InvalidOperationException("No extension found for type " + type);
        }
        return extension;
    }

    private void RenderInternal(TiptapJsonNode node, RenderContext context)
    {
        ExtensionFor(node.Type).Render(node, context, () => {
            if (node.Content != null)
            {
                foreach(var child in node.Content)
                {
                    RenderInternal(child, context);
                }
            }
        });
    }
}