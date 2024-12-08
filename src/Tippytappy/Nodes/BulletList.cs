namespace Tippytappy.Nodes;

public class BulletList : ITiptapNode
{
    public string Name => "bulletList";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.AppendLine("<ul>");
        next();
        context.AppendLine("</ul>");
    }
}