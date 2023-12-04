using system;

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

        public void setDateOfBirth(DateTime NewDateOfBirth)
        {
            DateOfBirth = NewDateOfBirth;
        }

     //Generate a public facing Age property that will get the system date and compare to DOB to calculate current age as an int
     public int getAge ()
     {
        //Get Current Date
        DateTime CurrentDate = DateTime.Today();

        //Calc Year difference between dates as a date
        DateTime Age = CurrentDate - getDateOfBirth();
        
        //Generate Int value which will store final result
        int FinalAge;

        //Check if the person has had their birthday this year
        if(DateOfBirth.Month > CurrentDate.Month || (DateOfBirth.Month == CurrentDate.Month && DateOfBirth.Day > CurrentDate.Day))
        {
            FinalAge = Age.Year -1;
        }
        else
        {
            FinalAge = Age.Year;
        }

        return FinalAge;
     }

}

