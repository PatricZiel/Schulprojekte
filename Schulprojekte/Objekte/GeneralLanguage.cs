using System;
using System.Collections.Generic;
using System.IO;

namespace Schulprojekte.Objekte
{
    public partial class GeneralLanguage
    {
        public static String language = "";
        public static Dictionary<String, String> languageRessource;

        public static void changeLanguage(String langaugeKey)
        {
            language = langaugeKey;

            languageRessource = new Dictionary<String, String>();
            string[] lines = File.ReadAllLines("../../Resources/Language/language_" + langaugeKey + ".txt");
            foreach(String line in lines) {
                if(!line.StartsWith("//") && line.Length > 0)
                {
                    String[] splittedString = line.Split(new String[]{ " = " }, StringSplitOptions.None);
                    try
                    {
                        languageRessource.Add(splittedString[0], splittedString[1]);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("ERROR GeneralLanguage Line 41:");
                        Console.WriteLine(e);
                    }
                }
            }
            Console.WriteLine(languageRessource.Count);
        }

        public static String GetTranslationByKey(String key)
        {
            return languageRessource[key];
        }
    }
}
