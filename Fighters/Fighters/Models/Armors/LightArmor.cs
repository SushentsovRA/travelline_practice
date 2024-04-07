using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Armors;
internal class LightArmor : IArmor
{
    public string Name { get; } = "Light armor";
    public int Armor { get; } = 5;
}
