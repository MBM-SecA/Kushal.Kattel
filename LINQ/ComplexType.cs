using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{

public class ComplexType
{
    public void LearnRestrictions()
    {
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


            //HW - Isthere any african county in yr collection.
            //HW - Print first two largest asian countryies names.




             // HW 1 - Is there any African country in your country collection
            
            var africanMember = countries.Any(x=> x.Continents==Continents.Africa);
                                
            if( africanMember)
                Console.WriteLine("List contains african member");
            else
                 Console.WriteLine("List doesn't contain african member");
        
        //Hw 2- Print First 2 largest asian country names.
        var areaOrderedList = countries.OrderByDescending( x => x.Area);
                                
        var firstTwoLargestCountry = areaOrderedList.Take(2);
         Console.WriteLine("Two largest members are:");
        foreach (var item in firstTwoLargestCountry)
            {
                Console.WriteLine(item.Name);
            }

            }
        }
    }
}