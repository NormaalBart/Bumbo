using AutoMapper;
using Bumbo.Models.Standard;

namespace Bumbo.Models.Converters
{
    public class StandardConverter : ITypeConverter<IEnumerable<BumboData.Models.Standard>, StandardViewModel>
    {
        public StandardViewModel Convert(IEnumerable<BumboData.Models.Standard> source, StandardViewModel destination, ResolutionContext context)
        {
            if(destination == null)
            {
                destination = new StandardViewModel();
            }
            foreach(var item in source)
            {
                switch (item.Key)
                {
                    case BumboData.Models.StandardType.COLI_TIME:
                        destination.ColiTime = item.Value;
                        break;
                    case BumboData.Models.StandardType.SHELF_STOCKING_TIME:
                        destination.ShelfStockingTimes = item.Value;
                        break;
                    case BumboData.Models.StandardType.CHECKOUT_EMPLOYEES:
                        destination.CheckoutEmployees = item.Value;
                        break;
                    case BumboData.Models.StandardType.FRESH_EMPLOYEES:
                        destination.FreshEmployees = item.Value;
                        break;
                    case BumboData.Models.StandardType.SHELF_ARRANGEMENT:
                        destination.ShelfArrangement = item.Value;
                        break;
                }
            }
            return destination;
        }
    }
}