using HotelBookingManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagementSystem.View
{
    public partial class CheckoutControl : UserControl
    {
        public CheckoutControl()
        {
            InitializeComponent();
        }

        private void CheckoutControl_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            CheckoutController.LoadDGV(dgvCheckedIn);

        }

        private void dgvCheckedIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckedIn.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            txtBookingID.Text = dgvCheckedIn.SelectedRows[0].Cells["BookingID"].Value.ToString();
            lblRefValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["Reference"].Value}";
            lblGuestValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["Guest"].Value}";
            lblPhoneValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["Phone"].Value}";
            lblRoomValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["Room"].Value}";
            lblCheckInValue.Text = $"- {Convert.ToDateTime(dgvCheckedIn.SelectedRows[0].Cells["Check-in"].Value):yyyy-MM-dd}";
            lblCheckOutValue.Text = $"- {Convert.ToDateTime(dgvCheckedIn.SelectedRows[0].Cells["Checkout"].Value):yyyy-MM-dd}";
            lblNightsValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["Nights"].Value}";
            lblGuestsValue.Text = $"- {dgvCheckedIn.SelectedRows[0].Cells["No. of Guests"].Value}";
            lblTotalValue.Text = $"- ₱{Convert.ToDecimal(dgvCheckedIn.SelectedRows[0].Cells["Total Amount"].Value):N2}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int userId = LoginController.userID;
            int bookingId = Convert.ToInt32(txtBookingID.Text);
            decimal amount = Convert.ToDecimal(lblTotalValue.Text.Replace("- ₱", "").Trim());
            string paymentMethod = cboPaymentMethod.SelectedItem.ToString();
            string transactionReference = TransactionReference();

            CheckoutController.ProcessCheckout(bookingId, amount, paymentMethod, transactionReference, userId);

            ClearReceipt();
            LoadDGV();
        }

        private string TransactionReference()
        {
            return $"TX-{DateTime.Now:yyyyMMdd}-{Random.Shared.Next(1000, 9999)}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void ClearReceipt()
        {
            txtBookingID.Clear();
            lblRefValue.Text = "-";
            lblGuestValue.Text = "-";
            lblPhoneValue.Text = "-";
            lblRoomValue.Text = "-";
            lblCheckInValue.Text = "-";
            lblCheckOutValue.Text = "-";
            lblNightsValue.Text = "-";
            lblGuestsValue.Text = "-";
            lblTotalValue.Text = "-";
            txtPayment.Text = "";
            cboPaymentMethod.SelectedIndex = -1;
        }
    }
}
