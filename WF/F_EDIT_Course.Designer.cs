
namespace WF
{
    partial class F_EDIT_Course
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.l_distance = new System.Windows.Forms.Label();
            this.l_nom = new System.Windows.Forms.Label();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.l_prix = new System.Windows.Forms.Label();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_te = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(211, 107);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(45, 25);
            this.tb_id.TabIndex = 21;
            this.tb_id.Visible = false;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(182, 114);
            this.l_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 18);
            this.l_id.TabIndex = 20;
            this.l_id.Text = "ID";
            this.l_id.Visible = false;
            // 
            // l_distance
            // 
            this.l_distance.AutoSize = true;
            this.l_distance.Location = new System.Drawing.Point(168, 33);
            this.l_distance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_distance.Name = "l_distance";
            this.l_distance.Size = new System.Drawing.Size(59, 18);
            this.l_distance.TabIndex = 15;
            this.l_distance.Text = "Distance";
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(13, 30);
            this.l_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(38, 18);
            this.l_nom.TabIndex = 14;
            this.l_nom.Text = "Nom";
            // 
            // tb_distance
            // 
            this.tb_distance.Location = new System.Drawing.Point(235, 30);
            this.tb_distance.Margin = new System.Windows.Forms.Padding(4);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.Size = new System.Drawing.Size(116, 25);
            this.tb_distance.TabIndex = 13;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(59, 27);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(101, 25);
            this.tb_nom.TabIndex = 12;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(264, 107);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(100, 32);
            this.btn_valider.TabIndex = 11;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // l_prix
            // 
            this.l_prix.AutoSize = true;
            this.l_prix.Location = new System.Drawing.Point(3, 59);
            this.l_prix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_prix.Name = "l_prix";
            this.l_prix.Size = new System.Drawing.Size(133, 18);
            this.l_prix.TabIndex = 23;
            this.l_prix.Text = "Prix Pour le Gagnant";
            // 
            // tb_prix
            // 
            this.tb_prix.Location = new System.Drawing.Point(144, 56);
            this.tb_prix.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(111, 25);
            this.tb_prix.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tarif Entrée";
            // 
            // tb_te
            // 
            this.tb_te.Location = new System.Drawing.Point(88, 107);
            this.tb_te.Margin = new System.Windows.Forms.Padding(4);
            this.tb_te.Name = "tb_te";
            this.tb_te.Size = new System.Drawing.Size(86, 25);
            this.tb_te.TabIndex = 24;
            // 
            // F_EDIT_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(393, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_te);
            this.Controls.Add(this.l_prix);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.l_distance);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.btn_valider);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_EDIT_Course";
            this.Text = "F_EDIT_Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_distance;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.TextBox tb_distance;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label l_prix;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_te;
    }
}