using FirstTaskPSP.interfaces;

namespace FirstTaskPSP.classes;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }
    
    public abstract void Apply(Character character);
}