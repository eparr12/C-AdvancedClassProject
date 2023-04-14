using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;
using GlobalConsultingUI.Validation;
using System.IO;

namespace GlobalConsultingUI
{
    public partial class LoginForm : Form
    {
        public static string User;
        public static int UserId;
        private client_schedule _context = new client_schedule();
        private string _path = @"..\..\..\LogFile\LogFile.txt";
        private string _culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Timer appointmentReminder = new Timer();
            appointmentReminder.Interval = 900000;
            appointmentReminder.Tick += new EventHandler(appointmentReminderTick);
            appointmentReminder.Enabled = true;
            appointmentReminder.Start();
        }

        private void appointmentReminderTick(object sender, EventArgs e)
        {
            if (UserId != null)
            {
                AppointmentReminder();
            }
        }

        private void AppointmentReminder()
        {
            var reminder = DateTime.UtcNow.AddMinutes(15);
            var now = DateTime.UtcNow;
            if (_context.appointments.Any(a => (a.userId == UserId) && (a.start >= now) && (a.start <= reminder)))
            {
                MessageBox.Show("You have an appointment in 15 minutes or less!!");
            }
        }

        bool Validation(string username, string password)
        {
            if (!InputValidators.LetterNumberValidator(username))
            {
                if (_culture == "ar")
                {
                    MessageBox.Show("يجب ألا يكون اسم المستخدم فارغًا ويمكن أن يحتوي فقط على أحرف وأرقام!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Username must not be empty and can only contain letters and numbers!");
                    return false;
                }
            }
            else if (!InputValidators.PasswordValidator(password))
            {
                if (_culture == "ar")
                {
                    MessageBox.Show("يجب ألا تكون كلمة المرور فارغة ويجب ألا تحتوي على <> أو '!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Password must not be empty and must not contain < > or '!");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var validation = Validation(loginIDTextBox.Text, passwordTextBox.Text);

                if (validation)
                {
                    if (!File.Exists(_path))
                    {
                        FileStream fs = File.Create(_path);
                        fs.Close();
                    }

                    var context = new client_schedule();

                    if (context.users.Any(u => u.userName == loginIDTextBox.Text && u.password == passwordTextBox.Text))
                    {
                        User = loginIDTextBox.Text;
                        UserId = context.users.Where(u => u.userName == loginIDTextBox.Text).Select(u => u.userId).FirstOrDefault();

                        File.AppendAllText(_path, Environment.NewLine + $"User {User} succesfully logged in at {DateTime.UtcNow} Utc time.");

                        AppointmentReminder();

                        this.Hide();
                        var form = new DashboardForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        File.AppendAllText(_path, Environment.NewLine + $"User {loginIDTextBox.Text} had a failed login at {DateTime.UtcNow} Utc time.");

                        if (_culture == "en")
                        {
                            MessageBox.Show("Incorrect Username Or Password!!");
                        }
                        else if (_culture == "ar")
                        {
                            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!!");
                        }
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
    }
}
