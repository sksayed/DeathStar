using System;
using System.Collections.Generic;
using System.Text;

namespace DeathStar
{
    class Turret : IWeapon
    {
        public int Damage { get { return 500; } set => throw new NotImplementedException(); }
    }
}
