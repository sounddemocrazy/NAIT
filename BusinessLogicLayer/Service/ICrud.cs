using BusinessLogicLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public interface ICrud
    {
        void Insert(SchoolInformationModel model);
        void Update(SchoolInformationModel model);
        List<SchoolInformationModel> schoolList();
        void Delete(int id);
        SchoolInformationModel SchoolDetail(int id);

    }
}