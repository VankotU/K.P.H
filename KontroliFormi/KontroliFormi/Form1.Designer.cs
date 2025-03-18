namespace KontroliFormi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nachaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrola1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrola2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnectionF = new System.Windows.Forms.Button();
            this.btnConnectionK = new System.Windows.Forms.Button();
            this.lblPanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl11 = new KontroliFormi.UserControl1();
            this.userControl21 = new KontroliFormi.UserControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachaloToolStripMenuItem,
            this.forma1ToolStripMenuItem,
            this.kontrola1ToolStripMenuItem,
            this.kontrola2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nachaloToolStripMenuItem
            // 
            this.nachaloToolStripMenuItem.Name = "nachaloToolStripMenuItem";
            this.nachaloToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nachaloToolStripMenuItem.Text = "Nachalo";
            // 
            // forma1ToolStripMenuItem
            // 
            this.forma1ToolStripMenuItem.Name = "forma1ToolStripMenuItem";
            this.forma1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.forma1ToolStripMenuItem.Text = "Forma 1";
            this.forma1ToolStripMenuItem.Click += new System.EventHandler(this.forma1ToolStripMenuItem_Click);
            // 
            // kontrola1ToolStripMenuItem
            // 
            this.kontrola1ToolStripMenuItem.Name = "kontrola1ToolStripMenuItem";
            this.kontrola1ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.kontrola1ToolStripMenuItem.Text = "Kontrola 1";
            this.kontrola1ToolStripMenuItem.Click += new System.EventHandler(this.kontrola1ToolStripMenuItem_Click);
            // 
            // kontrola2ToolStripMenuItem
            // 
            this.kontrola2ToolStripMenuItem.Name = "kontrola2ToolStripMenuItem";
            this.kontrola2ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.kontrola2ToolStripMenuItem.Text = "Kontrola 2";
            this.kontrola2ToolStripMenuItem.Click += new System.EventHandler(this.kontrola2ToolStripMenuItem_Click);
            // 
            // btnConnectionF
            // 
            this.btnConnectionF.Location = new System.Drawing.Point(12, 61);
            this.btnConnectionF.Name = "btnConnectionF";
            this.btnConnectionF.Size = new System.Drawing.Size(75, 23);
            this.btnConnectionF.TabIndex = 1;
            this.btnConnectionF.Text = "vruzka s f";
            this.btnConnectionF.UseVisualStyleBackColor = true;
            this.btnConnectionF.Click += new System.EventHandler(this.btnConnectionF_Click);
            // 
            // btnConnectionK
            // 
            this.btnConnectionK.Location = new System.Drawing.Point(12, 108);
            this.btnConnectionK.Name = "btnConnectionK";
            this.btnConnectionK.Size = new System.Drawing.Size(75, 23);
            this.btnConnectionK.TabIndex = 2;
            this.btnConnectionK.Text = "vruzka s k";
            this.btnConnectionK.UseVisualStyleBackColor = true;
            this.btnConnectionK.Click += new System.EventHandler(this.btnConnectionK_Click);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Location = new System.Drawing.Point(164, 162);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(34, 13);
            this.lblPanel.TabIndex = 3;
            this.lblPanel.Text = "Panel";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 133);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Controls.Add(this.userControl21);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(373, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 212);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(339, 209);
            this.userControl11.TabIndex = 7;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(3, 218);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(339, 209);
            this.userControl21.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flow layout panel";
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(12, 178);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(75, 23);
            this.btnEntrance.TabIndex = 7;
            this.btnEntrance.Text = "Vhod";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 332);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.btnConnectionK);
            this.Controls.Add(this.btnConnectionF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nachaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrola1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrola2ToolStripMenuItem;
        private System.Windows.Forms.Button btnConnectionF;
        private System.Windows.Forms.Button btnConnectionK;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

