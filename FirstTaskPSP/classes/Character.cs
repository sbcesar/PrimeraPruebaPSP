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

    public void AddItem(IItem item)
    {
        _inventory.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        _inventory.Remove(item);
    }

    public int Attack()
    {
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
    }

    public void Heal(int hp)
    {
        CurrentHitPoints += hp;
        if (CurrentHitPoints >= MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }
    }

    public void ReceiveDamage(int totalDamage)
    {
        CurrentHitPoints -= totalDamage;
    }
}