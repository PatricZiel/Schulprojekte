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
        public static string DBT_QUANTITATIVE_OFFER_COMPARISON = GeneralLanguage.GetTranslationByKey("dbt_quantitative_offer_comparison");
        public static string DBT_CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("dbt_check_digit");
        public static string DELIVERER_HERMES = GeneralLanguage.GetTranslationByKey("deliverer_hermes");
        public static string DELIVERER_DHL = GeneralLanguage.GetTranslationByKey("deliverer_dhl");
        public static string DELIVERER_DPD = GeneralLanguage.GetTranslationByKey("deliverer_dpd");
        public static string DELIVERER_SELF = GeneralLanguage.GetTranslationByKey("deliverer_self");
        public static string OFFER_COUNT = GeneralLanguage.GetTranslationByKey("offer_count");
        public static string DELIVERY_AMOUNT = GeneralLanguage.GetTranslationByKey("delivery_amount");
        public static string CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("check_digit");
        public static string CHECK_DIGIT_EAN = GeneralLanguage.GetTranslationByKey("check_digit_ean");
        public static string CHECK_DIGIT_IBAN = GeneralLanguage.GetTranslationByKey("check_digit_iban");
        public static string CHECK_THE_CHECK_DIGIT = GeneralLanguage.GetTranslationByKey("check_the_check_digit");
        public static string CHECK_DIGIT_CORRECT_MESSAGE = GeneralLanguage.GetTranslationByKey("check_digit_correct_message");
        public static string CHECK_DIGIT_CORRECT_MESSAGE_EAN = GeneralLanguage.GetTranslationByKey("check_digit_correct_message_ean");
        public static string CHECK_DIGIT_CORRECT_MESSAGE_IBAN = GeneralLanguage.GetTranslationByKey("check_digit_correct_message_iban");
        public static string CHECK_DIGIT_INCORRECT_MESSAGE = GeneralLanguage.GetTranslationByKey("check_digit_incorrect_message");
        public static string CHECK_DIGIT_INCORRECT_MESSAGE_EAN = GeneralLanguage.GetTranslationByKey("check_digit_incorrect_message_ean");
        public static string CHECK_DIGIT_INCORRECT_MESSAGE_IBAN = GeneralLanguage.GetTranslationByKey("check_digit_incorrect_message_iban");
        public static string CHECK_DIGIT_ERROR_NO_LANGUAGE_SUPPORT = GeneralLanguage.GetTranslationByKey("check_digit_error_no_language_support");
        public static string CHECK_DIGIT_ERROR_IBAN_EMPTY = GeneralLanguage.GetTranslationByKey("check_digit_error_iban_empty");
        public static string CHECK_DIGIT_ERROR_EAN_EMPTY = GeneralLanguage.GetTranslationByKey("check_digit_error_ean_empty");
        public static string CHECK_DIGIT_ERROR_INCORRECT = GeneralLanguage.GetTranslationByKey("check_digit_error_incorrect");
        public static string CHECK_DIGIT_ERROR_IBAN_LENGTH_UNEXPECTED = GeneralLanguage.GetTranslationByKey("check_digit_error_iban_length_unexpected");

        // Semi General
        public static string PLEASE_USE_ONLY_DIGITS = GeneralLanguage.GetTranslationByKey("please_use_only_digits"); 
        public static string LENGTH_IS_NOT_EXPECTED = GeneralLanguage.GetTranslationByKey("length_is_not_expected");

        // General
        public static string INPUT_INCORRECT = GeneralLanguage.GetTranslationByKey("input_incorrect");
        public static string LANGUAGE_FOR_ABBREVIATION_EN = GeneralLanguage.GetTranslationByKey("language_for_abbreviation_en");
        public static string LANGUAGE_FOR_ABBREVIATION_DE = GeneralLanguage.GetTranslationByKey("language_for_abbreviation_de");
    }
}
