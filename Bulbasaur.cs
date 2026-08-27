class Bulbasaur : Pokemon
{
    private int solarPower;
    public Bulbasaur(string name, int level, int health, int solarPower, Attack attack) : base(name, level, health, attack)
    {
        this.solarPower = solarPower;
    }
    public override void Attack(Pokemon target)
    {
            Console.WriteLine($"Bulbasaur usa {GetAttack().GetName()}.");
            target.TakeDamage(GetAttack().GetDamage());
    }
}   