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
    public partial class frmBookings : Form
    {
        private bool isInitializing = true;

        public frmBookings()
        {
            InitializeComponent();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            LoadRooms();

            // set the value date for today
            dtpCheckoutDate.Value = DateTime.Today.AddDays(1);
            dtpCheckinDate.Value = DateTime.Today;

            // set the minimum date to today
            dtpCheckinDate.MinDate = DateTime.Today;
            dtpCheckoutDate.MinDate = DateTime.Today.AddDays(1);

            isInitializing = false;
        }

        private void LoadRooms()
        {
            DataTable dt = BookingController.GetRoomTypes();

            cboRoomType.DisplayMember = "room_name";
            cboRoomType.ValueMember = "room_type_id";
            cboRoomType.DataSource = dt;
        }

        private void LoadAvailableRooms()
        {
            if (cboRoomType.SelectedIndex == -1)
                return;

            if (cboRoomType.SelectedValue is DataRowView)
                return;

            int roomTypeId = Convert.ToInt32(cboRoomType.SelectedValue);

            // gets the available only for a selected date
            DataTable dt = BookingController.GetAvailableRooms(
                roomTypeId,
                dtpCheckinDate.Value.Date,
                dtpCheckoutDate.Value.Date
            );

            cboRoomNumber.DisplayMember = "room_number";
            cboRoomNumber.ValueMember = "room_id";
            cboRoomNumber.DataSource = dt;
        }

        private void dtpCheckinDate_ValueChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;

            dtpCheckoutDate.MinDate = dtpCheckinDate.Value.AddDays(1);

            if (!BookingController.IsDateValid(dtpCheckinDate.Value, dtpCheckoutDate.Value))
            {
                dtpCheckoutDate.Value = dtpCheckoutDate.MinDate;
            }
            LoadAvailableRooms();
        }

        private void dtpCheckoutDate_ValueChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;

            if (!BookingController.IsDateValid(dtpCheckinDate.Value, dtpCheckoutDate.Value))
            {
                MessageBox.Show(
                    "Check in must be before checkout",
                    "Invalid date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dtpCheckoutDate.Value = dtpCheckoutDate.MinDate;
            }
            LoadAvailableRooms();
        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomType.SelectedIndex == -1)
                return;

            if (cboRoomType.SelectedValue is DataRowView)
                return;

            int roomTypeId = Convert.ToInt32(cboRoomType.SelectedValue);

            DataTable dt = BookingController.GetAvailableRooms(roomTypeId, dtpCheckinDate.Value, dtpCheckoutDate.Value);

            cboRoomNumber.DisplayMember = "room_number";
            cboRoomNumber.ValueMember = "room_number";
            cboRoomNumber.DataSource = dt;
        }

        private void nudGuests_ValueChanged(object sender, EventArgs e)
        {
            int guests, roomTypeID;

            roomTypeID = Convert.ToInt32(cboRoomType.SelectedValue);
            guests = Convert.ToInt32(nudGuests.Value);

            if (!BookingController.IsRoomCapacityValid(roomTypeID, guests))
            {
                MessageBox.Show(
                    "Guests exceeds the number of occupancy for this room type.",
                    "Maximum occupancy exceeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                nudGuests.Value -= 1;  // stops the increment in the nudGuest
                return;
            }
        }

        private void btnAddBookings_Click(object sender, EventArgs e)
        {
            //returns if no guest is selected
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show(
                    "Please select a guest",
                    "No guest",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int roomID = RoomController.GetRoomID(cboRoomNumber.SelectedValue.ToString());
            int roomTypeID = Convert.ToInt32(cboRoomType.SelectedValue);
            int guestID = Convert.ToInt32(txtGuestID.Text);

            DateTime checkIn = dtpCheckinDate.Value;
            DateTime checkOut = dtpCheckoutDate.Value;

            // calculates the total nights
            int nights = BookingController.CalculateNights(checkIn, checkOut);

            double basePrice = BookingController.GetRoomTypePrice(roomTypeID);
            double total = BookingController.CalculateLineTotal(basePrice, nights);

            dgvBookings.Rows.Add(
                roomID,
                guestID,
                checkIn,
                checkOut,
                cboRoomType.Text,
                cboRoomNumber.Text,
                nudGuests.Value,
                nights,
                total
            );

            // display the total
            string totalAmount = BookingController.CalculateGrandTotal(dgvBookings, lblTotalAmount.Text);
            lblTotalAmount.Text = totalAmount;

            BookingControls();
        }   

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            using (frmGuests guestForm = new frmGuests(true))
            {
                if (guestForm.ShowDialog() == DialogResult.OK)
                {
                    txtGuestID.Text = frmGuests.guestID.ToString();
                    txtFName.Text = frmGuests.firstName;
                    txtLName.Text = frmGuests.lastName;
                    txtEmail.Text = frmGuests.email;
                    txtPhoneNumber.Text = frmGuests.phone;
                }
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Guard against attempting confirmation without grid items or guest ID
                if (dgvBookings.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one booking item to the list.", "No Bookings Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtGuestID.Text))
                {
                    MessageBox.Show("Please select a valid guest.", "Missing Guest ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ask confirmation
                DialogResult result = MessageBox.Show(
                    "Confirm booking?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                int guestID = Convert.ToInt32(txtGuestID.Text);
                int createdByUserId = LoginController.userID;
                string totalAmount = lblTotalAmount.Text;
                DateTime checkin = dtpCheckinDate.Value;
                DateTime checkout = dtpCheckoutDate.Value;

                // Save booking and reset only on success
                if (BookingController.ProcessCompleteBooking(guestID, createdByUserId, totalAmount, dgvBookings))
                {
                    MessageBox.Show(
                        "Booking saved successfully!",
                        "Saved booking",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ResetControls();
                }
                else
                {
                    MessageBox.Show(
                        "Failed to save booking. Please check database logs.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookingControls()
        {
            btnSelectGuest.Enabled = false;
            btnNewGuest.Enabled = false;
            dtpCheckinDate.Enabled = false;
            dtpCheckoutDate.Enabled = false;
            nudGuests.Value = nudGuests.Minimum;
            cboRoomType.SelectedIndex = -1;
            cboRoomNumber.DataSource = null;
            btnConfirmBooking.Enabled = true;
        }

        private void ResetControls()
        {
            dgvBookings.Rows.Clear();
            lblTotalAmount.Text = "0.00";
            btnConfirmBooking.Enabled = false;
            btnNewGuest.Enabled = true;
            btnSelectGuest.Enabled = true;
            dtpCheckinDate.Enabled = true;
            dtpCheckoutDate.Enabled = true;
            txtFName.Clear();
            txtLName.Clear();
            txtGuestID.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
