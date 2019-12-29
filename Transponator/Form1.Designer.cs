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
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.button_transpose = new System.Windows.Forms.Button();
            this.listBox_output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.Location = new System.Drawing.Point(42, 77);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(261, 340);
            this.richTextBox_input.TabIndex = 2;
            this.richTextBox_input.Text = "";
            // 
            // button_transpose
            // 
            this.button_transpose.Location = new System.Drawing.Point(342, 77);
            this.button_transpose.Name = "button_transpose";
            this.button_transpose.Size = new System.Drawing.Size(117, 44);
            this.button_transpose.TabIndex = 4;
            this.button_transpose.Text = "Transponovat";
            this.button_transpose.UseVisualStyleBackColor = true;
            this.button_transpose.Click += new System.EventHandler(this.button_transpose_Click);
            // 
            // listBox_output
            // 
            this.listBox_output.FormattingEnabled = true;
            this.listBox_output.Location = new System.Drawing.Point(500, 77);
            this.listBox_output.Name = "listBox_output";
            this.listBox_output.Size = new System.Drawing.Size(261, 342);
            this.listBox_output.TabIndex = 5;
            this.listBox_output.SelectedIndexChanged += new System.EventHandler(this.listBox_output_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_output);
            this.Controls.Add(this.button_transpose);
            this.Controls.Add(this.richTextBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.Button button_transpose;
        private System.Windows.Forms.ListBox listBox_output;
    }
}

