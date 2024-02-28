//Objects and classes - exercise, Task 002
//27.02.2024, 23:31

string[] tokens = Console.ReadLine().Split(", ").ToArray();
Article art = new Article();

art.Title = tokens[0];
art.Content = tokens[1];
art.Author = tokens[2];

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(":", StringSplitOptions.TrimEntries).ToArray();

    string cmd = input[0];

    if(cmd == "Edit")
    {
        art.Edit(input[1]);
    }
    else if(cmd == "ChangeAuthor")
    {
        art.ChangeAuthor(input[1]);
    }
    else if(cmd == "Rename")
    {
        art.Rename(input[1]);
    }
}

Console.WriteLine(art.ToString());

public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article()
    {

    }

    public void Edit(string content)
    {
        Content = content;
    }

    public void ChangeAuthor(string author)
    {
        Author = author;
    }

    public void Rename(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return new string($"{Title} - {Content}: {Author}");
    }
}