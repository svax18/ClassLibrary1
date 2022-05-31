using System;
using ClassLibrary1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 obj = new Class1();
            //arrang
            int Length;
            string[] strings = { "hello world" };

            //act
            Length = obj.StringLengths(strings);

            //assert
            Assert.Equal(5, Length);

        }
    }
}
