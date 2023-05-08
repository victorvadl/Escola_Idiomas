using ExplorandoPropriedades.Models;


// Pessoa p1 = new Pessoa(nome: "Victor Rafael", sobrenome: "Vaz Albuquerque de Lima");

// Pessoa p2 = new Pessoa(nome: "Diana", sobrenome: "Batista Oliveira de Lima");

Curso cursos = new Curso();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursos.ListaDeCursos.Add(cursoDeIngles);

Curso cursoDeFrances = new Curso();
cursoDeFrances.Nome = "Francês";
cursoDeFrances.Alunos = new List<Pessoa>();
cursos.ListaDeCursos.Add(cursoDeFrances);

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// Console.WriteLine("Qual o seu nome?");
// p1.Nome = Console.ReadLine();
// Console.WriteLine("Qual a sua idade?");
// p1.Idade = Int32.Parse(Console.ReadLine());
// p1.Apresentar();

bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar aluno");
  Console.WriteLine("2 - Listar alunos do curso");
  Console.WriteLine("3 - Remover aluno");
  Console.WriteLine("4 - Encerrar");

  switch (Console.ReadLine())
  {
    case "1":
      Console.Clear();
      Console.WriteLine("CADASTRO");
      Console.WriteLine("Qual o nome do aluno?");
      string nome = Console.ReadLine();
      Console.WriteLine("Qual o sobrenome do aluno?");
      string sobrenome = Console.ReadLine();
      Pessoa p1 = new Pessoa(nome, sobrenome);
      Console.Clear();
      bool opcaoInvalida = true;

      while(opcaoInvalida)
      {

        Console.WriteLine($"Para qual curso você deseja matricular o aluno {p1.NomeCompleto}");
        cursos.ListarCursos();
        Console.WriteLine("3 - Voltar menu anterior.");
        
        switch (Console.ReadLine())
        {
          case "1":
            Console.Clear();
            cursoDeIngles.AdicionarAluno(p1);
            opcaoInvalida = false;
            break;
            
          case "2":
            cursoDeFrances.AdicionarAluno(p1);
            opcaoInvalida = false;
            break;
          
          case "3":
            opcaoInvalida = false;
            break;

          default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
        }
      }
      break;

    case "2":
      Console.Clear();
      Console.WriteLine("Você quer a lista de alunos para qual curso?");
      cursos.ListarCursos();
      switch (Console.ReadLine())
      {
        case "1":
          Console.Clear();
          cursoDeIngles.ListarAlunos();
          break;
          
        case "2":
          Console.Clear();
          cursoDeFrances.ListarAlunos();
          break;

        default:
          Console.WriteLine("Opção inválida");
          break;
      }
      break;
    case "3":
      Console.Clear();
      Console.WriteLine("Você quer a remover aluno de qual curso?");
      cursos.ListarCursos();
      switch (Console.ReadLine())
      {
        case "1":

          if(cursoDeIngles.Alunos.Count == 0)
          {
            Console.Clear();
            Console.WriteLine("Não possui alunos cadastrado no curso de Inglês");
            break;
          }
          Console.Clear();
          cursoDeIngles.ListarAlunos();
          Console.WriteLine("Digite o nome completo do aluno que deseja remover");
          string nome_aluno = Console.ReadLine();
          Pessoa aluno = cursoDeIngles.Alunos.FirstOrDefault( a=> a.NomeCompleto == nome_aluno.ToUpper());
          while (aluno == null)
          {
            Console.Clear();
            Console.WriteLine($"Não foi encontrado um aluno com o nome {nome_aluno} no curso de Inglês.");
            Console.WriteLine("Os alunos matriculados no curso de Ingês são:");
            cursoDeIngles.ListarAlunos();
            Console.WriteLine("Digite novamente o nome do aluno que você deseja remover. \nDigite 'cancelar' para voltar.");
            nome_aluno = Console.ReadLine();
            if (nome_aluno.ToLower() == "cancelar")
            {
                break;
            }
            aluno = cursoDeIngles.Alunos.FirstOrDefault( a=> a.NomeCompleto == nome_aluno.ToUpper());
          }
          if (aluno != null)
          {

          cursoDeIngles.RemoverAluno(aluno);
          Console.WriteLine($"O aluno {aluno.NomeCompleto} foi removido do curso de Inglês.");
          }
          break;
          
        case "2":
          if(cursoDeFrances.Alunos.Count == 0)
          {
            Console.Clear();
            Console.WriteLine("Não possui alunos cadastrado no curso de Francês");
            break;
          }
          Console.Clear();
          cursoDeFrances.ListarAlunos();
          Console.WriteLine("Digite o nome completo do aluno que deseja remover");
          nome_aluno = Console.ReadLine();
          aluno = cursoDeFrances.Alunos.FirstOrDefault( a=> a.NomeCompleto == nome_aluno.ToUpper());
          while (aluno == null)
          {
            Console.Clear();
            Console.WriteLine($"Não foi encontrado um aluno com o nome {nome_aluno} no curso de Francês.");
            Console.WriteLine("Os alunos matriculados no curso de Francês são:");
            cursoDeFrances.ListarAlunos();
            Console.WriteLine("Digite novamente o nome do aluno que você deseja remover. \nDigite 'cancelar' para voltar.");
            nome_aluno = Console.ReadLine();
            if (nome_aluno.ToLower() == "cancelar")
            {
                break;
            }
            aluno = cursoDeFrances.Alunos.FirstOrDefault( a=> a.NomeCompleto == nome_aluno.ToUpper());
          }
          if (aluno != null)
          {

          cursoDeFrances.RemoverAluno(aluno);
          Console.WriteLine($"O aluno {aluno.NomeCompleto} foi removido do curso de Francês.");
          }
          break;

        default:
          Console.WriteLine("Opção inválida");
          break;
      }
      break;

    case "4":
      exibirMenu = false;
      break;

  }
  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}