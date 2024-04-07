using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Bodies;
public interface IBody
{
    public string Name { get; }
    public int Speed { get; }
}