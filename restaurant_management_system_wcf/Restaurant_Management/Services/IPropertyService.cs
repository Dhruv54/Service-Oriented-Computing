using Restaurant_Management.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    [ServiceContract]
    interface IPropertyService
    {
        [OperationContract]
        int AddProperty(Property prpty);
        [OperationContract]
        void DeleteProperty(int id);
        [OperationContract]
        Property GetProperty(int id);
        [OperationContract]
        IEnumerable<Property> GetProperties();
        [OperationContract]
        void UpdateProperty(Property prprty);
        //[OperationContract]
        //byte[] getPropertyPhoto(string fileName);
        //[OperationContract]
        //void UploadImage(PropertyImageDto imageDto);
        [OperationContract]
        IEnumerable<Property> getPropertyBycategory(string category);
    }
}
