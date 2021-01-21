
namespace CajaPrototipo
{
    partial class EmployeeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMain));
            this.disp_panel = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.plazaTransBtn = new CajaPrototipo.CustButton();
            this.prestamoBtn = new CajaPrototipo.CustButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientReport = new CajaPrototipo.CustButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // disp_panel
            // 
            this.disp_panel.Location = new System.Drawing.Point(322, 82);
            this.disp_panel.Name = "disp_panel";
            this.disp_panel.Size = new System.Drawing.Size(632, 404);
            this.disp_panel.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(43, 22);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(454, 33);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Bienvenido First Name Last Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 96);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // plazaTransBtn
            // 
            this.plazaTransBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plazaTransBtn.BackColor = System.Drawing.Color.Transparent;
            this.plazaTransBtn.BorderColor = System.Drawing.Color.White;
            this.plazaTransBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.plazaTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plazaTransBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plazaTransBtn.ForeColor = System.Drawing.Color.Black;
            this.plazaTransBtn.Location = new System.Drawing.Point(35, 174);
            this.plazaTransBtn.Margin = new System.Windows.Forms.Padding(0);
            this.plazaTransBtn.Name = "plazaTransBtn";
            this.plazaTransBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.plazaTransBtn.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.plazaTransBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.plazaTransBtn.Size = new System.Drawing.Size(232, 49);
            this.plazaTransBtn.TabIndex = 9;
            this.plazaTransBtn.Text = " Historial de transacciones";
            this.plazaTransBtn.TextColor = System.Drawing.Color.White;
            this.plazaTransBtn.UseVisualStyleBackColor = false;
            this.plazaTransBtn.Click += new System.EventHandler(this.plazaTransBtn_Click);
            // 
            // prestamoBtn
            // 
            this.prestamoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prestamoBtn.BackColor = System.Drawing.Color.Transparent;
            this.prestamoBtn.BorderColor = System.Drawing.Color.White;
            this.prestamoBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.prestamoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prestamoBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestamoBtn.ForeColor = System.Drawing.Color.Black;
            this.prestamoBtn.Location = new System.Drawing.Point(35, 112);
            this.prestamoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.prestamoBtn.Name = "prestamoBtn";
            this.prestamoBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.prestamoBtn.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.prestamoBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.prestamoBtn.Size = new System.Drawing.Size(232, 45);
            this.prestamoBtn.TabIndex = 6;
            this.prestamoBtn.Text = "Buscar cedula";
            this.prestamoBtn.TextColor = System.Drawing.Color.White;
            this.prestamoBtn.UseVisualStyleBackColor = false;
            this.prestamoBtn.Click += new System.EventHandler(this.prestamoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ClientReport);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.plazaTransBtn);
            this.panel1.Controls.Add(this.prestamoBtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 499);
            this.panel1.TabIndex = 7;
            // 
            // ClientReport
            // 
            this.ClientReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientReport.BackColor = System.Drawing.Color.Transparent;
            this.ClientReport.BorderColor = System.Drawing.Color.White;
            this.ClientReport.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientReport.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientReport.ForeColor = System.Drawing.Color.Black;
            this.ClientReport.Location = new System.Drawing.Point(35, 236);
            this.ClientReport.Margin = new System.Windows.Forms.Padding(0);
            this.ClientReport.Name = "ClientReport";
            this.ClientReport.OnHoverBorderColor = System.Drawing.Color.White;
            this.ClientReport.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.ClientReport.OnHoverTextColor = System.Drawing.Color.White;
            this.ClientReport.Size = new System.Drawing.Size(232, 49);
            this.ClientReport.TabIndex = 13;
            this.ClientReport.Text = "Reporte de Clientes";
            this.ClientReport.TextColor = System.Drawing.Color.White;
            this.ClientReport.UseVisualStyleBackColor = false;
            this.ClientReport.Click += new System.EventHandler(this.ClientReport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Location = new System.Drawing.Point(304, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 75);
            this.panel2.TabIndex = 8;
            // 
            // EmployeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 498);
            this.Controls.Add(this.disp_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EmployeeMain";
            this.Load += new System.EventHandler(this.EmployeeMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel disp_panel;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustButton plazaTransBtn;
        private CustButton prestamoBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustButton ClientReport;
    }
}