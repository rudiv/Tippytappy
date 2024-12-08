namespace Tippytappy.Nodes;

public class Text : ITiptapNode
{
    public string Name => "text";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        if (node.Marks != null && node.Marks.Count != 0)
        {
            RenderMarks(node, context, 0);
        }
        else if (node.Text != null)
        {
            context.Append(node.Text);
        }
    }

    private void RenderMarks(TiptapJsonNode node, RenderContext context, int index)
    {
        if (index < node.Marks!.Count)
        {
            var mark = node.Marks[index];
            var markExtension = context.ExtensionFor(mark.Type);
            markExtension.Render(node, context, () => RenderMarks(node, context, index + 1));
        }
        else if (node.Text != null)
        {
            context.Append(node.Text);
        }
    }
}