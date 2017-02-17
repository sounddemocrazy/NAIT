using BusinessLogicLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.ViewModel;
using DataAccessLayer;

namespace BusinessLogicLayer.Implementaton
{
    public class Crud : ICrud
    {

        public void Delete(int id)
        {
            using (var entity = new MVCDbEntities())
            {
                var delete = entity.SchoolInformations.Where(x => x.ID == id).FirstOrDefault();
                entity.SchoolInformations.Remove(delete);
                entity.SaveChanges();
            }
        }

        public void Insert(SchoolInformationModel model)
        {
            using (var entity = new MVCDbEntities())
            {
                var table = new SchoolInformation();
                table.Name = model.Name;
                table.CreatedOn = DateTime.Now;
                entity.SchoolInformations.Add(table);
                entity.SaveChanges();
            }
        }

        public SchoolInformationModel SchoolDetail(int id)
        {
            using (var entity = new MVCDbEntities())
            {
                var detail = schoolList().Where(x => x.ID == id).FirstOrDefault();
                return detail;
            }
        }

        public List<SchoolInformationModel> schoolList()
        {
            var listData = new List<SchoolInformationModel>();
            using (var entity = new MVCDbEntities())
            {
                var dbData = entity.SchoolInformations.ToList();
                foreach (var item in dbData)
                {
                    var model = new SchoolInformationModel();
                    model.ID = item.ID;
                    model.Name = item.Name;
                    model.CreatedOn = item.CreatedOn;
                    listData.Add(model);
                }
                return listData;
            }
        }

        public void Update(SchoolInformationModel model)
        {
            using (var entity = new MVCDbEntities())
            {
                var table = schoolList().Where(x => x.ID == model.ID).FirstOrDefault();
                table.Name = model.Name;
                table.CreatedOn = DateTime.Now;
                entity.Entry(table).State = System.Data.Entity.EntityState.Modified;
                entity.SaveChanges();
            }
        }
    }
}
