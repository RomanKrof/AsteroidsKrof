using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AsteroidsKrof
{
    class APICaller
    {
        public static async Task<API_Data>
            Get(string li)
        {
            using (var http = new HttpClient())
            {
                var req = await http.GetAsync(li);

                if (req.IsSuccessStatusCode)
                {
                    return new API_Data { Data = await req.Content.ReadAsStringAsync() };
                }

                else 
                {
                    return null;
                }                    
            }
        }

    }
    public class API_Data
    {
        public string Data { get; set; }
    }
}
