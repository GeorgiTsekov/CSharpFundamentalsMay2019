

namespace P04Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}: {this.Grade:F2}";
        }
    }
}
