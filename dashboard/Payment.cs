using System;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Payment : Form
    {
        private string generatedOTP = ""; 

        public Payment()
        {
            InitializeComponent();
            btnSendOTP.Click += BtnSendOTP_Click;
            btnProceed.Click += BtnProceed_Click;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtOTP.Enabled = false;
        }

        /// <summary>

        /// </summary>
        private void BtnSendOTP_Click(object sender, EventArgs e)
        {

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please select a payment method!");
                return;
            }

            string phone = txtPhone.Text.Trim();
            if (phone.Length != 11 || !phone.StartsWith("01") || !ulong.TryParse(phone, out _))
            {
                MessageBox.Show("Enter a valid 11-digit phone number starting with '01'.");
                return;
            }

            Random rnd = new Random();
            generatedOTP = rnd.Next(1000, 9999).ToString();
            MessageBox.Show($"OTP sent: {generatedOTP}", "OTP Sent");

            txtOTP.Enabled = true;
            txtOTP.Focus();
        }

        /// <summary>

        /// </summary>
        private void BtnProceed_Click(object sender, EventArgs e)
        {
            // 1. Validate payment method again
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Please select a payment method!");
                return;
            }

            // 2. Validate phone number again
            string phone = txtPhone.Text.Trim();
            if (phone.Length != 11 || !phone.StartsWith("01") || !ulong.TryParse(phone, out _))
            {
                MessageBox.Show("Enter a valid 11-digit phone number starting with '01'.");
                return;
            }

            // 3. Validate OTP
            string enteredOTP = txtOTP.Text.Trim();
            if (string.IsNullOrEmpty(enteredOTP))
            {
                MessageBox.Show("Please enter the OTP!");
                return;
            }

            if (enteredOTP != generatedOTP)
            {
                MessageBox.Show("Invalid OTP! Please try again.");
                return;
            }

            // 4. Payment successful
            MessageBox.Show("Payment Done Successfully!", "Success");

            // Reset the form for next payment
            txtPhone.Clear();
            txtOTP.Clear();
            txtOTP.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            generatedOTP = "";
        }
    }
}
