using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    class Program
    {
        InvoiceDBContext db = new InvoiceDBContext();
        static void Main(string[] args)
        {
            var data=from a in db.Invoices
                               select a;
        }
    }
}
