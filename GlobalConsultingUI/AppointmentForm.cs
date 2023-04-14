using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GlobalConsultingUI.Validation;

namespace GlobalConsultingUI
{
    public partial class AppointmentForm : Form
    {
        private List<customer> _customers = new List<customer>();
        private client_schedule _context = new client_schedule();
        private int _appointmentId;
        private List<appointment> _existingAppointments = new List<appointment>();

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.CustomFormat = "yyyy-MM-dd  hh:mm:ss tt";
            startDatePicker.ShowUpDown = true;
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.CustomFormat = "yyyy-MM-dd  hh:mm:ss tt";
            endDatePicker.ShowUpDown = true;

            _customers = _context.customers.ToList();
            foreach (customer Customer in _customers)
            {
                customerComboBox.Items.Add(Customer.customerName);
            }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex > -1)
            {
                int id = GetCustomerId();
                var appointmentInfo = _context.appointments.Where(a => a.customerId == id && a.userId == LoginForm.UserId)
                                                           .Select(a => new // This lambda allows me to create a new object and set variables equal to the data from the query all in one action
                                                           {
                                                               AppointmentId = a.appointmentId,
                                                               Title = a.title,
                                                               Description = a.description,
                                                               Location = a.location,
                                                               Contact = a.contact,
                                                               Type = a.type,
                                                               Start = a.start,
                                                               End = a.end,
                                                           })
                                                           .FirstOrDefault();

                if (appointmentInfo != null)
                {
                    titleTextBox.Text = appointmentInfo.Title;
                    descriptionTextBox.Text = appointmentInfo.Description;
                    locationTextBox.Text = appointmentInfo.Location;
                    contactTextBox.Text = appointmentInfo.Contact;
                    typeTextBox.Text = appointmentInfo.Type;
                    startDatePicker.Value = appointmentInfo.Start.ToLocalTime();
                    endDatePicker.Value = appointmentInfo.End.ToLocalTime();
                    _appointmentId = appointmentInfo.AppointmentId;
                }
            }
        }

        private int GetCustomerId()
        {
            return _customers.Where(c => c.customerName.ToString() == customerComboBox.SelectedItem.ToString())
                                     .Select(c => c.customerId).SingleOrDefault();
        }

        private appointment GetAppointmentById()
        {
            return _context.appointments.Find(_appointmentId);
        }

        private DateTime ConvertUtc(DateTime date)
        {
            return TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.Local);
        }

        private void ClearData()
        {
            customerComboBox.SelectedIndex = -1;
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            locationTextBox.Text = "";
            contactTextBox.Text = "";
            typeTextBox.Text = "";
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
        }

        private bool Validation(string title, string description, string location, string contact, string type, DateTime start, DateTime end)
        {
            var startDtTimeLimit = new DateTime(2020, 01, 01, 14, 0, 0, DateTimeKind.Utc).ToLocalTime();
            var endTimeDtLimit = new DateTime(2020, 01, 01, 1, 0, 0, DateTimeKind.Utc).ToLocalTime();
            var startTime = start.TimeOfDay;
            var endTime = end.TimeOfDay;

            if (!InputValidators.LetterValidator(title))
            {
                MessageBox.Show("Title must not be empty and can only contain letters!");
                return false;
            }
            else if (!InputValidators.LetterNumberValidator(description))
            {
                MessageBox.Show("Description must not be empty and contain only letters and numbers!");
                return false;
            }
            else if (!InputValidators.LetterNumberValidator(location))
            {
                MessageBox.Show("Location must not be empty and can only contain letters and numbers!");
                return false;
            }
            else if (!InputValidators.LetterValidator(contact))
            {
                MessageBox.Show("Contact must not be empty and can only contain letters!");
                return false;
            }
            else if (!InputValidators.LetterValidator(type))
            {
                MessageBox.Show("Type must not be empty and can only contain letters!");
                return false;
            }
            else if (startTime > endTime)
            {
                MessageBox.Show("Start Time must be before End Time!!");
                return false;
            }
            else if ((startTime < startDtTimeLimit.TimeOfDay || endTime > endTimeDtLimit.TimeOfDay))
            {
                MessageBox.Show($"Appointment times must be between {startDtTimeLimit.TimeOfDay} and {endTimeDtLimit.TimeOfDay} Central Standard Time!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool AddValidation(string title, string description, string location, string contact, string type, DateTime start, DateTime end)
        {
            if (_context.appointments.Any(a => a.userId == LoginForm.UserId))
            {
                var Appointments = _context.appointments.Where(a => a.userId == LoginForm.UserId).ToList();

                foreach (appointment Appointment in Appointments)
                {
                    _existingAppointments.Add(Appointment);
                }
                foreach (appointment time in _existingAppointments)
                {
                    if ((time.start.ToLocalTime() <= start) && (start <= time.end.ToLocalTime()) || ((time.start.ToLocalTime() <= end) && (end <= time.end.ToLocalTime())))
                    {
                        MessageBox.Show($"{time.customer.customerName} already has an appointment during this time! Please select another time!");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = (AddValidation(titleTextBox.Text, descriptionTextBox.Text, locationTextBox.Text, contactTextBox.Text, typeTextBox.Text, startDatePicker.Value, endDatePicker.Value)) && 
                                  (Validation(titleTextBox.Text, descriptionTextBox.Text, locationTextBox.Text, contactTextBox.Text, typeTextBox.Text, startDatePicker.Value, endDatePicker.Value));

                if (validation)
                {
                    int id = GetCustomerId();
                    if (_context.appointments.Any(a => a.customerId == id && a.userId == LoginForm.UserId))
                    {
                        MessageBox.Show("You already have an appointment with this customer. Please update the current appointment!");
                        return;
                    }
                    var Appointment = new appointment()
                    {
                        customerId = id,
                        userId = LoginForm.UserId,
                        title = titleTextBox.Text,
                        description = descriptionTextBox.Text,
                        location = locationTextBox.Text,
                        contact = contactTextBox.Text,
                        type = typeTextBox.Text,
                        url = "",
                        start = ConvertUtc(startDatePicker.Value),
                        end = ConvertUtc(endDatePicker.Value),
                        createDate = ConvertUtc(DateTime.Now),
                        createdBy = LoginForm.User,
                        lastUpdate = ConvertUtc(DateTime.Now),
                        lastUpdateBy = LoginForm.User
                    };

                    _context.appointments.Add(Appointment);

                    _context.SaveChanges();
                    ClearData();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool validation = Validation(titleTextBox.Text, descriptionTextBox.Text, locationTextBox.Text, contactTextBox.Text, typeTextBox.Text, startDatePicker.Value, endDatePicker.Value);

                if (validation)
                {
                    var confirmUpdate = MessageBox.Show("Are you sure you want to update this appointment??",
                                   "Confirm Update!",
                                   MessageBoxButtons.YesNo);

                    if (confirmUpdate == DialogResult.Yes)
                    {
                        var updateAppointment = GetAppointmentById();
                        var startTime = ConvertUtc(startDatePicker.Value);
                        var endTime = ConvertUtc(endDatePicker.Value);
                        if (updateAppointment != null)
                        {
                            if (updateAppointment.userId == LoginForm.UserId && updateAppointment.title == titleTextBox.Text && updateAppointment.description == descriptionTextBox.Text &&
                                updateAppointment.location == locationTextBox.Text && updateAppointment.contact == contactTextBox.Text &&
                                updateAppointment.type == typeTextBox.Text && startTime == updateAppointment.start && endTime == updateAppointment.end)
                            {
                                MessageBox.Show("No information has been changed!");
                                return;
                            }
                            else
                            {
                                updateAppointment.userId = LoginForm.UserId;
                                updateAppointment.title = titleTextBox.Text;
                                updateAppointment.description = descriptionTextBox.Text;
                                updateAppointment.location = locationTextBox.Text;
                                updateAppointment.contact = contactTextBox.Text;
                                updateAppointment.type = typeTextBox.Text;
                                updateAppointment.start = ConvertUtc(startDatePicker.Value);
                                updateAppointment.end = ConvertUtc(endDatePicker.Value);
                                updateAppointment.lastUpdateBy = LoginForm.User;

                                _context.SaveChanges();

                                ClearData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no appointment to update for this customer! Please create one!");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete this customer??",
                                      "Confirm Delete!",
                                      MessageBoxButtons.YesNo);

                if (confirmDelete == DialogResult.Yes)
                {
                    if ((customerComboBox.SelectedIndex == -1) || (customerComboBox.SelectedItem.ToString() == null))
                    {
                        MessageBox.Show("You must select a customer appointment to delete!");
                        return;
                    }

                    var rmvAppointment = GetAppointmentById();

                    if (rmvAppointment == null)
                    {
                        MessageBox.Show("This customer doesn't have any appointments yet!");
                        return;
                    }

                    _context.appointments.Remove(rmvAppointment);

                    _context.SaveChanges();

                    ClearData();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
