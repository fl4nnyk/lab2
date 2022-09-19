using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Surname = "dsadfas";
            user.Name = "dasdas";
            user.Login = "dasda";
            user.Age = 14;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
    public class User
    {
        public User()
        {
            DateSubmited = DateTime.UtcNow;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime DateSubmited { get; }
    }
}
}
