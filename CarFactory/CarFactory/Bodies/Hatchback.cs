using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Bodies;
public class Hatchback : IBody
{
    public string Name { get; } = "Хэтчбек";
    public int Speed { get; } = 20;
}