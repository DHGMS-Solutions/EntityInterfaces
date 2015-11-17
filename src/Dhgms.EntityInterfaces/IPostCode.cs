using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.EntityInterfaces
{
    public interface IPostCode
    {
        string OutwardCode { get; }

        string InwardCode { get; }
    }
}
