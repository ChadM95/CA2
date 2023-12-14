using System;
namespace CA2
{
	public class Country
	{
		//constants
		const long WORLD_EMISSIONS = 35739608603;

		//properties
		public string Name { get; set; }
		public long Emissions { get; set; }
		public long PreviousYear { get; set; }
		public int Population { get; set; }

   
        //ctors
        public Country()
		{
		}

		public Country(string name, int population)
		{
			Name = name;
			Population = population;
		}

		public Country(string name, long emissions, long previousYear, int population)
		{
			Name = name;
			Emissions = emissions;
			PreviousYear = previousYear;
			Population = population;
		}

		//methods

		public override string ToString()
		{
			string output = "";
			string formatter = "{0,-22}{1,10}\n";

			output += string.Format(formatter, "Country Name", Name);
			output += string.Format(formatter, "Emissions", Emissions);
			output += string.Format(formatter, "Previous Year", PreviousYear);
			output += string.Format(formatter, "Population", Population);
			output += string.Format("{0,-22}{1,10:p2}\n", "Annual Change", GetAnnualChange());
            output += string.Format("{0,-22}{1,10:p2}\n", "Per Capita", GetPerCapita());
            output += string.Format("{0,-22}{1,10:p2}\n", "World Share", GetWorldShare());

            return output;
        }       

        public double GetAnnualChange()
		{
			double difference = Emissions - PreviousYear;
			
			return difference / PreviousYear;
		}

		public double GetPerCapita()
		{
			return Emissions / Population;
		}

		public double GetWorldShare()
		{
			return Emissions / WORLD_EMISSIONS;
		}


        
    }
}

