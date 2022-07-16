namespace HackCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMunicaoInfinita = new System.Windows.Forms.CheckBox();
            this.cbVidaInfinita = new System.Windows.Forms.CheckBox();
            this.cbColeteInfinito = new System.Windows.Forms.CheckBox();
            this.cbNoRecoil = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbMunicaoInfinita
            // 
            this.cbMunicaoInfinita.AutoSize = true;
            this.cbMunicaoInfinita.Location = new System.Drawing.Point(39, 35);
            this.cbMunicaoInfinita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMunicaoInfinita.Name = "cbMunicaoInfinita";
            this.cbMunicaoInfinita.Size = new System.Drawing.Size(138, 24);
            this.cbMunicaoInfinita.TabIndex = 0;
            this.cbMunicaoInfinita.Text = "Munição infinita";
            this.cbMunicaoInfinita.UseVisualStyleBackColor = true;
            this.cbMunicaoInfinita.CheckedChanged += new System.EventHandler(this.CBMunicaoInfinitaCheckedChanged);
            // 
            // cbVidaInfinita
            // 
            this.cbVidaInfinita.AutoSize = true;
            this.cbVidaInfinita.Location = new System.Drawing.Point(39, 91);
            this.cbVidaInfinita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVidaInfinita.Name = "cbVidaInfinita";
            this.cbVidaInfinita.Size = new System.Drawing.Size(111, 24);
            this.cbVidaInfinita.TabIndex = 1;
            this.cbVidaInfinita.Text = "Vida infinita";
            this.cbVidaInfinita.UseVisualStyleBackColor = true;
            this.cbVidaInfinita.CheckedChanged += new System.EventHandler(this.CBVidaInfinitaCheckedChanged);
            // 
            // cbColeteInfinito
            // 
            this.cbColeteInfinito.AutoSize = true;
            this.cbColeteInfinito.Location = new System.Drawing.Point(39, 150);
            this.cbColeteInfinito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbColeteInfinito.Name = "cbColeteInfinito";
            this.cbColeteInfinito.Size = new System.Drawing.Size(125, 24);
            this.cbColeteInfinito.TabIndex = 2;
            this.cbColeteInfinito.Text = "Colete Infinito";
            this.cbColeteInfinito.UseVisualStyleBackColor = true;
            this.cbColeteInfinito.CheckedChanged += new System.EventHandler(this.CBVColeteInfinitaCheckedChanged);
            // 
            // cbNoRecoil
            // 
            this.cbNoRecoil.AutoSize = true;
            this.cbNoRecoil.Location = new System.Drawing.Point(39, 215);
            this.cbNoRecoil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNoRecoil.Name = "cbNoRecoil";
            this.cbNoRecoil.Size = new System.Drawing.Size(96, 24);
            this.cbNoRecoil.TabIndex = 3;
            this.cbNoRecoil.Text = "No Recoil";
            this.cbNoRecoil.UseVisualStyleBackColor = true;
            this.cbNoRecoil.CheckedChanged += new System.EventHandler(this.CBVNoRecoilCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 277);
            this.Controls.Add(this.cbNoRecoil);
            this.Controls.Add(this.cbColeteInfinito);
            this.Controls.Add(this.cbVidaInfinita);
            this.Controls.Add(this.cbMunicaoInfinita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbMunicaoInfinita;
        private CheckBox cbVidaInfinita;
        private CheckBox cbColeteInfinito;
        private CheckBox cbNoRecoil;
    }
}