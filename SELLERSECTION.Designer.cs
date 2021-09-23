namespace InventoryManagementSystemProject
{
    partial class SELLERSECTION
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.AdProMangebutton = new System.Windows.Forms.Button();
            this.SellerHomebutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(580, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 33);
            this.label3.TabIndex = 51;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seller Section";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.exitLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 100);
            this.panel2.TabIndex = 5;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1154, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(29, 29);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            // 
            // AdProMangebutton
            // 
            this.AdProMangebutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdProMangebutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AdProMangebutton.Location = new System.Drawing.Point(181, 245);
            this.AdProMangebutton.Name = "AdProMangebutton";
            this.AdProMangebutton.Size = new System.Drawing.Size(268, 43);
            this.AdProMangebutton.TabIndex = 50;
            this.AdProMangebutton.Text = "Orders Section";
            this.AdProMangebutton.UseVisualStyleBackColor = true;
            this.AdProMangebutton.Click += new System.EventHandler(this.AdProMangebutton_Click);
            // 
            // SellerHomebutton
            // 
            this.SellerHomebutton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerHomebutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SellerHomebutton.Location = new System.Drawing.Point(263, 294);
            this.SellerHomebutton.Name = "SellerHomebutton";
            this.SellerHomebutton.Size = new System.Drawing.Size(106, 30);
            this.SellerHomebutton.TabIndex = 52;
            this.SellerHomebutton.Text = "Home";
            this.SellerHomebutton.UseVisualStyleBackColor = true;
            this.SellerHomebutton.Click += new System.EventHandler(this.SellerHomebutton_Click);
            // 
            // SELLERSECTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 506);
            this.Controls.Add(this.SellerHomebutton);
            this.Controls.Add(this.AdProMangebutton);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SELLERSECTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELLERSECTION";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button AdProMangebutton;
        private System.Windows.Forms.Button SellerHomebutton;
    }
}