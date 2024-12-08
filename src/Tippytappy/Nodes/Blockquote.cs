namespace Tippytappy.Nodes;

public class Blockquote : ITiptapNode
{
    public string Name => "blockquote";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<blockquote>");
        next();
        context.Append("</blockquote>");
    }
}