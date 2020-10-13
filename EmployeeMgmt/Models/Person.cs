using System.Collections.Generic;

public class Person
{
     public Person(string firstName, string lastName,string address, char gender, double salary,string nickName,object hobbies,object whoCanBeFriends) {
        firstName = FirstName;
        lastName = SurName;
        address = Address;
        gender = Gender;
        salary = Salary;
        whoCanBeFriends= WhoCanBeFriends;
        nickName= NickName;
        hobbies= Hobbies;

    }
    public string FirstName{ get; set; }

    public string SurName{ get; set; } 

    public string Address{ get; set; }

    public char Gender{get;set;}
    
   
    public double Salary{ get; set; }
    public string NickName{get; set;}


    public object Hobbies{get; set;}
    public object WhoCanBeFriends{get; set;}
  public static List<Person> GetEmployee(){
         Person empl1 = new Person("Kushal","Kattel","Solukhumbu",'M',1000,"KOKAA",   "Playing guitar, Singing", "Loyal,Rich");
 
        Person empl2 = new Person( "Rupesh",  "Chaulagain",  "Aakahsedhara",   'M',  100.0,"Rupu",
        "Playing guitar, Dancing", "Loyal,Rich");
        Person empl3 = new Person( "Aayam ", "Neupane",  "Hattiban",  'M',100.0,"Aalu",
        "Playing guitar, Dancing", "Loyal,Rich" );
        Person empl4 = new Person("Ayush",   "Karki",  "Kapan", 'M',  100.0,"Jungye",
         "Playing guitar, Dancing",  "Loyal,Rich");
        Person empl5 = new Person( "Paras",  "Tiwari",   "Boudha", 'M',   100.0,"Paru",
        "Playing guitar, Dancing", "Loyal,Rich") ;
        Person empl6 = new Person( "Utshav",  "Kuikel",   "Boudha", 'M',   100.0,"mitra",
        "Playing guitar, Dancing", "Loyal,Rich");  
        Person empl7 = new Person("Sampanna",  "Nepal",   "Chabahil", 'M',   100.0,"Cyan",
        "Playing guitar, Dancing", "Loyal,Rich"); 
        Person empl8 = new Person("Shreedhar",  "Pandey",   "Boudha", 'M',   100.0,"Pandey","Playing guitar, Dancing", "Loyal,Rich");

        List<Person> persons = new List<Person>{ empl1, empl2, empl3, empl4, empl5, empl6, empl7, empl8 };
        return persons;
    }


}