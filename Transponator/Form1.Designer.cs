namespace Transponator
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonTranspose = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(42, 77);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(261, 340);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "";
            // 
            // buttonTranspose
            // 
            this.buttonTranspose.Location = new System.Drawing.Point(342, 77);
            this.buttonTranspose.Name = "buttonTranspose";
            this.buttonTranspose.Size = new System.Drawing.Size(117, 44);
            this.buttonTranspose.TabIndex = 4;
            this.buttonTranspose.Text = "Transponovat";
            this.buttonTranspose.UseVisualStyleBackColor = true;
            this.buttonTranspose.Click += new System.EventHandler(this.buttonTranspose_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(500, 77);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(261, 342);
            this.listBoxOutput.TabIndex = 5;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonTranspose);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonTranspose;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}

