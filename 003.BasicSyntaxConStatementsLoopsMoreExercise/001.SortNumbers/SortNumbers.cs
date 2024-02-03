//Basic syntax, con statements and loops - more exercise, Task 001
//30.01.2024, 23:17

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int[] arr = new int[3];
arr[0] = firstNumber;
arr[1] = secondNumber;
arr[2] = thirdNumber;

Array.Sort(arr);
Array.Reverse(arr);

Console.WriteLine(string.Join("\r\n", arr));