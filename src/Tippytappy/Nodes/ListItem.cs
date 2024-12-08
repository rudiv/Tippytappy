namespace Tippytappy.Nodes;

public class ListItem : ITiptapNode
{
    public string Name => "listItem";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.AppendLine("<li>");
        next();
        context.AppendLine("</li>");
    }
}