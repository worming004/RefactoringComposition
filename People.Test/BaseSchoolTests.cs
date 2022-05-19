namespace People.Test
{
    public class BaseSchoolTests
    {
        public School BuildHelhaTournai()
        {
            return new() {Name = "Helha", IsPublic = true, CityName = "Tournai", Attrait = Attrait.ComputerScience};
        }
    }
}