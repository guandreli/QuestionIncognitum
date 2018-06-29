using QuestionIncognitu.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionIncognitu
{
    class Initialize
    {
        static void Main(string[] args)
        {
            Docente prof = new Docente();
            Docente docente = new Docente();
            Alunos alunos = new Alunos();
            Questionario questionario = new Questionario();

            do
            {
                Console.WriteLine("Codigo QR:");
                alunos.RA = int.Parse(Console.ReadLine());

                if (alunos.LoginQrCode(alunos.RA))
                {
                    Console.WriteLine("Campus:");
                    alunos.NomeCampus = Console.ReadLine();
                    Console.WriteLine("Curso:");
                    alunos.NomeCurso = Console.ReadLine();
                    Console.WriteLine("Disciplia:");
                    alunos.NomeDisciplina = Console.ReadLine();
                    Console.WriteLine("Turma:");
                    alunos.NomeTurma = Console.ReadLine();
                }
                else
                    Console.WriteLine("QR valido, deve começar com 1");
            } while (!alunos.LoginQrCode(alunos.RA));

            Console.Clear();
            Console.WriteLine("Professor:");
            docente.IsCoordenador = true;
            docente.NomeProfessor = Console.ReadLine();

            Console.Clear();
            var listaPerguntas = questionario.SubmitQuestao(docente);
            var listaResposta = questionario.SubmitResposta(alunos.RA, listaPerguntas);
            questionario.ResultadoProfessor(docente, listaResposta, alunos);
            Console.ReadKey();
        }
    }
}
