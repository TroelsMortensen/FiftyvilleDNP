using System.Collections.Generic;
using System.Linq;
using Fiftyville.DataAccess;
using Fiftyville.Model;
using static Fiftyville.PrintUtil.Printer;

namespace Fiftyville
{
    class Program
    {
        static void Main(string[] args)
        {
            FiftyVilleContext ctx = new FiftyVilleContext();
            
            // Your LINQ expression goes here
            
            
            List<Airport> result = ctx.Airports.ToList();
            // List<Person> result = ctx.People.Where(person => person.Name.ToLower().Contains("ch")).ToList();            
            
            
            // pretty printing result
            PrettyPrint(result);
        }
    }
}