﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Character : Tile
    {

        public enum Movement
        {
            Up,Down,Left,Right,None
        }

        protected int hp;
        protected int max_hp;
        protected int damage;
        protected Tile[] vision;

        public Character(int x, int y,Tile.TileType type) : base(x, y, type) { }
      

        public virtual void attack(Character target) 
        {
            target.setHp(target.getHp() - this.damage);
        }
    

        public Boolean isDead()
        {
            return hp <= 0;
        }


        public virtual Boolean checkRange(Character target) 
        { 
            return false;
        }

        private int distanceTo(Character target)
        {
            int x_diff = Math.Abs(target.getX() - this.x);
            int y_diff = Math.Abs(target.getY() - this.y);

            return x_diff + y_diff;
        }

        public void move(Movement direction)
        {
            if(direction == Movement.Up) { --this.y; }
            else if(direction == Movement.Down) { ++this.y; }
            else if(direction == Movement.Left) { --this.x; }
            else if(direction == Movement.Right) { ++this.x; }
        }

        public abstract Movement returnMove(Movement direction = 0);

        public abstract override string ToString();

        public void setHp(int hp)
        {
            this.hp = hp;
            if (hp <= 0)
            {
                hp = 0;
            }
        }

        public int getHp()
        {
            return this.hp;
        }

        public void setMaxHp(int max_hp)
        {
            this.max_hp = max_hp;
        }

        public int getMaxHp()
        {
            return this.max_hp;
        }

        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public int getDamage()
        {
            return this.damage;
        }

        public void setVision(Tile[] vision)
        {
            this.vision = vision;
        }

        public Tile[] getVision()
        {
            return this.vision;
        }

        
    }
}
