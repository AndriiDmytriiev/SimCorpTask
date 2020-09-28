namespace SimCorpTask
{
    partial class frmInvest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInvestSum = new System.Windows.Forms.Label();
            this.lblInvestRate = new System.Windows.Forms.Label();
            this.dtAgreementDate = new System.Windows.Forms.Label();
            this.lblCalculationDate = new System.Windows.Forms.Label();
            this.lblDebtPeriod = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtInvestSum = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInvestSum
            // 
            this.lblInvestSum.AutoSize = true;
            this.lblInvestSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInvestSum.Location = new System.Drawing.Point(24, 55);
            this.lblInvestSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInvestSum.Name = "lblInvestSum";
            this.lblInvestSum.Size = new System.Drawing.Size(115, 24);
            this.lblInvestSum.TabIndex = 0;
            this.lblInvestSum.Text = "Invest sum:";
            // 
            // lblInvestRate
            // 
            this.lblInvestRate.AutoSize = true;
            this.lblInvestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInvestRate.Location = new System.Drawing.Point(24, 98);
            this.lblInvestRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInvestRate.Name = "lblInvestRate";
            this.lblInvestRate.Size = new System.Drawing.Size(125, 24);
            this.lblInvestRate.TabIndex = 1;
            this.lblInvestRate.Text = "Interest rate:";
            // 
            // dtAgreementDate
            // 
            this.dtAgreementDate.AutoSize = true;
            this.dtAgreementDate.Location = new System.Drawing.Point(24, 136);
            this.dtAgreementDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dtAgreementDate.Name = "dtAgreementDate";
            this.dtAgreementDate.Size = new System.Drawing.Size(165, 24);
            this.dtAgreementDate.TabIndex = 2;
            this.dtAgreementDate.Text = "Agreement date:";
            // 
            // lblCalculationDate
            // 
            this.lblCalculationDate.AutoSize = true;
            this.lblCalculationDate.Location = new System.Drawing.Point(24, 192);
            this.lblCalculationDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCalculationDate.Name = "lblCalculationDate";
            this.lblCalculationDate.Size = new System.Drawing.Size(165, 24);
            this.lblCalculationDate.TabIndex = 3;
            this.lblCalculationDate.Text = "Calculation date:";
            // 
            // lblDebtPeriod
            // 
            this.lblDebtPeriod.AutoSize = true;
            this.lblDebtPeriod.Location = new System.Drawing.Point(24, 242);
            this.lblDebtPeriod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDebtPeriod.Name = "lblDebtPeriod";
            this.lblDebtPeriod.Size = new System.Drawing.Size(204, 24);
            this.lblDebtPeriod.TabIndex = 4;
            this.lblDebtPeriod.Text = "Debt period in years:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 136);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 29);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(233, 188);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 29);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2023, 9, 28, 13, 50, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtInvestSum
            // 
            this.txtInvestSum.Location = new System.Drawing.Point(233, 52);
            this.txtInvestSum.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvestSum.Name = "txtInvestSum";
            this.txtInvestSum.Size = new System.Drawing.Size(196, 29);
            this.txtInvestSum.TabIndex = 8;
            this.txtInvestSum.Text = "50000";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(233, 93);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(6);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(196, 29);
            this.txtInterestRate.TabIndex = 9;
            this.txtInterestRate.Text = "10";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(233, 237);
            this.txtYears.Margin = new System.Windows.Forms.Padding(6);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(196, 29);
            this.txtYears.TabIndex = 10;
            this.txtYears.Text = "3";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 35);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(652, 9);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(179, 24);
            this.lblPayments.TabIndex = 14;
            this.lblPayments.Text = "Monthly Payments";
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 24;
            this.lstPayments.Location = new System.Drawing.Point(480, 45);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(734, 388);
            this.lstPayments.TabIndex = 15;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(24, 377);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(272, 24);
            this.lblExtra.TabIndex = 16;
            this.lblExtra.Text = "Extra payment for the credit:";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(28, 409);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(268, 29);
            this.txtExtra.TabIndex = 17;
            // 
            // frmInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lstPayments);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtInvestSum);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDebtPeriod);
            this.Controls.Add(this.lblCalculationDate);
            this.Controls.Add(this.dtAgreementDate);
            this.Controls.Add(this.lblInvestRate);
            this.Controls.Add(this.lblInvestSum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInvest";
            this.Text = "Investment calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestSum;
        private System.Windows.Forms.Label lblInvestRate;
        private System.Windows.Forms.Label dtAgreementDate;
        private System.Windows.Forms.Label lblCalculationDate;
        private System.Windows.Forms.Label lblDebtPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtInvestSum;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
    }
}

