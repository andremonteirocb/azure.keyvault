using Fundamentos.Azure.KeyVault.Config;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Fundamentos.Azure.KeyVault.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly KeyVaultSettings _keyVaultSettings;

        public IndexModel(ILogger<IndexModel> logger,
            KeyVaultSettings keyVaultSettings)
        {
            _keyVaultSettings = keyVaultSettings;
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["KeyVault"] = JsonConvert.SerializeObject(_keyVaultSettings);
        }
    }
}
