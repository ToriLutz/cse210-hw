using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Addresses address = new Addresses("USA", "123 Main St", "NY", "New York");
        Addresses address2 = new Addresses("Canada", "456 Maple Rd", "ON", "Toronto");
        Addresses address3 = new Addresses("UK", "789 Baker St", "London", "London");

        Customer customer = new Customer("John Doe", address);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Alex Johnson", address3);


        Product product1 = new Product("P001", 10, 2);
        Product product2 = new Product("P002", 20, 1);
        Product product3 = new Product("P003", 15, 3);
        Product product4 = new Product("P004", 50, 1);
        Product product5 = new Product("P005", 7, 5);

        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        customer.Label();
        address.DisplayAddress();
        Console.WriteLine($"{customer.Name} from USA? {customer.IsFromUSA()}");
        order1.Display();
        Console.WriteLine();


        Order order2 = new Order();
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        customer2.Label();
        address2.DisplayAddress();
        Console.WriteLine($"{customer2.Name} from USA? {customer2.IsFromUSA()}");
        order2.Display();
        Console.WriteLine();

        Order order3 = new Order();
        order3.AddProduct(product3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);
        order3.AddProduct(product5);
        customer3.Label();
        address3.DisplayAddress();
        Console.WriteLine($"{customer3.Name} from USA? {customer3.IsFromUSA()}");
        order3.Display();
        Console.WriteLine();

    }

    class Order
    {
        private List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void Display()
        {
            int total = 0;
            foreach (var product in Products)
            {
                total += product._price * product._quantity;
            }
            Console.WriteLine($"Total Order Price: {total}");
        }
    }

    class Product
    {
        public string _id;
        public int _price;
        public int _quantity;

        public Product(string id, int price, int quantity)
        {
            _id = id;
            _price = price;
            _quantity = quantity;
        }
    }

    class Customer
    {
        public string Name;
        public Addresses Address;

        public Customer(string name, Addresses address)
        {
            Name = name;
            Address = address;
        }
        public bool IsFromUSA()
         {
        return Address.IsInUSA();
        }

        public void Label()
        {
            Console.WriteLine($"{Name}");
        }
    }

    class Addresses
    {
        private string _country;
        private string _street;
        private string _state;
        private string _City;
        private int _Ship;
        private bool _USA;


        public Addresses(string country, string street, string state, string city)
        {
            _country = country;
            _street = street;
            _state = state;
            _City = city;

            if (_country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES")
            {
                _Ship = 5;
                _USA = true;
            }
            else
            {
                _Ship = 35;
                _USA = false;
            }
        }

         public bool IsInUSA()
        {
        return _USA;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"{_street}, {_City}, {_state}, {_country}");
            Console.WriteLine($"Shipping Cost: {_Ship}");
        }
    }
}