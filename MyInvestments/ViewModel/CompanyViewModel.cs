using MyInvestments.Data;
using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class CompanyViewModel
    {
        public static List<CompanyMaster> GetCompanies()
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return investmentTypeContext.CompanyMaster.OrderBy(x => x.CompanyName).ToList();
        }

        public static List<CompanyMaster> GetCompaniesFromCompanyType(int CompanyTypeId)
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return (from ctmapp in investmentTypeContext.CompanyTypesMapping
                    join cm in investmentTypeContext.CompanyMaster on ctmapp.CompanyId equals cm.CompanyId
                    where ctmapp.CompanyTypeId == CompanyTypeId
                    orderby cm.CompanyName
                    select new CompanyMaster {CompanyId = cm.CompanyId, CompanyName = cm.CompanyName }).ToList<CompanyMaster>();            
        }

        public static void InsertCompany(CompanyMaster companyToInsert)
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            investmentTypeContext.CompanyMaster.Add(companyToInsert);
            investmentTypeContext.SaveChanges();
        }

        public static void UpdateCompany(CompanyMaster companyToUpdate)
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                investmentTypeContext.CompanyMaster.Update(companyToUpdate);
                investmentTypeContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static bool DeleteCompany(CompanyMaster companyToDelete)
        {
            try
            {
                using (var investmentTypeContext = new MyInvestmentsContext())
                {
                    var companyExistance = investmentTypeContext.CompanyMaster.Where(x => x.CompanyId == companyToDelete.CompanyId && x.CompanyName == companyToDelete.CompanyName).FirstOrDefault();
                    if (companyExistance != null)
                    {
                        investmentTypeContext.CompanyMaster.Remove(companyToDelete);
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
