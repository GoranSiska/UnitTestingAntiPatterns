namespace Composition.TestClasses
{
    public class InputTransformator : IInputTransformator
    {
        public const string Prefix = "transformed";

        public string LastTransformedInput { get; private set; }

        public string Transform(string input)
        {
            LastTransformedInput = $"{Prefix} @ {input}";

            return LastTransformedInput;
        }
    }
}
