using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignmentQ1ProgramII
{
    public class Rock : Tool
    {
        public Rock(int s)
        {
            strength = s;
            type = 'r';
        }
        public bool Fight(Tool opponent)
        {
            if (opponent.type == 's')
            {
                return strength * 2 > opponent.strength;
            }
            else if (opponent.type == 'p')
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
