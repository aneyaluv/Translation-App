using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TranslationApp
{
    public partial class TranslationPage : Form
    {
        private const string MyMemoryTranslateUrl = "https://api.mymemory.translated.net/get";
        private readonly Dictionary<string, string> LanguageCodes = new Dictionary<string, string>
{
    { "Afrikaans", "af" },
    { "Albanian", "sq" },
    { "Amharic", "am" },
    { "Arabic", "ar" },
    { "Armenian", "hy" },
    { "Azerbaijani", "az" },
    { "Bengali", "bn" },
    { "Bosnian", "bs" },
    { "Bulgarian", "bg" },
    { "Catalan", "ca" },
    { "Chinese (Simplified)", "zh-CN" },
    { "Chinese (Traditional)", "zh-TW" },
    { "Croatian", "hr" },
    { "Czech", "cs" },
    { "Danish", "da" },
    { "Dutch", "nl" },
    { "English", "en" },
    { "Estonian", "et" },
    { "Finnish", "fi" },
    { "French", "fr" },
    { "Georgian", "ka" },
    { "German", "de" },
    { "Greek", "el" },
    { "Gujarati", "gu" },
    { "Hebrew", "he" },
    { "Hindi", "hi" },
    { "Hungarian", "hu" },
    { "Icelandic", "is" },
    { "Indonesian", "id" },
    { "Irish", "ga" },
    { "Italian", "it" },
    { "Japanese", "ja" },
    { "Kannada", "kn" },
    { "Kazakh", "kk" },
    { "Korean", "ko" },
    { "Latvian", "lv" },
    { "Lithuanian", "lt" },
    { "Malay", "ms" },
    { "Maltese", "mt" },
    { "Marathi", "mr" },
    { "Mongolian", "mn" },
    { "Norwegian", "no" },
    { "Persian", "fa" },
    { "Polish", "pl" },
    { "Portuguese", "pt" },
    { "Punjabi", "pa" },
    { "Romanian", "ro" },
    { "Russian", "ru" },
    { "Serbian", "sr" },
    { "Slovak", "sk" },
    { "Slovenian", "sl" },
    { "Spanish", "es" },
    { "Swedish", "sv" },
    { "Tamil", "ta" },
    { "Telugu", "te" },
    { "Thai", "th" },
    { "Turkish", "tr" },
    { "Ukrainian", "uk" },
    { "Urdu", "ur" },
    { "Vietnamese", "vi" },
    { "Welsh", "cy" }
};

        private SpeechSynthesizer speechSynthesizer;

        public TranslationPage()
        {
            InitializeComponent();
            PopulateLanguageComboBoxes();

            TranslationTimer.Tick += TranslationTimer_Tick;
            TranslationTimer.Start();

            speechSynthesizer = new SpeechSynthesizer();
        }

        private void PopulateLanguageComboBoxes()
        {
            foreach (var language in LanguageCodes.Keys)
            {
                CmbSourceLang.Items.Add(language);
                CmbTargetLang.Items.Add(language);
            }

            if (CmbSourceLang.Items.Count > 0) CmbSourceLang.SelectedIndex = 0;
            if (CmbTargetLang.Items.Count > 0) CmbTargetLang.SelectedIndex = 0;
        }

        private async void TranslationTimer_Tick(object sender, EventArgs e)
        {        
                string inputText = TxtInput.Text.Trim();
                if (string.IsNullOrEmpty(inputText) || CmbSourceLang.SelectedItem == null || CmbTargetLang.SelectedItem == null)
                    return;

                string sourceLangCode = LanguageCodes[CmbSourceLang.SelectedItem.ToString()];
                string targetLangCode = LanguageCodes[CmbTargetLang.SelectedItem.ToString()];

                string translatedText = await TranslateText(inputText, sourceLangCode, targetLangCode);
                TxtOutput.Text = translatedText;            
        }


        private async Task<string> TranslateText(string text, string sourceLangCode, string targetLangCode)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var url = $"{MyMemoryTranslateUrl}?q={Uri.EscapeDataString(text)}&langpair={sourceLangCode}|{targetLangCode}";

                    // Send GET request to MyMemory API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Read and parse response
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject jsonResponse = JObject.Parse(responseBody);

                    if (jsonResponse["responseStatus"].ToString() != "200")
                    {
                        throw new Exception("Translation error: " + jsonResponse["responseDetails"]);
                    }

                    string translatedText = jsonResponse["responseData"]["translatedText"].ToString();

                    if (translatedText.Equals(text, StringComparison.OrdinalIgnoreCase))
                    {
                        return "No equivalent translation found";
                    }

                    return translatedText;
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Translation error: {ex.Message}");
                    return "Translation Error";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return "Error";
                }
            }
        }

        private void BtnSpeakInput_Click(object sender, EventArgs e)
        {
            string textToSpeak = TxtInput.Text.Trim();
            if (!string.IsNullOrEmpty(textToSpeak))
            {
                speechSynthesizer.SpeakAsync(textToSpeak);
            }
        }

        private void BtnSpeakOutput_Click(object sender, EventArgs e)
        {
            string textToSpeak = TxtOutput.Text.Trim();
            if (!string.IsNullOrEmpty(textToSpeak))
            {
                speechSynthesizer.SpeakAsync(textToSpeak);
            }
        }

        private void circularBtnBack_Click(object sender, EventArgs e)
        {
            WelcomePage form2 = new WelcomePage();
            form2.Show();
            this.Close();
        }

    }
}
