//Objects and classes - lab, Task 005
//24.02.2024, 19:15

string command = Console.ReadLine();
List<Students> students = new List<Students>();

while (true)
{
    if (command == "end")
    {
        break;
    }

    string[] tokens = command.Split();

    string firstName = tokens[0];
    string lastName = tokens[1];
    int age = int.Parse(tokens[2]);
    string town = tokens[3];

    if (IsStutentExisting(students, firstName, lastName))
    {
        Students student = GetStudent(students, firstName, lastName);

        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.HomeTown = town;
    }
    else
    {
        Students student = new Students()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = town
        };

        students.Add(student);
    }

    command = Console.ReadLine();
}

string filterTown = Console.ReadLine();

foreach (Students student in students)
{
    if (filterTown == student.HomeTown)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

static bool IsStutentExisting(List<Students> list, string firsName, string lastName)
{
    foreach (var item in list)
    {
        if (item.FirstName == firsName && item.LastName == lastName)
        {
            return true;
        }
    }

    return false;
}

static Students GetStudent(List<Students> list, string firsName, string lastName)
{
    Students existingStudent = null;

    foreach (Students student in list)
    {
        if (student.FirstName == firsName && student.LastName == lastName)
        {
            existingStudent = student;
        }
    }

    return existingStudent;
}

class Students
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