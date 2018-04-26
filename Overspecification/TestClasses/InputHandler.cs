namespace Overspecification.TestClasses
{
    public class InputHandler
    {
        public int Handle(string input)
        {
            return Calculate(input.Length);
        }

        private int Calculate(int inputLength)
        {
            return inputLength % 2;
        }
    }
}
