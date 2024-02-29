using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Welcome! Ask me a question ");
            question = Console.ReadLine();

            // Verificar se trata de uma questão que reconheça e determinar uma
            // resposta adequada
            switch (question)
            {
                case "Who painted Monalisa?":
                    response = "Leonardo Da Vinci";
                    break;
                case "What's your favorite food?":
                    response = "I don't have a favorite food.. I'm a machine remember?";
                    break;
                case "Are you dumb?":
                    response = "What kind of question is that?! Of course not! outrageous..";
                    break;
                case "40+50?":
                    response = "90";
                    break;
                default:
                    response = "My systems failed..ask me another question";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
