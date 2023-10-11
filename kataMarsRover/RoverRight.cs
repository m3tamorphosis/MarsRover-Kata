using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataMarsRover
{
    public class RoverRight
    {
        public string Direction(string pos)
        {
            switch (pos)
            {
                case "^":
                    return ">";
                case ">":
                    return "v";
                case "v":
                    return "<";
                case "<":
                    return "^";
            }
            return pos;
        }

    }
}
