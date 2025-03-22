using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortofolioRAZOR.Pages
{
    public class QuizModel : PageModel
    {
        public string[] Questions =
        {
            "Hvem var forsanger i Gasolin?",
            "Hvilket år blev Gasolin dannet?",
            "Hvad hed Gasolins første album?",
            "Hvad hed bandets bassist?",
            "Hvornår blev bandet opløst?"
        };

        public string[] Answers =
        {
            "Kim Larsen", "Johnny Madsen", "Lars Ulrich",
            "1965", "1969", "1972",
            "Langebro", "Efter endnu en dag", "Gasolin",
            "Wili Jønsson", "Søren Berlev", "Michael Hardinger",
            "2003", "1978", "1991"
        };

        public int[] CorrectAnswers = { 0, 1, 2, 0, 1 };
        public int PlayerScore;

        [BindProperty]
        public int[] UserAnswers { get; set; } = new int[5];

        public void OnPost()
        {
            PlayerScore = 0;

            for (int i = 0; i < CorrectAnswers.Length; i++)
            {
                if (UserAnswers[i] == CorrectAnswers[i])
                {
                    PlayerScore++;
                }
            }
        }
    }
}