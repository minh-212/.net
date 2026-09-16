using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bt4._2
{
    public partial class Form1 : Form
    {
        public class Course
        {
            public string CourseId { get; set; }
            public string CourseName { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            SetupControls();
            BindCourseData();
        }

        private void SetupControls()
        {
            mtxtPhone.Mask = "(000) 000-0000";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
        }

        private void BindCourseData()
        {
            List<Course> courses = new List<Course>
            {
                new Course { CourseId = "C01", CourseName = "Lap trinh C#" },
                new Course { CourseId = "C02", CourseName = "Lap trinh Web" },
                new Course { CourseId = "C03", CourseName = "Co so du lieu" },
                new Course { CourseId = "C04", CourseName = "Mang may tinh" }
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseId";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string courseName = cboCourse.Text;
            string courseId = cboCourse.SelectedValue?.ToString() ?? string.Empty;
            string gender = rdoMale.Checked ? "Nam" : (rdoFemale.Checked ? "Nu" : "Chua chon");

            string message = $"Thong tin dang ky:\n\n" +
                             $"- So dien thoai: {phone}\n" +
                             $"- Ngay sinh: {birthDate}\n" +
                             $"- Khoa hoc: {courseName} (Ma: {courseId})\n" +
                             $"- Gioi tinh: {gender}";

            MessageBox.Show(message, "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}