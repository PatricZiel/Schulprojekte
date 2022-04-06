using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulprojekte.Objekte
{
    internal class QuantitativeOfferComparisonInformation
    {
        public List<QuantitativeOfferComparisonOfferInformation> offerInformations = new List<QuantitativeOfferComparisonOfferInformation>();
        public int amound = 0;
        public int offerCount = 0;
    }

    internal class QuantitativeOfferComparisonOfferInformation
    {
        public String offererName;
        public double unitPrice;
        public string deliverer;
        public double deliveryDiscount;
        public double deliverySkonto;
        public double purchaseCost;
    }
}
