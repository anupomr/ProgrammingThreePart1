using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    class Program
    {
       // InvoiceDBContext db = new InvoiceDBContext();
        static void Main(string[] args)
        {
            
            using (var db = new InvoiceDBContext())
            {
                //Display All Item
                var dataItem=from a in db.Items select a;
                Console.WriteLine("All Item ");
                foreach (var data in dataItem)
                {
                    var name = data.Name.Trim();
                   // Console.WriteLine($" Item Name: {name}, Rice = {data.Price,2:c} Quantity: {data.Quantity}");
                    Console.WriteLine($"  Invoice Number: {data.InvoiceID} Item Name: {data.Name.Trim()}, Rrice = {data.Price,2:c} Quantity: {data.Quantity}");
                }
                Console.WriteLine("Do you want to Add any Item y/n?");
                if (Console.ReadLine() == "y") {
                    Item newItem = new Item();
                    
                    Console.WriteLine("Please enter Item Invoice : ");
                    newItem.InvoiceID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Item Name    : ");
                    newItem.Name = Console.ReadLine();
                    Console.WriteLine("Please enter Item Price   : ");
                    newItem.Price = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Please enter Item Quantity:");
                    newItem.Quantity = Convert.ToInt32(Console.ReadLine());

                    db.Items.Add(newItem);
                    db.SaveChanges();

                }
                Console.WriteLine("Do you want to see all Item y/n?");
                if (Console.ReadLine() == "y")
                {
                    //Display All Item
                  
                    Console.WriteLine("All Item ");
                    foreach (var data in dataItem)  
                    {
                        var name = data.Name.Trim();
                        // Console.WriteLine($" Item Name: {name}, Rice = {data.Price,2:c} Quantity: {data.Quantity}");
                        Console.WriteLine($"  Invoice Number: {data.InvoiceID} Item Name: {data.Name.Trim()}, Rrice = {data.Price,2:c} Quantity: {data.Quantity}");
                    }
                }

            }
                               
        }
    }
}
