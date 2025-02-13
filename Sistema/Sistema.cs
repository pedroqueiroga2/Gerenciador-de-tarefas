namespace sistema
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        // public Pessoa(string nome, string sobrenome, int idade)
        // {
        //     Nome = nome;
        //     Sobrenome = sobrenome;
        //     Idade = idade;
        // }
    }
    public class Sistema
    {
        Pessoa pessoa1 = new Pessoa();
        public void Usuario()
        {
            Console.WriteLine("Informe seu nome");
            pessoa1.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe seu sobrenome");
            pessoa1.Sobrenome = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe sua idade");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nDados do usuário:");
            Console.WriteLine($"Nome: {pessoa1.Nome} {pessoa1.Sobrenome}");
            Console.WriteLine($"Idade: {pessoa1.Idade} anos");
            Console.ResetColor();
        }
        public void Imprimir()
        {
            
            using (StreamWriter bloco = new StreamWriter("C:\\Users\\Alunos\\3D Objects\\Gerenciador-de-tarefas\\Sistema\\Dados.txt"))
            {
                Usuario();
                bloco.WriteLine(pessoa1.Nome + " " + pessoa1.Sobrenome + "  \n" + pessoa1.Idade);
                bloco.Close();
            }
        }

    }
}