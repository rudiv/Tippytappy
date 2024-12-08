namespace Tippytappy.Nodes;

public class Paragraph : ITiptapNode
{
    public string Name => "paragraph";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<p>");
        next();
        context.AppendLine("</p>");
    }
}