namespace FirstTaskPSP.classes.Pets;

public class Pet: Ring
{
    
    public override void Apply(Character character)
    {
        Console.WriteLine(character.Name + " has summoned a pet " + Name + ", lo que aumenta su vida máxima en " + Hp + " puntos.\n");
        character.MaxHitPoints += Hp;
        character.CurrentHitPoints += Hp;
    }
}