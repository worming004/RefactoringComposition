namespace People
{
    public class Student : Person
    {
        private School? _currentSchool;

        public School? CurrentSchool
        {
            get => _currentSchool;
        }

        public bool TrySetSchool(School s)
        {
            if (s is not null && (Attrait & s.Attrait) == Attrait)
            {
                _currentSchool = s;
                return true;
            }

            return false;
        }

        public Attrait Attrait { get; set; }
    }
}