﻿namespace Avaluos
{
    partial class Avaluos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avaluos));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelMostrarAvaluos = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvAvaluos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroPanel1.SuspendLayout();
            this.panelMostrarAvaluos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaluos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(159, 408);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton5.BackgroundImage")));
            this.metroButton5.Location = new System.Drawing.Point(3, 350);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(49, 55);
            this.metroButton5.TabIndex = 3;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(0, 219);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(156, 37);
            this.metroButton4.TabIndex = 2;
            this.metroButton4.Text = "Eliminar";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(0, 176);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(159, 37);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Editar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(0, 133);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(159, 37);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Agregar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 90);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(159, 37);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Mostrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panelMostrarAvaluos
            // 
            this.panelMostrarAvaluos.Controls.Add(this.comboBox1);
            this.panelMostrarAvaluos.Controls.Add(this.metroLabel1);
            this.panelMostrarAvaluos.Controls.Add(this.dgvAvaluos);
            this.panelMostrarAvaluos.Location = new System.Drawing.Point(202, 60);
            this.panelMostrarAvaluos.Name = "panelMostrarAvaluos";
            this.panelMostrarAvaluos.Size = new System.Drawing.Size(519, 408);
            this.panelMostrarAvaluos.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Lista de Avaluos";
            // 
            // dgvAvaluos
            // 
            this.dgvAvaluos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaluos.Location = new System.Drawing.Point(3, 52);
            this.dgvAvaluos.Name = "dgvAvaluos";
            this.dgvAvaluos.Size = new System.Drawing.Size(513, 353);
            this.dgvAvaluos.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Avaluos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 488);
            this.Controls.Add(this.panelMostrarAvaluos);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Avaluos";
            this.Text = "Avaluos";
            this.Load += new System.EventHandler(this.Avaluos_Load);
            this.metroPanel1.ResumeLayout(false);
            this.panelMostrarAvaluos.ResumeLayout(false);
            this.panelMostrarAvaluos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaluos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panelMostrarAvaluos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvAvaluos;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}