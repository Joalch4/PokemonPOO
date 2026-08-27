class PokemonFuego : Pokemon
{
    private int firePower;

    public PokemonFuego(string name, int level, int health, int firePower, Attack attack) : base(name, level, health, attack)
    {
        this.firePower = firePower;
    }
    public override void Attack(Pokemon target)
    {
        Console.WriteLine($"El pokemon de fuego esta atacando con {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}