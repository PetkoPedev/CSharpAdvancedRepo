using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            Person personTwo = new Person();
            Person personThree = new Person();

            personOne.Name = "Pesho";
            personOne.Age = 20;

            personTwo.Name = "Gosho";
            personTwo.Age = 18;

            personThree.Name = "Stamat";
            personThree.Age = 43;
        }
    }
}
