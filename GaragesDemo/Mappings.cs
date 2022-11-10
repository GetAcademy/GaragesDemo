using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesDemo
{
    internal class Mappings
    {
        public static string Postnr(Verksted v)
        {
            return v.Postnummer.ToString();
        }
    }
}
