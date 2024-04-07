using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Armors;
internal class HeavyArmor : IArmor
{
    public string Name { get; } = "Heavy armor";
    public int Armor { get; } = 20;
}
