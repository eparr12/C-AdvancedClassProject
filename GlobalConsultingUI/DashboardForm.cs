using System;
using System.Windows.Forms;

namespace GlobalConsultingUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void manageAppointmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AppointmentForm();
            form.ShowDialog();
        }

        private void manageCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CustomerForm();
            form.ShowDialog();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CalendarForm();
            form.ShowDialog();
        }

        private void appointmentsPerConsultantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AppointmentsPerConsultantForm();
            form.ShowDialog();
        }

        private void appointmentTypeByMonthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AppointmentTypeForm();
            form.ShowDialog();
        }

        private void consultantsSchedulesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ConsultantScheduleForm();
            form.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var confirmLogout = MessageBox.Show("Are you sure you want to logout??",
                                       "Confirm Logout!",
                                       MessageBoxButtons.YesNo);

            if (confirmLogout == DialogResult.Yes)
            {
                this.Hide();
                var form = new LoginForm();
                form.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
