using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Bodies;
public class Sedan : IBody
{
    public string Name { get; } = "Седан";
    public int Speed { get; } = 0;
}