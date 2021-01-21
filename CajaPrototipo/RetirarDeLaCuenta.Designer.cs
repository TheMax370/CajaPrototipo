
namespace CajaPrototipo
{
    partial class RetirarDeLaCuenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbo_usuario = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbo_monto = new System.Windows.Forms.RichTextBox();
            this.disp_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.retirarBtn = new CajaPrototipo.CustButton();
            this.disp_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de cuenta :";
            // 
            // tbo_usuario
            // 
            this.tbo_usuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbo_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbo_usuario.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbo_usuario.Location = new System.Drawing.Point(287, 127);
            this.tbo_usuario.MaxLength = 14;
            this.tbo_usuario.Multiline = false;
            this.tbo_usuario.Name = "tbo_usuario";
            this.tbo_usuario.Size = new System.Drawing.Size(255, 37);
            this.tbo_usuario.TabIndex = 6;
            this.tbo_usuario.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monto                      :";
            // 
            // tbo_monto
            // 
            this.tbo_monto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbo_monto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbo_monto.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbo_monto.Location = new System.Drawing.Point(287, 186);
            this.tbo_monto.MaxLength = 14;
            this.tbo_monto.Multiline = false;
            this.tbo_monto.Name = "tbo_monto";
            this.tbo_monto.Size = new System.Drawing.Size(255, 37);
            this.tbo_monto.TabIndex = 3;
            this.tbo_monto.Text = "";
            // 
            // disp_panel
            // 
            this.disp_panel.BackColor = System.Drawing.Color.White;
            this.disp_panel.Controls.Add(this.tbo_monto);
            this.disp_panel.Controls.Add(this.tbo_usuario);
            this.disp_panel.Controls.Add(this.panel3);
            this.disp_panel.Controls.Add(this.panel1);
            this.disp_panel.Controls.Add(this.label4);
            this.disp_panel.Controls.Add(this.retirarBtn);
            this.disp_panel.Location = new System.Drawing.Point(62, 12);
            this.disp_panel.Name = "disp_panel";
            this.disp_panel.Size = new System.Drawing.Size(583, 382);
            this.disp_panel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(33, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 37);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 37);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retirar de la cuenta";
            // 
            // retirarBtn
            // 
            this.retirarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retirarBtn.BackColor = System.Drawing.Color.Transparent;
            this.retirarBtn.BorderColor = System.Drawing.Color.White;
            this.retirarBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.retirarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirarBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirarBtn.ForeColor = System.Drawing.Color.White;
            this.retirarBtn.Location = new System.Drawing.Point(211, 258);
            this.retirarBtn.Name = "retirarBtn";
            this.retirarBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.retirarBtn.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.retirarBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.retirarBtn.Size = new System.Drawing.Size(172, 40);
            this.retirarBtn.TabIndex = 0;
            this.retirarBtn.TabStop = false;
            this.retirarBtn.Text = "Retirar";
            this.retirarBtn.TextColor = System.Drawing.Color.White;
            this.retirarBtn.UseVisualStyleBackColor = false;
            this.retirarBtn.Click += new System.EventHandler(this.retirarBtn_Click);
            // 
            // RetirarDeLaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disp_panel);
            this.Name = "RetirarDeLaCuenta";
            this.Text = "RetirarDeLaCuenta";
            this.Load += new System.EventHandler(this.RetirarDeLaCuenta_Load);
            this.disp_panel.ResumeLayout(false);
            this.disp_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbo_monto;
        private CustButton retirarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbo_usuario;
        public System.Windows.Forms.Panel disp_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}