using System.Windows.Forms;

namespace Doppler.Components
{
    public class RadioButtonExtend
    {
        private RadioButton Radio { get; set; }

        public string Name { get => Radio.Name; }

        public bool Checked { get => Radio.Checked; set
            {
                Radio.Checked = value;
            }
        }

        public string Value { get; set; }

        public RadioButtonExtend(RadioButton rb, string value)
        {
            Radio = rb;
            Value = value;
        }
    }
}
