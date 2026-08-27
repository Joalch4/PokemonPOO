class Charizard : PokemonFuego
{
    private bool canFly;
    public Charizard(string name, int level, int health, int firePower, bool canFly, Attack attack) : base(name, level, health, firePower, attack)
    {
        this.canFly = canFly;
    }
    public override void Attack(Pokemon target)
    {
        Console.WriteLine($"Charizard usa {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}