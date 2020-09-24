//using  Collections;
using System.Linq;
using System;
using System.IO;


    public class Program
    {     
         static void Main()
        {
          //Square square = new Square(34.5);
          //square.Display();
         // square.GetDiagonal();
          //Rectangle rectangle = new Rectangle(45.4,23.5);
          //rectangle.Display();
          //Circle circle = new Circle(45.4);
          //circle.Display();
//file handling

          //FileIO fileIO =new FileIO();
          // fileIO.LearnFileHandling();
          //fileIO.LearnFileInfo();
          //fileIO.LearnDirectories();
          var countriesText = File.ReadAllText("Countries.txt");
          string[] countries = countriesText.Split("\n\r");

          var countriesWidthNInitial = countries.Where(x => x.StartsWith("N")).Select(x => x);

          foreach(var country in countriesWidthNInitial)
          {
            Console.WriteLine(country);
          }

        } 
    

    }

