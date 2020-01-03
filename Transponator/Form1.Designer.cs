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
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonMinusOne = new System.Windows.Forms.Button();
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.buttonMinusTwo = new System.Windows.Forms.Button();
            this.buttonPlusTwo = new System.Windows.Forms.Button();
            this.labelTranspozice = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNakresHmatu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNakresHmatu)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxInput.Location = new System.Drawing.Point(28, 61);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(275, 304);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(500, 61);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(271, 304);
            this.listBoxOutput.TabIndex = 5;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // buttonMinusOne
            // 
            this.buttonMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinusOne.Location = new System.Drawing.Point(333, 111);
            this.buttonMinusOne.Name = "buttonMinusOne";
            this.buttonMinusOne.Size = new System.Drawing.Size(66, 39);
            this.buttonMinusOne.TabIndex = 6;
            this.buttonMinusOne.Text = "-1";
            this.buttonMinusOne.UseVisualStyleBackColor = true;
            this.buttonMinusOne.Click += new System.EventHandler(this.buttonMinusOne_Click);
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlusOne.Location = new System.Drawing.Point(405, 111);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(66, 39);
            this.buttonPlusOne.TabIndex = 7;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonPlusOne_Click);
            // 
            // buttonMinusTwo
            // 
            this.buttonMinusTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinusTwo.Location = new System.Drawing.Point(333, 156);
            this.buttonMinusTwo.Name = "buttonMinusTwo";
            this.buttonMinusTwo.Size = new System.Drawing.Size(66, 39);
            this.buttonMinusTwo.TabIndex = 8;
            this.buttonMinusTwo.Text = "-2";
            this.buttonMinusTwo.UseVisualStyleBackColor = true;
            this.buttonMinusTwo.Click += new System.EventHandler(this.buttonMinusTwo_Click);
            // 
            // buttonPlusTwo
            // 
            this.buttonPlusTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlusTwo.Location = new System.Drawing.Point(405, 156);
            this.buttonPlusTwo.Name = "buttonPlusTwo";
            this.buttonPlusTwo.Size = new System.Drawing.Size(66, 39);
            this.buttonPlusTwo.TabIndex = 9;
            this.buttonPlusTwo.Text = "+2";
            this.buttonPlusTwo.UseVisualStyleBackColor = true;
            this.buttonPlusTwo.Click += new System.EventHandler(this.buttonPlusTwo_Click);
            // 
            // labelTranspozice
            // 
            this.labelTranspozice.AutoSize = true;
            this.labelTranspozice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTranspozice.Location = new System.Drawing.Point(329, 77);
            this.labelTranspozice.Name = "labelTranspozice";
            this.labelTranspozice.Size = new System.Drawing.Size(99, 20);
            this.labelTranspozice.TabIndex = 10;
            this.labelTranspozice.Text = "Transpozice:";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShift.Location = new System.Drawing.Point(425, 77);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(18, 20);
            this.labelShift.TabIndex = 11;
            this.labelShift.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.oAplikaciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uložitToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // oAplikaciToolStripMenuItem
            // 
            this.oAplikaciToolStripMenuItem.Name = "oAplikaciToolStripMenuItem";
            this.oAplikaciToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.oAplikaciToolStripMenuItem.Text = "O aplikaci";
            this.oAplikaciToolStripMenuItem.Click += new System.EventHandler(this.oAplikaciToolStripMenuItem_Click);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozit.Location = new System.Drawing.Point(683, 393);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(88, 35);
            this.buttonUlozit.TabIndex = 13;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Akordy (každý na samostatný řádek):";
            // 
            // pictureBoxNakresHmatu
            // 
            this.pictureBoxNakresHmatu.Location = new System.Drawing.Point(28, 393);
            this.pictureBoxNakresHmatu.Name = "pictureBoxNakresHmatu";
            this.pictureBoxNakresHmatu.Size = new System.Drawing.Size(539, 148);
            this.pictureBoxNakresHmatu.TabIndex = 15;
            this.pictureBoxNakresHmatu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.pictureBoxNakresHmatu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelTranspozice);
            this.Controls.Add(this.buttonPlusTwo);
            this.Controls.Add(this.buttonMinusTwo);
            this.Controls.Add(this.buttonPlusOne);
            this.Controls.Add(this.buttonMinusOne);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Transponator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNakresHmatu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonMinusOne;
        private System.Windows.Forms.Button buttonPlusOne;
        private System.Windows.Forms.Button buttonMinusTwo;
        private System.Windows.Forms.Button buttonPlusTwo;
        private System.Windows.Forms.Label labelTranspozice;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikaciToolStripMenuItem;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNakresHmatu;
    }
}

