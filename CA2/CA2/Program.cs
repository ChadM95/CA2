namespace CA2;

class Program
{
    static void Main(string[] args)
    {
        //set up variables
        string name;
        long emissions, previousYear;
        int population;

        //get country info and create object 3 times

        GetCountryInfo(out name, out emissions, out previousYear, out population);
        Country c1 = new Country(name, emissions, previousYear, population);
        Console.WriteLine(); //makes console output easier to read

        GetCountryInfo(out name, out emissions, out previousYear, out population);
        Country c2 = new Country(name, emissions, previousYear, population);
        Console.WriteLine();

        GetCountryInfo(out name, out emissions, out previousYear, out population);
        Country c3 = new Country(name, emissions, previousYear, population);
        Console.WriteLine();

        //displays
        DisplayTable(c1,c2,c3);

        DisplayColourBars(c1);
        DisplayColourBars(c2);
        DisplayColourBars(c3);

        GetBiggestEmmitter(c1,c2,c3);

        ClimateClock();

        //pause program
        Console.ReadLine();
    }

    //method to get country info
    public static void GetCountryInfo(out string name, out long emissions, out long previousYear, out int population)
    {
        Console.Write("Please Enter Country Name > ");
        name = Console.ReadLine();
        Console.Write("Please Enter Emissions > ");
        emissions = Convert.ToInt64(Console.ReadLine());
        Console.Write("Please Enter Previous Year Emissions > ");
        previousYear = Convert.ToInt64(Console.ReadLine());
        Console.Write("Please Enter Population > ");
        population = int.Parse(Console.ReadLine());
    }

    public static void DisplayTable(Country c1, Country c2, Country c3)
    {
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);
    }

    public static void DisplayColourBars(Country c1)
    {
        Console.ResetColor();
        int amount = (int)c1.GetWorldShare();

        Console.BackgroundColor = ConsoleColor.Green;

        for (int i = 0; i < amount; i++)
        {
            Console.Write(" ");
        }
        
    }
   
    public static void GetBiggestEmmitter(Country c1, Country c2, Country c3)
    {
        string biggest = "";

        if (c1.Emissions > c2.Emissions && c1.Emissions > c3.Emissions)
        {
            biggest = c1.Name;
        }
        else if (c2.Emissions > c1.Emissions && c2.Emissions > c3.Emissions)
        {
            biggest = c2.Name;
        }
        else if (c3.Emissions > c1.Emissions && c3.Emissions > c2.Emissions)
        {
            biggest = c3.Name;
        }

        Console.WriteLine($"The biggest emmitter is {biggest}");
    }

    public static void ClimateClock()
    {

        DateTime today = DateTime.Now;

        DateTime deadline = new DateTime(2029,07,21);

        Console.WriteLine("It is {0:F2} days to 1.5 degrees hotter", (deadline - today).TotalDays);
    }  

}

