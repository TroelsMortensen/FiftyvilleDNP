﻿using System;
using System.Collections.Generic;
using System.Linq;
using Fiftyville.DataAccess;
using Fiftyville.Model;
using NUnit.Framework;
using static Fiftyville.PrintUtil.Printer;


namespace Fiftyville
{
    [TestFixture]
    public class QueryClass
    {
        private FiftyVilleContext ctx;

        [SetUp]
        public void Setup()
        {
            ctx = new FiftyVilleContext();
        }

        [Test]
        public void DisplayAirports()
        {
            var airports = ctx.Airports.FirstOrDefault();
            Console.WriteLine(airports);
            // PrettyPrint(airports);
        }

        [Test]
        public void DisplayPeopleWhosNameContainsCH()
        {
            List<Person> result = ctx.People.Where(person => person.Name.ToLower().Contains("ch")).ToList();
            PrettyPrint(result);
        }
        
        
    }
}