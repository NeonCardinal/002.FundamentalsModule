﻿//Associative arrays - exercise, Task 006
//02.03.2024, 21:49

int numberOfGrades = int.Parse(Console.ReadLine());
var grades = new List<double>();
var students = new Dictionary<string, List<double>>();

for (int i = 1; i <= numberOfGrades; i++)
{
    var name = Console.ReadLine();
    var grade = double.Parse(Console.ReadLine());

    if (students.ContainsKey(name))
    {
        students[name].Add(grade);
    }
    else
    {
        students.Add(name, grades);
        students[name].Add(grade);
    }
    grades = new List<double>();
}

foreach (var student in students.Where(x => x.Value.Average() >= 4.5))
//.OrderByDescending(x => x.Value.Average()))
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
}