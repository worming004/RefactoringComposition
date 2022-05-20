namespace People
{
    public class Student : Person
    {
        public School? CurrentSchool { get; private set; }

        public Attrait Attrait { get; set; }

        public bool TrySetSchool(School s)
        {
            if (s is not null && (Attrait & s.Attrait) == Attrait)
            {
                CurrentSchool = s;
                return true;
            }

            return false;
        }
    }
}