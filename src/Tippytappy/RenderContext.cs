using System.Text;

namespace Tippytappy;

public class RenderContext(Tippytappy tippytappy)
{
    private readonly StringBuilder builder = new();
    private bool disableInnerNodeRender = false;

    public void Append(string text)
    {
        builder.Append(text);
    }
    
    public void AppendLine(string text)
    {
        builder.AppendLine(text);
    }

    public ITiptapExtension ExtensionFor(string type)
    {
        return tippytappy.ExtensionFor(type);
    }

    public override string ToString()
    {
        return builder.ToString();
    }
    
    public bool ShouldRenderInnerNode()
    {
        return !disableInnerNodeRender;
    }

    public void ToggleChildElementRender()
    {
        disableInnerNodeRender = !disableInnerNodeRender;
    }
}