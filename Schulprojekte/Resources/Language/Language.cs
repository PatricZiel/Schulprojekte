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
        public static String CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("check_digit");
        public static String CHECK_DIGIT_EAN = GeneralLanguage.GetTranslationByKey("check_digit_ean");
        public static String CHECK_DIGIT_IBAN = GeneralLanguage.GetTranslationByKey("check_digit_iban");
        public static String CHECK_THE_CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("check_the_check_digit");
        public static String CHECK_DIGIT_CORRECT_MESSAGE = GeneralLanguage.GetTranslationByKey("check_digit_correct_message");
        public static String CHECK_DIGIT_INCORRECT_MESSAGE = GeneralLanguage.GetTranslationByKey("check_digit_incorrect_message");
        public static String CHECK_DIGIT_ERROR_NO_LANGUAGE_SUPPORT = GeneralLanguage.GetTranslationByKey("check_digit_error_no_language_support");
        public static String CHECK_DIGIT_ERROR_IBAN_EMPTY = GeneralLanguage.GetTranslationByKey("check_digit_error_iban_empty");
        public static String CHECK_DIGIT_ERROR_INCORRECT = GeneralLanguage.GetTranslationByKey("check_digit_error_incorrect");

        // Semi General
        public static String PLEASE_USE_ONLY_DIGITS = GeneralLanguage.GetTranslationByKey("please_use_only_digits"); 
        public static String LENGTH_IS_NOT_EXPECTED = GeneralLanguage.GetTranslationByKey("length_is_not_expected"); 

        // General
        public static String INPUT_INCORRECT = GeneralLanguage.GetTranslationByKey("input_incorrect");
    }
}
