using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEGP
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }

        private void l11_Click(object sender, EventArgs e)
        {
            
        }

        private void l1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.StudentDeatilsh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n On clicking student details, new frame renders having four buttons on top\r\n  named as year 1, year 2, year 3 and year 4.\r\n Clicking on year 1 button will show the stored data of all the students\r\n  studying in year one  along with their UOB’s, addresses, contact information etc.\r\n Similarly by clicking on any other button like Year2 or Year3 the software will show data of the students\r\n  who are currently enrolled in those years\r\n By clicking right Mouse you can send email , edit name of the student, delete name of the student etc";
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\nWhen system initializes, a software login page renders having  two text fields\r\n named as username and password.\r\nData provided by user in the text fields will be verified by the system\r\n and if it is correct system will allow him to access its resources\r\n otherwise message would pop up username or password is incorrect.";

            
             
        }

        private void l11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.StudentDeatilsh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n On clicking student details, new frame renders having four buttons on top\r\n  named as year 1, year 2, year 3 and year 4.\r\n Clicking on year 1 button will show the stored data of all the students\r\n  studying in year one  along with their UOB’s, addresses, contact information etc.\r\n Similarly by clicking on any other button like Year2 or Year3 the software will show data of the students\r\n  who are currently enrolled in those years\r\n By clicking right Mouse you can send email , edit name of the student, delete name of the student etc";
 
        }

        private void l12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.StudentDeatilsh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n On clicking student details, new frame renders having four buttons on top\r\n  named as year 1, year 2, year 3 and year 4.\r\n Clicking on year 1 button will show the stored data of all the students\r\n  studying in year one  along with their UOB’s, addresses, contact information etc.\r\n Similarly by clicking on any other button like Year2 or Year3 the software will show data of the students\r\n  who are currently enrolled in those years\r\n By clicking right Mouse you can send email , edit name of the student, delete name of the student etc";
 
        }

        private void l13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.StudentDeatilsh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n On clicking student details, new frame renders having four buttons on top\r\n  named as year 1, year 2, year 3 and year 4.\r\n Clicking on year 1 button will show the stored data of all the students\r\n  studying in year one  along with their UOB’s, addresses, contact information etc.\r\n Similarly by clicking on any other button like Year2 or Year3 the software will show data of the students\r\n  who are currently enrolled in those years\r\n By clicking right Mouse you can send email , edit name of the student, delete name of the student etc";
 
        }

        private void l14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.StudentDeatilsh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n On clicking student details, new frame renders having four buttons on top\r\n  named as year 1, year 2, year 3 and year 4.\r\n Clicking on year 1 button will show the stored data of all the students\r\n  studying in year one  along with their UOB’s, addresses, contact information etc.\r\n Similarly by clicking on any other button like Year2 or Year3 the software will show data of the students\r\n  who are currently enrolled in those years\r\n By clicking right Mouse you can send email , edit name of the student, delete name of the student etc";
 
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n Clicking on Teacher Details interface opens having two buttons at top right end labeled as partial load and full loads.After pressing partial load button, system  shows the data of all partial load teachers like their names, addresses and email etc.Clicking on full load button shall exactly access the data of full load teachers from database and show it in user interface.Right click Mouse gives the options of changing name address etc of the selected teacher as well as you ca delete teacher details you can insert functionality and you can also send the Mail to a paritcular teacher.";
            picture.Image = SEGP.Properties.Resources.TeacherDeatilsh;
        }

        private void l3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.EditInfoh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n 	When clicking the tile of edit data a new interface appears in which you can edit data. There are two buttons at top right one is named as “StudentEdit” and second is known as “TeacherEdit”. By clicking first button you can edit the data of any student whose data is already saved in database system. It will require UOB number to get all the data stored with respect to that UOB for example name,address,department etc. After editing required information you have to click enter button and new changes will be saved in the database system.By clicking second button known as “TeacherEdit” you can edit the data of any teacher whose data is already saved in database system. You have to provide name of the teacher in Teacher name text sheet and all the data of that teacher will appear on screen for example name,address,email,qualification etc.You can also edit infornmation of sudents and teachers form students and teacher details by right clicking the selected teacher or student.";
        }

        private void l31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.EditInfoh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n 	When clicking the tile of edit data a new interface appears in which you can edit data. There are two buttons at top right one is named as “StudentEdit” and second is known as “TeacherEdit”. By clicking first button you can edit the data of any student whose data is already saved in database system. It will require UOB number to get all the data stored with respect to that UOB for example name,address,department etc. After editing required information you have to click enter button and new changes will be saved in the database system.By clicking second button known as “TeacherEdit” you can edit the data of any teacher whose data is already saved in database system. You have to provide name of the teacher in Teacher name text sheet and all the data of that teacher will appear on screen for example name,address,email,qualification etc.You can also edit infornmation of sudents and teachers form students and teacher details by right clicking the selected teacher or student.";
  
        }

        private void l32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.EditInfoh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n 	When clicking the tile of edit data a new interface appears in which you can edit data. There are two buttons at top right one is named as “StudentEdit” and second is known as “TeacherEdit”. By clicking first button you can edit the data of any student whose data is already saved in database system. It will require UOB number to get all the data stored with respect to that UOB for example name,address,department etc. After editing required information you have to click enter button and new changes will be saved in the database system.By clicking second button known as “TeacherEdit” you can edit the data of any teacher whose data is already saved in database system. You have to provide name of the teacher in Teacher name text sheet and all the data of that teacher will appear on screen for example name,address,email,qualification etc.You can also edit infornmation of sudents and teachers form students and teacher details by right clicking the selected teacher or student.";
  
        }

        private void l4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.InsertDatah;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n	If you want to add data of any new student or new teacher which was left unintentionally or intentionally, you have to click on Insert data tile. There are two buttons at top of the interface of insert data i.e Insert teacher for inserting a data of teacher and insert students for inserting data for student. you have to fill the required information in student or teacher text boxes and click the save button to save the content.Uploading file option is also availabe in case when you have to insert an xls file for teachers or students information for example a new badge comes in and you have to save it in the data base.";

        }

        private void l41_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.InsertManuallyh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n	If you want to add data of any new student or new teacher which was left unintentionally or intentionally, you have to click on Insert data tile. There are two buttons at top of the interface of insert data i.e Insert teacher for inserting a data of teacher and insert students for inserting data for student. you have to fill the required information in student or teacher text boxes and click the save button to save the content.Uploading file option is also availabe in case when you have to insert an xls file for teachers or students information for example a new badge comes in and you have to save it in the data base.";

        }

        private void l42_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.InsertManuallyh;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n	If you want to add data of any new student or new teacher which was left unintentionally or intentionally, you have to click on Insert data tile. There are two buttons at top of the interface of insert data i.e Insert teacher for inserting a data of teacher and insert students for inserting data for student. you have to fill the required information in student or teacher text boxes and click the save button to save the content.Uploading file option is also availabe in case when you have to insert an xls file for teachers or students information for example a new badge comes in and you have to save it in the data base.";

        }

        private void l43_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.InsertDatah;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n	If you want to add data of any new student or new teacher which was left unintentionally or intentionally, you have to click on Insert data tile. There are two buttons at top of the interface of insert data i.e Insert teacher for inserting a data of teacher and insert students for inserting data for student. you have to fill the required information in student or teacher text boxes and click the save button to save the content.Uploading file option is also availabe in case when you have to insert an xls file for teachers or students information for example a new badge comes in and you have to save it in the data base.All you have to do is to click the browse button which will let you to select the file you want to to be inserted";

        }

        private void l44_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.InsertDatah;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n	If you want to add data of any new student or new teacher which was left unintentionally or intentionally, you have to click on Insert data tile. There are two buttons at top of the interface of insert data i.e Insert teacher for inserting a data of teacher and insert students for inserting data for student. you have to fill the required information in student or teacher text boxes and click the save button to save the content.Uploading file option is also availabe in case when you have to insert an xls file for teachers or students information for example a new badge comes in and you have to save it in the data base.";

        }

        private void l5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.Image = SEGP.Properties.Resources.MailPopUph;
            text.Text = "\r\n\r\n\r\n\r\n\r\n\r\n If you want to send email to any person you can select tile named as mail. After clicking new interface will appear in which there are three text fields.In “To” text field you have to write the email to whom you are sending. “Subject” is used to specify the subject of email and at the end message box you have to write the message you want to deliver. Email functionality is also available in teacher or students details portion by right clicking on the selected entity you can send email directly.";
        }
    }
}
