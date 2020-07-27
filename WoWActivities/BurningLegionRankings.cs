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
            InitTable();
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
