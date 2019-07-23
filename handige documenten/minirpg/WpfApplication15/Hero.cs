using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApplication15
{
    class Hero
    {
        private String name;
        private double currentHP;
        private double maxHP;
        private int level;
        private int xp;
        private int dmg;
        private double leech;
        private int result;
        private int maxMana;
        private int currentMana;


        public String Name
        {
            get
            {
                return name;
            }
        }
        public int MANA
        {
            get
            {
                return currentMana;
            }
        }

        public int XP
        {
            get
            {
                return xp;
            }
        }

        public int LEVEL
        {
            get
            {
                return level;
            }
        }

        public int AttackPoints
        {
            get
            {
                return dmg;
            }
        }

        public double Health
        {
            get
            {
                if (currentHP < 0)
                {
                    currentHP = 0;
                }
                return currentHP;
            }
        }

        public Hero(String heroname, int hp)
        {
            this.name = heroname;
            maxHP = hp;
            currentHP = maxHP;
            dmg = 20;
            leech = 0.1;
            maxMana = 10;
        }

        public void Fire(Bird enemey)
        {

            enemey.Damage(enemey.HP);
        }

        public void Attack(Bird enemey)
        {
          
                enemey.Damage(dmg);
        }

        public void Damage(int dmg)
        {
            currentHP = currentHP - dmg;
        }

        public void Attack(int amount, Hero h)
        {
            h.currentHP = h.currentHP - amount;
        }
        public void XpUp(int  exp)
        {
            xp = xp+exp;
        }
        public void LevelUp(int lvl)
        {
           if(xp >= 5)
            {
                level = level+ lvl;
                xp = 0;
            }
        }
        public void damageplus(int getal)
        {
            dmg = dmg + (getal*5);
        }
       
        public void leveldown(int getal)
        {
            level = level - getal;
        }
        public void vamp()
        {
           
            result = Convert.ToInt32(leech*dmg);
            currentHP = currentHP + result;
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
        }
        public void vampup(int getal)
        {
            leech = leech + (getal /5);
        }
        public void healthup(int getal)
        {
            maxHP = maxHP + (getal * 30);
            currentHP = currentHP + (getal * 30);
           
        }
        public void healthregen()
        {
          
                currentHP = currentHP + (maxHP*0.001);
            if(currentHP > maxHP)
            {
                currentHP = maxHP;
            }
               
            
        }
        public void manaregen()
        {
            currentMana++;
            if(currentMana > maxMana)
            {
                currentMana = maxMana;
            }
        }
        public void cooldown()
        {
            currentMana = 0;
        }
    }
}
