namespace FirstTaskPSP.classes;

public class Helmet : Protection
{
    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}