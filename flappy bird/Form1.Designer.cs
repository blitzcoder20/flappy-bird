namespace flappy_bird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Pnl = new System.Windows.Forms.Panel();
            this.pnl_Lost = new System.Windows.Forms.Panel();
            this.ContinuareNo = new System.Windows.Forms.Button();
            this.Continuare_Lbl = new System.Windows.Forms.Label();
            this.ContinuareSi = new System.Windows.Forms.Button();
            this.ScoreTxt = new System.Windows.Forms.Label();
            this.Terreno = new System.Windows.Forms.PictureBox();
            this.pg = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Pnl.SuspendLayout();
            this.pnl_Lost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Terreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl
            // 
            this.Pnl.BackgroundImage = global::flappy_bird.Properties.Resources.Clouds;
            this.Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl.Controls.Add(this.pnl_Lost);
            this.Pnl.Controls.Add(this.ScoreTxt);
            this.Pnl.Controls.Add(this.Terreno);
            this.Pnl.Controls.Add(this.pg);
            this.Pnl.Location = new System.Drawing.Point(0, 3);
            this.Pnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(1470, 745);
            this.Pnl.TabIndex = 0;
            // 
            // pnl_Lost
            // 
            this.pnl_Lost.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Lost.Controls.Add(this.ContinuareNo);
            this.pnl_Lost.Controls.Add(this.Continuare_Lbl);
            this.pnl_Lost.Controls.Add(this.ContinuareSi);
            this.pnl_Lost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lost.Location = new System.Drawing.Point(0, 0);
            this.pnl_Lost.Name = "pnl_Lost";
            this.pnl_Lost.Size = new System.Drawing.Size(1470, 745);
            this.pnl_Lost.TabIndex = 3;
            this.pnl_Lost.Visible = false;
            // 
            // ContinuareNo
            // 
            this.ContinuareNo.BackColor = System.Drawing.Color.Red;
            this.ContinuareNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuareNo.Location = new System.Drawing.Point(806, 381);
            this.ContinuareNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContinuareNo.Name = "ContinuareNo";
            this.ContinuareNo.Size = new System.Drawing.Size(141, 71);
            this.ContinuareNo.TabIndex = 9;
            this.ContinuareNo.Text = "No";
            this.ContinuareNo.UseVisualStyleBackColor = false;
            this.ContinuareNo.Click += new System.EventHandler(this.ContinuareNo_Click);
            // 
            // Continuare_Lbl
            // 
            this.Continuare_Lbl.AutoSize = true;
            this.Continuare_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Continuare_Lbl.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuare_Lbl.Location = new System.Drawing.Point(392, 293);
            this.Continuare_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Continuare_Lbl.Name = "Continuare_Lbl";
            this.Continuare_Lbl.Size = new System.Drawing.Size(687, 48);
            this.Continuare_Lbl.TabIndex = 8;
            this.Continuare_Lbl.Text = "Gioco finito vuoi continuare?";
            // 
            // ContinuareSi
            // 
            this.ContinuareSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ContinuareSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuareSi.Location = new System.Drawing.Point(490, 381);
            this.ContinuareSi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContinuareSi.Name = "ContinuareSi";
            this.ContinuareSi.Size = new System.Drawing.Size(141, 71);
            this.ContinuareSi.TabIndex = 7;
            this.ContinuareSi.Text = "Si";
            this.ContinuareSi.UseVisualStyleBackColor = false;
            this.ContinuareSi.Click += new System.EventHandler(this.ContinuareSi_Click);
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.BackColor = System.Drawing.Color.Transparent;
            this.ScoreTxt.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ScoreTxt.Location = new System.Drawing.Point(702, 54);
            this.ScoreTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(35, 57);
            this.ScoreTxt.TabIndex = 2;
            this.ScoreTxt.Text = "0";
            this.ScoreTxt.UseCompatibleTextRendering = true;
            // 
            // Terreno
            // 
            this.Terreno.Image = global::flappy_bird.Properties.Resources.Grass;
            this.Terreno.Location = new System.Drawing.Point(0, 628);
            this.Terreno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Terreno.Name = "Terreno";
            this.Terreno.Size = new System.Drawing.Size(1470, 117);
            this.Terreno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Terreno.TabIndex = 1;
            this.Terreno.TabStop = false;
            // 
            // pg
            // 
            this.pg.BackColor = System.Drawing.Color.Transparent;
            this.pg.Image = global::flappy_bird.Properties.Resources.Bird;
            this.pg.Location = new System.Drawing.Point(122, 337);
            this.pg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(78, 71);
            this.pg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pg.TabIndex = 0;
            this.pg.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 746);
            this.Controls.Add(this.Pnl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl.ResumeLayout(false);
            this.Pnl.PerformLayout();
            this.pnl_Lost.ResumeLayout(false);
            this.pnl_Lost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Terreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.PictureBox pg;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Terreno;
        private System.Windows.Forms.Label ScoreTxt;
        private System.Windows.Forms.Panel pnl_Lost;
        private System.Windows.Forms.Button ContinuareNo;
        private System.Windows.Forms.Label Continuare_Lbl;
        private System.Windows.Forms.Button ContinuareSi;
    }
}

