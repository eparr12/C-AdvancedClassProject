
namespace GlobalConsultingUI
{
    partial class ConsultantScheduleForm
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
            this.consultantComboBox = new System.Windows.Forms.ComboBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.consultantLabel = new System.Windows.Forms.Label();
            this.consultantScheduleGridView = new System.Windows.Forms.DataGridView();
            this.consultantScheduleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultantScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultantComboBox
            // 
            this.consultantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultantComboBox.FormattingEnabled = true;
            this.consultantComboBox.Location = new System.Drawing.Point(597, 143);
            this.consultantComboBox.Name = "consultantComboBox";
            this.consultantComboBox.Size = new System.Drawing.Size(272, 38);
            this.consultantComboBox.TabIndex = 57;
            this.consultantComboBox.SelectedIndexChanged += new System.EventHandler(this.consultantComboBox_SelectedIndexChanged);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(507, 557);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(257, 61);
            this.homeButton.TabIndex = 56;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // consultantLabel
            // 
            this.consultantLabel.AutoSize = true;
            this.consultantLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantLabel.Location = new System.Drawing.Point(401, 140);
            this.consultantLabel.Name = "consultantLabel";
            this.consultantLabel.Size = new System.Drawing.Size(145, 37);
            this.consultantLabel.TabIndex = 55;
            this.consultantLabel.Text = "Consultant";
            // 
            // consultantScheduleGridView
            // 
            this.consultantScheduleGridView.AllowUserToAddRows = false;
            this.consultantScheduleGridView.AllowUserToDeleteRows = false;
            this.consultantScheduleGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.consultantScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultantScheduleGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.consultantScheduleGridView.Location = new System.Drawing.Point(60, 208);
            this.consultantScheduleGridView.MultiSelect = false;
            this.consultantScheduleGridView.Name = "consultantScheduleGridView";
            this.consultantScheduleGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantScheduleGridView.Size = new System.Drawing.Size(1150, 284);
            this.consultantScheduleGridView.TabIndex = 54;
            // 
            // consultantScheduleLabel
            // 
            this.consultantScheduleLabel.AutoSize = true;
            this.consultantScheduleLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantScheduleLabel.Location = new System.Drawing.Point(466, 33);
            this.consultantScheduleLabel.Name = "consultantScheduleLabel";
            this.consultantScheduleLabel.Size = new System.Drawing.Size(339, 50);
            this.consultantScheduleLabel.TabIndex = 53;
            this.consultantScheduleLabel.Text = "Consultant Schedule";
            // 
            // ConsultantScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 669);
            this.Controls.Add(this.consultantComboBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.consultantLabel);
            this.Controls.Add(this.consultantScheduleGridView);
            this.Controls.Add(this.consultantScheduleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ConsultantScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultant Schedule";
            this.Load += new System.EventHandler(this.ConsultantScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultantScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox consultantComboBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label consultantLabel;
        private System.Windows.Forms.DataGridView consultantScheduleGridView;
        private System.Windows.Forms.Label consultantScheduleLabel;
    }
}