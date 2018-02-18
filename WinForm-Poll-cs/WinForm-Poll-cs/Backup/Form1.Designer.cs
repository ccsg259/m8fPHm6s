namespace WinForm_Poll_cs
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
            this.radMcCain = new System.Windows.Forms.RadioButton();
            this.radObama = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butResults = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMcCain
            // 
            this.radMcCain.AutoSize = true;
            this.radMcCain.Location = new System.Drawing.Point(31, 42);
            this.radMcCain.Name = "radMcCain";
            this.radMcCain.Size = new System.Drawing.Size(61, 17);
            this.radMcCain.TabIndex = 0;
            this.radMcCain.TabStop = true;
            this.radMcCain.Text = "McCain";
            this.radMcCain.UseVisualStyleBackColor = true;
            // 
            // radObama
            // 
            this.radObama.AutoSize = true;
            this.radObama.Location = new System.Drawing.Point(31, 65);
            this.radObama.Name = "radObama";
            this.radObama.Size = new System.Drawing.Size(59, 17);
            this.radObama.TabIndex = 1;
            this.radObama.TabStop = true;
            this.radObama.Text = "Obama";
            this.radObama.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radObama);
            this.groupBox1.Controls.Add(this.radMcCain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vote";
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(119, 71);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(75, 23);
            this.butSubmit.TabIndex = 3;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who is your favorite Candidate?";
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(12, 144);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(200, 80);
            this.lblResults.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "For more .NET Tutorials, please visit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "www.dotnettutorials.com";
            // 
            // butResults
            // 
            this.butResults.Location = new System.Drawing.Point(12, 118);
            this.butResults.Name = "butResults";
            this.butResults.Size = new System.Drawing.Size(90, 23);
            this.butResults.TabIndex = 6;
            this.butResults.Text = "Show Results";
            this.butResults.UseVisualStyleBackColor = true;
            this.butResults.Click += new System.EventHandler(this.butResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 264);
            this.Controls.Add(this.butResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Polling System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMcCain;
        private System.Windows.Forms.RadioButton radObama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butResults;
        private System.Windows.Forms.Button butSubmit;
    }
}

