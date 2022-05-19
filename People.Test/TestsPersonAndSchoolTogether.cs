using Xunit;

namespace People.Test
{
    public class TestsPersonAndSchoolTogether
    {
        private readonly BasePersonTests _personTestsHelper = new BasePersonTests();
        private readonly BaseSchoolTests _schoolTestsHelper = new BaseSchoolTests();
        [Fact]
        public void MathieuWithComputerScienceShouldAcceptHelhaSchool()
        {
            var m = _personTestsHelper.BuildMathieuAsStudent();
            var h = _schoolTestsHelper.BuildHelhaTournai();

            m.CurrentSchool = h;
            
            Assert.Equal(h, m.CurrentSchool);
        }
    }
}