using System;
using NUnit.Framework;
using People;
using StarSign;

namespace People.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void TestPersonInitialization()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            DateTime dob = new DateTime(1990, 5, 15);

            // Act
            People.Person person = new People.Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual(firstName, person.getName());
            Assert.AreEqual(lastName, person.getSurname());
            Assert.AreEqual(dob, person.getDateOfBirth());
        }

        [Test]
        public void TestInvalidDateOfBirth()
        {
            // Arrange
            string firstName = "Invalid";
            string lastName = "Date";
            DateTime futureDate = DateTime.Now.AddDays(1);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Person(lastName, firstName, futureDate));
        }

        [Test]
        public void TestValidAgeCalculation()
        {
            // Arrange
            string firstName = "Jane";
            string lastName = "Doe";
            DateTime dob = DateTime.Now.AddYears(-30);

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual(30, person.getAge());
        }

        [Test]
        public void TestStarSignCapricorn()
        {
            // Arrange
            string firstName = "Capricorn";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 1, 10); // January 10th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Capricorn", person.StarSign());
        }

        [Test]
        public void TestStarSignAquarius()
        {
            // Arrange
            string firstName = "Aquarius";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 2, 15); // February 15th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Aquarius", person.StarSign());
        }

        [Test]
        public void TestStarSignPisces()
        {
            // Arrange
            string firstName = "Pisces";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 3, 20); // March 20th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Pisces", person.StarSign());
        }

        [Test]
        public void TestStarSignTaurus()
        {
            // Arrange
            string firstName = "Taurus";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 4, 25); // April 25th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Taurus", person.StarSign());
        }

        [Test]
        public void TestStarSignGemini()
        {
            // Arrange
            string firstName = "Gemini";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 6, 5); // June 5th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Gemini", person.StarSign());
        }

        [Test]
        public void TestStarSignCancer()
        {
            // Arrange
            string firstName = "Cancer";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 7, 15); // July 15th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Cancer", person.StarSign());
        }

        [Test]
        public void TestStarSignLeo()
        {
            // Arrange
            string firstName = "Leo";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 8, 1); // August 1st

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Leo", person.StarSign());
        }

        [Test]
        public void TestStarSignVirgo()
        {
            // Arrange
            string firstName = "Virgo";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 9, 10); // September 10th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Virgo", person.StarSign());
        }

        [Test]
        public void TestStarSignLibra()
        {
            // Arrange
            string firstName = "Libra";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 10, 5); // October 5th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Libra", person.StarSign());
        }

        [Test]
        public void TestStarSignScorpio()
        {
            // Arrange
            string firstName = "Scorpio";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 11, 12); // November 12th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Scorpio", person.StarSign());
        }

        [Test]
        public void TestStarSignSagittarius()
        {
            // Arrange
            string firstName = "Sagittarius";
            string lastName = "Person";
            DateTime dob = new DateTime(DateTime.Now.Year-30, 12, 20); // December 20th

            // Act
            Person person = new Person(lastName, firstName, dob);

            // Assert
            Assert.AreEqual("Sagittarius", person.StarSign());
        }
    }
}
