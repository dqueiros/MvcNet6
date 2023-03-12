using LanchesMac.Domain.Entities;

namespace LanchesMac.Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
