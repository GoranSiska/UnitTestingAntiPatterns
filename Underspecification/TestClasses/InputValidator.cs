using System;

namespace Underspecification.TestClasses
{
    public class InputValidator : IInputValidator
    {
        public int Validate(int input)
        {
            if (input < 100)
            {
                //throw new ArgumentException("Specified argument was out of the range of valid values.Parameter name: input");
                throw new ArgumentOutOfRangeException("inputs");
            }
            return input;
        }
    }
}
