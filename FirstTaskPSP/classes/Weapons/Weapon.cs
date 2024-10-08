using FirstTaskPSP.interfaces;

namespace FirstTaskPSP.classes;

public abstract class Weapon : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    
    public abstract void Apply(Character character);
}