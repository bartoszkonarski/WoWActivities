using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WoWActivities
{
   
    public partial class BurningLegionRankings : Form
    {
        public class PlayerNameScore
        {
            public string Name { get; set; }
            public string Score { get; set; }
        }
        DataTable table;
        HtmlWeb web = new HtmlWeb();
        public BurningLegionRankings()
        {
            InitializeComponent();
        }
        private void InitTable()
        {
            table = new DataTable("RankingsTable");
            table.Columns.Add("No.", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(string));
            rankingsDataView.DataSource = table;
            rankingsDataView.RowHeadersVisible = false;
            rankingsDataView.ColumnHeadersVisible = false;
            rankingsDataView.BackgroundColor = Color.LightCoral;
            rankingsDataView.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            rankingsDataView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            rankingsDataView.MouseWheel += new MouseEventHandler(mousewheel);

        }
        private void ColorTable()
        {
            for (int i = 0; i < rankingsDataView.Rows.Count; i++)
            {
                if (i % 2 == 1)
                {
                    rankingsDataView[0, i].Style.BackColor = Color.Moccasin;
                    rankingsDataView[1, i].Style.BackColor = Color.Moccasin;
                    rankingsDataView[2, i].Style.BackColor = Color.Moccasin;
                }
                else
                {
                    rankingsDataView[0, i].Style.BackColor = Color.LightCoral;
                    rankingsDataView[1, i].Style.BackColor = Color.LightCoral;
                    rankingsDataView[2, i].Style.BackColor = Color.LightCoral;
                }

            }
        }
        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && rankingsDataView.FirstDisplayedScrollingRowIndex > 0)
            {
                rankingsDataView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0 && rankingsDataView.Rows.Count>1 && rankingsDataView.FirstDisplayedScrollingRowIndex !=8)
            {
                rankingsDataView.FirstDisplayedScrollingRowIndex++;
            }
        }
        private async Task<List<PlayerNameScore>> ClassRankingsFromRaiderIO(string chosenclass)
        {
            var page = await Task.Factory.StartNew(() => web.Load("https://raider.io/mythic-plus-character-realm-rankings/season-bfa-4/eu/burning-legion/"+chosenclass+"/0"));
            var nameNodes = page.DocumentNode.SelectNodes("//*[@id=\"content\"]/div//div//div//table//tr//td//div//div//h3//a");
            var names = nameNodes.Select(node => node.InnerText);
            var scoreNodes = page.DocumentNode.SelectNodes("//*[@id=\"content\"]//div//div//div//table//tr//td//a//b");
            var scores = scoreNodes.Select(node => node.InnerText);
            return names.Zip(scores,(name,score) =>new PlayerNameScore() { Name = name, Score = score }).ToList<PlayerNameScore>();
        }
        private void BurningLegionRankings_Load(object sender, EventArgs e)
        {
            //InitTable();
        }
        private async void DHiconbutton_Click(object sender, EventArgs e)
        {
            InitTable();
            var ranking = await ClassRankingsFromRaiderIO("demon-hunter/all");
            int counter = 1;
            foreach (var player in ranking)
            {
                table.Rows.Add(counter.ToString(), player.Name, player.Score);
                counter++;
                
            }
            ColorTable();
        }
        private async void WarIconButton_Click(object sender, EventArgs e)
        {
            InitTable();
            var ranking = await ClassRankingsFromRaiderIO("warrior/all");
            int counter = 1;
            foreach (var player in ranking)
            {
                table.Rows.Add(counter.ToString(), player.Name, player.Score);
                counter++;
            }
        }

        private async void HavocIconButton_Click(object sender, EventArgs e)
        {
            InitTable();
            var ranking = await ClassRankingsFromRaiderIO("demon-hunter/dps");
            int counter = 1;
            foreach (var player in ranking)
            {
                table.Rows.Add(counter.ToString(),player.Name, player.Score);
                counter++;
            }
        }

    }
}
