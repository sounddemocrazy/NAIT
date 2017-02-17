using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ViewModel
{
    public class LocationInformationModel
    {
        public int ID { get; set; }
        public int SchoolInformationId { get; set; }
        public string Location { get; set; }
    }

    public class LocationInformationModelList
    {
        public LocationInformationModelList()
        {
            this.locationList = new List<LocationInformationModel>();
        }
        public List<LocationInformationModel> locationList { get; set; }
    }
}
