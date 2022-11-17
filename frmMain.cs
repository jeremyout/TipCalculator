using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TipCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PopulateTipPercentages();
        }

        private void PopulateTipPercentages()
        {
            cmb_tipPercentage.BeginUpdate();
            cmb_tipPercentage.Items.Clear();

            cmb_tipPercentage.Items.Add("Pick one..."); // 0
            cmb_tipPercentage.Items.Add("15%");         // 1
            cmb_tipPercentage.Items.Add("20%");         // 2
            cmb_tipPercentage.Items.Add("25%");         // 3
            cmb_tipPercentage.Items.Add("Custom...");   // 4

            cmb_tipPercentage.SelectedIndex = 0;
            cmb_tipPercentage.EndUpdate();
        }

        private void ShowCustomSection()
        {
            lbl_customTip.Visible = true;
            lbl_customTipUnit.Visible = true;
            tb_customTip.Visible = true;
            rb_tipUnit_dollars.Visible = true;
            rb_tipUnit_percent.Visible = true;
        }

        private void HideCustomSection()
        {
            lbl_customTip.Visible = false;
            lbl_customTipUnit.Visible = false;
            tb_customTip.Visible = false;
            rb_tipUnit_dollars.Visible = false;
            rb_tipUnit_percent.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tb_billAmount.Text == "") 
            {
                MessageBox.Show("Please enter an amount for the bill");
                return; 
            }

            if (cmb_tipPercentage.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a tip option");
                return;
            }

            double billAmount = double.Parse(tb_billAmount.Text);
            double tipAmount = 0;
            double calculatedTip = 0;
            if (cmb_tipPercentage.SelectedIndex > 0 && cmb_tipPercentage.SelectedIndex < 4)
            {
                tipAmount = double.Parse(cmb_tipPercentage.SelectedItem.ToString().Split('%')[0])/100;
                calculatedTip = billAmount * tipAmount;
            }
            else if (cmb_tipPercentage.SelectedIndex == 4)
            {
                if (tb_customTip.Text == "")
                {
                    MessageBox.Show("Please enter a custom tip");
                    return;
                }
                if (rb_tipUnit_percent.Checked)
                {
                    tipAmount = double.Parse(tb_customTip.Text) / 100;
                    calculatedTip = billAmount * tipAmount;
                }
                else if (rb_tipUnit_dollars.Checked)
                {
                    calculatedTip = double.Parse(tb_customTip.Text);
                }
            }

            double calculatedTotal = billAmount + calculatedTip;
            
            lbl_outputString.Text = $"Your tip amount is ${Math.Round(calculatedTip,2)} and the total bill is ${Math.Round(calculatedTotal,2)}";
            lbl_outputString.Visible = true;
            btn_clear.Visible = true;

        }

        private void cmb_tipPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipPercentage.SelectedIndex == 4)
            {
                ShowCustomSection();
            } 
            else
            {
                HideCustomSection();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_tipPercentage.SelectedIndex = 0;
            tb_customTip.Text = "";
            rb_tipUnit_dollars.Checked = false;
            rb_tipUnit_percent.Checked = true;
            HideCustomSection();
            tb_billAmount.Text = "";
            lbl_outputString.Text = "";
            lbl_outputString.Visible = false;
            btn_clear.Visible = false;
        }
    }
}
