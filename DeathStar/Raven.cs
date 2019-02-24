using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
   public class Raven : IBattleShip, IShip
    {
        public List<IWeapon> Weapons { get; set; }
        public int Sheild { get; set; }
        public int Armor { get; set; }

        public int FireWeapon()
        {
            int damage = 0;

            if (Weapons != null)
            {
                foreach (var wp in Weapons)
                {
                    damage += wp.Damage;
                }
            }

            return damage;
        }
    }
}
