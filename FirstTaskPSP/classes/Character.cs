using FirstTaskPSP.interfaces;

namespace FirstTaskPSP.classes;

public class Character
{
    string name;
    int MaxHitPoints;
    int CurrentHitPoints;
    int BaseDamage;
    int BaseArmor;
    private List<IItem> _inventory;
    
    

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

    public void ReceiveDamage(int damage)
    {
        CurrentHitPoints -= damage;
    }
}