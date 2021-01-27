
namespace passgen
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
            this.intInput = new System.Windows.Forms.ComboBox();
            this.startFunc = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intInput
            // 
            this.intInput.FormattingEnabled = true;
            this.intInput.Location = new System.Drawing.Point(95, 154);
            this.intInput.Name = "intInput";
            this.intInput.Size = new System.Drawing.Size(186, 21);
            this.intInput.TabIndex = 0;
            // 
            // startFunc
            // 
            this.startFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startFunc.Location = new System.Drawing.Point(123, 191);
            this.startFunc.Name = "startFunc";
            this.startFunc.Size = new System.Drawing.Size(126, 36);
            this.startFunc.TabIndex = 1;
            this.startFunc.Text = "Generate";
            this.startFunc.UseVisualStyleBackColor = true;
            this.startFunc.Click += new System.EventHandler(this.startFunc_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(95, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(186, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startFunc);
            this.Controls.Add(this.intInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox intInput;
        private System.Windows.Forms.Button startFunc;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

