using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
   public interface IBattleShip
    {
        List<IWeapon> Weapons { get; set; }
    }
}
