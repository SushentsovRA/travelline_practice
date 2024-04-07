using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;
public interface IFighter
{
    public string Name { get; }
    public int CurrentHealth { get; }
    public IWeapon Weapon { get; }
    public IRace Race { get; }
    public IClass Class { get; }
    public IArmor Armor { get; }

    public void TakeDamage( int damage );
    public int CalculateDamage();
    public int CalculateDefense();
    public int MaxHealth();
}