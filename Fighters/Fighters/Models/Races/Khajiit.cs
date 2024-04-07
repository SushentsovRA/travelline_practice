using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
internal class Khajiit : IRace
{
    public string Name { get; } = "Khajiit";
    public int Damage { get; } = 15;
    public int Health { get; } = 90;
    public int Armor { get; } = 15;
    public int Initiative { get; } = 7;
}
