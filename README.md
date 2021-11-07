# FiftyvilleDNP

This project is a practice in LINQ, and a theft mystery you must solve.
Included in the project is a fiftyville.db sqlite file with all the data.

The intention is that you write LINQ queries in QueryClass class, and use the PrettyPrint method to output a query result as a table in the console. The QueryClass uses NUnit so that you can make a new method for each query, and not have to delete previous queries. 

You will have to go to the DataAccess/FiftyVilleContext.cs class and change the Data Source path to point to the fiftville.db file in your project, when you have cloned the project.

The model classes have no associations amongst each other, so they are not modelled as EFC proposes (this would require a larger rework of the data set, which I might do later. It means you cannot use .Include() for anything). It is instead modelled more like a database, using various foreign keys.

Here is a global relations diagram of the database. The model classes with their attributes are named similarly, though using C# naming conventions.
<img src="https://github.com/TroelsMortensen/FiftyvilleDNP/blob/main/Fiftyville/GRdiagram.png" alt="drawing" width="1000"/>
The diagram is also found here: https://github.com/TroelsMortensen/FiftyvilleDNP/blob/main/Fiftyville/GRdiagram.png


# Description:

A rubber duck was stolen from Fiftyville.

The town of Fiftyville wants you to solve the mystery of the stolen duck.
Authorities believe that the theif/thieves stole the duck and then, shortly afterwards, took a flight out of town, with the help of an accomplice. 
Your goal is to identify:

1) Who the thief is,
2) What city the thief escaped to,
3) Who the thief's accomplice is who helped them escape

All you know is that 
- The theft took place on July 28.
- Took place on Chamberlin Street

Come up with a list of suspects. Can you narrow it down to 8? How much further down can you narrow your suspects?

<img src="https://github.com/TroelsMortensen/FiftyvilleDNP/blob/main/Fiftyville/Sherlock.jpg" alt="drawing" width="400"/>

# Credits
*This exercise was borrowed from https://cs50.harvard.edu/x/2021/seminars/
It was originally an SQL adventure, and I converted it for C#.
