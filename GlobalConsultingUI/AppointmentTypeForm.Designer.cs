
namespace GlobalConsultingUI
{
    partial class AppointmentTypeForm
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
            this.appointmentTypeByMonthLabel = new System.Windows.Forms.Label();
            this.appointmentTypeGridView = new System.Windows.Forms.DataGridView();
            this.monthLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentTypeByMonthLabel
            // 
            this.appointmentTypeByMonthLabel.AutoSize = true;
            this.appointmentTypeByMonthLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeByMonthLabel.Location = new System.Drawing.Point(48, 26);
            this.appointmentTypeByMonthLabel.Name = "appointmentTypeByMonthLabel";
            this.appointmentTypeByMonthLabel.Size = new System.Drawing.Size(470, 50);
            this.appointmentTypeByMonthLabel.TabIndex = 26;
            this.appointmentTypeByMonthLabel.Text = "Appointment Type By Month";
            // 
            // appointmentTypeGridView
            // 
            this.appointmentTypeGridView.AllowUserToAddRows = false;
            this.appointmentTypeGridView.AllowUserToDeleteRows = false;
            this.appointmentTypeGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.appointmentTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentTypeGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.appointmentTypeGridView.Location = new System.Drawing.Point(76, 201);
            this.appointmentTypeGridView.MultiSelect = false;
            this.appointmentTypeGridView.Name = "appointmentTypeGridView";
            this.appointmentTypeGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeGridView.Size = new System.Drawing.Size(414, 284);
            this.appointmentTypeGridView.TabIndex = 27;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(50, 133);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(96, 37);
            this.monthLabel.TabIndex = 49;
            this.monthLabel.Text = "Month";
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(155, 521);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 51;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(246, 136);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(272, 38);
            this.monthComboBox.TabIndex = 52;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // AppointmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 622);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.appointmentTypeGridView);
            this.Controls.Add(this.appointmentTypeByMonthLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AppointmentTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Type By Month";
            this.Load += new System.EventHandler(this.AppointmentTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentTypeByMonthLabel;
        private System.Windows.Forms.DataGridView appointmentTypeGridView;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ComboBox monthComboBox;
    }
}