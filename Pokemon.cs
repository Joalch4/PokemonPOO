// Clase principal que representa un Pokemon
class Pokemon
{
    // Atributos principales de un Pokemon
    private string name;
    private int level;
    private int health;
    private Attack attack;

    // Constructor de Pokemon
    // Recibe los datos necesarios para crear un objeto Pokemon
    public Pokemon(string name, int level, int health, Attack attack)
    {
        this.name = name;
        this.level = level;
        this.health = health;
        this.attack = attack;
    }

    // Devuelve el ataque asignado al Pokemon
    public Attack GetAttack()
    {
        return attack;
    }

    // Muestra la informacion del Pokemon en consola
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Level: {level}, Health: {health}");
    }

    // Reduce la vida del Pokemon segun el daño recibido
    public void TakeDamage(int damage)
    {
        health = health - damage;

        // Evita que la vida del Pokemon sea menor que cero
        if (health < 0)
        {
            health = 0;
        }
    }

    // Metodo virtual que permite que las clases hijas
    // puedan sobrescribir su forma de atacar
    public virtual void Attack(Pokemon target)
    {
        // Muestra el ataque y aplica el daño al Pokemon objetivo
        Console.WriteLine($"{name} usa {attack.GetName()}.");
        target.TakeDamage(attack.GetDamage());
    }
}
