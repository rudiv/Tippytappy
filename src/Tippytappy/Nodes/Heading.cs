namespace Tippytappy.Nodes;

public class Heading : ITiptapNode
{
    public string Name => "heading";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        var tag = "h1";
        if (node.Attrs?.TryGetValue("level", out var level) == true)
        {
            tag = $"h{level}";
        }

        context.Append("<");
        context.Append(tag);
        context.Append(">");
        next();
        context.Append("</");
        context.Append(tag);
        context.AppendLine(">");
    }
}