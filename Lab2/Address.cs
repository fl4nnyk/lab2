using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    public class Address
    {
    private int _index;
    private string _country;
    private string _city;
    private string _street;
    private string _house;
    private string _apartment;

    public int Index { get { return _index; } set { _index = value; } }
    public string Country { get { return _country; } set { _country = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string Street { get { return _street; } set { _street = value; } }
    public string House { get { return _house; } set { _house = value; } }
    public string Apartment { get { return _apartment; } set { _apartment = value; } }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 1;
            address.Country = "aaa";
            address.City = "aaa";
            address.Street = "asd";
            address.House = "dsadsa";
            address.Apartment = "ddsadsa";

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }
            Console.ReadLine();
        }
    }
}