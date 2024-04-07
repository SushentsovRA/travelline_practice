using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Classes;
internal class Wizard : IClass
{
    public string Name { get; } = "Wizard";
    public int Damage { get; } = 15;
    public int Health { get; } = 10;
    public int Initiative { get; } = 3;
}
