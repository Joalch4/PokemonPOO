class Squirtle : Pokemon
{
    private int waterPower;

    public Squirtle(string name, int level, int health, int waterPower, Attack attack)
        : base(name, level, health, attack)
    {
        this.waterPower = waterPower;
    }

    public override void Attack(Pokemon target)
    {
            Console.WriteLine($"Squirtle usa {GetAttack().GetName()}.");
            target.TakeDamage(GetAttack().GetDamage());
    }
}