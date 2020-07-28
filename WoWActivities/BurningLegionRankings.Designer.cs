namespace WoWActivities
{
    partial class BurningLegionRankings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurningLegionRankings));
            this.DHiconbutton = new System.Windows.Forms.Button();
            this.WarIconButton = new System.Windows.Forms.Button();
            this.HavocIconButton = new System.Windows.Forms.Button();
            this.rankingsDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rankingsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // DHiconbutton
            // 
            this.DHiconbutton.BackColor = System.Drawing.Color.Transparent;
            this.DHiconbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DHiconbutton.BackgroundImage")));
            this.DHiconbutton.CausesValidation = false;
            this.DHiconbutton.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.DHiconbutton.FlatAppearance.BorderSize = 0;
            this.DHiconbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DHiconbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DHiconbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DHiconbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DHiconbutton.Location = new System.Drawing.Point(12, 12);
            this.DHiconbutton.Name = "DHiconbutton";
            this.DHiconbutton.Size = new System.Drawing.Size(170, 170);
            this.DHiconbutton.TabIndex = 0;
            this.DHiconbutton.UseVisualStyleBackColor = false;
            this.DHiconbutton.Click += new System.EventHandler(this.DHiconbutton_Click);
            // 
            // WarIconButton
            // 
            this.WarIconButton.BackColor = System.Drawing.Color.Transparent;
            this.WarIconButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WarIconButton.BackgroundImage")));
            this.WarIconButton.CausesValidation = false;
            this.WarIconButton.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.WarIconButton.FlatAppearance.BorderSize = 0;
            this.WarIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WarIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarIconButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WarIconButton.Location = new System.Drawing.Point(207, 12);
            this.WarIconButton.Name = "WarIconButton";
            this.WarIconButton.Size = new System.Drawing.Size(170, 170);
            this.WarIconButton.TabIndex = 2;
            this.WarIconButton.UseVisualStyleBackColor = false;
            this.WarIconButton.Click += new System.EventHandler(this.WarIconButton_Click);
            // 
            // HavocIconButton
            // 
            this.HavocIconButton.BackColor = System.Drawing.Color.Transparent;
            this.HavocIconButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HavocIconButton.BackgroundImage")));
            this.HavocIconButton.CausesValidation = false;
            this.HavocIconButton.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.HavocIconButton.FlatAppearance.BorderSize = 0;
            this.HavocIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HavocIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HavocIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HavocIconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HavocIconButton.Location = new System.Drawing.Point(38, 188);
            this.HavocIconButton.Name = "HavocIconButton";
            this.HavocIconButton.Size = new System.Drawing.Size(60, 60);
            this.HavocIconButton.TabIndex = 3;
            this.HavocIconButton.UseVisualStyleBackColor = false;
            this.HavocIconButton.Click += new System.EventHandler(this.HavocIconButton_Click);
            // 
            // rankingsDataView
            // 
            this.rankingsDataView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.rankingsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankingsDataView.Location = new System.Drawing.Point(953, 364);
            this.rankingsDataView.Name = "rankingsDataView";
            this.rankingsDataView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rankingsDataView.Size = new System.Drawing.Size(300, 314);
            this.rankingsDataView.TabIndex = 5;
            // 
            // BurningLegionRankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.rankingsDataView);
            this.Controls.Add(this.HavocIconButton);
            this.Controls.Add(this.WarIconButton);
            this.Controls.Add(this.DHiconbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BurningLegionRankings";
            this.Text = "Burning Legion Class Rankings";
            this.Load += new System.EventHandler(this.BurningLegionRankings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rankingsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DHiconbutton;
        private System.Windows.Forms.Button WarIconButton;
        private System.Windows.Forms.Button HavocIconButton;
        private System.Windows.Forms.DataGridView rankingsDataView;
    }
}