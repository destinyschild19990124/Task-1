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
            if (map.getHero().returnMove(dir) != Character.Movement.None)
            {
                map.updateCharaterPosition(map.getHero(), dir);
                moveEnemies();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void moveEnemies()
        {
            Enemy[] enemies = map.getEnemies();

            for(int i = 0; i < enemies.Length; ++i)
            {
                Character.Movement direction = enemies[i].returnMove(Character.Movement.None);  //None is just a placeholder
                map.updateCharaterPosition(enemies[i], direction);
            }
        }

        public Boolean attackEnemy(Character.Movement dir)
        {
            Hero h = map.getHero();
            Tile target = new EmptyTile(0,0); // Set as an empty tile for placeholding

            switch (dir)
            {
                case Character.Movement.Up:
                    target = map.getMap()[h.getY() - 1, h.getX()];
                    break;
                case Character.Movement.Down:
                    target = map.getMap()[h.getY() + 1, h.getX()];
                    break;
                case Character.Movement.Left:
                    target = map.getMap()[h.getY(), h.getX() - 1];
                    break;
                case Character.Movement.Right:
                    target = map.getMap()[h.getY(), h.getX() + 1];
                    break;
            }

            if(target is Enemy)
            {

                h.attack((Character)target);
                Character c_target = (Character)target;

                if (c_target.isDead())
                {
                    map.removeFromMap(c_target);
                }

                moveEnemies();

                return true;
            }
            else
            {
                return false;
            }

            
        }

    }
}
