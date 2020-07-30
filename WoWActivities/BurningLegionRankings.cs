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
   //This form is webscraping data from Raider.IO rankings webpage
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Mainmenu menu = new Mainmenu();
                this.Hide();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void InitTable()
        {
            table = new DataTable("RankingsTable");
            table.Columns.Add("No.", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(string));
            rankingsDataView.DataSource = table;
            rankingsDataView.Columns[0].Width = 30;
            rankingsDataView.Columns[1].Width = 145;
            rankingsDataView.Columns[2].Width = 145;
            rankingsDataView.RowTemplate.Height = 25;
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
                if (i == 0)
                {
                    rankingsDataView[0, i].Style.BackColor = Color.Gold;
                    rankingsDataView[1, i].Style.BackColor = Color.Gold;
                    rankingsDataView[2, i].Style.BackColor = Color.Gold;
                    continue;
                }
                if (i == 1)
                {
                    rankingsDataView[0, i].Style.BackColor = Color.Silver;
                    rankingsDataView[1, i].Style.BackColor = Color.Silver;
                    rankingsDataView[2, i].Style.BackColor = Color.Silver;
                    continue;
                }
                if (i == 2)
                {
                    rankingsDataView[0, i].Style.BackColor = Color.Tan;
                    rankingsDataView[1, i].Style.BackColor = Color.Tan;
                    rankingsDataView[2, i].Style.BackColor = Color.Tan;
                    continue;
                }
                if (i % 2 == 0)
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
        private void FillTable(List<PlayerNameScore> ranking)
        {
            int counter = 1;
            foreach (var player in ranking)
            {
                table.Rows.Add(counter.ToString(), player.Name, player.Score);
                counter++;

            }
            rankingsDataView.ClearSelection();
        }
        private void ShowTableTitle(Color c, string title)
        {
            DGVTitle.Visible = true;
            DGVTitle.BackColor = c;
            Title.Text = title;
            int x = (DGVTitle.Size.Width - Title.Size.Width) / 2;
            Title.Location = new Point(x, Title.Location.Y);
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
        
        //Makes window movable w/o title bar
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //
        private void BurningLegionRankings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private async Task<List<PlayerNameScore>> ClassRankingsFromRaiderIO(string chosenClassOrSpec)
        {
            var page = await Task.Factory.StartNew(() => web.Load("https://raider.io/mythic-plus-character-realm-rankings/season-bfa-4/eu/burning-legion/" + chosenClassOrSpec + "/0"));
            var nameNodes = page.DocumentNode.SelectNodes("//*[@id=\"content\"]/div//div//div//table//tr//td//div//div//h3//a");
            var names = nameNodes.Select(node => node.InnerText);
            var scoreNodes = page.DocumentNode.SelectNodes("//*[@id=\"content\"]//div//div//div//table//tr//td//a//b");
            var scores = scoreNodes.Select(node => node.InnerText);
            return names.Zip(scores, (name, score) => new PlayerNameScore() { Name = name, Score = score }).ToList<PlayerNameScore>();
            
        }
        private async void DHiconbutton_Click(object sender, EventArgs e)
        {
            InitTable();
            List<PlayerNameScore> ranking = await ClassRankingsFromRaiderIO("demon-hunter/all");
            FillTable(ranking);
            ColorTable();
            ShowTableTitle(Color.FromArgb(204, 0, 255), "Demon Hunters (All)");
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
            List<PlayerNameScore> ranking = await ClassRankingsFromRaiderIO("demon-hunter/dps");
            FillTable(ranking);
            ColorTable();
            ShowTableTitle(Color.FromArgb(204, 0, 255), "Demon Hunters (Havoc)");
        }

        private async void TankButton_Click(object sender, EventArgs e)
        {
            InitTable();
            List<PlayerNameScore> ranking = await ClassRankingsFromRaiderIO("all/tank");
            FillTable(ranking);
            ColorTable();
            ShowTableTitle(Color.FromArgb(39, 67, 207), "Tanks (All)");
        }

        private async void HealerButton_Click(object sender, EventArgs e)
        {
            InitTable();
            List<PlayerNameScore> ranking = await ClassRankingsFromRaiderIO("all/healer");
            FillTable(ranking);
            ColorTable();
            ShowTableTitle(Color.FromArgb(52, 224, 78), "Healers (All)");
        }

        private async void DPSButton_Click(object sender, EventArgs e)
        {
            InitTable();
            List<PlayerNameScore> ranking = await ClassRankingsFromRaiderIO("all/dps");
            FillTable(ranking);
            ColorTable();
            ShowTableTitle(Color.FromArgb(237, 100, 113), "Damage Dealers (All)");
        }
    }
}
