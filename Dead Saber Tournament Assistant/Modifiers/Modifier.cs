using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dead_Saber_Tournament_Assistant.Modifiers
{
    public class Modifier
    {
        public CheckBox checkBoxModifier;
        public readonly string name;

        public readonly float multiplier;

        public Modifier(Form1 form, string name, float multiplier, CheckBox checkBoxModifier)
        {
            this.name = name;
            this.multiplier = multiplier;

            this.checkBoxModifier = checkBoxModifier;
            this.checkBoxModifier.Text = name;
            this.checkBoxModifier.AutoSize = true;

            form.Controls.Add(checkBoxModifier);
        }
    }
}
