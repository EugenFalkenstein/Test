using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private Hello _sut;

        public UnitTest1()
        {
            _sut = new Hello();
        }

        [Theory]
        [InlineData("")]
        [InlineData("test")]
        [InlineData("test2")]
        [InlineData("test3")]
        public void Test1(string value)
        {
            //with

            //execute
            var ret = _sut.Echo(value);

            //then
            Xunit.Assert.Equal(ret,value);
        }
    }
}
