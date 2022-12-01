using AutoMapper;
using Bumbo.Models.Standard;

namespace Bumbo.Models.Converters
{
    public class StandardViewModelConverter
    {
        public static IEnumerable<BumboData.Models.Standard> Convert(StandardViewModel source)
        {
            var list = new List<BumboData.Models.Standard>();
            list.Add(new BumboData.Models.Standard
            {
                Key = BumboData.Models.StandardType.COLI_TIME,
                Value = source.ColiTime
            });
            list.Add(new BumboData.Models.Standard
            {
                Key = BumboData.Models.StandardType.CHECKOUT_EMPLOYEES,
                Value = source.CheckoutEmployees
            });
            list.Add(new BumboData.Models.Standard
            {
                Key = BumboData.Models.StandardType.FRESH_EMPLOYEES,
                Value = source.FreshEmployees
            });
            list.Add(new BumboData.Models.Standard
            {
                Key = BumboData.Models.StandardType.SHELF_ARRANGEMENT,
                Value = source.ShelfArrangement
            });
            list.Add(new BumboData.Models.Standard
            {
                Key = BumboData.Models.StandardType.SHELF_STOCKING_TIME,
                Value = source.ShelfStockingTimes
            }) ;
            return list;
        }
    }
}
