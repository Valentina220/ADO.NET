namespace CourseManager
{
    partial class CourseViewer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.saveChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewOfficesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.Location = new System.Drawing.Point(12, 25);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(185, 21);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentLis_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(191, 465);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(185, 36);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(228, 25);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.Size = new System.Drawing.Size(328, 160);
            this.courseGridView.TabIndex = 2;
            // 
            // saveChange
            // 
            this.saveChange.Location = new System.Drawing.Point(12, 81);
            this.saveChange.Name = "saveChange";
            this.saveChange.Size = new System.Drawing.Size(185, 36);
            this.saveChange.TabIndex = 3;
            this.saveChange.Text = "Обновить";
            this.saveChange.UseVisualStyleBackColor = true;
            this.saveChange.Click += new System.EventHandler(this.saveChange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 244);
            this.dataGridView1.TabIndex = 4;
            // 
            // viewOfficesButton
            // 
            this.viewOfficesButton.Location = new System.Drawing.Point(12, 149);
            this.viewOfficesButton.Name = "viewOfficesButton";
            this.viewOfficesButton.Size = new System.Drawing.Size(185, 36);
            this.viewOfficesButton.TabIndex = 5;
            this.viewOfficesButton.Text = "View Offices";
            this.viewOfficesButton.UseVisualStyleBackColor = true;
            this.viewOfficesButton.Click += new System.EventHandler(this.viewOfficesButton_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 517);
            this.Controls.Add(this.viewOfficesButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveChange);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.departmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button saveChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewOfficesButton;
    }
}

