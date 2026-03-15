using Addams.Core.Exceptions;
using Doppler.Core.Utils;
using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Doppler.Tabs
{
    public class Settings : ITab
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DopplerConfig Config;

        private ComboBox LanguageCb = new ComboBox();

        private readonly DopplerView View;

        public Settings(DopplerConfig config, DopplerView view)
        {
            Config = config;
            View = view;
        }

        public void AttachComponents(TabPage tab)
        {
            if (tab.Controls["languageCb"] is ComboBox languageCb)
                LanguageCb = languageCb;

            LanguageCb.DisplayMember = "Display";
            LanguageCb.ValueMember = "Value";
            SetComboLanguage();

            LanguageCb.SelectedValue = Config.AppLanguage;
            LanguageCb.SelectedIndexChanged += ChangeLanguage;
        }

        private void SetComboLanguage()
        {
            var languages = new List<ComboItem> {
                new ComboItem(Language.GetString("Language_EN"), "en-US"),
                new ComboItem(Language.GetString("Language_FR"), "fr-FR"),
                new ComboItem(Language.GetString("Language_ES"), "es-ES"),
                new ComboItem(Language.GetString("Language_DE"), "de-DE"),
                new ComboItem(Language.GetString("Language_IT"), "it-IT"),
            };
            LanguageCb.DataSource = languages;
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox ?? new ComboBox();
            if (comboBox.SelectedItem == null)
                return;

            var item = comboBox.SelectedItem as ComboItem ?? throw new ComboBoxException();
            var culture = item.Value;

            Config.AppLanguage = culture;
            Config.Save();

            View.ApplyTexts();
        }
    }

    internal class ComboItem
    {
        public string Display { get; set; }
        public string Value { get; set; }

        public ComboItem(string display, string value)
        {
            Display = display;
            Value = value;
        }
    }
}
