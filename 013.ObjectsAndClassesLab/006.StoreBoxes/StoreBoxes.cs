//Objects and classes - lab, Task 006
//27.02.2024, 13:18

List<Box> boxes = new List<Box>();

while(true)
{
    string input = Console.ReadLine();

    if(input == "end")
    {
        break;
    }

    string[] tokens = input.Split(" ").ToArray();
    string serialNumber = tokens[0];
    string itemName = tokens[1];
    int quantity = int.Parse(tokens[2]);
    decimal price = decimal.Parse(tokens[3]);

    Box box = new();

    box.SerialNumber = serialNumber;
    box.Item.Name = itemName;
    box.Item.Price = price;
    box.Quantity = quantity;
    box.BoxPrice = box.Quantity * box.Item.Price;

    boxes.Add(box);
}

List<Box> sortedBoxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();

foreach(var item in sortedBoxes)
{
    Console.WriteLine($"{item.SerialNumber}");
    Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:F2}: {item.Quantity}");
    Console.WriteLine($"-- ${item.BoxPrice:F2}");
}

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; } 
}

public class Box
{
    public Box()
    {
        Item = new Item();
    }

    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal BoxPrice { get; set; }
}