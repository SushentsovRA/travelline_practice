using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Armors;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using Fighters.Models.Classes;

namespace Fighters.Models.Fighters;
public class Fighter : IFighter
{
    public int CurrentHealth { get; private set; }
    public string Name { get; }
    public IRace Race { get; }
    public IClass Class { get; }    
    public IWeapon Weapon { get; }
    public IArmor Armor { get; }
    
    public Fighter( string name, IRace race, IClass _class, IWeapon weapon, IArmor armor)
    {
        Name = name;
        Race = race;
        Class = _class;
        CurrentHealth = MaxHealth();
        Weapon = weapon;
        Armor = armor;
    }

    public int MaxHealth()
    {
        return Race.Health + Class.Health;
    }

    public int CalculateDamage()
    {
        return Race.Damage + Class.Damage + Weapon.Damage;
    }

    public int CalculateDefense()
    {
        return Race.Armor + Armor.Armor;
    }

    public void TakeDamage( int damage )
    {
        CurrentHealth -= damage;
        if ( CurrentHealth < 0 )
        {
            CurrentHealth = 0;
        }
    }
}