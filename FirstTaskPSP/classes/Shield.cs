namespace FirstTaskPSP.classes;

public class Shield : Protection
{
    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}