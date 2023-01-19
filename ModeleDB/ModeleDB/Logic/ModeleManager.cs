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
            using (var context = new ModelContext())
            {
                ModeleModel modelToDelete = context.Models.FirstOrDefault(x => x.ID == id);
                context.Models.Remove(modelToDelete);
                context.SaveChanges();
            }
            return this;
        }

        public void UpdateModel(ModeleModel model)
        {
            using (var context = new ModelContext())
            {
                context.Models.Update(model);
                context.SaveChanges();
            }
        }

        public ModeleManager ChangeName(int id, string newDetails)
        {
            using (var context = new ModelContext())
            {
                var model = this.GetModel(id);
                if (string.IsNullOrEmpty(newDetails))
                {
                    newDetails = "Brak informacji";
                }
                model.Name = newDetails;
                context.Models.Update(model);
                context.SaveChanges();
            }
            return this;
        }

        public ModeleModel GetModel(int id)
        {
            using (var context = new ModelContext())
            {
                return context.Models.Single(x => x.ID == id);
            }
        }

        public List<ModeleModel> GetModels()
        {
            using (var context = new ModelContext())
            {
                return context.Models.ToList();
            }            
        }
    }
}
