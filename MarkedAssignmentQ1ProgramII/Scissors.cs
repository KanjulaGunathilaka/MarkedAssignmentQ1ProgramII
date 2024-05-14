using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignmentQ1ProgramII
{
    public class Scissors : Tool
    {
        public Scissors(int s)
        {
            strength = s;
            type = 's';
        }

        public bool Fight(Tool opponent)
        {
            if (opponent.type == 'p')
            {
                return strength * 2 > opponent.strength;
            }
            else if (opponent.type == 'r')
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
