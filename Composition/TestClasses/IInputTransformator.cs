namespace Composition.TestClasses
{
    public interface IInputTransformator
    {
        string LastTransformedInput { get; }
        string Transform(string input);
    }
}
