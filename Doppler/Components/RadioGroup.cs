using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doppler.Components
{
    public class RadioGroup
    {
        private IEnumerable<RadioButtonExtend> Radios;

        public RadioGroup(IEnumerable<RadioButtonExtend> radios)
        {
            Radios = radios;
        }

        public RadioButtonExtend Find(RadioButton rb)
        {
            return Radios.First(r => r.Name.Equals(rb.Name));
        }

        public string Handle(RadioButtonExtend rb)
        {
            foreach (var radio in Radios)
            {
                radio.Checked = false;
            }
            rb.Checked = true;

            return rb.Value;
        }
    }
}
