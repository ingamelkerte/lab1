namespace Menu1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToPoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusToFarhenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farhenheitToCelsiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incesToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToInchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbInputFrom = new System.Windows.Forms.Label();
            this.lbConvertTo = new System.Windows.Forms.Label();
            this.lbInputTo = new System.Windows.Forms.Label();
            this.labelInputFrom = new System.Windows.Forms.Label();
            this.labelInputTo = new System.Windows.Forms.Label();
            this.txInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.measurmentsToolStripMenuItem});
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poundToEuroToolStripMenuItem,
            this.euroToPoundToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // poundToEuroToolStripMenuItem
            // 
            this.poundToEuroToolStripMenuItem.Name = "poundToEuroToolStripMenuItem";
            this.poundToEuroToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.poundToEuroToolStripMenuItem.Text = "Pound to Euro";
            this.poundToEuroToolStripMenuItem.Click += new System.EventHandler(this.poundToEuroToolStripMenuItem_Click);
            // 
            // euroToPoundToolStripMenuItem
            // 
            this.euroToPoundToolStripMenuItem.Name = "euroToPoundToolStripMenuItem";
            this.euroToPoundToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.euroToPoundToolStripMenuItem.Text = "Euro to Pound";
            this.euroToPoundToolStripMenuItem.Click += new System.EventHandler(this.euroToPoundToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusToFarhenheitToolStripMenuItem,
            this.farhenheitToCelsiusToolStripMenuItem});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // celsiusToFarhenheitToolStripMenuItem
            // 
            this.celsiusToFarhenheitToolStripMenuItem.Name = "celsiusToFarhenheitToolStripMenuItem";
            this.celsiusToFarhenheitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.celsiusToFarhenheitToolStripMenuItem.Text = "Celsius to Fahrenheit";
            this.celsiusToFarhenheitToolStripMenuItem.Click += new System.EventHandler(this.celsiusToFarhenheitToolStripMenuItem_Click);
            // 
            // farhenheitToCelsiusToolStripMenuItem
            // 
            this.farhenheitToCelsiusToolStripMenuItem.Name = "farhenheitToCelsiusToolStripMenuItem";
            this.farhenheitToCelsiusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.farhenheitToCelsiusToolStripMenuItem.Text = "Fahrenheit to Celsius";
            this.farhenheitToCelsiusToolStripMenuItem.Click += new System.EventHandler(this.farhenheitToCelsiusToolStripMenuItem_Click);
            // 
            // measurmentsToolStripMenuItem
            // 
            this.measurmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incesToFeetToolStripMenuItem,
            this.feetToInchesToolStripMenuItem});
            this.measurmentsToolStripMenuItem.Name = "measurmentsToolStripMenuItem";
            this.measurmentsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.measurmentsToolStripMenuItem.Text = "Length";
            // 
            // incesToFeetToolStripMenuItem
            // 
            this.incesToFeetToolStripMenuItem.Name = "incesToFeetToolStripMenuItem";
            this.incesToFeetToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.incesToFeetToolStripMenuItem.Text = "Inches to Feet";
            this.incesToFeetToolStripMenuItem.Click += new System.EventHandler(this.incesToFeetToolStripMenuItem_Click);
            // 
            // feetToInchesToolStripMenuItem
            // 
            this.feetToInchesToolStripMenuItem.Name = "feetToInchesToolStripMenuItem";
            this.feetToInchesToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.feetToInchesToolStripMenuItem.Text = "Feet to Inches";
            this.feetToInchesToolStripMenuItem.Click += new System.EventHandler(this.feetToInchesToolStripMenuItem_Click);
            // 
            // lbInputFrom
            // 
            this.lbInputFrom.AutoSize = true;
            this.lbInputFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputFrom.Location = new System.Drawing.Point(176, 235);
            this.lbInputFrom.Name = "lbInputFrom";
            this.lbInputFrom.Size = new System.Drawing.Size(0, 20);
            this.lbInputFrom.TabIndex = 1;
            // 
            // lbConvertTo
            // 
            this.lbConvertTo.AutoSize = true;
            this.lbConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConvertTo.Location = new System.Drawing.Point(314, 235);
            this.lbConvertTo.Name = "lbConvertTo";
            this.lbConvertTo.Size = new System.Drawing.Size(0, 20);
            this.lbConvertTo.TabIndex = 2;
            this.lbConvertTo.Click += new System.EventHandler(this.lbConvertTo_Click);
            // 
            // lbInputTo
            // 
            this.lbInputTo.AutoSize = true;
            this.lbInputTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputTo.Location = new System.Drawing.Point(432, 235);
            this.lbInputTo.Name = "lbInputTo";
            this.lbInputTo.Size = new System.Drawing.Size(0, 20);
            this.lbInputTo.TabIndex = 3;
            // 
            // labelInputFrom
            // 
            this.labelInputFrom.AutoSize = true;
            this.labelInputFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputFrom.Location = new System.Drawing.Point(205, 235);
            this.labelInputFrom.Name = "labelInputFrom";
            this.labelInputFrom.Size = new System.Drawing.Size(0, 20);
            this.labelInputFrom.TabIndex = 4;
            // 
            // labelInputTo
            // 
            this.labelInputTo.AutoSize = true;
            this.labelInputTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputTo.Location = new System.Drawing.Point(438, 235);
            this.labelInputTo.Name = "labelInputTo";
            this.labelInputTo.Size = new System.Drawing.Size(0, 20);
            this.labelInputTo.TabIndex = 5;
            this.labelInputTo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txInput
            // 
            this.txInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInput.Location = new System.Drawing.Point(63, 234);
            this.txInput.Name = "txInput";
            this.txInput.Size = new System.Drawing.Size(85, 26);
            this.txInput.TabIndex = 6;
            this.txInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(144, 316);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 38);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(300, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(464, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please Select Option From The Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txInput);
            this.Controls.Add(this.labelInputTo);
            this.Controls.Add(this.labelInputFrom);
            this.Controls.Add(this.lbInputTo);
            this.Controls.Add(this.lbConvertTo);
            this.Controls.Add(this.lbInputFrom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multi Conversion Tool ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToPoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celsiusToFarhenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farhenheitToCelsiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incesToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToInchesToolStripMenuItem;
        private System.Windows.Forms.Label lbInputFrom;
        private System.Windows.Forms.Label lbConvertTo;
        private System.Windows.Forms.Label lbInputTo;
        private System.Windows.Forms.Label labelInputFrom;
        private System.Windows.Forms.Label labelInputTo;
        private System.Windows.Forms.TextBox txInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

