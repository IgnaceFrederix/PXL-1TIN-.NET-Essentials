using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication15
{
    class Bird
    {

        private int currentHP;
        private int maxHP;
        private int dmg=10;

        public int HP
        {
            get
            {
                if(currentHP< 0)
                {
                    currentHP = 0;
                }

                return currentHP;
            }
        }
        public int AttackPoints
        {
            get
            {
                return dmg;
            }
        }


        public Bird(int hp)
        {
            maxHP = hp;
            currentHP = maxHP;
           
        }

        internal void Damage(int dmg)
        {
            currentHP = currentHP - dmg;
        }
        public void Attack(Hero h)
        {
            h.Damage(dmg);
        }

        public void Attack(int amount, Bird b)
        {
            b.currentHP = b.currentHP - amount;
        }

        public void Attackup(int attack)
        {

            dmg = dmg + attack;
        }
    }
}
