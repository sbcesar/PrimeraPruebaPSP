namespace FirstTaskPSP.classes;

public class Sword : Weapon
{
    public override void Apply(Character character)
    {
        character.ReceiveDamage(Damage);
    }
}