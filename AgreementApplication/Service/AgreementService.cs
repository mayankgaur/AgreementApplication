using AgreementApplication.Models;
using AgreementApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgreementApplication.Service
{
    public class AgreementService
    {
        private GenericRepository<uc_Agreements> AgreementRepository;

        public AgreementService()
        {
            this.AgreementRepository = new GenericRepository<uc_Agreements>(new AgreementDBEntities());
        }


        public List <AgreementDetail> GetAll()
        {
            return AgreementRepository.GetAll().Select(u => new AgreementDetail() { 
             EndDate=u.EndDate,
              ID=u.ID,
               Name=u.Name,
                StartDate=u.StartDate,
                 Status=u.Status,
                  Value=u.Value
            
            }).ToList();
        }

        public AgreementDetail GetbyID(int ID)
        {
            uc_Agreements temp= AgreementRepository.GetbyID(ID);
            AgreementDetail details = new AgreementDetail();
            details.Value = temp.Value;
            details.EndDate = temp.EndDate;
            details.ID = temp.ID;
            details.Name = temp.Name;
            details.StartDate = temp.StartDate;
            details.Status = temp.Status;
            return details;
        }

        public void Insert(AgreementDetail model)
        {           
            uc_Agreements details = new uc_Agreements();
            details.Value = model.Value;
            details.EndDate = model.EndDate;
            details.ID = model.ID;
            details.Name = model.Name;
            details.StartDate = model.StartDate;
            details.Status = model.Status;
            AgreementRepository.Create(details);
        }

        public void Update(AgreementDetail model)
        {
            uc_Agreements details = new uc_Agreements();
            details.Value = model.Value;
            details.EndDate = model.EndDate;
            details.ID = model.ID;
            details.Name = model.Name;
            details.StartDate = model.StartDate;
            details.Status = model.Status;
            AgreementRepository.Update(details);
        }

    }
}