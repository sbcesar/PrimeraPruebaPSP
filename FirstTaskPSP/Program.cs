using FirstTaskPSP.classes;

Axe hacha = new Axe { Name = "Gran hacha de Caballero Negro", Damage = 20 };
Sword espada = new Sword { Name = "Uchigatana", Damage = 16 };
Helmet casco = new Helmet { Name = "Yelmo de Gundyr", Armor = 8 };
Shield escudo = new Shield { Name = "Gran escudo de Havel", Armor = 12 };

Character guerrero = new Character
{
    Name = "Siegmeyer de Catarina",
    MaxHitPoints = 100,
    CurrentHitPoints = 100,
    BaseDamage = 11,
    BaseArmor = 13
};

guerrero.AddItem(hacha);
hacha.Apply(guerrero);
guerrero.AddItem(casco);
casco.Apply(guerrero);
guerrero.AddItem(escudo);
escudo.Apply(guerrero);

Console.WriteLine("---->" + guerrero.Name + " tiene ahora un daño base de " + guerrero.BaseDamage + " y una armadura base de " + guerrero.BaseArmor + ".\n");

Character mago = new Character
{
    Name = "Hermana Friede",
    MaxHitPoints = 85,
    BaseDamage = 23,
    BaseArmor = 6
};

mago.AddItem(espada);
espada.Apply(mago);
mago.AddItem(casco);
casco.Apply(mago);

Console.WriteLine("---->" + mago.Name + " tiene ahora un daño base de " + mago.BaseDamage + " y una armadura base de " + mago.BaseArmor + ".\n");

Console.WriteLine("AHORA VIENE EL PVP");
Console.WriteLine("-------------------");
int dañoInfligido = guerrero.Attack(mago);
mago.ReceiveDamage(dañoInfligido);

Console.WriteLine("El guerrero " + guerrero.Name + " ha atacado a " + mago.Name + ".");
Console.WriteLine(mago.Name + " ahora tiene " + mago.CurrentHitPoints + " puntos de vida.");

int puntosCurados = mago.Heal(20);

Console.WriteLine(mago.Name + " se ha curado " + puntosCurados + " puntos de vida.");
Console.WriteLine("La vida actual de " + mago.Name + " es " + mago.CurrentHitPoints + ".");

