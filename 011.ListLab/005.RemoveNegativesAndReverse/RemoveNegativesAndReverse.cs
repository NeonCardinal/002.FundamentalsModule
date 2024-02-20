//List - lab, Task 005
//17.02.2024, 19:26

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

numbers.RemoveAll(n => n < 0);
numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(String.Join(" ", numbers));
}