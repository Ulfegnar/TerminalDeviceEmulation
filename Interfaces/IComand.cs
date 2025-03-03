using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUU.Commands
{
    public interface IComand
    {
        byte[] Signature { get; }
        byte TypeComand { get; }
    }
}
