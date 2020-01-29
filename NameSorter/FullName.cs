using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class FullName
    {
        public FullName(string fullName)
        {
            string[] givenName = fullName.Split(' ');

            if (givenName.Length > 0)
            {
                this.FirstName = givenName.First();
            }
            else
            {
                this.FirstName = "";
            }

            if (givenName.Length > 1)
            {
                this.LastName = givenName.Last();
            }
            else
            {
                this.LastName = "";
            }

            if (givenName.Length > 2)
            {
                this.SecondName = givenName[1];
            }
            else
            {
                this.SecondName = "";
            }

            if (givenName.Length > 3)
            {
                this.ThirdName = givenName[2];
            }
            else
            {
                this.ThirdName = "";
            }
        }

        public string GetFullName()
        {
            string fullname = "";
            if (!string.IsNullOrEmpty(this.FirstName))
            {
                fullname += this.FirstName;
            }
            if (!string.IsNullOrEmpty(this.SecondName))
            {
                fullname += " " + this.SecondName;
            }
            if (!string.IsNullOrEmpty(this.ThirdName))
            {
                fullname += " " + this.ThirdName;
            }
            if (!string.IsNullOrEmpty(this.LastName))
            {
                fullname += " " + this.LastName;
            }

            return fullname;
        }

        // Properties.
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
    }
}
