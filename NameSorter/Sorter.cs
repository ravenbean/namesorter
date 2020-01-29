using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class Sorter
    {
        /// <summary>
        /// Read file content and convert it into array of string
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>array of string</returns>
        public string[] ReadUnsortedNames(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
                return lines;
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return Array.Empty<string>();
            }
        }
        
        /// <summary>
        /// sort names by alphabetically, start by lastname then into any given names
        /// </summary>
        /// <param name="names">array of string contains names</param>
        /// <param name="isAsc">default value is ascending</param>
        /// <returns></returns>
        public string[] SortNames(string[] names, bool isAsc = true)
        {
            try
            {
                List<FullName> fullNames = new List<FullName>();
                foreach (string name in names)
                {
                    fullNames.Add(new FullName(name));
                }

                if (isAsc)
                {
                    List<FullName> sorted = fullNames.ToList().OrderBy(x => x.LastName).ThenBy(x => x.ThirdName).ThenBy(x => x.SecondName).ThenBy(x => x.FirstName).ToList();
                    return sorted.Select(x => x.GetFullName()).ToArray<string>();
                }
                else
                {
                    List<FullName> sorted = fullNames.ToList().OrderByDescending(x => x.LastName).ThenByDescending(x => x.ThirdName).ThenByDescending(x => x.SecondName).ThenByDescending(x => x.FirstName).ToList();
                    return sorted.Select(x => x.GetFullName()).ToArray<string>();
                }
            }
            catch(Exception e)
            {
                return Array.Empty<string>();
            }
        }
        
        public void WriteNamesToFile(string[] names, string filename = "sorted-names-list.txt")
        {
            try
            {
                File.WriteAllLines(filename, names);
            }
            catch(Exception e)
            {

            }
        }

        public string[] SortNamesOnFile(string filename, bool isAsc = true)
        {
            try
            {
                string[] unsortedNames = ReadUnsortedNames(filename);
                string[] sortedNames = SortNames(unsortedNames);
                return sortedNames;
            }
            catch(Exception e)
            {
                return Array.Empty<string>();
            }
        }
    }
}
