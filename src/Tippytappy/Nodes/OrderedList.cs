namespace Tippytappy.Nodes;

public class OrderedList : ITiptapNode
{
    public string Name => "orderedList";
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<ol");
        if (node.Attrs?.TryGetValue("start", out var start) == true)
        {
            context.Append(" start=\"");
            context.Append(start.ToString() ?? "1");
            context.Append("\"");
        }
        context.AppendLine(">");
        next();
        context.AppendLine("</ol>");
    }
}