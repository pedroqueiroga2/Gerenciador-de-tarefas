namespace Gerenciador
{
    public class Tarefa //criando classe pública
    {
        public string Nome { get; set; } //criando propriedade pública e passando métodos get; set;
        public int Id { get; set; } //criando propriedade pública e passando métodos get; set;

        public bool Status { get; set; } // criando propriedade pública e passando métodos get; set;

        public Tarefa(string nomeconstrutor, int idconstrutor) // criando constructor para que objeto seja iniciado com dois valores (new 'nome do obejto')
        {
            Id = idconstrutor;
            Nome = nomeconstrutor;
            Status = false;
        }
        public void Concluir()
        {
            Status = true;
        }
    }
    public class Gerencia
    {
        private List<Tarefa> tarefas = new List<Tarefa>(); //criando lista de tarefa a partir da classe Tarefa

        private int ID = 1; //variavel contadora

        public void GerenciadorTarefas()
        {
            tarefas = new List<Tarefa>();

        }
        public void AdicionarTarefa(string tarefa)
        {
            Console.WriteLine($"Informe a tarefa");
            string nome = Console.ReadLine();
            tarefas.Add(new Tarefa(nome, ID)); //adicionando tarefas à lista de tarefas



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{ID} - {tarefa}" + " \nAdicionado com sucesso!");
            Console.ResetColor();
            ID++;


        }

        public void ExcluirTarefa(int i) //criando metodo para excluir a tarefa
        {
            Console.WriteLine($"Informe a tarefa que deseja excluir");
            if (int.TryParse(Console.ReadLine(), out i))
            {
                Tarefa tarefa = tarefas.Find(t => t.Id == i); //utilizando expressão lambda para retornar um valor correspondente dentro da lista de tarefas
                {
                    if (tarefa != null)
                    {
                        tarefas.Remove(tarefa);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Tarefa removida");
                        Console.ResetColor();
                    }
                    else{

                    }
                }
            }
            else
            {
                Console.WriteLine($"erro");
            }

        }

        // public void mostrarTarefa()
        // {
        //     if (tarefas.Count == 0)
        //     {
        //         Console.WriteLine("Nenhum texto encontrado.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Tarefas:");
        //         foreach (var tarefa in tarefas)
        //         {
        //             Console.WriteLine(tarefa);
        //         }
        //     }
        // }
    }
}