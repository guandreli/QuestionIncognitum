using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionIncognitu.Academico
{
    public class Docente
    {
        public string NomeProfessor { get; set; }
        public bool IsCoordenador { get; set; }

        public List<Docente> ListaProfessor(int RA)
        {
            List<Docente> listaProfessorPorAluno = new List<Docente>();
            //Realiza o filtro de professores de acordo com o RA do aluno informado.
            return listaProfessorPorAluno;
        }
    }
}
