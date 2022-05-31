using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int StringLengths(string[] strings)
        {
            int result = 0;

            foreach (var str in strings)
            {
                result += str.Length;
            }

            return result;
        }
    }
}
