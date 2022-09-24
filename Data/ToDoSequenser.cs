using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoIT.Models;

namespace ToDoIT.Data
{
    internal class ToDoSequenser
    {
        private static int todoId;

        public static int NextToDoId()
        {
            return ++todoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }

    }
}
