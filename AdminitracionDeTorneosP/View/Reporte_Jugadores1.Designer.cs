﻿
namespace AdminitracionDeTorneosP.View
{
    partial class Reporte_Jugadores1
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
            this.ListadoJugadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(270, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 47);
            this.label5.TabIndex = 36;
            this.label5.Text = "Reporte Jugadores";
            // 
            // ListadoJugadores
            // 
            this.ListadoJugadores.AllowUserToAddRows = false;
            this.ListadoJugadores.AllowUserToDeleteRows = false;
            this.ListadoJugadores.BackgroundColor = System.Drawing.Color.Azure;
            this.ListadoJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoJugadores.GridColor = System.Drawing.Color.Azure;
            this.ListadoJugadores.Location = new System.Drawing.Point(46, 172);
            this.ListadoJugadores.Name = "ListadoJugadores";
            this.ListadoJugadores.ReadOnly = true;
            this.ListadoJugadores.RowHeadersVisible = false;
            this.ListadoJugadores.RowHeadersWidth = 51;
            this.ListadoJugadores.Size = new System.Drawing.Size(656, 210);
            this.ListadoJugadores.TabIndex = 37;
            // 
            // Reporte_Jugadores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadoJugadores);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reporte_Jugadores1";
            this.Text = "Reporte_Jugadores1";
            this.Load += new System.EventHandler(this.Reporte_Jugadores1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListadoJugadores;
    }
}