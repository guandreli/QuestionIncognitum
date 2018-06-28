using QuestionIncognitu.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionIncognitu
{
    public class Questionario
    {
        public string Pergunta { get; set; }
        public string Resposta { get; set; }

        public List<Questionario> CriarQuestionario(Docente docente)
        {
            // Cria o questionário pelo professor/coordenador
            List<Questionario> ListaPerguntas = new List<Questionario>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Questão {i + 1}: ");
                Questionario pergunta = new Questionario
                {
                    Pergunta = Console.ReadLine()
                };
                ListaPerguntas.Add(pergunta);
            }
            return ListaPerguntas;
        }

        public List<Questionario> ListaQuestionario(int RA, List<Questionario> ListaQuestionario)
        {
            // Aluno preenche as respostas de acordo com as perguntas do professor
            Console.Clear();
            if (((RA.ToString())[0] == '1') ? true : false)
            {
                List<Questionario> ListaResposta = new List<Questionario>();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Pergunta Professor: {ListaQuestionario[i].Pergunta}");
                    Console.Write($"Resposta questão {i + 1}: ");
                    Questionario resposta = new Questionario
                    {
                        Pergunta = ListaQuestionario[i].Pergunta,
                        Resposta = Console.ReadLine()
                    };
                    ListaResposta.Add(resposta);
                }
                return ListaResposta;
            }
            else
                throw new Exception("Aluno inválido");
        }

        public void ResultadoProfessor(Docente docente, List<Questionario> ListaPerguntasRespostas)
        {
            // Exibido as respostas das perguntas
            Console.Clear();
            if (docente.IsCoordenador)
            {
                foreach(var item in ListaPerguntasRespostas)
                {
                    Console.WriteLine($"Perunta: {item.Pergunta}\nResposta: {item.Resposta}\n");
                }
            }
            else
                throw new Exception("Você não é coordenador");
        }
    }
}
