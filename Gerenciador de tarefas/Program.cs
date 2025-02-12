using Gerenciador;

Gerencia x = new Gerencia();


while(true)
{
Console.WriteLine("informe: \n 1 - Adicionar Tarefa\n 2 - Excluir Tarefa\n 3 - Mostrar tarefa\n 4 - Concluir Tarefas");
string opcao = Console.ReadLine();
switch(opcao)
{
    case "1":
    x.AdicionarTarefa();
    break;

    case "2":
    x.ExcluirTarefa();
    break;
    case "3":
    x.mostrarTarefa();
    break;
    case "4":
    x.Concluir();
    break;
}

}





