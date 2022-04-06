using Restaurant_Management.Dto;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace Restaurant_Management.Services
{
        //public string paths = @"C:\Users\Dhruv j Patel\Desktop\wcf\restaurant_management_system_wcf\Restaurant_Management_Client\static\images";
    public class PropertyService : IPropertyService
    {
        public int AddProperty(Property prpty)
        {
            AppDbContext dbContext = new AppDbContext();
            try
            {
                Property prpty1 = dbContext.Properties.Add(prpty);
                dbContext.SaveChanges();
                return prpty1.Id;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void DeleteProperty(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            Property prpty = dbContext.Properties.Where<Property>(i => i.Id == id).FirstOrDefault();
            if (prpty != null)
            {
                dbContext.Properties.Remove(prpty);
                dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered id of property is not found");
                throw exception;
            }
        }

        public Property GetProperty(int id) 
        {
            AppDbContext dbContext = new AppDbContext();
            Property prpty = dbContext.Properties.Where<Property>(i => i.Id == id).FirstOrDefault();
            if (prpty != null)
            {
                return prpty;
            }
            else
            {
                Exception exception = new Exception("entered id of property is not found");
                throw exception;
            }
        }

        public IEnumerable<Property> getPropertyBycategory(string type)
        {
            AppDbContext dbContext = new AppDbContext();
            List<Property> prprties = dbContext.Properties.Where(i => i.Type.Equals(type, StringComparison.CurrentCultureIgnoreCase)).ToList();
            if (prprties != null)
            {
                return prprties;
            }
            else
            {
                Exception exception = new Exception("entered category of property is not found");
                throw exception;
            }
        }

        //public byte[] getPropertyPhoto(string fileName)
        //{
        //    FileStream fileStream = null;
        //    BinaryReader reader = null;
        //    string imagePath;
        //    byte[] imageBytes;
        //    try
        //    {
        //        imagePath = String.Format(@"{0}\{1}", paths, fileName);
        //        if (File.Exists(imagePath))
        //        {
        //            fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        //            reader = new BinaryReader(fileStream);

        //            imageBytes = reader.ReadBytes((int)fileStream.Length);
        //            return imageBytes;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public IEnumerable<Property> GetProperties()
        {
            List<Property> prprties;
            AppDbContext dbContext = new AppDbContext();
            prprties = dbContext.Properties.ToList<Property>();
            return prprties;
        }


        public void UpdateProperty(Property prprty)
        {
            AppDbContext dbContext = new AppDbContext();
            Property prprty1 = dbContext.Properties.Where<Property>(i => i.Id == prprty.Id).FirstOrDefault();
            if (prprty1 != null)
            {
                prprty1.Name = prprty.Name;
                prprty1.Price = prprty.Price;
                prprty1.Type = prprty.Type;
                prprty1.Location = prprty.Location;
                prprty1.Owner = prprty.Owner;
                dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered property details is not found");
                throw exception;
            }

        }

        //public void UploadImage(PropertyImageDto imageDto)
        //{
        //    FileStream fileStream = null;
        //    BinaryWriter writer = null;
        //    string filePath;

        //    AppDbContext dbContext = new AppDbContext();
        //    try
        //    {
        //        Property prprty = dbContext.Properties.Where(i => i.Id == imageDto.Id).FirstOrDefault();
        //        if (prprty == null)
        //        {
        //            Exception exception = new Exception("entered id of item is not found");
        //            throw exception;
        //        }
        //        string fileName = Guid.NewGuid().ToString() + ".jpeg";
        //        filePath = String.Format(@"{0}\{1}", paths, fileName);
        //        prprty.ImagePath = fileName;
        //        dbContext.SaveChanges();
        //        fileStream = File.Open(filePath, FileMode.Create);
        //        writer = new BinaryWriter(fileStream);
        //        writer.Write(imageDto.Image);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (fileStream != null)
        //            fileStream.Close();
        //        if (writer != null)
        //            writer.Close();
        //    }
        //}

    }
}
