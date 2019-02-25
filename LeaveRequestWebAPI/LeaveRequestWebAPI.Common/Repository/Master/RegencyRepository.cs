using LeaveRequestWebAPI.DataAccess.Context;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository.Master
{
    public class RegencyRepository : IRegencyRepository
    {
        MyContext myContext = new MyContext();
        Regency regency = new Regency();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getIdRegency = Get(Id);
            getIdRegency.IsDelete = true;
            getIdRegency.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;

        }

        public List<Regency> Get()
        {
            return myContext.Regencies.Where(x => x.IsDelete == false).ToList();
        }

        public Regency Get(int? Id)
        {
            return myContext.Regencies.Find(Id);
        }

        public bool Insert(RegencyParam regencyParam)
        {
            var result = 0;
            regency.Name = regencyParam.Name;
            regency.Provinces = myContext.Provinces.Find(regencyParam.Provinces_Id);
            regency.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Regencies.Add(regency);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, RegencyParam regencyParam)
        {
            var result = 0;
            var Regency = Get(Id);
            Regency.Name = regencyParam.Name;
            Regency.Provinces = myContext.Provinces.Find(regencyParam.Provinces_Id);
            Regency.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
