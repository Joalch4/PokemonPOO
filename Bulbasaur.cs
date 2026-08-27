// Clase Bulbasaur que hereda de la clase Pokemon
class Bulbasaur : Pokemon
{
    // Atributo propio de Bulbasaur
    private int solarPower;

    // Constructor de Bulbasaur
    // Recibe sus datos y utiliza base para enviarlos al constructor de Pokemon
    public Bulbasaur(string name, int level, int health, int solarPower, Attack attack)
        : base(name, level, health, attack)
    {
        this.solarPower = solarPower;
    }

    // Sobrescribe el metodo Attack heredado de Pokemon
    public override void Attack(Pokemon target)
    {
        // Muestra el ataque utilizado y aplica el daño al Pokemon objetivo
        Console.WriteLine($"Bulbasaur usa {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}
