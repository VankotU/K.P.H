namespace KontroliFormi
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnBacks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl21 = new KontroliFormi.UserControl2();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kum k2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBacks
            // 
            this.btnBacks.Location = new System.Drawing.Point(160, 184);
            this.btnBacks.Name = "btnBacks";
            this.btnBacks.Size = new System.Drawing.Size(75, 23);
            this.btnBacks.TabIndex = 1;
            this.btnBacks.Text = "back";
            this.btnBacks.UseVisualStyleBackColor = true;
            this.btnBacks.Click += new System.EventHandler(this.btnBacks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kontrola 1";
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(3, 3);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(257, 266);
            this.userControl21.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl21);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(263, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBacks;
        private System.Windows.Forms.Label label1;
        private UserControl2 userControl21;
    }
}
