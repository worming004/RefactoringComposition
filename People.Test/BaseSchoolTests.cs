namespace People.Test
{
    public class BaseSchoolTests
    {
        public School BuildHelhaTournai()
        {
            return new School
                {Name = "Helha", IsPublic = true, CityName = "Tournai", Attrait = Attrait.ComputerScience};
        }
    }
}