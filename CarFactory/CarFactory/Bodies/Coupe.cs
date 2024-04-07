using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Bodies;
public class Coupe : IBody
{
    public string Name { get; } = "Купе";
    public int Speed { get; } = 10;
}