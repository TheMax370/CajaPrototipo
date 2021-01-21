
namespace CajaPrototipo
{
    partial class CustomRetrio
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
            this.disp_panel = new System.Windows.Forms.Panel();
            this.tbo_monto = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.retiroBtn = new CajaPrototipo.CustButton();
            this.disp_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // disp_panel
            // 
            this.disp_panel.BackColor = System.Drawing.Color.White;
            this.disp_panel.Controls.Add(this.tbo_monto);
            this.disp_panel.Controls.Add(this.panel2);
            this.disp_panel.Controls.Add(this.label5);
            this.disp_panel.Controls.Add(this.retiroBtn);
            this.disp_panel.Location = new System.Drawing.Point(1, 1);
            this.disp_panel.Name = "disp_panel";
            this.disp_panel.Size = new System.Drawing.Size(440, 304);
            this.disp_panel.TabIndex = 15;
            // 
            // tbo_monto
            // 
            this.tbo_monto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbo_monto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbo_monto.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbo_monto.Location = new System.Drawing.Point(138, 129);
            this.tbo_monto.MaxLength = 14;
            this.tbo_monto.Multiline = false;
            this.tbo_monto.Name = "tbo_monto";
            this.tbo_monto.Size = new System.Drawing.Size(255, 37);
            this.tbo_monto.TabIndex = 3;
            this.tbo_monto.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(41, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 37);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retiro de efectivo";
            // 
            // retiroBtn
            // 
            this.retiroBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retiroBtn.BackColor = System.Drawing.Color.Transparent;
            this.retiroBtn.BorderColor = System.Drawing.Color.White;
            this.retiroBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.retiroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retiroBtn.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retiroBtn.ForeColor = System.Drawing.Color.White;
            this.retiroBtn.Location = new System.Drawing.Point(126, 207);
            this.retiroBtn.Name = "retiroBtn";
            this.retiroBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.retiroBtn.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.retiroBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.retiroBtn.Size = new System.Drawing.Size(172, 40);
            this.retiroBtn.TabIndex = 0;
            this.retiroBtn.TabStop = false;
            this.retiroBtn.Text = "Retiro";
            this.retiroBtn.TextColor = System.Drawing.Color.White;
            this.retiroBtn.UseVisualStyleBackColor = false;
            this.retiroBtn.Click += new System.EventHandler(this.retiroBtn_Click);
            // 
            // CustomRetrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 308);
            this.Controls.Add(this.disp_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomRetrio";
            this.Text = "CustomRetrio";
            this.disp_panel.ResumeLayout(false);
            this.disp_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel disp_panel;
        private System.Windows.Forms.RichTextBox tbo_monto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustButton retiroBtn;
    }
}