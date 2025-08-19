using SalasCoworking.Models;
using UsuariosCoworking.Models;


Console.WriteLine("Bem vindo ao Coworking ");

while (true)
{
    Console.WriteLine("1 - Cadastrar Sala");
    Console.WriteLine("2 -  Cadastrar Usuario");
    Console.WriteLine("3 - Listar Salas Cadastradas");
    Console.WriteLine("4 - Listar Usuarios Cadastrados");
    Console.WriteLine("5 - Reserva sala");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CriarSala.CadastrarSala();
            break;
        case 2 :
            CriarUsuario.CadastrarUsuario();
            break;
        case 3 :
            CriarSala.ListarSalas();
            break;
        case 4:
            CriarUsuario.ListarUsuario();
            break;
        case 5:
            break;
        default:
            break;
    }
    Console.Clear();

}