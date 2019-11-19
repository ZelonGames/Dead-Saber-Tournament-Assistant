using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using BeatSaverApiHelper;

namespace Dead_Saber_Tournament_Assistant
{
    public class Player
    {
        public readonly TextBox txtScore;
        public readonly TextBox txtNoteCount;
        public readonly Label lblPercent;
        public readonly ComboBox cmbDifficulty;
        private readonly MapData mapData;

        public int Score
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtScore.Text);
                }
                catch
                {

                    return 0;
                }
            }
        }

        public int NoteCount
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtNoteCount.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public Player(MapData mapData, Form1 form, ComboBox cmbDifficulty, TextBox txtScore, TextBox txtNoteCount)
        {
            this.mapData = mapData;

            cmbDifficulty.Items.Add("ExpertPlus");
            cmbDifficulty.Items.Add("Expert");
            cmbDifficulty.Items.Add("Hard");
            cmbDifficulty.Items.Add("Normal");
            cmbDifficulty.Items.Add("Easy");
            cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDifficulty.SelectedValueChanged += OnDifficultyChanged;

            this.cmbDifficulty = cmbDifficulty;
            this.txtScore = txtScore;
            this.txtNoteCount = txtNoteCount;
            this.txtNoteCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;


            lblPercent = new Label();
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(txtScore.Location.X + txtScore.Size.Width + 10, txtScore.Location.Y);
            lblPercent.Text = "0%";

            form.Controls.Add(cmbDifficulty);
            form.Controls.Add(this.txtScore);
            form.Controls.Add(this.txtNoteCount);
            form.Controls.Add(lblPercent);

        }

        public void OnDifficultyChanged(object sender, EventArgs e)
        {
            txtNoteCount.Text = GetNoteCount().ToString();
        }

        public int MaxRawScoreForNumberOfNotes(int noteCount, float multiplier)
        {
            int num = 0;
            int i;
            for (i = 1; i < 8; i *= 2)
            {
                if (noteCount < i * 2)
                {
                    num += i * noteCount;
                    noteCount = 0;
                    break;
                }
                num += i * i * 2 + i;
                noteCount -= i * 2;
            }
            num += noteCount * i;
            int maxScore = num * 115;

            return (int)Math.Floor(maxScore * multiplier);
        }

        public int GetNoteCount()
        {
            Difficulty difficulty = mapData.metadata.characteristics[0].difficulties.GetDifficulty(cmbDifficulty.SelectedItem.ToString());

            return difficulty != null ? difficulty.notes : 0;
        }

        public decimal GetAverageScore(float multiplier)
        {
            if (NoteCount <= 0)
                return 0;

            return (decimal)Score / MaxRawScoreForNumberOfNotes(NoteCount, multiplier);
        }
    }
}
