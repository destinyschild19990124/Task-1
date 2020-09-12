using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GameEngine
    {

        private Map map;

        public GameEngine(int min_width,int max_width,int min_height,int max_height,int num_enemies)
        {
            map = new Map(min_width, max_width, min_height, max_height, num_enemies);
        }

        public Boolean movePlayer(Character.Movement dir)
        {

        }

    }
}
