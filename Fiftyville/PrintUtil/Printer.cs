using System;
using System.Collections.Generic;
using System.Reflection;

namespace Fiftyville.PrintUtil
{
    public class Printer
    {
        public static void PrettyPrint<T>(List<T> list)
        {
            var properties = typeof(T).GetProperties();
            Dictionary<string, int> columnLengths = InitializeInfo(list, properties);
            var tableHeader = CreateTableHeader<T>(properties, columnLengths);
            
            string top = "";
            string bottom = "";
            for (int i = 0; i < tableHeader.Length; i++)
            {
                top += "_";
                bottom += "-";
            }

            tableHeader += bottom ;
            var table = CreateTable(list, tableHeader, properties, columnLengths);

            Console.WriteLine("\n"+top);
            Console.WriteLine(table);
            Console.WriteLine(bottom +"\n");
        }

        private static string CreateTable<T>(List<T> list, string tableHeader, PropertyInfo[] properties, Dictionary<string, int> columnLengths)
        {
            string table = tableHeader + "\n";
            foreach (T item in list)
            {
                string row = "";
                foreach (PropertyInfo prop in properties)
                {
                    string rowItem = prop.GetValue(item) != null ? prop.GetValue(item)?.ToString() : "null";
                    while (rowItem.Length <= columnLengths[prop.Name])
                    {
                        rowItem += " ";
                    }

                    row += rowItem + "| ";
                }

                row = row.TrimEnd('|');
                table += row + "\n";
            }

            table = table.TrimEnd('\n');
            return table;
        }

        private static string CreateTableHeader<T>(PropertyInfo[] properties, Dictionary<string, int> columnLengths)
        {
            string tableHeader = "";
            foreach (PropertyInfo prop in properties)
            {
                string headerItem = prop.Name;
                while (headerItem.Length <= columnLengths[prop.Name])
                {
                    headerItem += " ";
                }

                tableHeader += headerItem + "| ";
            }

            tableHeader = tableHeader.TrimEnd('|');
            return tableHeader;
        }

        private static Dictionary<string, int> InitializeInfo<T>(List<T> list, PropertyInfo[] properties)
        {
            Dictionary<string, int> columnLengths = new Dictionary<string, int>();

            foreach (PropertyInfo prop in properties)
            {
                columnLengths.Add(prop.Name, prop.Name.Length);
            }

            // Finding column lengths
            foreach (T item in list)
            {
                foreach (PropertyInfo prop in properties)
                {
                    if (prop.GetValue(item) != null && columnLengths[prop.Name] < prop.GetValue(item).ToString().Length)
                    {
                        columnLengths[prop.Name] = prop.GetValue(item).ToString().Length;
                    }
                }
            }

            return columnLengths;
        }
    }
}