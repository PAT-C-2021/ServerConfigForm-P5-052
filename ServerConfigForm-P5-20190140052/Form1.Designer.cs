
namespace ServerConfigForm_P5_20190140052
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
            this.buttonOFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.labelket1 = new System.Windows.Forms.Label();
            this.buttonON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(382, 243);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 1;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(283, 216);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(46, 17);
            this.labelOnOff.TabIndex = 3;
            this.labelOnOff.Text = "label1";
            // 
            // labelket1
            // 
            this.labelket1.AutoSize = true;
            this.labelket1.Location = new System.Drawing.Point(283, 178);
            this.labelket1.Name = "labelket1";
            this.labelket1.Size = new System.Drawing.Size(65, 17);
            this.labelket1.TabIndex = 4;
            this.labelket1.Text = "labelket1";
            this.labelket1.Click += new System.EventHandler(this.labelket1_Click);
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(214, 243);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 5;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonON);
            this.Controls.Add(this.labelket1);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOFF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Label labelket1;
        private System.Windows.Forms.Button buttonON;
    }
}

