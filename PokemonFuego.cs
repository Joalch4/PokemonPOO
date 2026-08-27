// Clase PokemonFuego que hereda de la clase Pokemon
class PokemonFuego : Pokemon
{
    // Atributo propio de los Pokemon de tipo fuego
    private int firePower;

    // Constructor de PokemonFuego
    // Utiliza base para enviar los datos principales al constructor de Pokemon
    public PokemonFuego(string name, int level, int health, int firePower, Attack attack)
        : base(name, level, health, attack)
    {
        this.firePower = firePower;
    }

    // Sobrescribe el metodo Attack heredado de Pokemon
    public override void Attack(Pokemon target)
    {
        // Muestra el ataque utilizado y aplica el daño al Pokemon objetivo
        Console.WriteLine($"El pokemon de fuego esta atacando con {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}
