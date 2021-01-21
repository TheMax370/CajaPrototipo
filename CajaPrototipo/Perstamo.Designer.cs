
namespace CajaPrototipo
{
    partial class Perstamo
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disp_panel = new System.Windows.Forms.Panel();
            this.disp_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pagar prestamo";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(95, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 300);
            this.panel1.TabIndex = 3;
            // 
            // disp_panel
            // 
            this.disp_panel.BackColor = System.Drawing.Color.White;
            this.disp_panel.Controls.Add(this.panel1);
            this.disp_panel.Controls.Add(this.label3);
            this.disp_panel.Location = new System.Drawing.Point(36, 12);
            this.disp_panel.Name = "disp_panel";
            this.disp_panel.Size = new System.Drawing.Size(375, 437);
            this.disp_panel.TabIndex = 11;
            // 
            // Perstamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.disp_panel);
            this.Name = "Perstamo";
            this.Text = "Perstamo";
            this.Load += new System.EventHandler(this.Perstamo_Load);
            this.disp_panel.ResumeLayout(false);
            this.disp_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel disp_panel;
    }
}