namespace Overspecification.TestClasses
{
    public class InputTransformator : IInputTransformator
    {
        public const string Prefix = "transformed";

        public string Transform(string input)
        {
            return $"{Prefix} @ {input}";
        }
    }
}
