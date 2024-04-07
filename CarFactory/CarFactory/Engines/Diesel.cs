using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Engines;
public class Diesel : IEngine
{
    public string Name { get; } = "Дизельный";
    public int Speed { get; } = 150;
}