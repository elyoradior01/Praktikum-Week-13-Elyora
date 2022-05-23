namespace Praktikum_Week_13_Elyora
{
    partial class FormPlayer
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
            this.btnbackbnyk = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnmaju = new System.Windows.Forms.Button();
            this.btnmajubnyk = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelultah = new System.Windows.Forms.Label();
            this.labelnegara = new System.Windows.Forms.Label();
            this.labeltim = new System.Windows.Forms.Label();
            this.labelnotim = new System.Windows.Forms.Label();
            this.txtboxplayer = new System.Windows.Forms.TextBox();
            this.txtboxnama = new System.Windows.Forms.TextBox();
            this.dtpultah = new System.Windows.Forms.DateTimePicker();
            this.numnotim = new System.Windows.Forms.NumericUpDown();
            this.lblavl = new System.Windows.Forms.Label();
            this.cbtim = new System.Windows.Forms.ComboBox();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numnotim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackbnyk
            // 
            this.btnbackbnyk.Location = new System.Drawing.Point(54, 37);
            this.btnbackbnyk.Name = "btnbackbnyk";
            this.btnbackbnyk.Size = new System.Drawing.Size(102, 51);
            this.btnbackbnyk.TabIndex = 0;
            this.btnbackbnyk.Text = "<<";
            this.btnbackbnyk.UseVisualStyleBackColor = true;
            this.btnbackbnyk.Click += new System.EventHandler(this.btnbackbnyk_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(183, 37);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(109, 51);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnmaju
            // 
            this.btnmaju.Location = new System.Drawing.Point(335, 37);
            this.btnmaju.Name = "btnmaju";
            this.btnmaju.Size = new System.Drawing.Size(112, 51);
            this.btnmaju.TabIndex = 2;
            this.btnmaju.Text = ">";
            this.btnmaju.UseVisualStyleBackColor = true;
            this.btnmaju.Click += new System.EventHandler(this.btnmaju_Click);
            // 
            // btnmajubnyk
            // 
            this.btnmajubnyk.Location = new System.Drawing.Point(487, 37);
            this.btnmajubnyk.Name = "btnmajubnyk";
            this.btnmajubnyk.Size = new System.Drawing.Size(100, 51);
            this.btnmajubnyk.TabIndex = 3;
            this.btnmajubnyk.Text = ">>";
            this.btnmajubnyk.UseVisualStyleBackColor = true;
            this.btnmajubnyk.Click += new System.EventHandler(this.btnmajubnyk_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(70, 132);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(73, 20);
            this.labelid.TabIndex = 4;
            this.labelid.Text = "Player ID";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(70, 171);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(98, 20);
            this.labelnama.TabIndex = 5;
            this.labelnama.Text = "Player Name";
            // 
            // labelultah
            // 
            this.labelultah.AutoSize = true;
            this.labelultah.Location = new System.Drawing.Point(70, 213);
            this.labelultah.Name = "labelultah";
            this.labelultah.Size = new System.Drawing.Size(77, 20);
            this.labelultah.TabIndex = 6;
            this.labelultah.Text = "BirthDate";
            // 
            // labelnegara
            // 
            this.labelnegara.AutoSize = true;
            this.labelnegara.Location = new System.Drawing.Point(70, 254);
            this.labelnegara.Name = "labelnegara";
            this.labelnegara.Size = new System.Drawing.Size(82, 20);
            this.labelnegara.TabIndex = 7;
            this.labelnegara.Text = "Nationality";
            // 
            // labeltim
            // 
            this.labeltim.AutoSize = true;
            this.labeltim.Location = new System.Drawing.Point(70, 296);
            this.labeltim.Name = "labeltim";
            this.labeltim.Size = new System.Drawing.Size(49, 20);
            this.labeltim.TabIndex = 8;
            this.labeltim.Text = "Team";
            // 
            // labelnotim
            // 
            this.labelnotim.AutoSize = true;
            this.labelnotim.Location = new System.Drawing.Point(70, 339);
            this.labelnotim.Name = "labelnotim";
            this.labelnotim.Size = new System.Drawing.Size(109, 20);
            this.labelnotim.TabIndex = 9;
            this.labelnotim.Text = "Team Number";
            // 
            // txtboxplayer
            // 
            this.txtboxplayer.Location = new System.Drawing.Point(203, 126);
            this.txtboxplayer.Name = "txtboxplayer";
            this.txtboxplayer.Size = new System.Drawing.Size(353, 26);
            this.txtboxplayer.TabIndex = 10;
            // 
            // txtboxnama
            // 
            this.txtboxnama.Location = new System.Drawing.Point(203, 165);
            this.txtboxnama.Name = "txtboxnama";
            this.txtboxnama.Size = new System.Drawing.Size(353, 26);
            this.txtboxnama.TabIndex = 11;
            // 
            // dtpultah
            // 
            this.dtpultah.Location = new System.Drawing.Point(203, 213);
            this.dtpultah.Name = "dtpultah";
            this.dtpultah.Size = new System.Drawing.Size(353, 26);
            this.dtpultah.TabIndex = 13;
            // 
            // numnotim
            // 
            this.numnotim.Location = new System.Drawing.Point(203, 337);
            this.numnotim.Name = "numnotim";
            this.numnotim.Size = new System.Drawing.Size(187, 26);
            this.numnotim.TabIndex = 14;
            this.numnotim.ValueChanged += new System.EventHandler(this.numnotim_ValueChanged);
            // 
            // lblavl
            // 
            this.lblavl.AutoSize = true;
            this.lblavl.Location = new System.Drawing.Point(436, 343);
            this.lblavl.Name = "lblavl";
            this.lblavl.Size = new System.Drawing.Size(72, 20);
            this.lblavl.TabIndex = 15;
            this.lblavl.Text = "Available";
            // 
            // cbtim
            // 
            this.cbtim.FormattingEnabled = true;
            this.cbtim.Location = new System.Drawing.Point(203, 293);
            this.cbtim.Name = "cbtim";
            this.cbtim.Size = new System.Drawing.Size(244, 28);
            this.cbtim.TabIndex = 16;
            // 
            // cbnegara
            // 
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Location = new System.Drawing.Point(203, 251);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(244, 28);
            this.cbnegara.TabIndex = 17;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(74, 412);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(154, 39);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(290, 412);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(157, 39);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 498);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.cbtim);
            this.Controls.Add(this.lblavl);
            this.Controls.Add(this.numnotim);
            this.Controls.Add(this.dtpultah);
            this.Controls.Add(this.txtboxnama);
            this.Controls.Add(this.txtboxplayer);
            this.Controls.Add(this.labelnotim);
            this.Controls.Add(this.labeltim);
            this.Controls.Add(this.labelnegara);
            this.Controls.Add(this.labelultah);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.btnmajubnyk);
            this.Controls.Add(this.btnmaju);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnbackbnyk);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numnotim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackbnyk;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnmaju;
        private System.Windows.Forms.Button btnmajubnyk;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labelultah;
        private System.Windows.Forms.Label labelnegara;
        private System.Windows.Forms.Label labeltim;
        private System.Windows.Forms.Label labelnotim;
        private System.Windows.Forms.TextBox txtboxplayer;
        private System.Windows.Forms.TextBox txtboxnama;
        private System.Windows.Forms.DateTimePicker dtpultah;
        private System.Windows.Forms.NumericUpDown numnotim;
        private System.Windows.Forms.Label lblavl;
        private System.Windows.Forms.ComboBox cbtim;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}

