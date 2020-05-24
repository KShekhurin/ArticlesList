using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class IdCreator
    {
        static int currentId = 0;

        public static int CreateId()
        {
            currentId++;
            return currentId;
        }
    }
}
