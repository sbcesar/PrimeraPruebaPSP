using FirstTaskPSP.classes;

class Program
{
    static void Main(string[] args)
    {
        Axe hacha = new Axe { Name = "Gran hacha de CAballero Negro", Damage = 20 };
        Sword espada = new Sword { Name = "Uchigatana", Damage = 16 };
        Helmet casco = new Helmet { Name = "Yelmo de Gundyr", Armor = 8 };
        Shield escudo = new Shield { Name = "Gran escudo de Havel", Armor = 12 };
    }

    private Character guerrero = new Character
    {
        Name = "Siegmeyer de Catarina",
        MaxHitPoints = 100,
        BaseDamage = 11,
        BaseArmor = 13
    };
    
    

    private Character mago = new Character
    {
        Name = "Hermana Friede",
        MaxHitPoints = 85,
        BaseDamage = 23,
        BaseArmor = 6
    };
    
    
}