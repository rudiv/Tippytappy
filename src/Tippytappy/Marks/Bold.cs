namespace Tippytappy.Marks;

public class Bold : ITiptapMark
{
    public string Name => "bold";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<strong>");
        next();
        context.Append("</strong>");
    }
}