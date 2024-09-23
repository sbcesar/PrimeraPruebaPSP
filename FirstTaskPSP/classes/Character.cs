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
        Console.WriteLine("Se ha añadido " + item.Name + ".");
    }

    public void RemoveItem(IItem item)
    {
        Inventory.Remove(item);
        Console.WriteLine("Se ha eliminado " + item.Name + ".");
    }

    public int Attack(Character target)
    {
        int totalDamage = BaseDamage;
        
        foreach (var item in Inventory)
        {
            var weapon = item as Weapon;
            if (weapon != null)
            {
                totalDamage += weapon.Damage;
            }
        }
        
        int weaponDamageAdded = totalDamage - target.Defense();
        if (weaponDamageAdded < 0) weaponDamageAdded = 0;

        return weaponDamageAdded;
    }

    public int Defense()
    {
        int totalArmor = BaseArmor;

        foreach (var item in Inventory)
        {
            var protection = item as Protection;
            if (protection != null)
            {
                totalArmor += protection.Armor;
            }
        }
        
        return totalArmor;
    }

    public int Heal(int hp)
    {
        int hpHealed = hp;
        CurrentHitPoints += hp;
        
        if (CurrentHitPoints > MaxHitPoints)
        {
            hpHealed -= (CurrentHitPoints - MaxHitPoints);
            CurrentHitPoints = MaxHitPoints;
        }

        return hpHealed;
    }

    public void ReceiveDamage(int damage)
    {
        int totalDamage = damage - Defense();

        if (totalDamage < 0)
        {
            totalDamage = 0;
        }
        
        CurrentHitPoints -= totalDamage;
        if (CurrentHitPoints < 0)
        {
            CurrentHitPoints = 0;
        }
    }
}