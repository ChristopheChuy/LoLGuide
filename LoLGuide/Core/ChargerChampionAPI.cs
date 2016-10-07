using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ChargerChampionAPI : ChargerChampion
    {
        public async void LoadChampion()
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response =  await client.GetAsync("https://euw.api.pvp.net/api/lol/euw/v1.2/champion?api_key=6c2ec2f3-72bb-4b83-a3d0-982da8adb4c0");
                if (response.IsSuccessStatusCode)
                {
                    var champions =  await response.Content.ReadAsStringAsync();
                    JObject o = JObject.Parse(champions);
                    Int32 firstChampion = (Int32)o["champions"]["id"];
                    //IList<string> names = o["champions"].Select(t => (string)t).ToList();
                    Debug.WriteLine(champions);
                }

            }
        }

    }
}
