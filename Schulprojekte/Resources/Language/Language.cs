using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schulprojekte.Objekte;

namespace Schulprojekte.Resources.Language
{
    internal class Language
    {
        public static String DBT_QUANTITATIVE_OFFER_COMPARISON = GeneralLanguage.GetTranslationByKey("dbt_quantitative_offer_comparison");
        public static String DBT_CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("dbt_check_digit");
        public static String DELIVERER_HERMES = GeneralLanguage.GetTranslationByKey("deliverer_hermes");
        public static String DELIVERER_DHL = GeneralLanguage.GetTranslationByKey("deliverer_dhl");
        public static String DELIVERER_DPD = GeneralLanguage.GetTranslationByKey("deliverer_dpd");
        public static String DELIVERER_SELF = GeneralLanguage.GetTranslationByKey("deliverer_self");
        public static String OFFER_COUNT = GeneralLanguage.GetTranslationByKey("offer_count");
        public static String DELIVERY_AMOUNT = GeneralLanguage.GetTranslationByKey("delivery_amount");
    }
}
