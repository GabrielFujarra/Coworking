using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SalasCoworking.Models
{
    public class CriarSala
    {

        private static List<CriarSala> Salas = new List<CriarSala>();
        public int Capacidade { get; set; }
        public string NomeSala { get; set; }

        public CriarSala(string nomesala, int capacidade)
        {
            NomeSala = nomesala;
            Capacidade = capacidade;

        }

        public static void CadastrarSala()
        {
            Console.Write("Digite o Nome da Sala : ");
            string nomesala = Console.ReadLine();

            Console.Write("Digite a capacidade da sala : ");
            int capacidade = int.Parse(Console.ReadLine());

            CriarSala novaSala = new CriarSala(nomesala, capacidade);
            Salas.Add(novaSala);




        }

        public static void ListarSalas()
        {
            if (Salas.Count == 0)
            {
                Console.WriteLine("Nao existe salas cadastradas !!");
            }
            else
            {
                foreach (var i in Salas)
                {
                    Console.WriteLine("Nome :  {0}  -  Capacidade : {1}", i.NomeSala, i.Capacidade);
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

    }

}