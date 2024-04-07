using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
internal class Axe : IWeapon
{
    public string Name { get; } = "Axe";
    public int Damage { get; } = 15;
}
