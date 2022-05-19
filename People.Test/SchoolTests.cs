using Xunit;

namespace People.Test
{
    public class SchoolTests : BaseSchoolTests
    {
        [Fact]
        public void HelhaShouldBePublic()
        {
            var h = BuildHelhaTournai();
            Assert.True(h.IsPublic);
        }
    }
}