namespace Students
{
    internal class Student
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
        public double getGrade()
        {
            return this.Grade;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName, this.SecondName, this.Grade);
        }
    }
}