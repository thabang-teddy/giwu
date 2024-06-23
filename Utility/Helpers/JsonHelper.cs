using DataAccess.ViewModel.BibleView;
using DataAccess.Models;
using System.Text.Json;

namespace Utility.helpers
{
    public static class JsonHelper
    {
        public static List<BibleDetailsBookListViewModel>? TurnStringToList (string? jsonString = null)
        {
            List<BibleDetailsBookListViewModel> newLIst = new();

            if (jsonString == null)
            {
                return newLIst;
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            
            newLIst = JsonSerializer.Deserialize<List<BibleDetailsBookListViewModel>>(jsonString, options);

            return newLIst;
        }
    }
}
