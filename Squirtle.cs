// Clase Squirtle que hereda de la clase Pokemon
class Squirtle : Pokemon
{
    // Atributo propio de Squirtle relacionado con su poder de agua
    private int waterPower;

    // Constructor de Squirtle
    // Utiliza base para enviar los datos principales al constructor de Pokemon
    public Squirtle(string name, int level, int health, int waterPower, Attack attack)
        : base(name, level, health, attack)
    {
        this.waterPower = waterPower;
    }

    // Sobrescribe el metodo Attack heredado de Pokemon
    public override void Attack(Pokemon target)
    {
        // Muestra el ataque utilizado y aplica el daño al Pokemon objetivo
        Console.WriteLine($"Squirtle usa {GetAttack().GetName()}.");
        target.TakeDamage(GetAttack().GetDamage());
    }
}
