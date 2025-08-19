using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace UsuariosCoworking.Models
{
    public class CriarUsuario
    {

        public int Cpf { get; set; }
        private string _NomeUsuario; 
        public string NomeUsuario
        {
            get { return _NomeUsuario; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Esse campo nao pode ficarr vazio !!");
                }
                _NomeUsuario = value;
            }
        }
        private static List<CriarUsuario> Users = new List<CriarUsuario>();


        public CriarUsuario(string nome, int cpf)
        {
            NomeUsuario = nome;
            Cpf = cpf;
        }

        public static void CadastrarUsuario()
        {
            Console.Write("Digite seu Nome Completo : ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu CPF : ");
            int cpf = int.Parse(Console.ReadLine());

            CriarUsuario novo = new CriarUsuario(nome, cpf);
            Users.Add(novo);


        }

        public static void ListarUsuario()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("Nao tem usuarios cadastrados");
            }
            else
            {
                foreach (var i in Users)
                {
                    Console.WriteLine("Nome : {0}  -   CPF : {1}", i._NomeUsuario, i.Cpf);
                }

                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
           
        }
    }
}