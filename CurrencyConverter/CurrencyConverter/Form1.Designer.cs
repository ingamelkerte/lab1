namespace CurrencyConverter
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
            this.lbCurrencyFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.cmBoxToCurency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCurrencyFrom = new System.Windows.Forms.TextBox();
            this.txtCurrencyTo = new System.Windows.Forms.TextBox();
            this.btnUseResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCurrencyFrom
            // 
            this.lbCurrencyFrom.AutoSize = true;
            this.lbCurrencyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrencyFrom.Location = new System.Drawing.Point(59, 61);
            this.lbCurrencyFrom.Name = "lbCurrencyFrom";
            this.lbCurrencyFrom.Size = new System.Drawing.Size(145, 24);
            this.lbCurrencyFrom.TabIndex = 0;
            this.lbCurrencyFrom.Text = "Currency I Have";
            this.lbCurrencyFrom.Click += new System.EventHandler(this.lbCurrencyFrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency I Want";
            // 
            // cmBoxCurrencyFrom
            // 
            this.cmBoxCurrencyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxCurrencyFrom.FormattingEnabled = true;
            this.cmBoxCurrencyFrom.Location = new System.Drawing.Point(63, 99);
            this.cmBoxCurrencyFrom.Name = "cmBoxCurrencyFrom";
            this.cmBoxCurrencyFrom.Size = new System.Drawing.Size(154, 32);
            this.cmBoxCurrencyFrom.TabIndex = 2;
            this.cmBoxCurrencyFrom.Text = "Euro";
            this.cmBoxCurrencyFrom.SelectedIndexChanged += new System.EventHandler(this.cmBoxCurrencyFrom_SelectedIndexChanged);
            // 
            // cmBoxToCurency
            // 
            this.cmBoxToCurency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxToCurency.FormattingEnabled = true;
            this.cmBoxToCurency.Location = new System.Drawing.Point(273, 99);
            this.cmBoxToCurency.Name = "cmBoxToCurency";
            this.cmBoxToCurency.Size = new System.Drawing.Size(154, 32);
            this.cmBoxToCurency.TabIndex = 3;
            this.cmBoxToCurency.Text = "Euro";
            this.cmBoxToCurency.SelectedIndexChanged += new System.EventHandler(this.cmBoxToCurency_SelectedIndexChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(54, 238);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 43);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCurrencyFrom
            // 
            this.txtCurrencyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyFrom.Location = new System.Drawing.Point(63, 177);
            this.txtCurrencyFrom.Name = "txtCurrencyFrom";
            this.txtCurrencyFrom.Size = new System.Drawing.Size(154, 29);
            this.txtCurrencyFrom.TabIndex = 6;
            this.txtCurrencyFrom.Text = "0";
            this.txtCurrencyFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrencyFrom.TextChanged += new System.EventHandler(this.txtCurrencyFrom_TextChanged);
            // 
            // txtCurrencyTo
            // 
            this.txtCurrencyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyTo.Location = new System.Drawing.Point(273, 177);
            this.txtCurrencyTo.Name = "txtCurrencyTo";
            this.txtCurrencyTo.Size = new System.Drawing.Size(154, 29);
            this.txtCurrencyTo.TabIndex = 7;
            this.txtCurrencyTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrencyTo.TextChanged += new System.EventHandler(this.txtCurrencyTo_TextChanged);
            // 
            // btnUseResult
            // 
            this.btnUseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseResult.Location = new System.Drawing.Point(316, 238);
            this.btnUseResult.Name = "btnUseResult";
            this.btnUseResult.Size = new System.Drawing.Size(120, 43);
            this.btnUseResult.TabIndex = 8;
            this.btnUseResult.Text = "Use Result";
            this.btnUseResult.UseVisualStyleBackColor = true;
            this.btnUseResult.Click += new System.EventHandler(this.btnUseResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 327);
            this.Controls.Add(this.btnUseResult);
            this.Controls.Add(this.txtCurrencyTo);
            this.Controls.Add(this.txtCurrencyFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmBoxToCurency);
            this.Controls.Add(this.cmBoxCurrencyFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCurrencyFrom);
            this.Name = "Form1";
            this.Text = "Currency Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrencyFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxCurrencyFrom;
        private System.Windows.Forms.ComboBox cmBoxToCurency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCurrencyFrom;
        private System.Windows.Forms.TextBox txtCurrencyTo;
        private System.Windows.Forms.Button btnUseResult;
    }
}

