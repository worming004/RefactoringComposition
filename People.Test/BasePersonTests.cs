namespace People.Test
{
    public class BasePersonTests
    {
        internal Student BuildMathieuAsStudent()
        {
            return new Student
                {FirstName = "Mathieu", LastName = "Scolas", Attrait = Attrait.ComputerScience | Attrait.Math};
        }
    }
}