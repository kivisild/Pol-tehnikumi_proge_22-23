using System.Reflection;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {

            }
        }

        public class Invoice
        {
            public string Id { get; set; }
            public Person Person { get; set; }
            public AssemblyCompanyAttribute Company { get; set; }

        }
        public class Person
            {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string IdCode { get; set; }

            }
        
    }
}
