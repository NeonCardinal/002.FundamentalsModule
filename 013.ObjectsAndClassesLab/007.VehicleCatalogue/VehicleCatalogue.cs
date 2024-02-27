//Objects and classes - lab, Task 007
//27.02.2024, 13:56

//List<Car> cars = new();
//List<Truck> trucks = new();

Catalog catalogList = new Catalog();

ReadData();
PrintData(catalogList);

void ReadData()
{
    while(true)
    {
        string input = Console.ReadLine();

        if(input == "end")
        {
            break;
        }

        string[] tokens = input.Split("/").ToArray();
        string modelType = tokens[0];
        Car car = new Car();
        Truck truck = new Truck();


        if(modelType == "Car")
        {
            car.Brand = tokens[1];
            car.Model = tokens[2];
            car.HorsePower = int.Parse(tokens[3]);
            catalogList.Cars.Add(car);
        }
        else if(modelType == "Truck")
        {
            truck.Brand = tokens[1];
            truck.Model = tokens[2];
            truck.Weight = int.Parse(tokens[3]);
            catalogList.Trucks.Add(truck);
        }
    }
}

void PrintData(Catalog catalog)
{
    Catalog sortedCatalog = new();
    sortedCatalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();
    sortedCatalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();

    if(catalog.Cars.Count != 0)
    {
        Console.WriteLine("Cars:");
    }
    foreach (var item in sortedCatalog.Cars)
    {
        Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
    }

    if (catalog.Trucks.Count != 0)
    {
        Console.WriteLine("Trucks:");
    }
    foreach (var item in sortedCatalog.Trucks)
    {
        Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
    }
}

public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

public class Car
{
    public string Brand { set; get; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

public class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }
}