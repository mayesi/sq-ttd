namespace sq_ttd
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
            this.angle1Box = new System.Windows.Forms.TextBox();
            this.angle2Box = new System.Windows.Forms.TextBox();
            this.angle3Box = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.calcAnglesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // angle1Box
            // 
            resources.ApplyResources(this.angle1Box, "angle1Box");
            this.angle1Box.Name = "angle1Box";
            // 
            // angle2Box
            // 
            resources.ApplyResources(this.angle2Box, "angle2Box");
            this.angle2Box.Name = "angle2Box";
            // 
            // angle3Box
            // 
            resources.ApplyResources(this.angle3Box, "angle3Box");
            this.angle3Box.Name = "angle3Box";
            // 
            // areaBox
            // 
            resources.ApplyResources(this.areaBox, "areaBox");
            this.areaBox.Name = "areaBox";
            // 
            // calcAnglesButton
            // 
            resources.ApplyResources(this.calcAnglesButton, "calcAnglesButton");
            this.calcAnglesButton.Name = "calcAnglesButton";
            this.calcAnglesButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // feedbackLabel
            // 
            resources.ApplyResources(this.feedbackLabel, "feedbackLabel");
            this.feedbackLabel.Name = "feedbackLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcAnglesButton);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.angle3Box);
            this.Controls.Add(this.angle2Box);
            this.Controls.Add(this.angle1Box);
            this.Name = "Form1";
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox angle1Box;
        private System.Windows.Forms.TextBox angle2Box;
        private System.Windows.Forms.TextBox angle3Box;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Button calcAnglesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedbackLabel;
    }
}

