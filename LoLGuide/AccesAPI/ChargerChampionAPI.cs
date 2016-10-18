using Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Core
{
    public class ChargerChampionAPI : ChargerChampion
    {
        public const String URLAPI= "https://global.api.pvp.net/api/lol/static-data/euw/v1.2/champion?champData=allytips,enemytips,info,lore,passive,spells,tags&api_key=6c2ec2f3-72bb-4b83-a3d0-982da8adb4c0";

        async public Task<List<IChampion>> LoadChampion()
        {

            return await loadIdChampion();

        }

        private async Task<List<IChampion>> loadIdChampion()
        {
            List<IChampion> listeChampions1 = new List<IChampion>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(URLAPI);
                if (response.IsSuccessStatusCode)
                {

                    var champions = await response.Content.ReadAsStringAsync();
                    JObject o = JObject.Parse(champions);

                    var ListeChampions = o["data"].Children().Select(champ => new
                    {
                        champion = new Champion(
                            (int)champ.First()["id"],
                            (string)champ.First()["name"],
                            ((string)champ.First()["lore"]).Replace("<br>", "")
                        ),
                        listeSorts = champ.First()["spells"].Children().Select(spell => new Sort(
                                  (string)spell["name"],
                                  ((string)spell["description"]).Replace("<br>", "")
                                  )
                        ).ToList()
                    }
                    ).OrderBy(champ => champ.champion.Nom).ToList();

                    foreach(var cs in ListeChampions){
                        cs.champion.addSort(cs.listeSorts);
                    }

                    ListeChampions.ForEach(championSort => Debug.WriteLine(championSort.champion));
                    listeChampions1 =  ListeChampions.Select(championSort => (IChampion)championSort.champion).ToList();
                }
            }
            return listeChampions1;

        }
    }
}
