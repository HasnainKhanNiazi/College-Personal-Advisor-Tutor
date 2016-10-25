using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEGP
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
            
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == year2Document)
                e.Control = new SEGP.Year2();
            if (e.Document == year1Document)
                e.Control = new SEGP.Year1();
            if (e.Document == year4Document)
                e.Control = new SEGP.Year4();
            if (e.Document == year3Document)
                e.Control = new SEGP.Year3();
            if (e.Document == sendMailDocument)
                e.Control = new SEGP.SendMail();
            if (e.Document == partialTeacherDocument)
                e.Control = new SEGP.PartialTeacher();
            if (e.Document == fullLoadDocument)
                e.Control = new SEGP.FullLoad();
            if (e.Document == teacherEditDocument)
                e.Control = new SEGP.TeacherEdit();
            if (e.Document == studentEditDocument)
                e.Control = new SEGP.StudentEdit();
            if (e.Document == insertStudentsDocument)
                e.Control = new SEGP.InsertStudents();
            if (e.Document == insertTeachersDocument)
                e.Control = new SEGP.InsertTeachers();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
