﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CourseManager
{
    public partial class CourseViewer : Form
    {
        public CourseViewer()
        {
            InitializeComponent();
        }

        private SchoolEntities schoolContext;

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();

            var departments = 
                from d in schoolContext.Departments.Include("Courses")
                orderby d.Name
                select d;

            try
            {
                this.departmentList.DisplayMember = "Name";
                this.departmentList.DataSource = departments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = schoolContext.Courses.Local.ToBindingList();
        }

        private void departmentLis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department department = (Department)this.departmentList.SelectedItem;
                courseGridView.DataSource = department.Courses.ToList();
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;
                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChange_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
            schoolContext.Dispose();
        }

        private void viewOfficesButton_Click(object sender, EventArgs e)
        {
            OfficeAssignment officeForm = new OfficeAssignment();
            officeForm.Visible = true;
        }
    }
}