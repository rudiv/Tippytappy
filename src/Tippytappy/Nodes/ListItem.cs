namespace Tippytappy.Nodes;

public class ListItem : ITiptapNode
{
    public string Name => "listItem";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.AppendLine("<li>");
        context.ToggleChildElementRender();
        next();
        context.ToggleChildElementRender();
        context.AppendLine("</li>");
    }
}