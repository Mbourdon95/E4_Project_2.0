
namespace WF
{
    partial class F_First
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gCourse = new System.Windows.Forms.Button();
            this.btn_gLapins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gCourse
            // 
            this.btn_gCourse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_gCourse.Location = new System.Drawing.Point(12, 31);
            this.btn_gCourse.Name = "btn_gCourse";
            this.btn_gCourse.Size = new System.Drawing.Size(158, 36);
            this.btn_gCourse.TabIndex = 0;
            this.btn_gCourse.Text = "Organisateur de Course";
            this.btn_gCourse.UseVisualStyleBackColor = true;
            // 
            // btn_gLapins
            // 
            this.btn_gLapins.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_gLapins.Location = new System.Drawing.Point(203, 31);
            this.btn_gLapins.Name = "btn_gLapins";
            this.btn_gLapins.Size = new System.Drawing.Size(143, 36);
            this.btn_gLapins.TabIndex = 1;
            this.btn_gLapins.Text = "Entraîneur de Lapin";
            this.btn_gLapins.UseVisualStyleBackColor = true;
            // 
            // F_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(359, 98);
            this.Controls.Add(this.btn_gCourse);
            this.Controls.Add(this.btn_gLapins);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_First";
            this.Text = "F_First_Choix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gCourse;
        private System.Windows.Forms.Button btn_gLapins;
    }
}

