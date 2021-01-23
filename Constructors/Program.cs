using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor (Yapıcı) new komutu geldiği zaman 1 kere çalışır ve bir daha çalışmaz.
            
            Customer customer1 = new Customer {Id=1, FirstName="Cem",LastName="Eröksüz",City="Ankara" };
            Customer customer2 = new Customer (2,"Engin","Demiroğ","Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;


            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        //yukarıdaki tanımlanan farklı tanımları da kullanabilmek için hem parametreli hem de parametresiz olarak yazlıabilir.
        //Default Constructor
        
        public Customer()
        {
            Console.WriteLine("Varsayılan Yapıcı Blok Çalıştı");

        }
        //overloading 
        public Customer(int id, string firstName, string lastName, string city)
        {
           //parametrelerin okunabilmesi için gelen parametreleri değişkenlere atamamız gerekir.
           
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
