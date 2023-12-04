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

}