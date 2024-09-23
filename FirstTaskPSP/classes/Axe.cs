namespace FirstTaskPSP.classes;

public class Axe : Weapon
{
    public override void Apply(Character character)
    {
        character.ReceiveDamage(Damage);
    }
}