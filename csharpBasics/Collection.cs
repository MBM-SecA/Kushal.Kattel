using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte>() {3,4};
            ages.Add(35);
            ages.Add(10);
            ages.Add(100);
            ages.Add(255);

            List<Country>countries =new List <Country>();
            Country country1 =new Country();

            countries.Add(new Country());
        }
    void LearnDictionary()
    {
        //var CountryCapitals = new Dictionary<string,string>
        Dictionary<string , string> CountryCapitals = new Dictionary<string,string>()
        {
            ["Nepal"]="Kathmandu";
            ["France"]="Paris";
            ["Spain"]="Madrid";
        };
        //CountryCapitals.Add("Nepal","Kathmandu");
        //CountryCapitals.Add("France","Paris");
        //CountryCapitals.Add("Spain","Madrid");

        foreach (var country in CountryCapitals)
        {
            Console.WriteLine($"Country: {country.Key} Capital City : {country.value}");
        }
    }
    }
    }

    }
    public class Country
    {
        public string Name{get; set;}
    }
}