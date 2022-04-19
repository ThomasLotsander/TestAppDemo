using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
    internal class PersonService
    {
        public void SavePseronName(Person person)
        {
            // save name on person 

            var name = "Thomas";
            // Comment
            name = "Börje";

        }

        public void GetStuff()
        {
            throw new NotImplementedException();
        }

        public int WhatIsMyAge()
        {
            return 555;
        }
    }
}
