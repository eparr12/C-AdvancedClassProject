using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GlobalConsultingUI
{
    public partial class AppointmentTypeForm : Form
    {
        private List<string> _months = new List<string>();
        private client_schedule _context = new client_schedule();

        public AppointmentTypeForm()
        {
            InitializeComponent();

            LoadMonths();
        }

        private void AppointmentTypeForm_Load(object sender, EventArgs e)
        {
            appointmentTypeGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);

            monthComboBox.DataSource = _months;
            monthComboBox.SelectedIndex = 0;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (monthComboBox.SelectedItem != null && monthComboBox.SelectedIndex != 0)
                {
                    var month = DateTime.ParseExact(monthComboBox.SelectedItem.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;

                    var appointmentTypes = _context.appointments.Where(a => a.start.Month == month || a.end.Month == month)
                                                                .GroupBy(a => a.type)
                                                                .Select(a => new
                                                                {
                                                                    Type = a.Key,
                                                                    Number = a.Select(p => p.type).Count()
                                                                })
                                                                .ToList();

                    appointmentTypeGridView.DataSource = appointmentTypes;
                }
                else
                {
                    appointmentTypeGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMonths()
        {
            _months.Add("");
            _months.Add("January");
            _months.Add("February");
            _months.Add("March");
            _months.Add("April");
            _months.Add("May");
            _months.Add("June");
            _months.Add("July");
            _months.Add("August");
            _months.Add("September");
            _months.Add("October");
            _months.Add("November");
            _months.Add("December");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new DashboardForm();
            form.ShowDialog();
        }
    }
}
