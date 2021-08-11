using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepsions
{
    public class RecordNotFoundExcepsion : Exception
    {
        public RecordNotFoundExcepsion(string message):base(message)
        {
            
        }
    }
}
