namespace Tippytappy.Nodes;

public class Paragraph : ITiptapNode
{
    public string Name => "paragraph";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        if (context.ShouldRenderInnerNode())
        {
            context.Append("<p>");
        }

        next();
        
        if (context.ShouldRenderInnerNode()) {
            context.AppendLine("</p>");
        }
    }
}