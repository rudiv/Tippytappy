namespace Tippytappy.Nodes;

public class HardBreak : ITiptapNode
{
    public string Name => "hardBreak";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.AppendLine("<br/>");
        next();
    }
}