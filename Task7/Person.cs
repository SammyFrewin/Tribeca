using System;
namespace People
{
    public class Person
    {
    //Generate private variable to store the name of the person. String type selected as we are dealing with a collection of characters
        private string Name;
        //Generate private variable to store the Surname of the person. String type selected as we are dealing with a collection of characters
        private string Surname;
        //Generate private variable to store the Date of Birth (DOB) of the person. DateTime type selected as we are dealing with a date
        private DateTime DateOfBirth;

        //Generate constructor
        public Person(string lastName, string firstName, DateTime DOB)
        {
            setSurname(lastName);
            setName(firstName);
            setDateOfBirth(DOB);
        }

        //Generating getters and setters properties for the class variables
        public string getName ()
        {
            return Name;
        }
        public void setName(string NewName)
        {
            Name = NewName;
        }

        public string getSurname ()
        {
            return Surname;
        }
        public void setSurname(string NewSurname)
        {
            Surname = NewSurname;
        }

        public DateTime getDateOfBirth ()
        {
            return DateOfBirth;
        }

        //Added validation to stop entry of DOBs younger than a year or older than 150 years thowing a out of range exception 
        public void setDateOfBirth(DateTime NewDateOfBirth)
        {
             int age = getYearsbetween(NewDateOfBirth);
            if(age < 1 || age >150)
            {
                throw new ArgumentOutOfRangeException("Users must be at least 1-years-old and less than 150 years old.");
            }
            else
            {
                DateOfBirth = NewDateOfBirth;
            }
        }

        //Generate a public facing Age property that will get the system date and compare to DOB to calculate current age as an int
    public int getAge()
    {
        return getYearsbetween(getDateOfBirth());
    }

        //A private function that calcuates the date difference between a historical date and today
     private int getYearsbetween (DateTime StartDate)
     {
        //Get Current Date
        DateTime CurrentDate = DateTime.Today;
        int Age;
        //Calc Year difference between dates as a date with added validation to stop future dates
        if(StartDate < CurrentDate)
        {
            Age = CurrentDate.Year - StartDate.Year;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Date cannot be in the future");
        }
        

        //Check if the person has had their birthday this year
        if(DateOfBirth.Month > CurrentDate.Month || (DateOfBirth.Month == CurrentDate.Month && DateOfBirth.Day > CurrentDate.Day))
        {
            Age = Age -1;
        }

        return Age;
     }
       


}
}
namespace Utils
{
    using People;
    using System.Reflection;

//Generate a public static class called Utilities which will allow users to get the name of a given person object
      public static class Utilities 
    {
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
                BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                FieldInfo field = type.GetField(fieldName, bindFlags);
                return field.GetValue(instance);
        }
        public static string GetPersonsName(Person Individual)
        {
            string str = GetInstanceField(typeof(Person), Individual, "Name") as string;
            return str;
        }
    }
}



namespace StarSign
{
    using People;
 public static class MyExtensions
    {
        public static string StarSign(this Person Individual)
        {
            //Collect date of birth as as int for quicker referencing
            int DateOfBirthDay = Individual.getDateOfBirth().Day;

            //Check month of birth 
            switch(Individual.getDateOfBirth().Month)
            {
                //check what star sign a person has based on the day and month they were born
                case 1:
                    if(DateOfBirthDay <= 19)
                    {
                        return "Capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                case 2:
                    if(DateOfBirthDay <= 18)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Pisces";
                    }
                case 3:
                    if(DateOfBirthDay <= 20)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                case 4:
                    if (DateOfBirthDay <= 19)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                case 5:
                    if (DateOfBirthDay <= 20)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Gemini";
                    }
                case 6:
                    if (DateOfBirthDay <= 20)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                case 7:
                    if (DateOfBirthDay <= 22)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                case 8:
                    if (DateOfBirthDay <= 22)
                    {
                        return "Leo";
                    }
                    else
                    {
                        return "Virgo";
                    }
                case 9:
                    if (DateOfBirthDay <= 22)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }
                case 10:
                    if (DateOfBirthDay <= 22)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                case 11:
                    if (DateOfBirthDay <= 21)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                case 12:
                    if (DateOfBirthDay <= 21)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricorn";
                    }
                default:
                    return "Error";

            }
        }
    }
}
namespace ConsoleApp
{
    using People;
    using Utils;
    using System.Diagnostics;
    public class ConsoleApp
    {

       
        public static void Main(string[] args)
        {
            //Clear user instructions
            Console.WriteLine("A new person will be created \nPlease enter the following details");

            //Prompt
            Console.Write("Firstname: ");

            //Data Collection
            string Name = Console.ReadLine();


            //Prompt
            Console.Write("Surname: ");

            //Data Collection
            string Surname = Console.ReadLine();


            //Prompt
            Console.Write("Format: (DD/MM/YYYY)\nDate Of Birth: ");

            //Data Collection (Data validation is not present here could be added, will currently throw a Format execption)
            //Try catch added to stop unhanded error
            try{
            DateTime DOB = DateTime.Parse (Console.ReadLine ());
            Person NewPerson = new Person( Surname, Name, DOB);

            Console.WriteLine("This Person is {0} years old", NewPerson.getAge());

            Console.WriteLine("The name of this person is {0}", Utilities.GetPersonsName(NewPerson));
            }
            catch(Exception e)
            {
            Console.WriteLine(e.Message);
            }

            
           



        }
    }
}