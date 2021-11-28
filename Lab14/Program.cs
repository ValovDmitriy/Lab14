using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            
            Dog dog = new Dog();
            dog.ShowInfo();
            
        }
    }
    // абстрактный класс Animal
    abstract class Animal 
    {
        // абстрактное свойство название животного
        public abstract string NameAnimal { get; set; }
        // конструктор устанавливающий значение по-умолчанию
        public Animal()
        {
            this.NameAnimal = "Животное";
        }
        // абстрактный метод Say
        public abstract string Say();    
        // неабстрактный метод ShowInfo выводит Имя и Звук
        public void ShowInfo()
        {
            Console.Write(NameAnimal);
            Console.WriteLine(Say());
        }
    }
    // класс Cat 
    class Cat : Animal
    {
        string catAnimal;
        string catSay;
        // свойство название животного 
        public override string NameAnimal
        {
            get
            {
                return catAnimal;
            }
            set
            {
                catAnimal = "Кошка ";
            }
        }
        // Мяу соответственно 
        public override string Say()
        {
            catSay = "Мяу";
            return catSay;
        }

    }
    class Dog : Animal
    {
        string dogAnimal;
        string dogSay;
        // свойство название животного 
        public override string NameAnimal
        {
            get
            {
                return dogAnimal;
            }
            set
            {
                dogAnimal = "Собака ";
            }
        }
        // Гав соответственно 
        public override string Say()
        {
            dogSay = "Гав";
            return dogSay;
        }

    }
}
