using MyInvestments.Data;
using MyInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyInvestments.ViewModel
{
    public class InvestmentTypesViewModel
    {
        public static List<InvestmentTypes> GetInvestmentTypes()
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return investmentTypeContext.InvestmentTypes.OrderBy(x => x.InvestmentTypeName).ToList();
        }

        public static int GetInvestmentTypeIdFromName(string investmentTypeNameParam)
        {
            using var investmentTypeContext = new MyInvestmentsContext();
            return (from inv in investmentTypeContext.InvestmentTypes
                                   where inv.InvestmentTypeName == investmentTypeNameParam
                                   select inv.InvestmentTypeId).FirstOrDefault();
        }
    }

}
