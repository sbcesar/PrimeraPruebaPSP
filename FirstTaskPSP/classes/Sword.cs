namespace FirstTaskPSP.classes;

public class Sword : Weapon
{
    public override void Apply(Character character)
    {
        Console.WriteLine(character.Name + " ha equipado " + Name + ", lo que aumenta su daño en " + Damage + " puntos.\n");
        character.BaseDamage += Damage;
    }
}