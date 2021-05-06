
namespace WF
{
    partial class F_lesGerant
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
            this.lb_lesGerants = new System.Windows.Forms.ListBox();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.l_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_lesGerants
            // 
            this.lb_lesGerants.FormattingEnabled = true;
            this.lb_lesGerants.ItemHeight = 18;
            this.lb_lesGerants.Location = new System.Drawing.Point(12, 33);
            this.lb_lesGerants.Name = "lb_lesGerants";
            this.lb_lesGerants.Size = new System.Drawing.Size(319, 274);
            this.lb_lesGerants.TabIndex = 0;
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(276, 313);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(98, 23);
            this.btn_Connexion.TabIndex = 1;
            this.btn_Connexion.Text = "Se Connecter";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(2, 315);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(71, 18);
            this.l_Password.TabIndex = 2;
            this.l_Password.Text = "Password ";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(71, 311);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(148, 25);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(337, 49);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(75, 23);
            this.btn_modif.TabIndex = 4;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(161, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 26);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(358, 78);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 25);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(358, 109);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 28);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "Update";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(242, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 26);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // F_lesGerant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(445, 345);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.lb_lesGerants);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_lesGerant";
            this.Text = "Les Entraîneurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_lesGerants;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_save;
    }
}