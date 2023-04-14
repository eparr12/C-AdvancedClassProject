using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GlobalConsultingUI.Models;

namespace GlobalConsultingUI
{
    public partial class ConsultantScheduleForm : Form
    {
        List<string> _consultants = new List<string>();
        private client_schedule _context = new client_schedule();
        private BindingList<CalendarAppointmentModel> _appointments = new BindingList<CalendarAppointmentModel>();

        public ConsultantScheduleForm()
        {
            InitializeComponent();

            LoadAppointments();
        }

        private void ConsultantScheduleForm_Load(object sender, EventArgs e)
        {
            _consultants = _context.users.Select(u => u.userName).ToList();

            foreach (string consultant in _consultants)
            {
                consultantComboBox.Items.Add(consultant);
            }

            consultantScheduleGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
        }

        private void consultantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (consultantComboBox.SelectedItem != null)
            {
                consultantScheduleGridView.DataSource = _appointments.Where(a => a.User == consultantComboBox.SelectedItem.ToString()).ToList();
            }
        }

        private void LoadAppointments()
        {
            var schedule = _context.appointments.Select(a => new
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
                                                .OrderBy(a => a.Start )
                                                .ToList();

            int i = 0;
            foreach (var result in schedule)
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
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}
