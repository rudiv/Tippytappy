namespace Tippytappy.Marks;

public class Code : ITiptapMark
{
    public string Name => "code";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<code>");
        next();
        context.Append("</code>");
    }
}