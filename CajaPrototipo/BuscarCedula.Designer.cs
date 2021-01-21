
namespace CajaPrototipo
{
    partial class BuscarCedula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCedula));
            this.label1 = new System.Windows.Forms.Label();
            this.tbo_cedula = new System.Windows.Forms.RichTextBox();
            this.button1 = new CajaPrototipo.CustButton();
            this.lbl_comienzo = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_com = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cliente por Cédula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbo_cedula
            // 
            this.tbo_cedula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbo_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbo_cedula.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbo_cedula.Location = new System.Drawing.Point(155, 61);
            this.tbo_cedula.MaxLength = 14;
            this.tbo_cedula.Multiline = false;
            this.tbo_cedula.Name = "tbo_cedula";
            this.tbo_cedula.Size = new System.Drawing.Size(255, 37);
            this.tbo_cedula.TabIndex = 4;
            this.tbo_cedula.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(169, 117);
            this.button1.Name = "button1";
            this.button1.OnHoverBorderColor = System.Drawing.Color.White;
            this.button1.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.Size = new System.Drawing.Size(172, 42);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Buscar";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_comienzo
            // 
            this.lbl_comienzo.AutoSize = true;
            this.lbl_comienzo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comienzo.ForeColor = System.Drawing.Color.Black;
            this.lbl_comienzo.Location = new System.Drawing.Point(226, 314);
            this.lbl_comienzo.Name = "lbl_comienzo";
            this.lbl_comienzo.Size = new System.Drawing.Size(145, 22);
            this.lbl_comienzo.TabIndex = 13;
            this.lbl_comienzo.Text = "Cerrar del día :";
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.Color.Black;
            this.lbl_cerrar.Location = new System.Drawing.Point(226, 350);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(145, 22);
            this.lbl_cerrar.TabIndex = 12;
            this.lbl_cerrar.Text = "Cerrar del día :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cerrar del día :";
            // 
            // tbl_com
            // 
            this.tbl_com.AutoSize = true;
            this.tbl_com.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_com.ForeColor = System.Drawing.Color.Black;
            this.tbl_com.Location = new System.Drawing.Point(42, 314);
            this.tbl_com.Name = "tbl_com";
            this.tbl_com.Size = new System.Drawing.Size(178, 22);
            this.tbl_com.TabIndex = 10;
            this.tbl_com.Text = "Comienzo del día :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbo_cedula);
            this.panel2.Location = new System.Drawing.Point(22, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 196);
            this.panel2.TabIndex = 16;
            // 
            // BuscarCédula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_comienzo);
            this.Controls.Add(this.lbl_cerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbl_com);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarCédula";
            this.Load += new System.EventHandler(this.BuscarCédula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbo_cedula;
        private CustButton button1;
        private System.Windows.Forms.Label lbl_comienzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tbl_com;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_cerrar;
    }
}