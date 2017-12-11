using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Portfolio
{

        #region FileName Enum Options
    public enum FileName
        {
            switchStatement,
            Calculator,
            IamBroken,
            listPractice,
    }
    #endregion

    public partial class MainScreen : Form
    {
        #region Declaration
        FileName selectedFileName;
        InitializeData dataInitializer = new InitializeData();
        ProjectExecutables ActiveObject = new ProjectExecutables();
        #endregion

        #region MainScreenInitialization
        public MainScreen()
        {
            InitializeComponent();
           // homeText1.BorderStyle = BorderStyle.FixedSingle;
           // homeText2.BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion

        #region ProgramSelection
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSelectedProgram();
        }
        public void ChangeSelectedProgram()
        {
            Enum.TryParse<FileName>(selectFile.Text, out selectedFileName);
            ActiveObject = dataInitializer.FindActiveObject(selectedFileName);
            ChangeUI();
        }
        public void ChangeUI()
        {
            lblSelectedExe.Text = ("Selected File: " + ActiveObject.FileName);
            programListTextBox.Text = ("Program Description: " + ActiveObject.FileDescription);
        }
        #endregion

        #region ProgramLaunch
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            LaunchProgram();
        }
        public void LaunchProgram()
        {
            try
            {
                Process.Start(CheckPath());
            }
            catch
            {
                MessageBox.Show("404: File Not Found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string CheckPath()
        {
            string path = "";

            path = ActiveObject.FilePath;

            return path;
        }
        #endregion
    }
}
