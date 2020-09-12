﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Map
    {
        private Random rnd = new Random();

        private Tile[,] map;
        private Hero hero;
        private Enemy[] enemies;
        private int width;
        private int height;

        public Map(int min_width,int max_width,int min_height,int max_height,int num_enemies)
        {
            this.width = rnd.Next(min_width, max_width + 1);
            this.height = rnd.Next(min_height, max_height + 1);

            this.map = new Tile[height, width];
            this.enemies = new Enemy[num_enemies];
            generateEmptyMap();
            this.hero = (Hero)create(Tile.TileType.Hero);

            for (int i = 0; i < enemies.Length; ++i)
            {
                enemies[i] = (Goblin)create(Tile.TileType.Enemy);
            }

            updateVision();
        }

        private void generateEmptyMap()
        {
            for(int i= 0; i < height;++i)
            {
                for(int j = 0; j < width; ++j)
                {
                    if (i == 0 || i == (height - 1))
                    {
                        map[i, j] = new Obstacle(i, j);
                    }
                    else if (j == 0 || j == (width - 1))
                    {
                        map[i, j] = new Obstacle(i, j);
                    }
                    else
                    {
                        map[i, j] = new EmptyTile(i, j);
                    }
                }
            }
        }

        private Tile create(Tile.TileType type)
        {
            int[] spawn_location = getSpawnPosition();

            if(type == Tile.TileType.Hero)
            {
                return new Hero(spawn_location[1], spawn_location[0], 10);
            }
            else if(type == Tile.TileType.Enemy)
            {
                return new Goblin(spawn_location[1], spawn_location[0]);
            }
            else
            {
                return new EmptyTile(spawn_location[1], spawn_location[0]);
            }
        }

        private void updateVision()
        {
            hero.setVision(returnVision(hero.getX(), hero.getY()));

            for (int i = 0; i < enemies.Length; ++i)
            {
              
                enemies[i].setVision(returnVision(enemies[i].getX(), enemies[i].getY()));
            }
        }

        private Tile[] returnVision(int x,int y)
        {
            Tile[] vision = new Tile[4];

            vision[0] = map[y - 1, x];  //North
            vision[1] = map[y + 1, x];  //South
            vision[2] = map[y, x - 1];  //West
            vision[4] = map[y, x + 1];  //East

            return vision;

        }

        private int[] getSpawnPosition()
        {
            int x_position = rnd.Next(1, width);
            int y_position = rnd.Next(1, height);

            if(map[y_position,x_position] is EmptyTile)
            {
                int[] s_point = new int[2];
                s_point[0] = y_position;
                s_point[1] = x_position;

                return s_point;
            }
            else
            {
                return getSpawnPosition();
            }
        }

        public void setMap(Tile[,] map)
        {
            this.map = map;
        }

        public Tile[,] getMap()
        {
            return this.map;
        }

        public void setHero(Hero hero)
        {
            this.hero = hero;
        }

        public Hero getHero()
        {
            return this.hero;
        }

        public void setEnemies(Enemy[] enemies)
        {
            this.enemies = enemies;
        }

        public Enemy[] getEnemies()
        {
            return this.enemies;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return this.width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getHeight()
        {
            return this.height;
        }
    }
}
