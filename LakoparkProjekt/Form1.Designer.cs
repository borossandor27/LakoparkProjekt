namespace LakoparkProjekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Utcakep = new System.Windows.Forms.Panel();
            this.button_Jobbra = new System.Windows.Forms.Button();
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LakoparkProjekt.Properties.Resources.Van_Gogh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Utcakep
            // 
            this.panel_Utcakep.Location = new System.Drawing.Point(204, 39);
            this.panel_Utcakep.Name = "panel_Utcakep";
            this.panel_Utcakep.Size = new System.Drawing.Size(568, 330);
            this.panel_Utcakep.TabIndex = 1;
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackColor = System.Drawing.Color.Transparent;
            this.button_Jobbra.BackgroundImage = global::LakoparkProjekt.Properties.Resources.jobbnyil;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Jobbra.FlatAppearance.BorderSize = 0;
            this.button_Jobbra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Jobbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Jobbra.Location = new System.Drawing.Point(466, 375);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(93, 63);
            this.button_Jobbra.TabIndex = 2;
            this.button_Jobbra.UseVisualStyleBackColor = false;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // button_Balra
            // 
            this.button_Balra.BackColor = System.Drawing.Color.Transparent;
            this.button_Balra.BackgroundImage = global::LakoparkProjekt.Properties.Resources.balnyil;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Balra.FlatAppearance.BorderSize = 0;
            this.button_Balra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Balra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Balra.Location = new System.Drawing.Point(338, 375);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(93, 63);
            this.button_Balra.TabIndex = 2;
            this.button_Balra.UseVisualStyleBackColor = false;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(33, 302);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(140, 39);
            this.button_Mentes.TabIndex = 3;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.panel_Utcakep);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Utcakep;
        private System.Windows.Forms.Button button_Jobbra;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Mentes;
    }
}

