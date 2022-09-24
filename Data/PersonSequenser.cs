using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoIT.Models;

namespace ToDoIT.Data
{
    internal class PersonSequenser
    {
        private static int personId;

        public static int NextPersonId()
        {
            return ++personId;
        }

        public static void Reset()
        {
            personId = 0;
        }

    }
}
