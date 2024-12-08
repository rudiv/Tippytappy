namespace Tippytappy.Nodes;

public class HorizontalRule : ITiptapNode
{
    public string Name => "horizontalRule";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.AppendLine("<hr/>");
        next();
    }
}