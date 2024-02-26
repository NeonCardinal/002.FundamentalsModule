//Objects and classes - lab, Task 004
//24.02.2024, 18:50

List<Student> students = new();

ReadStudents(students);

string city = Console.ReadLine();

PrintStudent(students, city);


void ReadStudents(List<Student> st)
{
    while(true)
    {
        string input = Console.ReadLine();

        if(input == "end")
        {
            break;
        }

        string[] tokens = input.Split(" ").ToArray();

        Student student = new Student();

        student.FirstName = tokens[0];
        student.LastName = tokens[1];
        student.Age = int.Parse(tokens[2]);
        student.HomeTown = tokens[3];

        students.Add(student);
    }
}

void PrintStudent(List<Student> st, string city)
{
    foreach(var student in st)
    {
        if(student.HomeTown == city)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }
}

class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private string homeTown;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}