using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dead_Saber_Tournament_Assistant.Modifiers
{
    public static class ModifierHelper
    {
        public delegate void ModifierChangedEventHandler(float multiplier);
        public static event ModifierChangedEventHandler ModifierChanged = null;

        public static List<Modifier> modifiers = new List<Modifier>();

        public static float TotalMultiplier { get; private set; }
        

        public static void AddModifiers(Form1 form, Label lblModifier)
        {
            int spacing = 5;

            var noFailModifierCheckBox = new CheckBox();
            noFailModifierCheckBox.Location = new Point(lblModifier.Location.X + lblModifier.Size.Width + spacing, lblModifier.Location.Y);

            var noFailModifier = new Modifier(form, "No Fail", 0.5f, noFailModifierCheckBox);
            TotalMultiplier = noFailModifier.multiplier;

            modifiers.Add(noFailModifier);
            modifiers.Add(new Modifier(form, "Faster Song", 1.08f, new CheckBox()));
            modifiers.Add(new Modifier(form, "Ghost Notes", 1.11f, new CheckBox()));
            modifiers.Add(new Modifier(form, "Disappearing Arrows", 1.07f, new CheckBox()));

            modifiers[0].checkBoxModifier.CheckedChanged += OnModifierChecked;
            for (int i = 1; i < modifiers.Count; i++)
            {
                modifiers[i].checkBoxModifier.CheckedChanged += OnModifierChecked;

                CheckBox prevCheckbox = modifiers[i - 1].checkBoxModifier;
                modifiers[i].checkBoxModifier.Location = new Point(prevCheckbox.Location.X + prevCheckbox.Size.Width + spacing, lblModifier.Location.Y);
            }

            noFailModifier.checkBoxModifier.Checked = true;
        }

        private static void OnModifierChecked(object sender, EventArgs e)
        {
            List<Modifier> checkedModifiers = modifiers.Where(x => x.checkBoxModifier.Checked).ToList();
            TotalMultiplier = 1 + checkedModifiers.Sum(x => x.multiplier - 1);

            ModifierChanged?.Invoke(TotalMultiplier);
        }
    }
}
