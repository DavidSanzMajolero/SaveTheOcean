using System;

namespace SaveTheOcean
{
    /// <summary>
    /// Classe principal que gestiona el joc per salvar l'oceà.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mètode principal que inicia el joc.
        /// </summary>
        public static void Main()
        {
            string WelcomeMessage = "Salva l'oceà! \nQuè vols fer?\n1. Jugar!\n2. Sortir";
            string GoodbyeMessage = "Adéu!";

            Console.WriteLine(WelcomeMessage);
            int option;
            do
            {
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 1 && option != 2);

            switch (option)
            {
                case 1:
                    IniciarJoc();
                    break;
                case 2:
                    Console.WriteLine(GoodbyeMessage);
                    break;
            }
        }

        /// <summary>
        /// Mètode que inicia el joc.
        /// </summary>
        public static void IniciarJoc()
        {
            string SelectRole = "Genial! Quin és el teu rol?\n1. Tècnic (45 XP)\n2. Veterinari (80 XP)";
            string SelectName = "I el teu nom?";
            string InvalidOption = "Opció no vàlida.";
            string Choose = "Vols tractar-lo aquí (1) o transportar-lo al centre (2)?";


            Console.WriteLine(SelectRole);
            int roleOption;
            do
            {
                roleOption = Convert.ToInt32(Console.ReadLine());
            } while (roleOption != 1 && roleOption != 2);

            Console.WriteLine(SelectName);
            string name = Console.ReadLine();

            Person jugador;

            switch (roleOption)
            {
                case 1:
                    jugador = new Technician(name, 45);
                    break;
                case 2:
                    jugador = new Veterinarian(name, 80);
                    break;
                default:
                    Console.WriteLine(InvalidOption);
                    return;
            }

            Console.WriteLine($"Hola, {jugador.Name}! El 112 ha rebut una trucada de rescat d'un animal marí.");
            Animal animal = GenerarAnimalMaríAleatori();
            Console.ReadLine();
            Console.WriteLine("S'han proporcionat les següents dades:");
            Console.WriteLine($"Número de Rescat: {animal.NumberRescue}");
            Console.WriteLine($"Data de Rescat: {animal.RescueDate}");
            Console.WriteLine($"Espècie: {animal.Species}");
            Console.WriteLine($"Grau d'Afecte: {animal.AffectionDegree}%");
            Console.WriteLine($"Ubicació: {animal.Location}");
            Console.ReadLine();
            Console.WriteLine($"Aquí tens el perfil de l'animal:");
            Console.WriteLine($"Nom: {animal.Name}");
            Console.WriteLine($"Espècie: {animal.Species}");
            Console.WriteLine($"Pes aproximat: {animal.Weight}kg");

            Console.WriteLine(Choose);
            string treatmentOption = Console.ReadLine();
            int finalExperience = 0;
            switch (treatmentOption)
            {
                case "1":
                    finalExperience = CurarAnimal(animal, jugador);
                    break;
                case "2":
                    finalExperience = TransportarAnimal(animal, jugador);
                    break;
                default:
                    Console.WriteLine(InvalidOption);
                    return;
            }

            Console.WriteLine($"Els teus nous punts d'experiència: {finalExperience}");
        }

        /// <summary>
        /// Mètode que genera un animal marí de forma aleatòria.
        /// </summary>
        /// <returns>Retorna una instància de l'animal marí generat.</returns>
        public static Animal GenerarAnimalMaríAleatori()
        {
            Random random = new Random();
            int animalType = random.Next(1, 4);
            switch (animalType)
            {
                case 1:
                    return new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");
                case 2:
                    return new SeaBird("Ocell", "Ocell de mar", 12.4, "3/5/2023", "BCN");
                case 3:
                    return new Cetacean("Dofi", "Dofi blau", 54, "2/2/2023", "BCN");
                default:
                    return null;
            }
        }

        /// <summary>
        /// Mètode que cura un animal marí.
        /// </summary>
        /// <param name="animal">Animal marí a curar.</param>
        /// <param name="jugador">Jugador que realitza el tractament.</param>
        /// <returns>Retorna els nous punts d'experiència del jugador.</returns>
        public static int CurarAnimal(Animal animal, Person jugador)
        {
            int x;
            int nouGrauAfecte = 0;
            string GoodTreatment = "El rescat ha estat un èxit! L'animal es pot reintroduir a l'entorn natural.";
            string BadTreatment = "El tractament no ha estat suficient. L'animal necessita una revisió més a fons al centre.";

            switch (animal)
            {
                case Tortoise:
                    x = 5;
                    nouGrauAfecte = animal.AffectionDegree - (((animal.AffectionDegree - 2) * (2 * animal.AffectionDegree + 3)) - x);
                    break;
                case SeaBird:
                    x = 5;
                    nouGrauAfecte = animal.AffectionDegree - (animal.AffectionDegree * animal.AffectionDegree + x);
                    break;
                case Cetacean:
                    x = 25;
                    nouGrauAfecte = animal.AffectionDegree - (int)Math.Log10(animal.AffectionDegree) - x;
                    break;
            }


            if (nouGrauAfecte < 5)
            {
                Console.WriteLine(GoodTreatment);
                jugador.UpdateExperience(50);
            }
            else
            {
                Console.WriteLine(BadTreatment);
                jugador.UpdateExperience(-20);
            }
            return jugador.Experience;
        }

        /// <summary>
        /// Mètode que transporta un animal marí al centre per a una revisió més a fons.
        /// </summary>
        /// <param name="animal">Animal marí a transportar.</param>
        /// <param name="jugador">Jugador que realitza el transport.</param>
        /// <returns>Retorna els nous punts d'experiència del jugador.</returns>
        public static int TransportarAnimal(Animal animal, Person jugador)
        {
            string Msg = "L'animal ha estat transportat al centre per a una revisió més a fons.";
            Console.WriteLine(Msg);
            jugador.UpdateExperience(-20);
            return jugador.Experience;
        }
    }
}
