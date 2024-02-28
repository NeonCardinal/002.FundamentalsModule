//Objects and classes - exercise, Task 004
//28.02.2024, 00:04

List<Students> studentsList = new List<Students>();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ").ToArray();
    string firstName = input[0];
    string lastName = input[1];
    double grade = double.Parse(input[2]);

    Students student = new Students();

    student.Name = firstName;
    student.LastName = lastName;
    student.Grade = grade;

    studentsList.Add(student);
}

List<Students> sortedStudents = studentsList.OrderByDescending(stud => stud.Grade).ToList();

foreach(var item in sortedStudents)
{
    Console.WriteLine($"{item.Name} {item.LastName}: {item.Grade:F2}");
}

public class Students
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}