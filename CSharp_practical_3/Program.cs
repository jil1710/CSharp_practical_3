class Sponsor
{
    protected string owner = "Rakuteen";
}

class Team : Sponsor
{
    private string? teamName;

    public void PrintInfo()
    {
        Console.WriteLine(string.Concat(owner," ",teamName));
    }

    public static void Main(string[] args)
    {
        Team s = new Team();
        s.teamName = "ASP.NET";
        s.PrintInfo();
        Console.ReadKey();
    }
}
