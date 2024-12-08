namespace Tippytappy.Marks;

public class Italic : ITiptapMark
{
    public string Name => "italic";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<em>");
        next();
        context.Append("</em>");
    }
}