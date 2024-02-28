//Objects and classes - exercise, Task 003
//27.02.2024, 23:49

List<Article> articlesList = new List<Article>();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(", ").ToArray();

    Article art = new Article();

    art.Title = tokens[0];
    art.Content = tokens[1];
    art.Author = tokens[2];

    articlesList.Add(art);
}

foreach(var item in articlesList)
{
    Console.WriteLine(item.ToString());
}

public class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article()
    {

    }

    public override string ToString()
    {
        return new string($"{Title} - {Content}: {Author}");
    }
}