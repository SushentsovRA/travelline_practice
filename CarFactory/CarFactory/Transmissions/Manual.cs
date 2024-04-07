using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Transmissions;
public class Manual : ITransmission
{
    public string Name { get; } = "Механическая";
    public int Speed { get; } = 20;
    public int NumberOfGears { get; } = 6;
}
