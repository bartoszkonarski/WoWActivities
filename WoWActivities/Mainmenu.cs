using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WoWActivities
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BurningLegionRankings blrank = new BurningLegionRankings();
            this.Hide();
            blrank.StartPosition = FormStartPosition.Manual;
            blrank.Size = this.Size;
            blrank.Location = this.Location;
            blrank.Show();


        }
    }
}
