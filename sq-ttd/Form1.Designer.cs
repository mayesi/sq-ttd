﻿namespace sq_ttd
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
            this.angleBox1 = new System.Windows.Forms.TextBox();
            this.angleBox2 = new System.Windows.Forms.TextBox();
            this.angleBox3 = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.calcAnglesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sideBox1 = new System.Windows.Forms.TextBox();
            this.sideBox2 = new System.Windows.Forms.TextBox();
            this.sideBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hypButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // angleBox1
            // 
            resources.ApplyResources(this.angleBox1, "angleBox1");
            this.angleBox1.Name = "angleBox1";
            // 
            // angleBox2
            // 
            resources.ApplyResources(this.angleBox2, "angleBox2");
            this.angleBox2.Name = "angleBox2";
            // 
            // angleBox3
            // 
            this.angleBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.angleBox3, "angleBox3");
            this.angleBox3.Name = "angleBox3";
            this.angleBox3.ReadOnly = true;
            // 
            // areaBox
            // 
            this.areaBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.areaBox, "areaBox");
            this.areaBox.Name = "areaBox";
            this.areaBox.ReadOnly = true;
            // 
            // calcAnglesButton
            // 
            resources.ApplyResources(this.calcAnglesButton, "calcAnglesButton");
            this.calcAnglesButton.Name = "calcAnglesButton";
            this.calcAnglesButton.UseVisualStyleBackColor = true;
            this.calcAnglesButton.Click += new System.EventHandler(this.calcAnglesButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // sideBox1
            // 
            resources.ApplyResources(this.sideBox1, "sideBox1");
            this.sideBox1.Name = "sideBox1";
            // 
            // sideBox2
            // 
            resources.ApplyResources(this.sideBox2, "sideBox2");
            this.sideBox2.Name = "sideBox2";
            // 
            // sideBox3
            // 
            this.sideBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.sideBox3, "sideBox3");
            this.sideBox3.Name = "sideBox3";
            this.sideBox3.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // hypButton
            // 
            resources.ApplyResources(this.hypButton, "hypButton");
            this.hypButton.Name = "hypButton";
            this.hypButton.UseVisualStyleBackColor = true;
            this.hypButton.Click += new System.EventHandler(this.hypButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hypButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sideBox3);
            this.Controls.Add(this.sideBox2);
            this.Controls.Add(this.sideBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcAnglesButton);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.angleBox3);
            this.Controls.Add(this.angleBox2);
            this.Controls.Add(this.angleBox1);
            this.Name = "Form1";
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox angleBox1;
        private System.Windows.Forms.TextBox angleBox2;
        private System.Windows.Forms.TextBox angleBox3;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Button calcAnglesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideBox1;
        private System.Windows.Forms.TextBox sideBox2;
        private System.Windows.Forms.TextBox sideBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hypButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

