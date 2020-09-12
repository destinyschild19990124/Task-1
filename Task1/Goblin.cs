using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Goblin : Enemy
    {

        public Goblin(int x,int y) : base(x, y, Tile.TileType.Enemy, 1, 10) { }

        public override Movement returnMove()
        {
            Character.Movement direction = (Character.Movement)(rnd.Next(0, 6));

            if(direction == Character.Movement.Up)
            {

            }else if(direction == Character.Movement.Down)
            {

            }else if(direction == Character.Movement.Left)
            {

            }else if(direction == Character.Movement.Right)
            {

            }
            else
            {
                return Character.Movement.None;
            }
            
        }


    }
}
