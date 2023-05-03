using System.Reflection;

class Laptop
{
    private string? brand;

    private string? model;

    public string SetAndGetBrand { private get => brand; set => value = brand = value; }
    public string SetAndGetModel { private get => model; set => value = model = value; }

    public void LaptopDetails()

    {

        Console.WriteLine("Brand: " + brand);

        Console.WriteLine("Model: " + model);

    }

    private void MotherBoardInfo()

    {

        Console.WriteLine("MotherBoard Information");

    }

    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop();
        laptop.SetAndGetBrand = "HP";
        laptop.SetAndGetModel = "HP Spectre x360";
        laptop.LaptopDetails();
        laptop.MotherBoardInfo();
        Console.ReadKey();
    }
}