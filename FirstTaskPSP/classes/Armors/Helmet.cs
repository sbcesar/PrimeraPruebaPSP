namespace FirstTaskPSP.classes;

public class Helmet : Protection
{
    public override void Apply(Character character)
    {
        Console.WriteLine(character.Name + " ha equipado " + Name + ", lo que aumenta su armadura en " + Armor + " puntos.\n");
        character.BaseArmor += Armor;
    }
}