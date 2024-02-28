//Objects and classes - exercise, Task 006
//28.02.2024, 16:46

using System.ComponentModel.Design;

Catalog catalog = new Catalog();

while(true)
{
    string input = Console.ReadLine();

    if(input == "End")
    {
        break;
    }

    string[] tokens = input.Split(" ").ToArray();
    string type = tokens[0];
    string model = tokens[1];
    string color = tokens[2];
    int horsePower = int.Parse(tokens[3]);

    if(type == "car")
    {
        Car car = new Car();

        car.Model = model;
        car.Color = color;
        car.HorsePower = horsePower;

        catalog.CarsList.Add(car);
    }
    else if(type == "truck")
    {
        Truck truck = new Truck();

        truck.Model = model;
        truck.Color = color;
        truck.HorsePower = horsePower;

        catalog.TruckList.Add(truck);
    }
}

while(true)
{
    string input = Console.ReadLine();

    if(input == "Close the Catalogue")
    {
        if(catalog.CarsList.Count > 0)
        {
            double carsAverageHP = catalog.CarsList.Average(x => x.HorsePower * 1.0);
            //double trucksAverageHP = catalog.TruckList.Average(x => x.HorsePower * 1.0);

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
        }
        else if(catalog.TruckList.Count > 0)
        {
            //double carsAverageHP = catalog.CarsList.Average(x => x.HorsePower * 1.0);
            double trucksAverageHP = catalog.TruckList.Average(x => x.HorsePower * 1.0);

            Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:F2}.");
        }
        else if(catalog.CarsList.Count > 0 && catalog.TruckList.Count > 0)
        {
            double carsAverageHP = catalog.CarsList.Average(x => x.HorsePower * 1.0);
            double trucksAverageHP = catalog.TruckList.Average(x => x.HorsePower * 1.0);

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:F2}.");
        }
        else if((catalog.CarsList.Count == 0 && catalog.TruckList.Count == 0))
        {
            Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
        }
        break;
    }

    bool isCarExist = catalog.CarsList.Any(x => x.Model == input);
    bool isTruckExist = catalog.TruckList.Any(x => x.Model == input);

    if(isCarExist)
    {
        int indexName = catalog.CarsList.FindIndex(x => x.Model == input);
        Console.WriteLine("Type: Car");
        Console.WriteLine($"Model: {catalog.CarsList[indexName].Model}");
        Console.WriteLine($"Color: {catalog.CarsList[indexName].Color}");
        Console.WriteLine($"Horsepower: {catalog.CarsList[indexName].HorsePower}");
    }
    else if(isTruckExist)
    {
        int indexName = catalog.TruckList.FindIndex(x => x.Model == input);
        Console.WriteLine("Type: Truck");
        Console.WriteLine($"Model: {catalog.TruckList[indexName].Model}");
        Console.WriteLine($"Color: {catalog.TruckList[indexName].Color}");
        Console.WriteLine($"Horsepower: {catalog.TruckList[indexName].HorsePower}");
    }
}

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}

public class Truck
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }
}

public class Catalog
{
    public List<Car> CarsList { get; set; }
    public List<Truck> TruckList { get; set; }

    public Catalog()
    {
        CarsList = new List<Car>();
        TruckList = new List<Truck>();
    }
}