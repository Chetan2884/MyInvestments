using MyInvestments.Data;
using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class CompanyTypeViewModel
    {
        public static List<CompanyTypesMaster> GetCompanyTypes()
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return investmentTypeContext.CompanyTypesMaster.OrderBy(x => x.CompanyTypeName).ToList();
        }

        public static void InsertCompanyType(CompanyTypesMaster companyTypeToInsert)
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            investmentTypeContext.CompanyTypesMaster.Add(companyTypeToInsert);
            investmentTypeContext.SaveChanges();
        }

        public static void UpdateCompanyType(CompanyTypesMaster companyTypeToUpdate)
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                investmentTypeContext.CompanyTypesMaster.Update(companyTypeToUpdate);
                investmentTypeContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static bool DeleteCompanyType(CompanyTypesMaster companyTypeToDelete)
        {
            try
            {
                using (var investmentTypeContext = new MyInvestmentsContext())
                {
                    var companyExistance = investmentTypeContext.CompanyTypesMaster.Where(x => x.CompanyTypeId == companyTypeToDelete.CompanyTypeId && x.CompanyTypeName == companyTypeToDelete.CompanyTypeName).FirstOrDefault();
                    if (companyExistance != null)
                    {
                        investmentTypeContext.CompanyTypesMaster.Remove(companyTypeToDelete);
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
