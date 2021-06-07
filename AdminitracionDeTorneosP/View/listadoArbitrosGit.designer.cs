
namespace AdminitracionDeTorneosP.View
{
    partial class listadoArbitrosGit
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
            this.label5 = new System.Windows.Forms.Label();
            this.listArbitros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(199, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 47);
            this.label5.TabIndex = 35;
            this.label5.Text = "Listado de Árbitros";
            // 
            // listArbitros
            // 
            this.listArbitros.AllowUserToAddRows = false;
            this.listArbitros.AllowUserToDeleteRows = false;
            this.listArbitros.BackgroundColor = System.Drawing.Color.Azure;
            this.listArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listArbitros.GridColor = System.Drawing.Color.Azure;
            this.listArbitros.Location = new System.Drawing.Point(62, 108);
            this.listArbitros.Name = "listArbitros";
            this.listArbitros.ReadOnly = true;
            this.listArbitros.RowHeadersVisible = false;
            this.listArbitros.Size = new System.Drawing.Size(608, 210);
            this.listArbitros.TabIndex = 34;
            // 
            // listadoArbitrosGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(730, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listArbitros);
            this.Name = "listadoArbitrosGit";
            this.Text = "Listado Arbitros";
            ((System.ComponentModel.ISupportInitialize)(this.listArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView listArbitros;
    }
}