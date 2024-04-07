﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
internal class Sword : IWeapon
{
    public string Name { get; } = "Sword";
    public int Damage { get; } = 10;
}
