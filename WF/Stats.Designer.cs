
namespace WF
{
    partial class Stats
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
            this.pb_vitesse = new System.Windows.Forms.ProgressBar();
            this.pb_chance = new System.Windows.Forms.ProgressBar();
            this.pb_endurance = new System.Windows.Forms.ProgressBar();
            this.cb_laps = new System.Windows.Forms.ComboBox();
            this.l_v = new System.Windows.Forms.Label();
            this.l_e = new System.Windows.Forms.Label();
            this.l_c = new System.Windows.Forms.Label();
            this.l_sur = new System.Windows.Forms.Label();
            this.l_age = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_sur = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_va = new System.Windows.Forms.Label();
            this.l_valeur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_vitesse
            // 
            this.pb_vitesse.Location = new System.Drawing.Point(87, 168);
            this.pb_vitesse.MarqueeAnimationSpeed = 50;
            this.pb_vitesse.Maximum = 10;
            this.pb_vitesse.Name = "pb_vitesse";
            this.pb_vitesse.Size = new System.Drawing.Size(361, 20);
            this.pb_vitesse.Step = 1;
            this.pb_vitesse.TabIndex = 0;
            // 
            // pb_chance
            // 
            this.pb_chance.Location = new System.Drawing.Point(87, 253);
            this.pb_chance.Maximum = 10;
            this.pb_chance.Name = "pb_chance";
            this.pb_chance.Size = new System.Drawing.Size(361, 20);
            this.pb_chance.Step = 1;
            this.pb_chance.TabIndex = 1;
            // 
            // pb_endurance
            // 
            this.pb_endurance.Location = new System.Drawing.Point(87, 211);
            this.pb_endurance.Maximum = 10;
            this.pb_endurance.Name = "pb_endurance";
            this.pb_endurance.Size = new System.Drawing.Size(361, 20);
            this.pb_endurance.Step = 1;
            this.pb_endurance.TabIndex = 2;
            // 
            // cb_laps
            // 
            this.cb_laps.FormattingEnabled = true;
            this.cb_laps.Location = new System.Drawing.Point(12, 12);
            this.cb_laps.Name = "cb_laps";
            this.cb_laps.Size = new System.Drawing.Size(293, 26);
            this.cb_laps.TabIndex = 3;
            // 
            // l_v
            // 
            this.l_v.AutoSize = true;
            this.l_v.Location = new System.Drawing.Point(9, 168);
            this.l_v.Name = "l_v";
            this.l_v.Size = new System.Drawing.Size(51, 18);
            this.l_v.TabIndex = 4;
            this.l_v.Text = "Vitesse";
            // 
            // l_e
            // 
            this.l_e.AutoSize = true;
            this.l_e.Location = new System.Drawing.Point(9, 211);
            this.l_e.Name = "l_e";
            this.l_e.Size = new System.Drawing.Size(72, 18);
            this.l_e.TabIndex = 5;
            this.l_e.Text = "Endurance";
            // 
            // l_c
            // 
            this.l_c.AutoSize = true;
            this.l_c.Location = new System.Drawing.Point(12, 255);
            this.l_c.Name = "l_c";
            this.l_c.Size = new System.Drawing.Size(52, 18);
            this.l_c.TabIndex = 6;
            this.l_c.Text = "Chance";
            // 
            // l_sur
            // 
            this.l_sur.AutoSize = true;
            this.l_sur.Location = new System.Drawing.Point(12, 136);
            this.l_sur.Name = "l_sur";
            this.l_sur.Size = new System.Drawing.Size(56, 18);
            this.l_sur.TabIndex = 7;
            this.l_sur.Text = "Surnom";
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(97, 51);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(31, 18);
            this.l_age.TabIndex = 8;
            this.l_age.Text = "Age";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(12, 51);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(20, 18);
            this.l_id.TabIndex = 9;
            this.l_id.Text = "id";
            // 
            // tb_sur
            // 
            this.tb_sur.Enabled = false;
            this.tb_sur.Location = new System.Drawing.Point(86, 133);
            this.tb_sur.Name = "tb_sur";
            this.tb_sur.Size = new System.Drawing.Size(192, 25);
            this.tb_sur.TabIndex = 10;
            // 
            // tb_age
            // 
            this.tb_age.Enabled = false;
            this.tb_age.Location = new System.Drawing.Point(134, 48);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(31, 25);
            this.tb_age.TabIndex = 11;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(385, 15);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 12;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(38, 48);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(34, 25);
            this.tb_id.TabIndex = 13;
            // 
            // l_va
            // 
            this.l_va.AutoSize = true;
            this.l_va.Location = new System.Drawing.Point(357, 57);
            this.l_va.Name = "l_va";
            this.l_va.Size = new System.Drawing.Size(54, 18);
            this.l_va.TabIndex = 14;
            this.l_va.Text = "Valeur :";
            // 
            // l_valeur
            // 
            this.l_valeur.AutoSize = true;
            this.l_valeur.Location = new System.Drawing.Point(406, 57);
            this.l_valeur.Name = "l_valeur";
            this.l_valeur.Size = new System.Drawing.Size(0, 18);
            this.l_valeur.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "La Valeur d\'un Lapin dépend avant tout de ses capacités physiques ; \r\nLa Chance, " +
    "L\'Endurance, La Vitesse\r\n\r\n";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_valeur);
            this.Controls.Add(this.l_va);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_sur);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.l_age);
            this.Controls.Add(this.l_sur);
            this.Controls.Add(this.l_c);
            this.Controls.Add(this.l_e);
            this.Controls.Add(this.l_v);
            this.Controls.Add(this.cb_laps);
            this.Controls.Add(this.pb_endurance);
            this.Controls.Add(this.pb_chance);
            this.Controls.Add(this.pb_vitesse);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_vitesse;
        private System.Windows.Forms.ProgressBar pb_chance;
        private System.Windows.Forms.ProgressBar pb_endurance;
        private System.Windows.Forms.ComboBox cb_laps;
        private System.Windows.Forms.Label l_v;
        private System.Windows.Forms.Label l_e;
        private System.Windows.Forms.Label l_c;
        private System.Windows.Forms.Label l_sur;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_sur;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_va;
        private System.Windows.Forms.Label l_valeur;
        private System.Windows.Forms.Label label1;
    }
}