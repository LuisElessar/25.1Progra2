using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSem1
{
    internal class Menu : IMenu
    {
        private Player player;
        private Dictionary<int, string> decisions = new Dictionary<int, string>()
        {
            {1, "Explorar el bosque" },
            {2, "Descansar en la posada" },
            {3, "Explorar la plaza" },
            {4, "Entrenar con los solados" },
            {5, "Explorar las cuevas" }
        };

        public void Execute()
        {
            CreatePlayer();
            ShowMenu();
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Introduce el nombre del jugador:");
            string name = Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"¡Bienvenido! {player.Name} actualmente eres nivel: {player.Level} y tienes {player.Experience} de experiencia. ¡Que tu estadía sea próspera!");
        }
        private void ShowMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Elige qué hacer aventurero:");
                foreach (var decision in decisions)
                {
                  Console.WriteLine($"{decision.Key}: {decision.Value}");
                }
                Console.WriteLine("0: Salir");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Exploraste el bosque y encontraste un cofre");
                            player.GainExperience(60);
                            break;
                        case 2: 
                            Console.WriteLine("Has entrado a descansar y recuperar tus energías, acompañado de una buena cerveza");
                            break;
                        case 3: 
                            Console.WriteLine("En el centro de la plaza te encuentras un anciano de aspecto extraño. Oculto entre viejos ropajes te otorga un pequeño mapa, esperando tener tu ayuda");
                            break;
                        case 4: 
                            Console.WriteLine("Entrenas con los soldados, y ganas experiencia");
                            player.GainExperience(40);
                            break;
                        case 5: 
                            Console.WriteLine("Exploras las cuevas cerca de la ciudad y te encuentras con un pequeño grupo de goblins a quienes abates con facilidad.");
                            player.GainExperience(100);
                            break;
                        case 0:
                            continueFlag = false;
                            break;
                        default:
                            Console.WriteLine("Por favor introduzca una opción válida.");
                            break ;

                    }
                    player.ShowStatus();
                }
                else
                {
                    Console.WriteLine("POr favor, ingrese un número válido");
                }
            }
        }
    }
}
