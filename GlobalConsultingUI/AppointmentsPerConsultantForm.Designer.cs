
namespace GlobalConsultingUI
{
    partial class AppointmentsPerConsultantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appointmentsPerConsultantLabel = new System.Windows.Forms.Label();
            this.appointmentsPerConsultantGridView = new System.Windows.Forms.DataGridView();
            this.homeButton = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.viewSelectedDatesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsPerConsultantGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsPerConsultantLabel
            // 
            this.appointmentsPerConsultantLabel.AutoSize = true;
            this.appointmentsPerConsultantLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.appointmentsPerConsultantLabel.Location = new System.Drawing.Point(122, 25);
            this.appointmentsPerConsultantLabel.Name = "appointmentsPerConsultantLabel";
            this.appointmentsPerConsultantLabel.Size = new System.Drawing.Size(476, 50);
            this.appointmentsPerConsultantLabel.TabIndex = 27;
            this.appointmentsPerConsultantLabel.Text = "Appointments Per Consultant";
            // 
            // appointmentsPerConsultantGridView
            // 
            this.appointmentsPerConsultantGridView.AllowUserToAddRows = false;
            this.appointmentsPerConsultantGridView.AllowUserToDeleteRows = false;
            this.appointmentsPerConsultantGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.appointmentsPerConsultantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsPerConsultantGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.appointmentsPerConsultantGridView.Location = new System.Drawing.Point(153, 232);
            this.appointmentsPerConsultantGridView.MultiSelect = false;
            this.appointmentsPerConsultantGridView.Name = "appointmentsPerConsultantGridView";
            this.appointmentsPerConsultantGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsPerConsultantGridView.Size = new System.Drawing.Size(414, 284);
            this.appointmentsPerConsultantGridView.TabIndex = 28;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.homeButton.Location = new System.Drawing.Point(56, 560);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 52;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(300, 100);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(272, 35);
            this.startDatePicker.TabIndex = 54;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.startLabel.Location = new System.Drawing.Point(149, 98);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(71, 37);
            this.startLabel.TabIndex = 53;
            this.startLabel.Text = "Start";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(295, 168);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(272, 35);
            this.endDatePicker.TabIndex = 56;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.endLabel.Location = new System.Drawing.Point(153, 166);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(62, 37);
            this.endLabel.TabIndex = 55;
            this.endLabel.Text = "End";
            // 
            // viewSelectedDatesButton
            // 
            this.viewSelectedDatesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewSelectedDatesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.viewSelectedDatesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewSelectedDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedDatesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.viewSelectedDatesButton.Location = new System.Drawing.Point(408, 560);
            this.viewSelectedDatesButton.Name = "viewSelectedDatesButton";
            this.viewSelectedDatesButton.Size = new System.Drawing.Size(257, 61);
            this.viewSelectedDatesButton.TabIndex = 57;
            this.viewSelectedDatesButton.Text = "View Selected Dates";
            this.viewSelectedDatesButton.UseVisualStyleBackColor = true;
            this.viewSelectedDatesButton.Click += new System.EventHandler(this.viewSelectedDatesButton_Click);
            // 
            // AppointmentsPerConsultantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 657);
            this.Controls.Add(this.viewSelectedDatesButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.appointmentsPerConsultantGridView);
            this.Controls.Add(this.appointmentsPerConsultantLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AppointmentsPerConsultantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments Per ConsultantForm";
            this.Load += new System.EventHandler(this.AppointmentsPerConsultantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsPerConsultantGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentsPerConsultantLabel;
        private System.Windows.Forms.DataGridView appointmentsPerConsultantGridView;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button viewSelectedDatesButton;
    }
}