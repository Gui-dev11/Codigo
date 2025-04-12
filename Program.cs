using static System.Console;
using static System.DateTime;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pe = new Pessoa();
            Escola es = new Escola();
            Endereco end = new Endereco();
            Professor prof = new Professor();
            Disciplina disc = new Disciplina();
            Turma turma = new Turma();
            Avaliacao aval = new Avaliacao();

            WriteLine("Cadastro do aluno:");
            WriteLine();

            Write("Informe o nome: ");
            pe.SetNome(ReadLine());

            Write("Informe o CPF: ");
            pe.SetCpf(ReadLine());

            Write("Informe a data de nascimento: ");
            pe.SetDataNas(ReadLine());

            Write("Informe a rua ou avenida: ");
            end.SetLogradouro(ReadLine());

            Write("Informe o bairro: ");
            end.SetBairro(ReadLine());

            WriteLine();
            WriteLine("Informações da escola:");
            Write("Nome da escola: ");
            es.SetNome(ReadLine());

            Write("CNPJ da escola: ");
            es.SetCnpj(ReadLine());

            Write("Endereço da escola: ");
            es.SetEndereco(ReadLine());

            Write("Tipo da escola: ");
            es.SetTipo(ReadLine());

            Write("Categoria da escola: ");
            es.SetCategoria(ReadLine());

            WriteLine();
            WriteLine("Informações do professor:");
            Write("Nome do professor: ");
            prof.SetNomeCompleto(ReadLine());

            Write("Matrícula funcional: ");
            prof.SetMatriculaFuncional(ReadLine());

            Write("E-mail corporativo: ");
            prof.SetEmailCorporativo(ReadLine());

            Write("Disciplina principal: ");
            prof.SetDisciplinaPrincipal(ReadLine());

            Write("Data de nascimento (dd/MM/yyyy): ");
            prof.SetDataNascimento(Parse(ReadLine()));

            Write("Salário do professor: ");
            prof.SetSalario(decimal.Parse(ReadLine()));

            WriteLine();
            WriteLine("Informações da disciplina:");
            Write("Nome da disciplina: ");
            disc.SetNome(ReadLine());

            Write("Código da disciplina: ");
            disc.SetCodigo(ReadLine());

            Write("Carga horária (em horas): ");
            disc.SetCargaHoraria(int.Parse(ReadLine()));

            Write("Descrição da ementa: ");
            disc.SetDescricaoEmenta(ReadLine());

            Write("Área do conhecimento: ");
            disc.SetAreaConhecimento(ReadLine());

            Write("Ano/série recomendada: ");
            disc.SetAnoSerieRecomendada(int.Parse(ReadLine()));

            WriteLine();
            WriteLine("Informações da turma:");
            Write("Código da turma: ");
            turma.SetCodigoTurma(ReadLine());

            Write("Ano letivo: ");
            turma.SetAnoLetivo(int.Parse(ReadLine()));

            Write("Semestre/período: ");
            turma.SetSemestrePeriodo(ReadLine());

            Write("Sala: ");
            turma.SetSala(ReadLine());

            Write("Máximo de alunos: ");
            turma.SetMaximoAlunos(int.Parse(ReadLine()));

            Write("Turno (Manhã, Tarde, Noite): ");
            turma.SetTurno(ReadLine());

            WriteLine();
            WriteLine("Informações da avaliação:");
            Write("Descrição da avaliação: ");
            aval.SetDescricao(ReadLine());

            Write("Tipo da avaliação (Prova, Trabalho etc.): ");
            aval.SetTipo(ReadLine());

            Write("Data de aplicação (dd/MM/yyyy): ");
            aval.SetDataAplicacao(DateTime.Parse(ReadLine()));

            Write("Peso na média (ex: 0,4): ");
            aval.SetPeso(double.Parse(ReadLine()));

            Write("Valor máximo da nota: ");
            aval.SetValorMaximo(decimal.Parse(ReadLine()));

            Write("Código da disciplina associada: ");
            aval.SetCodigoDisciplinaAssociada(ReadLine());

            Console.Clear();

            WriteLine($"Nome: {pe.GetNome()}");
            WriteLine("CPF: {0}", pe.GetCpf());
            WriteLine("Rua: {0}", end.GetLogradouro());
            WriteLine("Bairro: {0}", end.GetBairro());
            WriteLine("Data de nascimento: {0}", pe.GetDataNas());

            WriteLine();
            WriteLine($"Nome da escola: {es.GetNome()}");
            WriteLine($"CNPJ da escola: {es.GetCnpj()}");
            WriteLine($"Endereço da escola: {es.GetEndereco()}");
            WriteLine($"Tipo da escola: {es.GetTipo()}");
            WriteLine($"Categoria da escola: {es.GetCategoria()}");

            WriteLine();
            WriteLine($"Nome do professor: {prof.GetNomeCompleto()}");
            WriteLine($"Matrícula: {prof.GetMatriculaFuncional()}");
            WriteLine($"E-mail: {prof.GetEmailCorporativo()}");
            WriteLine($"Disciplina principal: {prof.GetDisciplinaPrincipal()}");
            WriteLine($"Data de nascimento: {prof.GetDataNascimento():dd/MM/yyyy}");
            WriteLine($"Salário: {prof.GetSalario()}");

            WriteLine();
            WriteLine($"Nome da disciplina: {disc.GetNome()}");
            WriteLine($"Código: {disc.GetCodigo()}");
            WriteLine($"Carga horária: {disc.GetCargaHoraria()} horas");
            WriteLine($"Ementa: {disc.GetDescricaoEmenta()}");
            WriteLine($"Área do conhecimento: {disc.GetAreaConhecimento()}");
            WriteLine($"Ano/série recomendada: {disc.GetAnoSerieRecomendada()}");

            WriteLine();
            WriteLine($"Código da turma: {turma.GetCodigoTurma()}");
            WriteLine($"Ano letivo: {turma.GetAnoLetivo()}");
            WriteLine($"Período: {turma.GetSemestrePeriodo()}");
            WriteLine($"Sala: {turma.GetSala()}");
            WriteLine($"Capacidade máxima: {turma.GetMaximoAlunos()} alunos");
            WriteLine($"Turno: {turma.GetTurno()}");

            WriteLine();
            WriteLine($"Descrição da avaliação: {aval.GetDescricao()}");
            WriteLine($"Tipo: {aval.GetTipo()}");
            WriteLine($"Data de aplicação: {aval.GetDataAplicacao():dd/MM/yyyy}");
            WriteLine($"Peso: {aval.GetPeso()}");
            WriteLine($"Valor máximo: {aval.GetValorMaximo()}");
            WriteLine($"Disciplina associada: {aval.GetCodigoDisciplinaAssociada()}");

            DateTime cadastro = DateTime.Now;
            WriteLine();
            WriteLine("Cadastro concluído com sucesso! {0}", cadastro);

            ReadKey();

        }
    }
}
