// Clase que representa a un entrenador Pokemon
class Trainer
{
    // Atributos del entrenador
    private string trainerName;
    private Pokemon pokemon;

    // Constructor de Trainer
    // Recibe el nombre del entrenador y el Pokemon que tiene asignado
    public Trainer(string trainerName, Pokemon pokemon)
    {
        this.trainerName = trainerName;
        this.pokemon = pokemon;
    }

    // Muestra la informacion del entrenador y de su Pokemon
    public void DisplayInfo()
    {
        Console.WriteLine($"Trainer Name: {trainerName}");
        pokemon.DisplayInfo();
    }

    // Ordena al Pokemon del entrenador atacar a otro Pokemon
    public void CommandAttack(Pokemon target)
    {
        pokemon.Attack(target);
    }
}
