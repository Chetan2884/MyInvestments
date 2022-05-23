using MyInvestments.Data;
using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class CompanyTypesMappingViewModel
    {
        public static dynamic GetCompanyTypesMapping()
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                return (from ctmapp in investmentTypeContext.CompanyTypesMapping
                        join cm in investmentTypeContext.CompanyMaster on ctmapp.CompanyId equals cm.CompanyId
                        join ctmast in investmentTypeContext.CompanyTypesMaster on ctmapp.CompanyTypeId equals ctmast.CompanyTypeId
                        orderby cm.CompanyName
                        select new { ctmapp.CompanyTypesMappingId, ctmapp.CompanyId, cm.CompanyName, ctmapp.CompanyTypeId, ctmast.CompanyTypeName }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static void InsertCompanyTypesMapping(CompanyTypesMapping companyTypesMappingToInsert)
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                investmentTypeContext.CompanyTypesMapping.Add(companyTypesMappingToInsert);
                investmentTypeContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateCompanyTypesMapping(CompanyTypesMapping companyTypesMappingToUpdate)
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                investmentTypeContext.CompanyTypesMapping.Update(companyTypesMappingToUpdate);
                investmentTypeContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteCompanyTypesMapping(CompanyTypesMapping companyTypesMappingToDelete)
        {
            try
            {
                using (var investmentTypeContext = new MyInvestmentsContext())
                {
                    var companyExistance = investmentTypeContext.CompanyTypesMapping.Where(x => x.CompanyTypesMappingId == companyTypesMappingToDelete.CompanyTypesMappingId).FirstOrDefault();
                    if (companyExistance != null)
                    {
                        investmentTypeContext.CompanyTypesMapping.Remove(companyTypesMappingToDelete);
                        investmentTypeContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
