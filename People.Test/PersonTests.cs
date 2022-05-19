using Xunit;

namespace People.Test
{
    public class PersonTests
    {
        private readonly BasePersonTests _personTestsHelper = new BasePersonTests();
        
        [Fact]
        public void PersonHaveName()
        {
            var m = _personTestsHelper.BuildMathieuAsStudent();
            Assert.Equal("Mathieu", m.FirstName);
        }
    }
}