namespace Tippytappy;

public interface ITiptapMark : ITiptapExtension
{
    TiptapExtensionType ITiptapExtension.Type => TiptapExtensionType.Mark;
}