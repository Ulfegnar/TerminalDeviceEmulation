using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Data
{
    public static class DataToPacket
    {
        private static PackageHandler _packageHandler = new PackageHandler();        

        public static Package GetPacket(byte[] message)
        {            
            var isValid = _packageHandler.ValidatePackage(message);
            if (isValid)
            {
                return _packageHandler.Parse(message);
            }
            else return null;
        }
    }
}
