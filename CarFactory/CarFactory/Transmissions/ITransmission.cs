using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Transmissions;
public interface ITransmission
{
    public string Name { get; }
    public int Speed { get; }
    public int NumberOfGears { get; }
}