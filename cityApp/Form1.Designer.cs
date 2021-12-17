
namespace cityApp
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
            this.txtCityResult = new System.Windows.Forms.RichTextBox();
            this.btnCityResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCityResult
            // 
            this.txtCityResult.Location = new System.Drawing.Point(-1, -1);
            this.txtCityResult.Name = "txtCityResult";
            this.txtCityResult.Size = new System.Drawing.Size(416, 452);
            this.txtCityResult.TabIndex = 0;
            this.txtCityResult.Text = "";
            // 
            // btnCityResult
            // 
            this.btnCityResult.Location = new System.Drawing.Point(495, 396);
            this.btnCityResult.Name = "btnCityResult";
            this.btnCityResult.Size = new System.Drawing.Size(94, 29);
            this.btnCityResult.TabIndex = 1;
            this.btnCityResult.Text = "Show cities";
            this.btnCityResult.UseVisualStyleBackColor = true;
            this.btnCityResult.Click += new System.EventHandler(this.btnCityResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCityResult);
            this.Controls.Add(this.txtCityResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCityResult;
        private System.Windows.Forms.Button btnCityResult;
    }
}

