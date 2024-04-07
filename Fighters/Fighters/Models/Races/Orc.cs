using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
internal class Orc : IRace
{
    public string Name { get; } = "Orc";
    public int Damage { get; } = 20;
    public int Health { get; } = 110;
    public int Armor { get; } = 5;
    public int Initiative { get; } = 5;
}
