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
using System.Runtime.InteropServices;

namespace WoWActivities
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //Makes window movable w/o title bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Mainmenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //

        //Close App on Esc press
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //

        private void RaiderIOButton_Click(object sender, EventArgs e)
        {
            BurningLegionRankings blrank = new BurningLegionRankings();
            this.Hide();
            blrank.StartPosition = FormStartPosition.Manual;
            blrank.Location = this.Location;
            blrank.Show();

        }
    }
}
