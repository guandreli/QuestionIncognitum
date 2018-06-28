using QuestionIncognitu.CorpoAcademico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionIncognitu.Academico
{
    public class Alunos : DiarioClasse
    {
        public int RA { get; set; }

        public bool LoginQrCode(int RA)
        {
            RA = this.RA;
            // Realiza a validação dos dados
            var retorno = ((RA.ToString())[0] == '1') ? true : false; //validação apenas para criterio de teste
            return retorno;
        }
    }
}
