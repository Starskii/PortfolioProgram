namespace Portfolio
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnLaunch = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.ComboBox();
            this.lblSelectedExe = new System.Windows.Forms.Label();
            this.tabControlMainScreen = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.homeText2 = new System.Windows.Forms.TextBox();
            this.homeText1 = new System.Windows.Forms.TextBox();
            this.ProgramList = new System.Windows.Forms.TabPage();
            this.programListTextBox = new System.Windows.Forms.TextBox();
            this.AboutMe = new System.Windows.Forms.TabPage();
            this.aboutMeTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControlMainScreen.SuspendLayout();
            this.Home.SuspendLayout();
            this.ProgramList.SuspendLayout();
            this.AboutMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(6, 6);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // selectFile
            // 
            this.selectFile.FormattingEnabled = true;
            this.selectFile.Items.AddRange(new object[] {
            "Calculator",
            "listPractice",
            "switchStatement",
            "IamBroken"});
            this.selectFile.Location = new System.Drawing.Point(87, 8);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(121, 21);
            this.selectFile.TabIndex = 1;
            this.selectFile.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelectedExe
            // 
            this.lblSelectedExe.AutoSize = true;
            this.lblSelectedExe.Location = new System.Drawing.Point(3, 46);
            this.lblSelectedExe.Name = "lblSelectedExe";
            this.lblSelectedExe.Size = new System.Drawing.Size(111, 13);
            this.lblSelectedExe.TabIndex = 2;
            this.lblSelectedExe.Text = "Selected File: (NONE)";
            // 
            // tabControlMainScreen
            // 
            this.tabControlMainScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMainScreen.Controls.Add(this.Home);
            this.tabControlMainScreen.Controls.Add(this.ProgramList);
            this.tabControlMainScreen.Controls.Add(this.AboutMe);
            this.tabControlMainScreen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControlMainScreen.Location = new System.Drawing.Point(-2, 3);
            this.tabControlMainScreen.Name = "tabControlMainScreen";
            this.tabControlMainScreen.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMainScreen.SelectedIndex = 0;
            this.tabControlMainScreen.Size = new System.Drawing.Size(370, 342);
            this.tabControlMainScreen.TabIndex = 3;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.homeText2);
            this.Home.Controls.Add(this.homeText1);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(362, 316);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // homeText2
            // 
            this.homeText2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.homeText2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homeText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.homeText2.Location = new System.Drawing.Point(3, 152);
            this.homeText2.Multiline = true;
            this.homeText2.Name = "homeText2";
            this.homeText2.ReadOnly = true;
            this.homeText2.Size = new System.Drawing.Size(226, 161);
            this.homeText2.TabIndex = 4;
            this.homeText2.Text = "If you would like to know more about me, you can click on the \"About Me\" page.";
            // 
            // homeText1
            // 
            this.homeText1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.homeText1.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeText1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.homeText1.Location = new System.Drawing.Point(229, 3);
            this.homeText1.Multiline = true;
            this.homeText1.Name = "homeText1";
            this.homeText1.ReadOnly = true;
            this.homeText1.Size = new System.Drawing.Size(130, 310);
            this.homeText1.TabIndex = 3;
            this.homeText1.Text = "Hello, welcome to my Portfolio program. To Look at and launch previous projects t" +
    "hat I\'ve worked on you can select the \"Program List\" tab.";
            // 
            // ProgramList
            // 
            this.ProgramList.Controls.Add(this.pictureBox3);
            this.ProgramList.Controls.Add(this.programListTextBox);
            this.ProgramList.Controls.Add(this.lblSelectedExe);
            this.ProgramList.Controls.Add(this.selectFile);
            this.ProgramList.Controls.Add(this.btnLaunch);
            this.ProgramList.Location = new System.Drawing.Point(4, 22);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramList.Size = new System.Drawing.Size(362, 316);
            this.ProgramList.TabIndex = 1;
            this.ProgramList.Text = "Program List";
            this.ProgramList.UseVisualStyleBackColor = true;
            // 
            // programListTextBox
            // 
            this.programListTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.programListTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.programListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programListTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.programListTextBox.Location = new System.Drawing.Point(229, 3);
            this.programListTextBox.Multiline = true;
            this.programListTextBox.Name = "programListTextBox";
            this.programListTextBox.ReadOnly = true;
            this.programListTextBox.Size = new System.Drawing.Size(130, 310);
            this.programListTextBox.TabIndex = 4;
            this.programListTextBox.Text = "Program Description: ";
            // 
            // AboutMe
            // 
            this.AboutMe.Controls.Add(this.pictureBox2);
            this.AboutMe.Controls.Add(this.aboutMeTextBox);
            this.AboutMe.Location = new System.Drawing.Point(4, 22);
            this.AboutMe.Name = "AboutMe";
            this.AboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.AboutMe.Size = new System.Drawing.Size(362, 316);
            this.AboutMe.TabIndex = 2;
            this.AboutMe.Text = "About Me";
            this.AboutMe.UseVisualStyleBackColor = true;
            // 
            // aboutMeTextBox
            // 
            this.aboutMeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMeTextBox.Location = new System.Drawing.Point(144, 7);
            this.aboutMeTextBox.Name = "aboutMeTextBox";
            this.aboutMeTextBox.ReadOnly = true;
            this.aboutMeTextBox.Size = new System.Drawing.Size(212, 303);
            this.aboutMeTextBox.TabIndex = 1;
            this.aboutMeTextBox.Text = resources.GetString("aboutMeTextBox.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Portfolio.Properties.Resources.Welcome;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Portfolio.Properties.Resources.ProgramPic;
            this.pictureBox3.Location = new System.Drawing.Point(6, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 209);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Portfolio.Properties.Resources.Me;
            this.pictureBox2.Location = new System.Drawing.Point(6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.tabControlMainScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainScreen";
            this.Text = "[CIT] 110 Portfolio Captstone";
            this.tabControlMainScreen.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.ProgramList.ResumeLayout(false);
            this.ProgramList.PerformLayout();
            this.AboutMe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox selectFile;
        private System.Windows.Forms.Label lblSelectedExe;
        private System.Windows.Forms.TabControl tabControlMainScreen;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage ProgramList;
        private System.Windows.Forms.TabPage AboutMe;
        private System.Windows.Forms.TextBox homeText2;
        private System.Windows.Forms.TextBox homeText1;
        private System.Windows.Forms.RichTextBox aboutMeTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox programListTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

