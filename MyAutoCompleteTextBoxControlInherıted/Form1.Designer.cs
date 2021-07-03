namespace MyAutoCompleteTextBox201913709054_FarukAydogan
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
        protected override void Dispose ( bool disposing )
        {
            if(disposing && (components != null))
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
        private void InitializeComponent ( )
        {
            this.myAutoCompleteTextBox1 = new MyAutoCompleteTextBox201913709054_FarukAydogan.MyAutoCompleteTextBox();
            this.SuspendLayout();
            // 
            // myAutoCompleteTextBox1
            // 
            this.myAutoCompleteTextBox1.Location = new System.Drawing.Point(231, 100);
            this.myAutoCompleteTextBox1.Name = "myAutoCompleteTextBox1";
            this.myAutoCompleteTextBox1.Size = new System.Drawing.Size(180, 20);
            this.myAutoCompleteTextBox1.TabIndex = 0;
            this.myAutoCompleteTextBox1.Text = "myAutoCompleteTextBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myAutoCompleteTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyAutoCompleteTextBox myAutoCompleteTextBox1;
    }
}