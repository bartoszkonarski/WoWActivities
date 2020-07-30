namespace WoWActivities
{
    partial class Mainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.RaiderIOButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaiderIOButton
            // 
            this.RaiderIOButton.BackColor = System.Drawing.Color.Transparent;
            this.RaiderIOButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaiderIOButton.BackgroundImage")));
            this.RaiderIOButton.CausesValidation = false;
            this.RaiderIOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RaiderIOButton.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.RaiderIOButton.FlatAppearance.BorderSize = 0;
            this.RaiderIOButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RaiderIOButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RaiderIOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaiderIOButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RaiderIOButton.Location = new System.Drawing.Point(12, 461);
            this.RaiderIOButton.Name = "RaiderIOButton";
            this.RaiderIOButton.Size = new System.Drawing.Size(100, 100);
            this.RaiderIOButton.TabIndex = 3;
            this.RaiderIOButton.UseVisualStyleBackColor = false;
            this.RaiderIOButton.Click += new System.EventHandler(this.RaiderIOButton_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.RaiderIOButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 729);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1296, 729);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainmenu_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RaiderIOButton;
    }
}

