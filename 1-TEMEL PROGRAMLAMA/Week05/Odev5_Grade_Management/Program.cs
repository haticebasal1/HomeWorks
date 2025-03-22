namespace Odev5_Grade_Management;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Grade Management App");
        Student[] students = [
            new Student("Ayhan"),
            new Student("Cemal"),
            new Student("Osimhen"),
            new Student("Ceren")
        ];

        Random random = new Random();
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                int grade = random.Next(1, 101);
                students[i].AddGrade(grade);
            }
        }
        Student topStudent = students[0];
        for (int i = 0; i < students.Length; i++)
        {
            students[i].DisplayInfo();
            if (students[i].CalculateAverage() > topStudent.CalculateAverage())
            {
                topStudent = students[i];
            }
        }
        Console.WriteLine($"En yüksek ortalamaya sahip öğrenci: {topStudent.Name}");
        Console.WriteLine($"Ortalaması: {topStudent.CalculateAverage():N2}");
    }
}
    

