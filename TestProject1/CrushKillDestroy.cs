using System;
using ClassLibrary1;
using Xunit;

namespace TestProject1
{
    public class CrushKillDestroy
    {
        [Fact]
        public void Test1()
        {
            Class1 obj = new Class1();
            //arrang
            int length;
            string[] strings = { "hello world" };

            //act
            length = obj.StringLengths(strings);

            //assert
            Assert.Equal(, length)}
        }
    }
}
