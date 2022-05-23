using MyInvestments.Data;
using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class MutualFundSchemeTypesViewModel
    {
        public static List<MutualFundSchemeTypesMaster> GetMutualFundSchemeTypes()
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return investmentTypeContext.MutualFundSchemeTypesMaster.OrderBy(x => x.MutualFundSchemeTypeName).ToList();
        }        

        public static void InsertMutualFundSchemeType(MutualFundSchemeTypesMaster mutualFundSchemeTypeToInsert)
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            investmentTypeContext.MutualFundSchemeTypesMaster.Add(mutualFundSchemeTypeToInsert);
            investmentTypeContext.SaveChanges();
        }

        public static void UpdateMutualFundSchemeType(MutualFundSchemeTypesMaster mutualFundSchemeTypeToUpdate)
        {
            try
            {
                using var investmentTypeContext = new MyInvestmentsContext();
                investmentTypeContext.MutualFundSchemeTypesMaster.Update(mutualFundSchemeTypeToUpdate);
                investmentTypeContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static bool DeleteMutualFundSchemeType(MutualFundSchemeTypesMaster mutualFundSchemeTypeToDelete)
        {
            try
            {
                using (var investmentTypeContext = new MyInvestmentsContext())
                {
                    var mutualFundSchemeTypeExistance = investmentTypeContext.MutualFundSchemeTypesMaster.Where(x => x.MutualFundSchemeTypeId == mutualFundSchemeTypeToDelete.MutualFundSchemeTypeId && x.MutualFundSchemeTypeName == mutualFundSchemeTypeToDelete.MutualFundSchemeTypeName).FirstOrDefault();
                    if (mutualFundSchemeTypeExistance != null)
                    {
                        investmentTypeContext.MutualFundSchemeTypesMaster.Remove(mutualFundSchemeTypeExistance);
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
