using DataAccess.ViewModel.BibleView;
using System.Text.Json;

namespace Utility.helpers
{
    public static class JsonHelper
    {
        public static List<BibleDetailsBookListViewModel>? TurnStringToList (string? jsonString = null)
        {
            List<BibleDetailsBookListViewModel> newLIst = new();

            if (string.IsNullOrEmpty(jsonString))
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
