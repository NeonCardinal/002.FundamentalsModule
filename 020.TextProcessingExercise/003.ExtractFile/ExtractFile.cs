//Text processing - exercise, Task 003
//11.03.2024, 22:18

string path = Console.ReadLine();

int backSlashIndex = path.LastIndexOf('\\');
string fileInfo = path.Substring(backSlashIndex + 1);
int dotIndex = fileInfo.LastIndexOf('.');
string fileName = fileInfo.Substring(0, dotIndex);
string extensionName = fileInfo.Substring(dotIndex + 1);

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extensionName}");