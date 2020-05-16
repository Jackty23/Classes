using System;
using System.Collections.Generic;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour red = new Colour(255, 0, 0, "Red");
            Colour green = new Colour(0, 255, 0, "Green");
            Colour blue = new Colour(0, 0, 255, "Blue");

            Cookie myCookie1 = new Cookie(100, "Circle");
            myCookie1.CookieColour = red;

            Cookie myCookie2 = new Cookie(200, "Triangle");
            myCookie2.CookieColour = green;

            Cookie myCookie3 = new Cookie(300, "Square");
            myCookie3.CookieColour = blue;

            Cookie myCookie4 = new Cookie(400, "Rectangle");
            myCookie4.CookieColour = red;



            Console.WriteLine(myCookie3.Shape);
            Console.WriteLine(myCookie2.Weight);
            Person myPersonJack = new Person("Jack", "Ty", new DateTime(1998, 11, 26), 165);
            Console.WriteLine(myPersonJack.GetFullName());

            Person myPersonIndo = new Person("Indo", "Ty", new DateTime(1979, 5, 23), 171);
            Console.WriteLine(myPersonIndo.GetFullName());
            int differenceInHeight = myPersonIndo.GetHeightDifference(myPersonJack);
            Console.WriteLine("The Height Difference is " + differenceInHeight +  " cm between " + myPersonIndo.FirstName + " and " + myPersonJack.FirstName);

            Person myPersonMark = new Person("Mark", "Smith", new DateTime(1966,2,11), 166);
            int differenceInHeight2 = myPersonMark.GetHeightDifference(myPersonJack);
            Console.WriteLine("The Height Difference is " + differenceInHeight2  + " cm between " + myPersonMark.FirstName + " and " + myPersonJack.FirstName);

            int differenceInHeight3 = myPersonIndo.GetHeightDifference(myPersonMark);
            Console.WriteLine("The Height Difference is " + differenceInHeight3 + " cm between " + myPersonIndo.FirstName + " and " + myPersonMark.FirstName);
            
            Console.WriteLine(myPersonMark.ID);
            Console.WriteLine(myPersonJack.ID);
            Console.WriteLine(myPersonIndo.ID);
            myPersonJack.AddSubject(new Subject("Maths", 2018, 60));
            myPersonJack.AddSubject(new Subject("Database", 2019, 70));
            myPersonJack.AddSubject(new Subject ("Networking", 2019, 80));
            myPersonJack.DisplaySubjects();


        }
    }

    public class Cookie
    {

        public Cookie(int weight, string shape)
        {
            Weight = weight;
            Shape = shape;
        }


        public int Weight;
        public string Shape;
        public Colour CookieColour;
    }

    public class Colour
    {

        public Colour(int red, int green, int blue, string name)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Name = name;
        }
        public int Red;
        public int Green;
        public int Blue;
        public string Name;
    }

    public class Person
    {
        private Random rand = new Random();
        public Person(string firstName, string surname, DateTime dateOfBirth, int height)
        {
            FirstName = firstName;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Height = height;
            ID = rand.Next (1000,9999);
            ListOfSubjects = new List<Subject>();


        }

        public string FirstName;
        public string Surname;
        public DateTime DateOfBirth;
        public int Height;
        public int ID;
        public List<Subject> ListOfSubjects;

        public string GetFullName()
        {
            return FirstName + " " + Surname;
        }
        public int GetHeightDifference(Person otherPerson)
        {
           return  Math.Abs(Height - otherPerson.Height);
        }
        public void AddSubject(Subject newSubject)
        {
            ListOfSubjects.Add(newSubject);
        }
        public void DisplaySubjects()
        {
            foreach (Subject subjectObject in ListOfSubjects)
            {
                Console.WriteLine(subjectObject.Name + " Grade " + subjectObject.Grade);
            }
        }


    }
    public class Subject
    {
        public Subject(string name, int yearOfDelivery, int grade)
        {
            Name = name;
            YearOfDelivery = yearOfDelivery;
            Grade = grade;
        }
        public string Name;
        public int YearOfDelivery;
        public int Grade;
    }

}
