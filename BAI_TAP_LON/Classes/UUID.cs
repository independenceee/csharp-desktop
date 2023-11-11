using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.Classes
{
    internal class UUID
    {
        public string getUUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
