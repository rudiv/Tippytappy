namespace Tippytappy;

public class TippytappyConfiguration
{
    internal List<Type> Extensions { get; set; } = [];

    public TippytappyConfiguration AddExtension<TExtension>()
        where TExtension : ITiptapExtension

    {
        Extensions.Add(typeof(TExtension));
        return this;
    }
}
