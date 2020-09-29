using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers ={ 23 ,34 , 56 ,67,89,9,0,56,45,90,567,2,3,4,5};
            //Using method syntax -lamda Expression
            var numbersGreaterThan50 = numbers.Where(x => x>50);
            //Using sql query syntax - querry expression
            var numbersGreaterThanFifty = from num in numbers
                                          where num > 50
                                          select num;
            String[] names = {"Kushal","abrupeshc","Rajesh","abd","Ramesh","kamal","Ramsey","rohit"}; 
             //Using method syntax -lamda Expression
             var namesStartingFromR = names.Where(x => x.ToUpper().StartsWith("R") && x.Length>3);
             //Using sql query syntax - querry expression
             var namesStartingFromR2 = from name in names
                                        where name.ToUpper().StartsWith("R") && name.Length>3
                                        select name;


            foreach( var name in namesStartingFromR2)
                    Console.WriteLine(name); 
            //listing out Asian countries
            List<Country> countries = Country.GetCountries();
            var asianCountries = from member in countries
                                 where member.Continents == Continents.Asia
                                 select member;
            foreach (var member in asianCountries)
            {
                Console.WriteLine(member.Name);
            }
            //HW1: List of countries in Europe Which Have population less <10k
            var europeanCountries = from member in countries
                                    where (member.Continents == Continents.Europe)&& (member.Population < 10000)
                                    select member;
            Console.WriteLine("List of Europen countries which has population less than 10K are:");
            foreach (var member in europeanCountries)
            {
                Console.WriteLine(member.Name);
            }
            //HW2: List of asian countries which are not ever invaded.

            
            var nonColonizedAsian = from member in countries
                                    where(member.Continents == Continents.Asia) && ( member.IndependenceDay==default)
                                    select member;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var member in nonColonizedAsian)
            {
                Console.WriteLine(member.Name);
            }


            //projections

            var squareR5 =from num in numbers
                           select num*num;
            foreach(var num in squareR5)
            {
                Console.WriteLine(num);
            }

            var result6=from num in numbers
                        orderby num
                        select num;

            /*var result7 =from name in names 
                        orderby name descending
                        select name;*/
                //Partitioning
            var result7 =numbers.Skip(5).Take(5);


                //Quantifier
            var result8 =numbers.Any(x=>x%2==0);
            var result9 =numbers.All(x=>x%2==0);
            var result10 =numbers.Contains(34);
            var result11 = Enumerable.Range(1,1000);
            var result12 = Enumerable.Repeat("Hello World",10);


            foreach (var num in result7)
            {
                Console.WriteLine(num);
            }
            ComplexType complexType =new ComplexType();
            complexType.LearnRestrictions();
            

        }
    }
}