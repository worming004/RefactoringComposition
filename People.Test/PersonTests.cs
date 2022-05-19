using Xunit;

namespace People.Test
{
    public class PersonTests : BasePersonTests
    {
        [Fact]
        public void PersonHaveName()
        {
            var m = BuildMathieuAsStudent();
            Assert.Equal("Mathieu", m.FirstName);
        }
    }
}