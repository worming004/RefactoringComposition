using Xunit;

namespace People.Test
{
    public class SchoolTests
    {
        private readonly BaseSchoolTests _schoolTestsHelper = new BaseSchoolTests();
        [Fact]
        public void HelhaShouldBePublic()
        {
            var h = _schoolTestsHelper.BuildHelhaTournai();
            Assert.True(h.IsPublic);
        }
    }
}