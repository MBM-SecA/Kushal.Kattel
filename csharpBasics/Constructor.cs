using System;

namespace AllAboutClasses
{
    public class Country
    {
        //default constructor
        public string Name{get;set;}
         public int Population { get; set; }
         public readonly double AREA=43443.45; 
         public static readonly bool IsOnEarth;
                public Country()
        {

        }
        // Parameterized Constructor
        public Country(string name)
        {
            Name =name;
        }

        public Country(string name,int population, double area)
        {
            Name =name;
            Population = population;
            AREA = area;
        }
        //static constructor
        static Country()
        {
            IsOnEarth=true;
        }//executes only one time 
    //finalizer
        ~Country()
        {
            Console.WriteLine("I am dying..");
        }
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country coountry2 = new Country("Nepal");

        }
    }
}