﻿namespace Sistema_Condominio.View
{
    partial class MoradorLista
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
            this.dataGridListaMorador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaMorador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListaMorador
            // 
            this.dataGridListaMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaMorador.Location = new System.Drawing.Point(12, 24);
            this.dataGridListaMorador.Name = "dataGridListaMorador";
            this.dataGridListaMorador.Size = new System.Drawing.Size(838, 189);
            this.dataGridListaMorador.TabIndex = 0;
            this.dataGridListaMorador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MoradorLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 261);
            this.Controls.Add(this.dataGridListaMorador);
            this.Name = "MoradorLista";
            this.Text = "MoradorLista";
            this.Load += new System.EventHandler(this.MoradorLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaMorador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListaMorador;
    }
}