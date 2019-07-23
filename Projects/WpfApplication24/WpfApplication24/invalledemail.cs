using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication24
{
    class invalledemail : ApplicationException
    {
        public invalledemail(string msg = "Invalaid email") : base(msg)
        {

        }
    }
}
