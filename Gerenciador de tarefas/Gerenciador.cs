namespace Gerenciador
{
    public class Gerencia
    {
        private List<string> tarefas;

        public  void GerenciadorTarefas()
        {
            tarefas = new List<string>();
        }
        public void AdicionarTarefa(string tarefa)
        {
            tarefas.Add(tarefa);
            Console.WriteLine(tarefa);
        }
        public void ExcluirTarefa(string tarefa)
        {
            tarefas.Remove()
        }
    }
}