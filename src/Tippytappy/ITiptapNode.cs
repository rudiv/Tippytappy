namespace Tippytappy;

public interface ITiptapNode : ITiptapExtension
{
    TiptapExtensionType ITiptapExtension.Type => TiptapExtensionType.Node;
}