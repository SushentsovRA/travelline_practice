using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Classes;
internal class Bandit : IClass
{
    public string Name { get; } = "Bandit";
    public int Damage { get; } = 5;
    public int Health { get; } = 5;
    public int Initiative { get; } = 1;
}
