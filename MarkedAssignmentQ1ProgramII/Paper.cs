using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignmentQ1ProgramII
{
    public class Paper : Tool
    {
        public Paper(int s)
        {
            strength = s;
            type = 'p';
        }

        public bool Fight(Tool opponent)
        {
            if (opponent.type == 'r')
            {
                return strength * 2 > opponent.strength;
            }
            else if (opponent.type == 's')
            {
                return strength / 2 > opponent.strength;
            }
            else
            {
                return strength > opponent.strength;
            }
        }
    }
}
