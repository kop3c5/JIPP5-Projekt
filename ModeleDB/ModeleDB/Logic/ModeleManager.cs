using ModeleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeleDB.Logic
{
    public class ModeleManager
    {
        public ModeleManager AddModel(ModeleModel modeleModel)
        {
            using (var context = new ModelContext())
            {
                context.Add(modeleModel);
                context.SaveChanges();
            }
            return this;
        }

        public ModeleManager RemoveModel(int id)
        {
            return this;
        }

        public ModeleManager UpdateFilm(ModeleModel modeleModel)
        {
            return this;
        }

        public ModeleManager ChangeDetails(int id, string newDetails)
        {
            return this;
        }

        public ModeleManager GetModel(int id)
        {
            return null;
        }

        public List<ModeleModel> GetModels()
        {
            return null;
        }
    }
}
