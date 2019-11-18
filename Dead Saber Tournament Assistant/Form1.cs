using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using BeatSaverApiHelper;

namespace Dead_Saber_Tournament_Assistant
{
    public partial class Form1 : Form
    {
        public List<Player> players = new List<Player>();
        public HttpClient client = new HttpClient();
        public MapData _MapData { get; private set; }

        public int amountOfPlayers = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximumSize = MinimumSize = Size;

            for (int i = 1; i <= cmbPrecision.MaxDropDownItems; i++)
            {
                cmbPrecision.Items.Add(i);
            }

            cmbPrecision.SelectedIndex = 3;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int decimals = Convert.ToInt32(cmbPrecision.SelectedItem.ToString());

            foreach (var player in players)
            {
                if (player.NoteCount <= 0 || player.Score <= 0)
                    continue;

                int maxScore = player.MaxRawScoreForNumberOfNotes(player.NoteCount);
                decimal accuracy = Math.Round((decimal)player.Score / maxScore, decimals) * 100;

                player.lblPercent.Text = accuracy + "% / " + maxScore;
            }

            int totalScore = players.Sum(x => x.Score);
            decimal average = Math.Round(players.Sum(x => x.GetAverageScore()) / players.Count, decimals) * 100;

            lblTotalScore.Text = "Total Score: " + totalScore;
            lblAverage.Text = "Average: " + average + "%";
        }

        public async Task SetMapData(string key)
        {
            var responseString = await client.GetStringAsync("https://beatsaver.com/api/maps/detail/" + key);

            _MapData = JsonConvert.DeserializeObject<MapData>(responseString);
        }

        private async void btnMapData_Click(object sender, EventArgs e)
        {
            if (txtMapKey.Text == "")
                return;

            await SetMapData(txtMapKey.Text);

            if (_MapData == null)
                return;

            if (players.Count > 0)
            {
                foreach (var player in players)
                {
                    Controls.Remove(player.cmbDifficulty);
                    Controls.Remove(player.txtNoteCount);
                    Controls.Remove(player.txtScore);
                    Controls.Remove(player.lblPercent);
                }

                players.Clear();
            }
            
            int startY = lblPlayerScores.Location.Y + lblPlayerScores.Size.Height + 10;
            
            for (int i = 0; i < amountOfPlayers; i++)
            {
                var cmbDifficulty = new ComboBox();
                cmbDifficulty.Location = new Point(lblPlayerScores.Location.X, (cmbDifficulty.Size.Height + 5) * i + startY);

                var scoreInputField = new TextBox();
                scoreInputField.TabIndex = i;
                scoreInputField.Location = new Point(cmbDifficulty.Location.X + cmbDifficulty.Size.Width + 10, cmbDifficulty.Location.Y);

                var noteCountInputField = new TextBox();
                noteCountInputField.TabIndex = amountOfPlayers + i;
                noteCountInputField.Location = new Point(btnCalculate.Location.X + btnCalculate.Size.Width - noteCountInputField.Size.Width, cmbDifficulty.Location.Y);

                var player = new Player(_MapData, this, cmbDifficulty, scoreInputField, noteCountInputField);
                if (i > player.cmbDifficulty.Items.Count - 1)
                    i = player.cmbDifficulty.Items.Count - 1;
                player.cmbDifficulty.SelectedIndex = i;

                player.txtNoteCount.Text = player.GetNoteCount().ToString();

                players.Add(player);
            }

            lblAmountOfNotes.Location = new Point(players[0].txtNoteCount.Location.X, lblAmountOfNotes.Location.Y);
        }

        private void cmbPrecision_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
