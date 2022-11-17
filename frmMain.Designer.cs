namespace TipCalculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmb_tipPercentage = new System.Windows.Forms.ComboBox();
            this.billAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tb_billAmount = new System.Windows.Forms.TextBox();
            this.tb_customTip = new System.Windows.Forms.TextBox();
            this.lbl_customTip = new System.Windows.Forms.Label();
            this.lbl_customTipUnit = new System.Windows.Forms.Label();
            this.rb_tipUnit_percent = new System.Windows.Forms.RadioButton();
            this.rb_tipUnit_dollars = new System.Windows.Forms.RadioButton();
            this.lbl_outputString = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_tipPercentage
            // 
            this.cmb_tipPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_tipPercentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipPercentage.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipPercentage.FormattingEnabled = true;
            this.cmb_tipPercentage.ItemHeight = 25;
            this.cmb_tipPercentage.Location = new System.Drawing.Point(279, 143);
            this.cmb_tipPercentage.Name = "cmb_tipPercentage";
            this.cmb_tipPercentage.Size = new System.Drawing.Size(140, 33);
            this.cmb_tipPercentage.TabIndex = 0;
            this.cmb_tipPercentage.SelectedIndexChanged += new System.EventHandler(this.cmb_tipPercentage_SelectedIndexChanged);
            // 
            // billAmountLabel
            // 
            this.billAmountLabel.AutoSize = true;
            this.billAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.billAmountLabel.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.billAmountLabel.Location = new System.Drawing.Point(65, 82);
            this.billAmountLabel.Name = "billAmountLabel";
            this.billAmountLabel.Size = new System.Drawing.Size(208, 27);
            this.billAmountLabel.TabIndex = 1;
            this.billAmountLabel.Text = "Enter Bill Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Tip Amount:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(486, 98);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(159, 57);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tb_billAmount
            // 
            this.tb_billAmount.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_billAmount.Location = new System.Drawing.Point(279, 79);
            this.tb_billAmount.Name = "tb_billAmount";
            this.tb_billAmount.Size = new System.Drawing.Size(140, 33);
            this.tb_billAmount.TabIndex = 4;
            // 
            // tb_customTip
            // 
            this.tb_customTip.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customTip.Location = new System.Drawing.Point(279, 204);
            this.tb_customTip.Name = "tb_customTip";
            this.tb_customTip.Size = new System.Drawing.Size(140, 33);
            this.tb_customTip.TabIndex = 6;
            this.tb_customTip.Visible = false;
            // 
            // lbl_customTip
            // 
            this.lbl_customTip.AutoSize = true;
            this.lbl_customTip.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customTip.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customTip.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_customTip.Location = new System.Drawing.Point(70, 207);
            this.lbl_customTip.Name = "lbl_customTip";
            this.lbl_customTip.Size = new System.Drawing.Size(203, 27);
            this.lbl_customTip.TabIndex = 5;
            this.lbl_customTip.Text = "Enter Custom Tip:";
            this.lbl_customTip.Visible = false;
            // 
            // lbl_customTipUnit
            // 
            this.lbl_customTipUnit.AutoSize = true;
            this.lbl_customTipUnit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customTipUnit.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customTipUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_customTipUnit.Location = new System.Drawing.Point(153, 250);
            this.lbl_customTipUnit.Name = "lbl_customTipUnit";
            this.lbl_customTipUnit.Size = new System.Drawing.Size(140, 19);
            this.lbl_customTipUnit.TabIndex = 7;
            this.lbl_customTipUnit.Text = "Custom Tip unit:";
            this.lbl_customTipUnit.Visible = false;
            // 
            // rb_tipUnit_percent
            // 
            this.rb_tipUnit_percent.AutoSize = true;
            this.rb_tipUnit_percent.BackColor = System.Drawing.Color.Transparent;
            this.rb_tipUnit_percent.Checked = true;
            this.rb_tipUnit_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tipUnit_percent.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_tipUnit_percent.Location = new System.Drawing.Point(299, 248);
            this.rb_tipUnit_percent.Name = "rb_tipUnit_percent";
            this.rb_tipUnit_percent.Size = new System.Drawing.Size(41, 24);
            this.rb_tipUnit_percent.TabIndex = 8;
            this.rb_tipUnit_percent.TabStop = true;
            this.rb_tipUnit_percent.Text = "%";
            this.rb_tipUnit_percent.UseVisualStyleBackColor = false;
            this.rb_tipUnit_percent.Visible = false;
            // 
            // rb_tipUnit_dollars
            // 
            this.rb_tipUnit_dollars.AutoSize = true;
            this.rb_tipUnit_dollars.BackColor = System.Drawing.Color.Transparent;
            this.rb_tipUnit_dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tipUnit_dollars.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_tipUnit_dollars.Location = new System.Drawing.Point(356, 248);
            this.rb_tipUnit_dollars.Name = "rb_tipUnit_dollars";
            this.rb_tipUnit_dollars.Size = new System.Drawing.Size(36, 24);
            this.rb_tipUnit_dollars.TabIndex = 9;
            this.rb_tipUnit_dollars.Text = "$";
            this.rb_tipUnit_dollars.UseVisualStyleBackColor = false;
            this.rb_tipUnit_dollars.Visible = false;
            // 
            // lbl_outputString
            // 
            this.lbl_outputString.AutoSize = true;
            this.lbl_outputString.BackColor = System.Drawing.Color.Transparent;
            this.lbl_outputString.Font = new System.Drawing.Font("Bahnschrift Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputString.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_outputString.Location = new System.Drawing.Point(56, 335);
            this.lbl_outputString.Name = "lbl_outputString";
            this.lbl_outputString.Size = new System.Drawing.Size(0, 27);
            this.lbl_outputString.TabIndex = 10;
            this.lbl_outputString.Visible = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(647, 447);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(68, 34);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 493);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_outputString);
            this.Controls.Add(this.rb_tipUnit_dollars);
            this.Controls.Add(this.rb_tipUnit_percent);
            this.Controls.Add(this.lbl_customTipUnit);
            this.Controls.Add(this.tb_customTip);
            this.Controls.Add(this.lbl_customTip);
            this.Controls.Add(this.tb_billAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billAmountLabel);
            this.Controls.Add(this.cmb_tipPercentage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipPercentage;
        private System.Windows.Forms.Label billAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tb_billAmount;
        private System.Windows.Forms.TextBox tb_customTip;
        private System.Windows.Forms.Label lbl_customTip;
        private System.Windows.Forms.Label lbl_customTipUnit;
        private System.Windows.Forms.RadioButton rb_tipUnit_percent;
        private System.Windows.Forms.RadioButton rb_tipUnit_dollars;
        private System.Windows.Forms.Label lbl_outputString;
        private System.Windows.Forms.Button btn_clear;
    }
}

