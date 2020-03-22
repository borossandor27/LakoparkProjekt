namespace LakoparkProjekt
{
    partial class Form_Statisztika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Statisztika));
            this.textBox_Stat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Stat
            // 
            this.textBox_Stat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Stat.Location = new System.Drawing.Point(0, 0);
            this.textBox_Stat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Stat.Multiline = true;
            this.textBox_Stat.Name = "textBox_Stat";
            this.textBox_Stat.Size = new System.Drawing.Size(769, 363);
            this.textBox_Stat.TabIndex = 0;
            // 
            // Form_Statisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 363);
            this.Controls.Add(this.textBox_Stat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Statisztika";
            this.Text = "Statisztika adatok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Statisztika_FormClosing);
            this.Load += new System.EventHandler(this.Form_Statisztika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Stat;
    }
}