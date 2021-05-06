
namespace WF
{
    partial class F_Edit_Gerant
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_prenom = new System.Windows.Forms.Label();
            this.l_pssword = new System.Windows.Forms.Label();
            this.l_age = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_bud = new System.Windows.Forms.TextBox();
            this.l_bud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(340, 75);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(63, 12);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(113, 25);
            this.tb_nom.TabIndex = 1;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(243, 12);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(110, 25);
            this.tb_prenom.TabIndex = 2;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(19, 19);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(38, 18);
            this.l_nom.TabIndex = 3;
            this.l_nom.Text = "Nom";
            // 
            // l_prenom
            // 
            this.l_prenom.AutoSize = true;
            this.l_prenom.Location = new System.Drawing.Point(182, 19);
            this.l_prenom.Name = "l_prenom";
            this.l_prenom.Size = new System.Drawing.Size(55, 18);
            this.l_prenom.TabIndex = 4;
            this.l_prenom.Text = "Prenom";
            // 
            // l_pssword
            // 
            this.l_pssword.AutoSize = true;
            this.l_pssword.Location = new System.Drawing.Point(237, 47);
            this.l_pssword.Name = "l_pssword";
            this.l_pssword.Size = new System.Drawing.Size(68, 18);
            this.l_pssword.TabIndex = 5;
            this.l_pssword.Text = "Password";
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(70, 47);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(31, 18);
            this.l_age.TabIndex = 6;
            this.l_age.Text = "Age";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(311, 44);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(124, 25);
            this.tb_pwd.TabIndex = 7;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(107, 44);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(124, 25);
            this.tb_age.TabIndex = 8;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(6, 50);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 18);
            this.l_id.TabIndex = 9;
            this.l_id.Text = "ID";
            this.l_id.Visible = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(33, 44);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(35, 25);
            this.tb_id.TabIndex = 10;
            this.tb_id.Visible = false;
            // 
            // tb_bud
            // 
            this.tb_bud.Location = new System.Drawing.Point(86, 74);
            this.tb_bud.Name = "tb_bud";
            this.tb_bud.Size = new System.Drawing.Size(219, 25);
            this.tb_bud.TabIndex = 12;
            // 
            // l_bud
            // 
            this.l_bud.AutoSize = true;
            this.l_bud.Location = new System.Drawing.Point(30, 77);
            this.l_bud.Name = "l_bud";
            this.l_bud.Size = new System.Drawing.Size(50, 18);
            this.l_bud.TabIndex = 11;
            this.l_bud.Text = "Budget";
            // 
            // F_Edit_Gerant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(454, 106);
            this.Controls.Add(this.tb_bud);
            this.Controls.Add(this.l_bud);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.l_age);
            this.Controls.Add(this.l_pssword);
            this.Controls.Add(this.l_prenom);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.btn_valider);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Edit_Gerant";
            this.Text = "F_Edit_Gerant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_prenom;
        private System.Windows.Forms.Label l_pssword;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_bud;
        private System.Windows.Forms.Label l_bud;
    }
}