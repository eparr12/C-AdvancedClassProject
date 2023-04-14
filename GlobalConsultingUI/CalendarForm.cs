using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GlobalConsultingUI.Models;

namespace GlobalConsultingUI
{
    public partial class CalendarForm : Form
    {
        private client_schedule _context = new client_schedule();
        private BindingList<CalendarAppointmentModel> _appointments = new BindingList<CalendarAppointmentModel>();

        public CalendarForm()
        {
            InitializeComponent();

            LoadAppointments();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            calendarGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);

            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "MMM-dd-yyyy";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "MMM-dd-yyyy";
        }

        private void LoadAppointments()
        {
            var results = _context.appointments.Where(a => a.userId == LoginForm.UserId)
                                   .Select(a => new
                                   {
                                       Customer = a.customer.customerName,
                                       User = a.user.userName,
                                       Title = a.title,
                                       Description = a.description,
                                       Location = a.location,
                                       Contact = a.contact,
                                       Type = a.type,
                                       Start = a.start,
                                       End = a.end,
                                   })
                                    .ToList();

            int i = 0;
            foreach (var result in results)
            {
                _appointments.Add(new CalendarAppointmentModel());
                _appointments[i].Customer = result.Customer;
                _appointments[i].User = result.User;
                _appointments[i].Title = result.Title;
                _appointments[i].Description = result.Description;
                _appointments[i].Location = result.Location;
                _appointments[i].Contact = result.Contact;
                _appointments[i].Type = result.Type;
                _appointments[i].Start = result.Start.ToLocalTime();
                _appointments[i].End = result.End.ToLocalTime();
                i++;
            }

            calendarGridView.DataSource = _appointments;
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            calendarGridView.DataSource = _appointments;
        }

        private void viewSelectedDatesButton_Click(object sender, EventArgs e)
        {
            calendarGridView.DataSource = _appointments.Where(a => (a.Start.Date >= startDatePicker.Value.Date) && (a.End.Date <= endDatePicker.Value.Date)).ToList();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}
