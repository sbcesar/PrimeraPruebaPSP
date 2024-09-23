﻿using FirstTaskPSP.classes;

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
guerrero.AddItem(casco);
guerrero.AddItem(escudo);

Character mago = new Character
{
    Name = "Hermana Friede",
    MaxHitPoints = 85,
    BaseDamage = 23,
    BaseArmor = 6
};

mago.AddItem(espada);
mago.AddItem(casco);
mago.AddItem(hacha);
mago.RemoveItem(hacha);

mago.CurrentHitPoints = guerrero.Attack(mago.MaxHitPoints, guerrero.BaseDamage);
Console.WriteLine("El guerrero " + guerrero.Name + " ha atacado a " + mago.Name + ".");
Console.WriteLine(mago.CurrentHitPoints + " hp.");
int hpHealed = mago.Heal(20);
Console.WriteLine("El mago " + mago.Name + " se ha curado " + hpHealed + ".");
Console.WriteLine("La hp actual de " + mago.Name + " es " + mago.CurrentHitPoints + ".");

