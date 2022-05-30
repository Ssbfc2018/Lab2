Weapon newSword = new Sword();
Console.WriteLine("A Fire Based Enemy Appear!");
Console.WriteLine("Upgrade your weapon to win? (Y/N)");
while (Console.ReadLine() != "Y")
{
    Console.WriteLine("This is a Demo, please enter Y.");
}
newSword = new Ice(newSword);
Console.WriteLine("Upgrade Success!");
Console.WriteLine("Gain Special Ability of Ice: Can Defeat Fire Based Enemy. ");
Console.WriteLine("Congratulation! You defeat Fire Based Enemy! ");

public abstract class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Level { get; set; }
    protected List<string> ability;
    public virtual List<string> Ability()
    {
        return ability;
    }
    protected List<string> defeat;
    public virtual List<string> Defeat()
    {
        return defeat;
    }
}
public class Sword : Weapon
{
    public Sword()
    {
        Name = "Sword";
        Damage = 10;
        Level = 1;
    }
}
public class Axe : Weapon
{
    public Axe()
    {
        Name = "Axe";
        Damage = 8;
        Level = 1;
    }
}

public abstract class AbilityDecorator : Weapon
{
    public Weapon Weapon { get; set; }

    public abstract override List<string> Ability();
    public abstract override List<string> Defeat();
}
public class Ice : AbilityDecorator
{
    public Ice(Weapon weapon)
    {
        Weapon = weapon;
    }

    public override List<string> Ability()
    {
        Weapon.Ability().Add("Ice");
        return Weapon.Ability();
    }
    public override List<string> Defeat()
    {
        Weapon.Defeat().Add("Fire");
        return Weapon.Defeat();
    }
}
public class Fire : AbilityDecorator
{
    public Fire(Weapon weapon)
    {
        Weapon = weapon;
    }

    public override List<string> Ability()
    {
        Weapon.Ability().Add("Fire");
        return Weapon.Ability();
    }
    public override List<string> Defeat()
    {
        Weapon.Defeat().Add("Ice");
        return Weapon.Defeat();
    }
}
