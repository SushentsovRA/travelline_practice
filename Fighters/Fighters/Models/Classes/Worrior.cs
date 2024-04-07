using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Classes;
internal class Worrior : IClass
{
    public string Name { get; } = "Worrior";
    public int Damage { get; } = 10;
    public int Health { get; } = 50;
    public int Initiative { get; } = 5;
}
