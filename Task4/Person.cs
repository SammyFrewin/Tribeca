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