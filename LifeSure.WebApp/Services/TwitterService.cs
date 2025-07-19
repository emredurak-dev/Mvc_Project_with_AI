using LifeSure.WebApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using LifeSure.WebApp.Models; // ViewModel namespace'ini ekle

public class TwitterService
{
    private readonly string apiUrl = "https://twitter241.p.rapidapi.com/user?username={0}";
    private readonly string apiKey = "YOUR-RAPIDAPI-KEY";
    private readonly string apiHost = "twitter241.p.rapidapi.com";

    public async Task<TwitterUserViewModel> GetUserInfo(string username)
    {
        using (var client = new HttpClient())
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(string.Format(apiUrl, username)),
            };
            request.Headers.Add("x-rapidapi-key", apiKey);
            request.Headers.Add("x-rapidapi-host", apiHost);

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                try
                {
                    var obj = JObject.Parse(body);
                    var legacy = obj["result"]?["data"]?["user"]?["result"]?["legacy"];
                    var core = obj["result"]?["data"]?["user"]?["result"]?["core"];

                    return new TwitterUserViewModel
                    {
                        Username = (string)(core?["screen_name"] ?? username),
                        FollowersCount = (int)(legacy?["followers_count"] ?? 0)
                    };
                }
                catch (Exception ex)
                {
                    // parse hatasi alinca 0 ile devam et
                    return new TwitterUserViewModel
                    {
                        Username = username,
                        FollowersCount = 0
                    };
                }
            }
        }
    }
}