using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doppler.Utils
{
    public class ThemeManager
    {
        DopplerTheme Theme { get; set; }
        private DopplerConfig Config { get; }

        private DopplerForm Application;

        public ThemeManager(DopplerConfig config)
        {
            Config = config;
            Theme = config.Theme;
        }

        public void AttachComponents(DopplerForm application)
        {
            Application = application;
            Application.themeSwitch.Checked = Convert.ToBoolean(Config.Theme);
            ApplyTheme();
        }

        public void ChangeTheme(object sender, EventArgs e)
        {
            Theme = ((CheckBox)sender).Checked ? DopplerTheme.DARK : DopplerTheme.LIGHT;
            Config.Theme = Theme;
            Config.Save();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            if (Theme == DopplerTheme.DARK)
            {
                Application.BackColor = Color.FromArgb(45, 45, 48); // Dark color
                Application.ForeColor = Color.White;

                foreach (Control c in Application.Controls)
                {
                    c.BackColor = Color.FromArgb(28, 28, 28);
                    c.ForeColor = Color.White;
                }

                foreach (Control tab in Application.tabControl1.TabPages)
                {
                    tab.BackColor = Color.FromArgb(28, 28, 28);
                    tab.ForeColor = Color.White;
                    foreach (Control c in tab.Controls)
                    {
                        c.BackColor = Color.FromArgb(28, 28, 28);
                        c.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                Application.BackColor = SystemColors.Control; // Light  color
                Application.ForeColor = Color.Black;

                foreach (Control c in Application.Controls)
                {
                    c.BackColor = SystemColors.Control;
                    c.ForeColor = Color.Black;
                }

                foreach (Control tab in Application.tabControl1.TabPages)
                {
                    tab.BackColor = SystemColors.Control;
                    tab.ForeColor = Color.Black;
                    foreach (Control c in tab.Controls)
                    {
                        c.BackColor = SystemColors.Control;
                        c.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
