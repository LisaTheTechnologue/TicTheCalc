namespace Application1
{
    partial class CalculatorStd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorStd));
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.buttonMiPl = new System.Windows.Forms.Button();
            this.BtnPeriod = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.TxtBoxCalc = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Gray;
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDel.Location = new System.Drawing.Point(209, 38);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(53, 34);
            this.BtnDel.TabIndex = 13;
            this.BtnDel.Text = "C";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.Gray;
            this.BtnEqual.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEqual.Location = new System.Drawing.Point(209, 247);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(53, 34);
            this.BtnEqual.TabIndex = 17;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.Gray;
            this.BtnMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinus.Location = new System.Drawing.Point(209, 165);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(53, 34);
            this.BtnMinus.TabIndex = 15;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Gray;
            this.BtnPlus.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPlus.Location = new System.Drawing.Point(209, 206);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(53, 34);
            this.BtnPlus.TabIndex = 16;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.Btn_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.newToolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "&File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "&Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "S&cientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.newToolStripMenuItem2.Text = "&New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem1});
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutMeToolStripMenuItem.Text = "&Help";
            // 
            // aboutMeToolStripMenuItem1
            // 
            this.aboutMeToolStripMenuItem1.Name = "aboutMeToolStripMenuItem1";
            this.aboutMeToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.aboutMeToolStripMenuItem1.Text = "&About me";
            this.aboutMeToolStripMenuItem1.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Gray;
            this.BtnDiv.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDiv.Location = new System.Drawing.Point(209, 83);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(53, 34);
            this.BtnDiv.TabIndex = 14;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.BackColor = System.Drawing.Color.Gray;
            this.BtnMulti.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMulti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMulti.Location = new System.Drawing.Point(209, 124);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(53, 34);
            this.BtnMulti.TabIndex = 14;
            this.BtnMulti.Text = "*";
            this.BtnMulti.UseVisualStyleBackColor = false;
            this.BtnMulti.Click += new System.EventHandler(this.Btn_Click);
            // 
            // buttonMiPl
            // 
            this.buttonMiPl.BackColor = System.Drawing.Color.Silver;
            this.buttonMiPl.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMiPl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMiPl.Location = new System.Drawing.Point(31, 227);
            this.buttonMiPl.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMiPl.Name = "buttonMiPl";
            this.buttonMiPl.Padding = new System.Windows.Forms.Padding(2);
            this.buttonMiPl.Size = new System.Drawing.Size(40, 40);
            this.buttonMiPl.TabIndex = 1;
            this.buttonMiPl.Text = "±";
            this.buttonMiPl.UseVisualStyleBackColor = false;
            this.buttonMiPl.Click += new System.EventHandler(this.buttonMiPl_Click);
            // 
            // BtnPeriod
            // 
            this.BtnPeriod.BackColor = System.Drawing.Color.Silver;
            this.BtnPeriod.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPeriod.Location = new System.Drawing.Point(158, 227);
            this.BtnPeriod.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPeriod.Name = "BtnPeriod";
            this.BtnPeriod.Padding = new System.Windows.Forms.Padding(2);
            this.BtnPeriod.Size = new System.Drawing.Size(40, 40);
            this.BtnPeriod.TabIndex = 3;
            this.BtnPeriod.Text = ".";
            this.BtnPeriod.UseVisualStyleBackColor = false;
            this.BtnPeriod.Click += new System.EventHandler(this.BtnPeriod_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Silver;
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn2.Location = new System.Drawing.Point(97, 186);
            this.Btn2.Margin = new System.Windows.Forms.Padding(5);
            this.Btn2.Name = "Btn2";
            this.Btn2.Padding = new System.Windows.Forms.Padding(2);
            this.Btn2.Size = new System.Drawing.Size(40, 40);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Silver;
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn7.Location = new System.Drawing.Point(31, 104);
            this.Btn7.Margin = new System.Windows.Forms.Padding(5);
            this.Btn7.Name = "Btn7";
            this.Btn7.Padding = new System.Windows.Forms.Padding(2);
            this.Btn7.Size = new System.Drawing.Size(40, 40);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Silver;
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn9.Location = new System.Drawing.Point(158, 104);
            this.Btn9.Margin = new System.Windows.Forms.Padding(5);
            this.Btn9.Name = "Btn9";
            this.Btn9.Padding = new System.Windows.Forms.Padding(2);
            this.Btn9.Size = new System.Drawing.Size(40, 40);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Silver;
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn3.Location = new System.Drawing.Point(158, 186);
            this.Btn3.Margin = new System.Windows.Forms.Padding(5);
            this.Btn3.Name = "Btn3";
            this.Btn3.Padding = new System.Windows.Forms.Padding(2);
            this.Btn3.Size = new System.Drawing.Size(40, 40);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Silver;
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn8.Location = new System.Drawing.Point(97, 104);
            this.Btn8.Margin = new System.Windows.Forms.Padding(5);
            this.Btn8.Name = "Btn8";
            this.Btn8.Padding = new System.Windows.Forms.Padding(2);
            this.Btn8.Size = new System.Drawing.Size(40, 40);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Silver;
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn4.Location = new System.Drawing.Point(31, 145);
            this.Btn4.Margin = new System.Windows.Forms.Padding(5);
            this.Btn4.Name = "Btn4";
            this.Btn4.Padding = new System.Windows.Forms.Padding(2);
            this.Btn4.Size = new System.Drawing.Size(40, 40);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Silver;
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn5.Location = new System.Drawing.Point(97, 145);
            this.Btn5.Margin = new System.Windows.Forms.Padding(5);
            this.Btn5.Name = "Btn5";
            this.Btn5.Padding = new System.Windows.Forms.Padding(2);
            this.Btn5.Size = new System.Drawing.Size(40, 40);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Silver;
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn6.Location = new System.Drawing.Point(158, 145);
            this.Btn6.Margin = new System.Windows.Forms.Padding(5);
            this.Btn6.Name = "Btn6";
            this.Btn6.Padding = new System.Windows.Forms.Padding(2);
            this.Btn6.Size = new System.Drawing.Size(40, 40);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.Silver;
            this.Btn0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn0.Location = new System.Drawing.Point(97, 227);
            this.Btn0.Margin = new System.Windows.Forms.Padding(5);
            this.Btn0.Name = "Btn0";
            this.Btn0.Padding = new System.Windows.Forms.Padding(2);
            this.Btn0.Size = new System.Drawing.Size(40, 40);
            this.Btn0.TabIndex = 2;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.click_Shown);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Silver;
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn1.Location = new System.Drawing.Point(31, 186);
            this.Btn1.Margin = new System.Windows.Forms.Padding(5);
            this.Btn1.Name = "Btn1";
            this.Btn1.Padding = new System.Windows.Forms.Padding(2);
            this.Btn1.Size = new System.Drawing.Size(40, 40);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.click_Shown);
            // 
            // TxtBoxCalc
            // 
            this.TxtBoxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCalc.Location = new System.Drawing.Point(31, 38);
            this.TxtBoxCalc.Name = "TxtBoxCalc";
            this.TxtBoxCalc.Size = new System.Drawing.Size(162, 38);
            this.TxtBoxCalc.TabIndex = 18;
            this.TxtBoxCalc.Text = "0.";
            this.TxtBoxCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxCalc.Click += new System.EventHandler(this.TxtBoxCalc_TextChanged);
            this.TxtBoxCalc.TextChanged += new System.EventHandler(this.TxtBoxCalc_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.aboutMeToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // CalculatorStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 294);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.buttonMiPl);
            this.Controls.Add(this.BtnPeriod);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TxtBoxCalc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorStd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator (Standard)";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button buttonMiPl;
        private System.Windows.Forms.Button BtnPeriod;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox TxtBoxCalc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
    }
}