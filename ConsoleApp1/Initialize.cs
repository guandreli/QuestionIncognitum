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

            alunos.RA = 123456;
            docente.IsCoordenador = true;
            docente.NomeProfessor = "Otaviano";

            var listaPerguntas = questionario.CriarQuestionario(docente);
            var listaResposta = questionario.ListaQuestionario(alunos.RA, listaPerguntas);
            questionario.ResultadoProfessor(docente, listaResposta);
            Console.ReadKey();
        }
    }
}
