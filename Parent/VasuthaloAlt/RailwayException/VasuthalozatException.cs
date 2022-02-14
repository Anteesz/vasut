using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthaloAlt.RailwayException
{
    class VasuthalozatException : Exception
    {
        public VasuthalozatException(string uzenet): base(uzenet) { }

    }
}
