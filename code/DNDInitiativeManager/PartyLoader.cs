using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DNDInitiativeManager
{
    static class PartyLoader
    {

        private const string _partyFile = "party.dat";
        private static BinaryFormatter _formatter = new BinaryFormatter();
        public static Initiative.PartyDataTable Party { get; private set; }

        public static Initiative.PartyDataTable Load()
        {
            if (Party != null)
            {
                return Party;
            }

            Initiative.PartyDataTable table = null;

            if (File.Exists(_partyFile))
            {
                using (var file = File.OpenRead(_partyFile))
                {
                    table = (Initiative.PartyDataTable) _formatter.Deserialize(file);
                }
                
            }
            else
            {
                table = new Initiative.PartyDataTable();
            }

            Party = table;

            return table;
        }

        public static void Save(Initiative.PartyDataTable party)
        {
            if (party == null)
            {
                throw new ArgumentNullException("party");
            }
            using(var file = File.OpenWrite(_partyFile))
            {
                _formatter.Serialize(file, party);
            }
        }
    }
}
