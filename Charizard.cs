// Clase Charizard que hereda de la clase PokemonFuego
class Charizard : PokemonFuego
{
    // Atributo propio de Charizard que indica si puede volar
    private bool canFly;

    // Constructor de Charizard
    // Recibe sus datos y utiliza base para enviarlos al constructor de PokemonFuego
    public Charizard(string name, int level, int health, int firePower, bool canFly, Attack attack)
        : base(name, level, health, firePower, attack)
    {
        this.canFly = canFly;
    }

    // Sobrescribe el metodo Attack heredado de PokemonFuego
    public override void Attack(Pokemon target)
    {
        // Muestra el ataque utilizado y aplica el daño al Pokemon objetivo
        Console.WriteLine($"Charizard usa {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}
