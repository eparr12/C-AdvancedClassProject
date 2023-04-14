using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GlobalConsultingUI
{
    public partial class AppointmentsPerConsultantForm : Form
    {
        private client_schedule _context = new client_schedule();

        public AppointmentsPerConsultantForm()
        {
            InitializeComponent();
        }

        private void AppointmentsPerConsultantForm_Load(object sender, EventArgs e)
        {
            appointmentsPerConsultantGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
        }

        private DateTime ConvertUtc(DateTime date)
        {
            return TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.Local);
        }

        private void viewSelectedDatesButton_Click(object sender, EventArgs e)
        {
            var start = ConvertUtc(startDatePicker.Value);
            var end = ConvertUtc(endDatePicker.Value);

            var appointments = _context.appointments.Where(a => (a.start >= start) && (a.start <= end))
                                                               .GroupBy(a => a.user.userName)
                                                               .Select(a => new
                                                               {
                                                                   Consultant = a.Key,
                                                                   Number = a.Select(p => p.type).Count()
                                                               })
                                                               .ToList();

            appointmentsPerConsultantGridView.DataSource = appointments;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}
