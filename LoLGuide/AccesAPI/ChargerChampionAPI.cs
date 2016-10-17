using Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
        public const String URLAPI= "https://euw.api.pvp.net/api/lol/euw/v1.2/champion";
        public const String APIKEYS= "6c2ec2f3-72bb-4b83-a3d0-982da8adb4c0";
        public async void LoadChampion()
        {

           loadIdChampion();

        }
       
        private async void loadIdChampion()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("https://global.api.pvp.net/api/lol/static-data/euw/v1.2/champion?champData=allytips,enemytips,info,lore,passive,spells,tags&api_key=6c2ec2f3-72bb-4b83-a3d0-982da8adb4c0");
                if (response.IsSuccessStatusCode)
                {

                    var champions = await response.Content.ReadAsStringAsync();
                    JObject o = JObject.Parse(champions);

                    var ListeChampions = o["data"].Children().Select(champ => new
                    {
                        champion = new Champion(
                            (int)champ.First()["id"],
                            (string)champ.First()["name"],
                            (string)champ.First()["lore"]
                        ),
                        listSort = champ.First()["spells"].Children().Select(spell => new Sort(
                                  (string)spell["name"],
                                 (string)spell["description"]
                                  )
                        ).ToList()
                    }
                    ).OrderBy(champ => champ.champion.Nom).ToList();

                    foreach(var cs in ListeChampions){
                        cs.champion.addSort(cs.listSort);
                    }

                   
                    


                    ListeChampions.ForEach(championSort => Debug.WriteLine(championSort.champion));
           }

            }
            
        }
    }
}
