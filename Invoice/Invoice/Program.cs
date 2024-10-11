namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var invoice = new Invoice();
            invoice.Id = 1;
            invoice.InvoiceNo = "2024/1";
            invoice.InvoiceDate = new DateTime(2024, 8, 10);
            invoice.DueDate = invoice.InvoiceDate.AddDays(14);
            invoice.Customer = new Customer
            {
                 Id = 1,
                 Name = "Test",
                 Email = "test1@example.com",
                 Phone = "512342416",
                 Address = "Street x"
            };

            var line = new InvoiceLine
            {
                Id = 1,
                LineItem = "Eesti juust",
                Quantity = 2,
                Unit = "kg",
                UnitPrice = 7.50m,
                VatRate = 0
            };
            invoice.Lines.Add(line);
            line = new InvoiceLine
            {
                Id = 2,
                LineItem = "Coca-Cola",
                Quantity = 1,
                Unit = "pudel",
                VatRate = 0,
                UnitPrice = 1.50m
            };
            invoice.Lines.Add(line);

            Console.WriteLine(invoice.InvoiceNo);
            Console.WriteLine("----------------------");
            foreach(var currentLine in invoice.Lines)
            {
                Console.WriteLine(currentLine.LineItem);
                Console.WriteLine("Unit price: " + currentLine.UnitPrice);
                Console.WriteLine("Net total: " + currentLine.NetTotal);
                Console.WriteLine("VAT: " + currentLine.Vat);
                Console.WriteLine("Total: " + currentLine.Total);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine(invoice.NetTotal);
            // Console.WriteLine("VAT: " + );
            // Console.WriteLine("Total: " + );


        }
    }

    internal class Invoice
    {  
        public int Id { get; set; }
        public string InvoiceNo {  get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public Customer Customer { get; set; }
        public IList<InvoiceLine> Lines { get; set; }
        public Invoice()
        {
            Lines = new List<InvoiceLine>();
        }
        public decimal NetTotal
        {
            get 
            {  
                return Lines.Sum(line => line.NetTotal);
            }
        }

    }

    internal class InvoiceLine
    {
        public int Id { get; set; }
        public string LineItem { get; set;}
        public decimal Quantity { get; set;}
        public string Unit { get; set;}
        public decimal UnitPrice { get; set;}
        public decimal VatRate { get; set; }
        public decimal NetTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
        public decimal Total
        {
            get
            {
                return NetTotal * (1 + VatRate);
            }
        }
        public decimal Vat
        {
            get
            {
                return NetTotal * VatRate;
            }
        }
    }

    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}