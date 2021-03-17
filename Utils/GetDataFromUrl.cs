using System.Net.Http;
using System.Threading.Tasks;

namespace Utils
{
    public class GetDataFromUrl
    {
        public static async Task<string> GetStringData(string url)
        {
            var http = new HttpClient();
            var result = await http.GetStringAsync(url);
            return result;
        }
    }
}