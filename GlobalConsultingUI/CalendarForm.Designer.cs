
namespace GlobalConsultingUI
{
    partial class CalendarForm
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
            this.calendarLabel = new System.Windows.Forms.Label();
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.viewSelectedDatesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(525, 25);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(161, 50);
            this.calendarLabel.TabIndex = 25;
            this.calendarLabel.Text = "Calendar";
            // 
            // calendarGridView
            // 
            this.calendarGridView.AllowUserToAddRows = false;
            this.calendarGridView.AllowUserToDeleteRows = false;
            this.calendarGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.calendarGridView.Location = new System.Drawing.Point(57, 195);
            this.calendarGridView.MultiSelect = false;
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarGridView.Size = new System.Drawing.Size(1150, 284);
            this.calendarGridView.TabIndex = 26;
            // 
            // viewAllButton
            // 
            this.viewAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.viewAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllButton.Location = new System.Drawing.Point(325, 528);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(257, 61);
            this.viewAllButton.TabIndex = 41;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // viewSelectedDatesButton
            // 
            this.viewSelectedDatesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewSelectedDatesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.viewSelectedDatesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewSelectedDatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedDatesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSelectedDatesButton.Location = new System.Drawing.Point(689, 528);
            this.viewSelectedDatesButton.Name = "viewSelectedDatesButton";
            this.viewSelectedDatesButton.Size = new System.Drawing.Size(257, 61);
            this.viewSelectedDatesButton.TabIndex = 42;
            this.viewSelectedDatesButton.Text = "View Selected Dates";
            this.viewSelectedDatesButton.UseVisualStyleBackColor = true;
            this.viewSelectedDatesButton.Click += new System.EventHandler(this.viewSelectedDatesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(507, 633);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 43;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(831, 116);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(272, 35);
            this.endDatePicker.TabIndex = 51;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(325, 116);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(272, 35);
            this.startDatePicker.TabIndex = 50;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(689, 114);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(62, 37);
            this.endLabel.TabIndex = 49;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(174, 114);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(71, 37);
            this.startLabel.TabIndex = 48;
            this.startLabel.Text = "Start";
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 737);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.viewSelectedDatesButton);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.calendarGridView);
            this.Controls.Add(this.calendarLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.DataGridView calendarGridView;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button viewSelectedDatesButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
    }
}