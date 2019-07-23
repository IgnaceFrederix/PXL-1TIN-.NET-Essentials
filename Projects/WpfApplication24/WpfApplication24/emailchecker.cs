using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication24
{
    class emailchecker
    {
        public void checkAdress(string email)
        {
            if (email.Contains('@'))
            {
                //geldig email
            }
            else
            {
                throw new invalledemail
            }
        }
    }
}
