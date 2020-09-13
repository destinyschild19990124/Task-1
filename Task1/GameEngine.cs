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

        public Tile[,] getMapView()
        {
            return map.getMap();
        }

        public int getWidth()
        {
            return map.getWidth();
        }

        public int getHeight()
        {
            return map.getHeight();
        }

        public Boolean movePlayer(Character.Movement dir)
        {

            moveEnemies();
        }

        private void moveEnemies()
        {

        }

        public Boolean attackEnemy(Character.Movement dir)
        {

            moveEnemies();
        }

    }
}
