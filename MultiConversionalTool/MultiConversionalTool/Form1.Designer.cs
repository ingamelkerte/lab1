namespace MultiConversionalTool
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
            this.rbtnInchesFeet = new System.Windows.Forms.RadioButton();
            this.rbtnFarCelsius = new System.Windows.Forms.RadioButton();
            this.rbtnEuroPound = new System.Windows.Forms.RadioButton();
            this.rbtnFootInch = new System.Windows.Forms.RadioButton();
            this.rbtnCelsiusFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbtnPoundEuro = new System.Windows.Forms.RadioButton();
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtConvertTo = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnInchesFeet
            // 
            this.rbtnInchesFeet.AutoSize = true;
            this.rbtnInchesFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInchesFeet.Location = new System.Drawing.Point(34, 71);
            this.rbtnInchesFeet.Name = "rbtnInchesFeet";
            this.rbtnInchesFeet.Size = new System.Drawing.Size(107, 28);
            this.rbtnInchesFeet.TabIndex = 1;
            this.rbtnInchesFeet.TabStop = true;
            this.rbtnInchesFeet.Text = "Inch/Foot";
            this.rbtnInchesFeet.UseVisualStyleBackColor = true;
            this.rbtnInchesFeet.CheckedChanged += new System.EventHandler(this.rbtnInchesFeet_CheckedChanged);
            // 
            // rbtnFarCelsius
            // 
            this.rbtnFarCelsius.AutoSize = true;
            this.rbtnFarCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFarCelsius.Location = new System.Drawing.Point(270, 105);
            this.rbtnFarCelsius.Name = "rbtnFarCelsius";
            this.rbtnFarCelsius.Size = new System.Drawing.Size(190, 28);
            this.rbtnFarCelsius.TabIndex = 2;
            this.rbtnFarCelsius.TabStop = true;
            this.rbtnFarCelsius.Text = "Fahrenheit/Celsius ";
            this.rbtnFarCelsius.UseVisualStyleBackColor = true;
            // 
            // rbtnEuroPound
            // 
            this.rbtnEuroPound.AutoSize = true;
            this.rbtnEuroPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEuroPound.Location = new System.Drawing.Point(270, 37);
            this.rbtnEuroPound.Name = "rbtnEuroPound";
            this.rbtnEuroPound.Size = new System.Drawing.Size(130, 28);
            this.rbtnEuroPound.TabIndex = 3;
            this.rbtnEuroPound.TabStop = true;
            this.rbtnEuroPound.Text = "Euro/Pound";
            this.rbtnEuroPound.UseVisualStyleBackColor = true;
            // 
            // rbtnFootInch
            // 
            this.rbtnFootInch.AutoSize = true;
            this.rbtnFootInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFootInch.Location = new System.Drawing.Point(270, 71);
            this.rbtnFootInch.Name = "rbtnFootInch";
            this.rbtnFootInch.Size = new System.Drawing.Size(107, 28);
            this.rbtnFootInch.TabIndex = 4;
            this.rbtnFootInch.TabStop = true;
            this.rbtnFootInch.Text = "Foot/Inch";
            this.rbtnFootInch.UseVisualStyleBackColor = true;
            // 
            // rbtnCelsiusFahrenheit
            // 
            this.rbtnCelsiusFahrenheit.AutoSize = true;
            this.rbtnCelsiusFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCelsiusFahrenheit.Location = new System.Drawing.Point(34, 105);
            this.rbtnCelsiusFahrenheit.Name = "rbtnCelsiusFahrenheit";
            this.rbtnCelsiusFahrenheit.Size = new System.Drawing.Size(185, 28);
            this.rbtnCelsiusFahrenheit.TabIndex = 5;
            this.rbtnCelsiusFahrenheit.TabStop = true;
            this.rbtnCelsiusFahrenheit.Text = "Celsius/Fahrenheit";
            this.rbtnCelsiusFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbtnPoundEuro
            // 
            this.rbtnPoundEuro.AutoSize = true;
            this.rbtnPoundEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPoundEuro.Location = new System.Drawing.Point(34, 37);
            this.rbtnPoundEuro.Name = "rbtnPoundEuro";
            this.rbtnPoundEuro.Size = new System.Drawing.Size(130, 28);
            this.rbtnPoundEuro.TabIndex = 6;
            this.rbtnPoundEuro.TabStop = true;
            this.rbtnPoundEuro.Text = "Pound/Euro";
            this.rbtnPoundEuro.UseVisualStyleBackColor = true;
            this.rbtnPoundEuro.CheckedChanged += new System.EventHandler(this.rbtnPoundEuro_CheckedChanged);
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertFrom.Location = new System.Drawing.Point(137, 281);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.ReadOnly = true;
            this.txtConvertFrom.Size = new System.Drawing.Size(100, 29);
            this.txtConvertFrom.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(331, 281);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 29);
            this.txtOutput.TabIndex = 8;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtConvertTo
            // 
            this.txtConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertTo.Location = new System.Drawing.Point(436, 281);
            this.txtConvertTo.Name = "txtConvertTo";
            this.txtConvertTo.ReadOnly = true;
            this.txtConvertTo.Size = new System.Drawing.Size(100, 29);
            this.txtConvertTo.TabIndex = 9;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(31, 281);
            this.txtInput.Name = "txtInput";
            this.txtInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInput.Size = new System.Drawing.Size(100, 29);
            this.txtInput.TabIndex = 10;
            this.txtInput.Text = "0";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(85, 349);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 43);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(238, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 43);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(382, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 43);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.rbtnInchesFeet);
            this.groupBox1.Controls.Add(this.rbtnFootInch);
            this.groupBox1.Controls.Add(this.rbtnEuroPound);
            this.groupBox1.Controls.Add(this.rbtnFarCelsius);
            this.groupBox1.Controls.Add(this.rbtnCelsiusFahrenheit);
            this.groupBox1.Controls.Add(this.rbtnPoundEuro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select From the Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(182, 139);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(99, 43);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtConvertTo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtConvertFrom);
            this.Name = "Form1";
            this.Text = "Multi Conversion Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnInchesFeet;
        private System.Windows.Forms.RadioButton rbtnFarCelsius;
        private System.Windows.Forms.RadioButton rbtnEuroPound;
        private System.Windows.Forms.RadioButton rbtnFootInch;
        private System.Windows.Forms.RadioButton rbtnCelsiusFahrenheit;
        private System.Windows.Forms.RadioButton rbtnPoundEuro;
        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtConvertTo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
    }
}

