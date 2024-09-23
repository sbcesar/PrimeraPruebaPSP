using FirstTaskPSP.classes;

namespace FirstTaskPSP.interfaces;

public interface IItem
{
    string Name { get; set; }
    void Apply(Character character);
}