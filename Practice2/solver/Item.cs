namespace Practice2;

public struct Item
{
    public string name;
    public string dateOfArrival;
    public double weight;
    public double price;
    public string nameOfProducer;
    public string maxStoragePeriod;

    public Item(string name, string dateOfArrival, double weight, double price, string nameOfProducer,
        string maxStoragePeriod)
    {
        this.name = name;
        this.dateOfArrival = dateOfArrival;
        this.weight = weight;
        this.price = price;
        this.nameOfProducer = nameOfProducer;
        this.maxStoragePeriod = maxStoragePeriod;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва товару: {name}");
        Console.WriteLine($"Дата надходження: {dateOfArrival}");
        Console.WriteLine($"Маса: {weight} кг");
        Console.WriteLine($"Ціна: {price} грн");
        Console.WriteLine($"Назва постачальника: {nameOfProducer}");
        Console.WriteLine($"Максимальний термін збереження: {maxStoragePeriod}");
    }
}