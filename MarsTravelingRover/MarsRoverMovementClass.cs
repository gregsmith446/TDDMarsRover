using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTravelingRover
{
    class MarsRoverMovementClass
    {
        public int[] RovingRover(int[] location, char direction, int[] grid, string commands)
        {

            for(var i = 0; i < commands.Length; i++)
            {
                if (direction == 'e' && commands[i] == 'r')
                    direction = 's';
                else if (direction == 's' && commands[i] == 'r')
                    direction = 'w';
                else if (direction == 'w' && commands[i] == 'r')
                    direction = 'n';
                else if (direction == 'n' && commands[i] == 'r')
                    direction = 'e';
                else if(direction == 'e' && commands[i] == 'l')
                    direction = 'n';
                else if(direction == 'n' && commands[i] == 'l')
                    direction = 'w';
                else if (direction == 'w' && commands[i] == 'l')
                    direction = 's';
                else if (direction == 's' && commands[i] == 'l')
                    direction = 'e';

                if (direction == 'e')
                {
                    if (commands[i] == 'f')
                    {   
                        if(location[1] == 100)
                            location[1] = 0;
                        else
                        location[1]++;
                    }
                    else if (commands[i] == 'b')
                    {
                        if (location[1] == 0)
                            location[1] = 100;
                        else
                            location[1]--;
                    }
                }

                if (direction == 's')
                {
                    if (commands[i] == 'f')
                    {
                        if (location[0] == 100)
                            location[0] = 0;
                        location[0]++;
                    }
                    else if (commands[i] == 'b')
                    {
                        if (location[0] == 0)
                            location[0] = 100;
                        else
                            location[0]--;
                    }
                }

                if (direction == 'n')
                {
                    if (commands[i] == 'f')
                    {
                        if (location[0] == 0)
                            location[0] = 100;
                        else
                            location[0]--;
                    }
                    else if (commands[i] == 'b')
                    {
                        if (location[0] == 100)
                            location[0] = 0;
                        else
                        location[0]++;
                    }
                }

                if (direction == 'w')
                {
                    if (commands[i] == 'f')
                    {
                        if (location[1] == 0)
                            location[1] = 100;
                        else
                            location[1]--;
                    }
                    else if (commands[i] == 'b')
                    {
                        if (location[1] == 100)
                            location[1] = 0;
                        else
                        location[1]++;
                    }
                }
            }
            return location;
        }

    }
}
