using FirstTaskPSP.interfaces;

namespace FirstTaskPSP.classes;

public class Character
{
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    
    private List<IItem> _inventory = new List<IItem>();
    
    public List<IItem> Inventory { get => _inventory; set => _inventory = value; }

    public void AddItem(IItem item)
    {
        Inventory.Add(item);
        Console.WriteLine("Se ha añadido " + item);
    }

    public void RemoveItem(IItem item)
    {
        Inventory.Remove(item);
        Console.WriteLine("Se ha eliminado " + item);
    }

    public int Attack(int hp, int damage)
    {
        return hp - damage;
    }

    public int Defense()
    {
        return BaseArmor;
    }

    public int Heal(int hp)
    {
        int hpHealed = MaxHitPoints - (CurrentHitPoints + hp);
        CurrentHitPoints = hp;
        if (CurrentHitPoints >= MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }

        return hpHealed;
    }

    public void ReceiveDamage(int totalDamage)
    {
        CurrentHitPoints -= totalDamage;
    }
}