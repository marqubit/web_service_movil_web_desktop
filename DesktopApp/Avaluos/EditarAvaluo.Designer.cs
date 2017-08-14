namespace Avaluos
{
    partial class EditarAvaluo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAvaluo));
            this.panelAddAvaluos = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbAvaluoEd = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtFechaEd = new MetroFramework.Controls.MetroDateTime();
            this.txtTotalAvaluoEd = new MetroFramework.Controls.MetroTextBox();
            this.txtSubAvaluoEd = new MetroFramework.Controls.MetroTextBox();
            this.txtctoAvaluoEd = new MetroFramework.Controls.MetroTextBox();
            this.txtPagoCatastroEd = new MetroFramework.Controls.MetroTextBox();
            this.cbTipoAvaluoEd = new MetroFramework.Controls.MetroComboBox();
            this.cbClienteEd = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Subtotal = new MetroFramework.Controls.MetroLabel();
            this.cto_Avaluo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.panelAddAvaluos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddAvaluos
            // 
            this.panelAddAvaluos.Controls.Add(this.metroLabel2);
            this.panelAddAvaluos.Controls.Add(this.cbAvaluoEd);
            this.panelAddAvaluos.Controls.Add(this.metroLabel1);
            this.panelAddAvaluos.Controls.Add(this.dtFechaEd);
            this.panelAddAvaluos.Controls.Add(this.txtTotalAvaluoEd);
            this.panelAddAvaluos.Controls.Add(this.txtSubAvaluoEd);
            this.panelAddAvaluos.Controls.Add(this.txtctoAvaluoEd);
            this.panelAddAvaluos.Controls.Add(this.txtPagoCatastroEd);
            this.panelAddAvaluos.Controls.Add(this.cbTipoAvaluoEd);
            this.panelAddAvaluos.Controls.Add(this.cbClienteEd);
            this.panelAddAvaluos.Controls.Add(this.metroLabel9);
            this.panelAddAvaluos.Controls.Add(this.metroLabel8);
            this.panelAddAvaluos.Controls.Add(this.Subtotal);
            this.panelAddAvaluos.Controls.Add(this.cto_Avaluo);
            this.panelAddAvaluos.Controls.Add(this.metroLabel5);
            this.panelAddAvaluos.Controls.Add(this.metroLabel4);
            this.panelAddAvaluos.Controls.Add(this.metroLabel3);
            this.panelAddAvaluos.Controls.Add(this.metroButton6);
            this.panelAddAvaluos.Location = new System.Drawing.Point(36, 53);
            this.panelAddAvaluos.Name = "panelAddAvaluos";
            this.panelAddAvaluos.Size = new System.Drawing.Size(650, 376);
            this.panelAddAvaluos.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(443, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(173, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "selecciona el avaluo a editar";
            // 
            // cbAvaluoEd
            // 
            this.cbAvaluoEd.FormattingEnabled = true;
            this.cbAvaluoEd.ItemHeight = 23;
            this.cbAvaluoEd.Location = new System.Drawing.Point(134, 28);
            this.cbAvaluoEd.Name = "cbAvaluoEd";
            this.cbAvaluoEd.Size = new System.Drawing.Size(303, 29);
            this.cbAvaluoEd.TabIndex = 8;
            this.cbAvaluoEd.UseSelectable = true;
            this.cbAvaluoEd.SelectedIndexChanged += new System.EventHandler(this.cbAvaluo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Avaluo a Editar ";
            // 
            // dtFechaEd
            // 
            this.dtFechaEd.Location = new System.Drawing.Point(134, 180);
            this.dtFechaEd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaEd.Name = "dtFechaEd";
            this.dtFechaEd.Size = new System.Drawing.Size(382, 29);
            this.dtFechaEd.TabIndex = 6;
            this.dtFechaEd.ValueChanged += new System.EventHandler(this.dtFechaEd_ValueChanged);
            // 
            // txtTotalAvaluoEd
            // 
            this.txtTotalAvaluoEd.Lines = new string[0];
            this.txtTotalAvaluoEd.Location = new System.Drawing.Point(134, 306);
            this.txtTotalAvaluoEd.MaxLength = 32767;
            this.txtTotalAvaluoEd.Name = "txtTotalAvaluoEd";
            this.txtTotalAvaluoEd.PasswordChar = '\0';
            this.txtTotalAvaluoEd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAvaluoEd.SelectedText = "";
            this.txtTotalAvaluoEd.Size = new System.Drawing.Size(142, 23);
            this.txtTotalAvaluoEd.TabIndex = 5;
            this.txtTotalAvaluoEd.UseSelectable = true;
            // 
            // txtSubAvaluoEd
            // 
            this.txtSubAvaluoEd.Lines = new string[0];
            this.txtSubAvaluoEd.Location = new System.Drawing.Point(134, 262);
            this.txtSubAvaluoEd.MaxLength = 32767;
            this.txtSubAvaluoEd.Name = "txtSubAvaluoEd";
            this.txtSubAvaluoEd.PasswordChar = '\0';
            this.txtSubAvaluoEd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubAvaluoEd.SelectedText = "";
            this.txtSubAvaluoEd.Size = new System.Drawing.Size(142, 23);
            this.txtSubAvaluoEd.TabIndex = 5;
            this.txtSubAvaluoEd.UseSelectable = true;
            // 
            // txtctoAvaluoEd
            // 
            this.txtctoAvaluoEd.Lines = new string[0];
            this.txtctoAvaluoEd.Location = new System.Drawing.Point(134, 223);
            this.txtctoAvaluoEd.MaxLength = 32767;
            this.txtctoAvaluoEd.Name = "txtctoAvaluoEd";
            this.txtctoAvaluoEd.PasswordChar = '\0';
            this.txtctoAvaluoEd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtctoAvaluoEd.SelectedText = "";
            this.txtctoAvaluoEd.Size = new System.Drawing.Size(142, 23);
            this.txtctoAvaluoEd.TabIndex = 5;
            this.txtctoAvaluoEd.UseSelectable = true;
            // 
            // txtPagoCatastroEd
            // 
            this.txtPagoCatastroEd.Lines = new string[0];
            this.txtPagoCatastroEd.Location = new System.Drawing.Point(134, 138);
            this.txtPagoCatastroEd.MaxLength = 32767;
            this.txtPagoCatastroEd.Name = "txtPagoCatastroEd";
            this.txtPagoCatastroEd.PasswordChar = '\0';
            this.txtPagoCatastroEd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPagoCatastroEd.SelectedText = "";
            this.txtPagoCatastroEd.Size = new System.Drawing.Size(142, 23);
            this.txtPagoCatastroEd.TabIndex = 5;
            this.txtPagoCatastroEd.UseSelectable = true;
            // 
            // cbTipoAvaluoEd
            // 
            this.cbTipoAvaluoEd.FormattingEnabled = true;
            this.cbTipoAvaluoEd.ItemHeight = 23;
            this.cbTipoAvaluoEd.Items.AddRange(new object[] {
            "Catastral",
            "Infonavit",
            "Traspaso de Propiedad",
            "Comercial"});
            this.cbTipoAvaluoEd.Location = new System.Drawing.Point(134, 103);
            this.cbTipoAvaluoEd.Name = "cbTipoAvaluoEd";
            this.cbTipoAvaluoEd.Size = new System.Drawing.Size(303, 29);
            this.cbTipoAvaluoEd.TabIndex = 4;
            this.cbTipoAvaluoEd.UseSelectable = true;
            // 
            // cbClienteEd
            // 
            this.cbClienteEd.FormattingEnabled = true;
            this.cbClienteEd.ItemHeight = 23;
            this.cbClienteEd.Location = new System.Drawing.Point(134, 60);
            this.cbClienteEd.Name = "cbClienteEd";
            this.cbClienteEd.Size = new System.Drawing.Size(303, 29);
            this.cbClienteEd.TabIndex = 3;
            this.cbClienteEd.UseSelectable = true;
            this.cbClienteEd.SelectedIndexChanged += new System.EventHandler(this.cbClienteEd_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(29, 70);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Cliente";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(29, 306);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(36, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Total";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(29, 266);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(57, 19);
            this.Subtotal.TabIndex = 2;
            this.Subtotal.Text = "Subtotal";
            // 
            // cto_Avaluo
            // 
            this.cto_Avaluo.AutoSize = true;
            this.cto_Avaluo.Location = new System.Drawing.Point(29, 223);
            this.cto_Avaluo.Name = "cto_Avaluo";
            this.cto_Avaluo.Size = new System.Drawing.Size(73, 19);
            this.cto_Avaluo.TabIndex = 2;
            this.cto_Avaluo.Text = "cto_Avaluo";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(29, 180);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Fecha";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Pago a Catastro";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tipo de Avaluo";
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton6.BackgroundImage")));
            this.metroButton6.Location = new System.Drawing.Point(547, 316);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(49, 47);
            this.metroButton6.TabIndex = 0;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // EditarAvaluo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 488);
            this.Controls.Add(this.panelAddAvaluos);
            this.Name = "EditarAvaluo";
            this.Text = "EditarAvaluo";
            this.Load += new System.EventHandler(this.EditarAvaluo_Load);
            this.panelAddAvaluos.ResumeLayout(false);
            this.panelAddAvaluos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddAvaluos;
        private MetroFramework.Controls.MetroDateTime dtFechaEd;
        private MetroFramework.Controls.MetroTextBox txtTotalAvaluoEd;
        private MetroFramework.Controls.MetroTextBox txtSubAvaluoEd;
        private MetroFramework.Controls.MetroTextBox txtctoAvaluoEd;
        private MetroFramework.Controls.MetroTextBox txtPagoCatastroEd;
        private MetroFramework.Controls.MetroComboBox cbTipoAvaluoEd;
        private MetroFramework.Controls.MetroComboBox cbClienteEd;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel Subtotal;
        private MetroFramework.Controls.MetroLabel cto_Avaluo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroComboBox cbAvaluoEd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}