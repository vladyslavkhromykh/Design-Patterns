using System;
namespace Prototype
{
    public class Person : IPrototype<Person>
    {
        private string name;
        private int age;

        public override string ToString()
        {
            return $"Name: {name}, age: {age}";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person Clone()
        {
            var person = new Person(this.name, this.age);
            return person;
        }
    }
}