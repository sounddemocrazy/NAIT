using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ViewModel
{
    public class SchoolInformationModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
    }
    public class SchoolInformationModelList
    {
        public SchoolInformationModelList()
        {
            this.schoolList = new List<SchoolInformationModel>();
        }
        public List<SchoolInformationModel> schoolList { get; set; }
    }
}
