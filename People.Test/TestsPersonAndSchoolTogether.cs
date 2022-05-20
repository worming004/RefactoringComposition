using Xunit;

namespace People.Test
{
    public class TestsPersonAndSchoolTogether
    {
        private readonly BasePersonTests _personTestsHelper = new();
        private readonly BaseSchoolTests _schoolTestsHelper = new();

        [Fact]
        public void MathieuWithComputerScienceShouldAcceptHelhaSchool()
        {
            var m = _personTestsHelper.BuildMathieuAsStudent();
            var h = _schoolTestsHelper.BuildHelhaTournai();

            Assert.True(m.TrySetSchool(h));

            Assert.Equal(h, m.CurrentSchool);
        }
    }
}