using System;
using System.IO;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter();

            //if no arguments provided then use default filename 'unsorted-names-list.txt' on current dir
            if (args.Length == 0)
            {
                string[] sortedNames = sorter.SortNamesOnFile("unsorted-names-list.txt");
                Array.ForEach(sortedNames, Console.WriteLine);
                sorter.WriteNamesToFile(sortedNames);
            }

            Console.ReadLine();
        }

        
    }
}
