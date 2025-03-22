using System;

namespace Odev5_Grade_Management
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Grades = new List<int>();//Bu int[] gibi bir şey, bir sonraki konumuzda detaylıca öğreneceksiniz
        }
     public List<int> Grades { get; set; }

    public void AddGrade(int grade)
    {
        Grades.Add(grade);
        Console.WriteLine($"{Name} adlı öğrenciye {grade} notu eklendi.");
    }

    public double CalculateAverage()
    {
        return Grades.Average();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} adlı öğrencinin not ortalaması: {CalculateAverage():N2}");
    }
}
    }

