using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataMarsRover
{
    public class RoverLeft
    {
        public string Direction(string pos)
        {
            switch (pos)
            {
                case "^":
                    return "<";
                case ">":
                    return "^";
                case "v":
                    return ">";
                case "<":
                    return "v";
            }
            return pos;
        }


    }
}
