using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Engines;
public class Gasoline : IEngine
{
    public string Name { get; } = "Бензиновый";
    public int Speed { get; } = 180;
}