using Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PersistanceXML
{
    class ChargerChampionXML : ChargerChampion
    {
        public Task<List<IChampion>> LoadChampion()
        {
            /*     Directory.SetCurrentDirectory(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "champions", "XML"));

                 StringBuilder stringBuilder = new StringBuilder("ListChampion.xml");
                 using (XmlReader reader = XmlReader.Create(stringBuilder))
                 {
                     while (reader.Read())
                     {

                     }*/
            return null;
        }
    }
}
