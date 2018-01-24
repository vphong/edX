using System;
using Xunit;
using myLib;

namespace myTests
{
    public class MathHelper_MaxShould
    {
        // setup for tests - to avoid rewriting code
        private readonly MathHelper _mathHelper;

        public MathHelper_MaxShould() 
        {
            _mathHelper = new MathHelper();
        }

        [Fact]
        public void Return0GivenValuesOf0()
        {
            // var mathHelper = new MathHelper(); 

            var result = _mathHelper.Max(0,0);

            // if (result == 0) 
            // {
            //     Console.WriteLine("Success");
            // }
            // else`
            // {
            //     Console.WriteLine("Failed");
            // }

            Assert.Equal(0, result);
        }
    }
}
