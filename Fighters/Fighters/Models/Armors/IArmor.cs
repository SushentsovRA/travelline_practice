﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Armors;
public interface IArmor
{
    string Name { get; }
    int Armor { get; }
}