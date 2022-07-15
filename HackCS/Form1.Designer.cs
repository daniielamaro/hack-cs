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
            this.SuspendLayout();
            // 
            // cbMunicaoInfinita
            // 
            this.cbMunicaoInfinita.AutoSize = true;
            this.cbMunicaoInfinita.Location = new System.Drawing.Point(34, 26);
            this.cbMunicaoInfinita.Name = "cbMunicaoInfinita";
            this.cbMunicaoInfinita.Size = new System.Drawing.Size(113, 19);
            this.cbMunicaoInfinita.TabIndex = 0;
            this.cbMunicaoInfinita.Text = "Munição infinita";
            this.cbMunicaoInfinita.UseVisualStyleBackColor = true;
            this.cbMunicaoInfinita.CheckedChanged += new System.EventHandler(this.CBMunicaoInfinitaCheckedChanged);
            // 
            // cbVidaInfinita
            // 
            this.cbVidaInfinita.AutoSize = true;
            this.cbVidaInfinita.Location = new System.Drawing.Point(34, 68);
            this.cbVidaInfinita.Name = "cbVidaInfinita";
            this.cbVidaInfinita.Size = new System.Drawing.Size(89, 19);
            this.cbVidaInfinita.TabIndex = 1;
            this.cbVidaInfinita.Text = "Vida infinita";
            this.cbVidaInfinita.UseVisualStyleBackColor = true;
            this.cbVidaInfinita.CheckedChanged += new System.EventHandler(this.CBVidaInfinitaCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 113);
            this.Controls.Add(this.cbVidaInfinita);
            this.Controls.Add(this.cbMunicaoInfinita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbMunicaoInfinita;
        private CheckBox cbVidaInfinita;
    }
}