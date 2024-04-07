using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Transmissions;
public class Automatic : ITransmission
{
    public string Name { get; } = "Автоматическая";
    public int Speed { get; } = 10;
    public int NumberOfGears { get; } = 5;
}