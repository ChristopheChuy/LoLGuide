using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace PersistanceXML
{
    public class SauvegarderChampionXML : SauvegarderChampion
    {
        /// <summary>
        /// sauvegarde une listes de champions dans un fichier XML
        /// </summary>
        /// <param name="champions"></param>
        public void sauvegarderChampion(List<IChampion> champions)
        {
            List<ChampionXML> listeChampionXML = champions.Select(champion => new ChampionXML(champion)).ToList();
            Directory.SetCurrentDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "PersistanceXML", "XML"));
            
            var serializer = new DataContractSerializer(typeof(ChampionXML));

            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            StringBuilder stringBuilder = new StringBuilder("ListChampion.xml");

            using (XmlWriter writer = XmlWriter.Create(stringBuilder, settings))
            {
                serializer.WriteObject(writer, listeChampionXML);
            }
        }
    }
}
