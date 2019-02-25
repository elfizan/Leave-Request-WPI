using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.Common.Repository.Master;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class RegencyService : IRegencyService
    {
        private readonly IRegencyRepository _regencyRepository;
        public RegencyService(RegencyRepository regencyRepository)
        {
            _regencyRepository = regencyRepository;
        }
        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _regencyRepository.Delete(Id);
            }
            return status;
        }

        public List<Regency> Get()
        {
            return _regencyRepository.Get();
        }

        public Regency Get(int? Id)
        {
            return _regencyRepository.Get(Id);
        }

        public bool Insert(RegencyParam regencyParam)
        {
            if (regencyParam != null)
            {
                status = _regencyRepository.Insert(regencyParam);
            }
            return status;
        }

        public bool Update(int? Id, RegencyParam regencyParam)
        {
            if (Id != null && regencyParam != null)
            {
                status = _regencyRepository.Update(Id, regencyParam);
            }
            return status;
        }
    }
}
