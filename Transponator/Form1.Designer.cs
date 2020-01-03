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
            this.transponovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPultonViceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDvaPultonyViceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPultonMeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDvaPultonyMeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowserNakresHmatu = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxInput.Location = new System.Drawing.Point(28, 80);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(275, 304);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(500, 80);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(271, 300);
            this.listBoxOutput.TabIndex = 5;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // buttonMinusOne
            // 
            this.buttonMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinusOne.Location = new System.Drawing.Point(333, 130);
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
            this.buttonPlusOne.Location = new System.Drawing.Point(405, 130);
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
            this.buttonMinusTwo.Location = new System.Drawing.Point(333, 175);
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
            this.buttonPlusTwo.Location = new System.Drawing.Point(405, 175);
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
            this.labelTranspozice.Location = new System.Drawing.Point(329, 96);
            this.labelTranspozice.Name = "labelTranspozice";
            this.labelTranspozice.Size = new System.Drawing.Size(99, 20);
            this.labelTranspozice.TabIndex = 10;
            this.labelTranspozice.Text = "Transpozice:";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShift.Location = new System.Drawing.Point(425, 96);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(18, 20);
            this.labelShift.TabIndex = 11;
            this.labelShift.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.transponovatToolStripMenuItem,
            this.oAplikaciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 24);
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
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // transponovatToolStripMenuItem
            // 
            this.transponovatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPultonViceToolStripMenuItem,
            this.oDvaPultonyViceToolStripMenuItem,
            this.oPultonMeneToolStripMenuItem,
            this.oDvaPultonyMeneToolStripMenuItem});
            this.transponovatToolStripMenuItem.Name = "transponovatToolStripMenuItem";
            this.transponovatToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.transponovatToolStripMenuItem.Text = "Transponovat";
            // 
            // oPultonViceToolStripMenuItem
            // 
            this.oPultonViceToolStripMenuItem.Name = "oPultonViceToolStripMenuItem";
            this.oPultonViceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.oPultonViceToolStripMenuItem.Text = "O půltón více";
            this.oPultonViceToolStripMenuItem.Click += new System.EventHandler(this.oPultonViceToolStripMenuItem_Click);
            // 
            // oDvaPultonyViceToolStripMenuItem
            // 
            this.oDvaPultonyViceToolStripMenuItem.Name = "oDvaPultonyViceToolStripMenuItem";
            this.oDvaPultonyViceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.oDvaPultonyViceToolStripMenuItem.Text = "O dva půltóny více";
            this.oDvaPultonyViceToolStripMenuItem.Click += new System.EventHandler(this.oDvaPultonyViceToolStripMenuItem_Click);
            // 
            // oPultonMeneToolStripMenuItem
            // 
            this.oPultonMeneToolStripMenuItem.Name = "oPultonMeneToolStripMenuItem";
            this.oPultonMeneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.oPultonMeneToolStripMenuItem.Text = "O půltón méně";
            this.oPultonMeneToolStripMenuItem.Click += new System.EventHandler(this.oPultonMeneToolStripMenuItem_Click);
            // 
            // oDvaPultonyMeneToolStripMenuItem
            // 
            this.oDvaPultonyMeneToolStripMenuItem.Name = "oDvaPultonyMeneToolStripMenuItem";
            this.oDvaPultonyMeneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.oDvaPultonyMeneToolStripMenuItem.Text = "O dva půltóny méně";
            this.oDvaPultonyMeneToolStripMenuItem.Click += new System.EventHandler(this.oDvaPultonyMeneToolStripMenuItem_Click);
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
            this.buttonUlozit.Location = new System.Drawing.Point(683, 421);
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
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Akordy (každý na samostatný řádek):";
            // 
            // webBrowserNakresHmatu
            // 
            this.webBrowserNakresHmatu.AllowWebBrowserDrop = false;
            this.webBrowserNakresHmatu.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserNakresHmatu.Location = new System.Drawing.Point(810, 80);
            this.webBrowserNakresHmatu.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowserNakresHmatu.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNakresHmatu.Name = "webBrowserNakresHmatu";
            this.webBrowserNakresHmatu.ScrollBarsEnabled = false;
            this.webBrowserNakresHmatu.Size = new System.Drawing.Size(501, 376);
            this.webBrowserNakresHmatu.TabIndex = 16;
            this.webBrowserNakresHmatu.TabStop = false;
            this.webBrowserNakresHmatu.Url = new System.Uri("https://akordiky.cz/img/chords/svg/D_1.svg", System.UriKind.Absolute);
            this.webBrowserNakresHmatu.WebBrowserShortcutsEnabled = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(496, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transponované akordy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(806, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Schéma hmatu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1340, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowserNakresHmatu);
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
        private System.Windows.Forms.WebBrowser webBrowserNakresHmatu;
        private System.Windows.Forms.ToolStripMenuItem transponovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPultonViceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDvaPultonyViceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPultonMeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDvaPultonyMeneToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

