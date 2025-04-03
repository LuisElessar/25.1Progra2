using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1_Semana1
{
    internal class Menu : IMenu
    {
        private Player player;

        public void Execute()
        {
            CreatePlayer();
            GainExperienceMenu();
        }

        private void CreatePlayer()
        {
            string name;
            Console.WriteLine("Intorduce el nombre:");
            name = Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"Se ha creado el jugador con nombre: {player.Name} y está en nivel {player.Level} con {player.Experience} de experiencia");
        }

        private void GainExperienceMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Selecciona 1 opción");
                Console.WriteLine("1.Obtén 10 de Exp");
                Console.WriteLine("2.Obtén 100 de Exp");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        player.GainExp(10);
                        Console.WriteLine($"Nueva experiencia obtenida: {player.Experience}, Nivel: {player.Level}");
                        break;
                    case "2":
                        player.GainExp(100);
                        Console.WriteLine($"Nueva experiencia obtenida: {player.Experience}, Nivel: {player.Level}");
                        break;
                    case "0":
                        player.GainExp(100);
                        Console.WriteLine($"Nueva experiencia obtenida: {player.Experience}, Nivel: {player.Level}");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                    
            }
        }
    }
}
