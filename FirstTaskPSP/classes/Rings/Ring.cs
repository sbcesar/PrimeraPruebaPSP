using FirstTaskPSP.interfaces;

namespace FirstTaskPSP.classes.Pets;

public abstract class Ring: IItem
{
    public string Name { get; set; }
    
    public int Hp { get; set; }

    public abstract void Apply(Character character);
}