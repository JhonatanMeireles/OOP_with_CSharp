using ContatoOOPExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebOOPExemplo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Contato Contato { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Contato = new()
            {
                Nome = "Bernardo",
                Celular = "(21) 99191-9191",
                Email = "BBB@gmail.com",
                RedeSocial = "Instagram",
                Telefone = "(21) 99191-9191",
                WhatsApp = "(21) 99191-9191",
            };
        }
    }
}