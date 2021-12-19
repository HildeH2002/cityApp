
using System;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinPopulation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVisitCity = new System.Windows.Forms.TextBox();
            this.btnSaveCity = new System.Windows.Forms.Button();
            this.btnShowSavedCities = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtraInfo = new System.Windows.Forms.RichTextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCityToRemove = new System.Windows.Forms.TextBox();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCityResult
            // 
            this.txtCityResult.Location = new System.Drawing.Point(-1, -1);
            this.txtCityResult.Name = "txtCityResult";
            this.txtCityResult.Size = new System.Drawing.Size(416, 485);
            this.txtCityResult.TabIndex = 0;
            this.txtCityResult.Text = "";
            // 
            // btnCityResult
            // 
            this.btnCityResult.Location = new System.Drawing.Point(435, 109);
            this.btnCityResult.Name = "btnCityResult";
            this.btnCityResult.Size = new System.Drawing.Size(155, 29);
            this.btnCityResult.TabIndex = 1;
            this.btnCityResult.Text = "Show cities";
            this.btnCityResult.UseVisualStyleBackColor = true;
            this.btnCityResult.Click += new System.EventHandler(this.btnCityResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(435, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum population:";
            // 
            // txtMinPopulation
            // 
            this.txtMinPopulation.Location = new System.Drawing.Point(435, 24);
            this.txtMinPopulation.Name = "txtMinPopulation";
            this.txtMinPopulation.Size = new System.Drawing.Size(152, 27);
            this.txtMinPopulation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(438, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name prefix:";
            // 
            // txtNamePrefix
            // 
            this.txtNamePrefix.Location = new System.Drawing.Point(435, 76);
            this.txtNamePrefix.Name = "txtNamePrefix";
            this.txtNamePrefix.Size = new System.Drawing.Size(155, 27);
            this.txtNamePrefix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "City to visit:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtVisitCity
            // 
            this.txtVisitCity.Location = new System.Drawing.Point(435, 181);
            this.txtVisitCity.Name = "txtVisitCity";
            this.txtVisitCity.Size = new System.Drawing.Size(155, 27);
            this.txtVisitCity.TabIndex = 7;
            // 
            // btnSaveCity
            // 
            this.btnSaveCity.Location = new System.Drawing.Point(435, 311);
            this.btnSaveCity.Name = "btnSaveCity";
            this.btnSaveCity.Size = new System.Drawing.Size(155, 29);
            this.btnSaveCity.TabIndex = 8;
            this.btnSaveCity.Text = "Save city";
            this.btnSaveCity.UseVisualStyleBackColor = true;
            this.btnSaveCity.Click += new System.EventHandler(this.btnSaveCity_Click);
            // 
            // btnShowSavedCities
            // 
            this.btnShowSavedCities.Location = new System.Drawing.Point(435, 346);
            this.btnShowSavedCities.Name = "btnShowSavedCities";
            this.btnShowSavedCities.Size = new System.Drawing.Size(155, 29);
            this.btnShowSavedCities.TabIndex = 9;
            this.btnShowSavedCities.Text = "Show saved cities";
            this.btnShowSavedCities.UseVisualStyleBackColor = true;
            this.btnShowSavedCities.Click += new System.EventHandler(this.btnShowSavedCities_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(414, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 11);
            this.progressBar1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Extra information:";
            // 
            // txtExtraInfo
            // 
            this.txtExtraInfo.Location = new System.Drawing.Point(435, 235);
            this.txtExtraInfo.Name = "txtExtraInfo";
            this.txtExtraInfo.Size = new System.Drawing.Size(152, 70);
            this.txtExtraInfo.TabIndex = 12;
            this.txtExtraInfo.Text = "";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar2.Location = new System.Drawing.Point(414, 381);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(188, 10);
            this.progressBar2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "City name:";
            // 
            // txtCityToRemove
            // 
            this.txtCityToRemove.Location = new System.Drawing.Point(435, 417);
            this.txtCityToRemove.Name = "txtCityToRemove";
            this.txtCityToRemove.Size = new System.Drawing.Size(155, 27);
            this.txtCityToRemove.TabIndex = 15;
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Location = new System.Drawing.Point(435, 450);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(155, 29);
            this.btnRemoveCity.TabIndex = 16;
            this.btnRemoveCity.Text = "Remove City";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 485);
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.txtCityToRemove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.txtExtraInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowSavedCities);
            this.Controls.Add(this.btnSaveCity);
            this.Controls.Add(this.txtVisitCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamePrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinPopulation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCityResult);
            this.Controls.Add(this.txtCityResult);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "City app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCityResult;
        private System.Windows.Forms.Button btnCityResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinPopulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVisitCity;
        private System.Windows.Forms.Button btnSaveCity;
        private System.Windows.Forms.Button btnShowSavedCities;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtExtraInfo;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCityToRemove;
        private System.Windows.Forms.Button btnRemoveCity;
    }
}

