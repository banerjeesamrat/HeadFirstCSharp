namespace HeadFirst6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give 10$ to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive 5$ from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(43, 23);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(65, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe has 50$";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(43, 51);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(73, 13);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has 100$";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(43, 79);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(100, 13);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "The bank has 100$";
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(43, 161);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(75, 40);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(139, 161);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(75, 40);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 213);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

