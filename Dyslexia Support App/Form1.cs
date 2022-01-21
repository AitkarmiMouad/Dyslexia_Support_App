using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;
using System.Speech;
using System.IO;


namespace Dyslexia_Support_App
{

    public partial class Form1 : Form
    {
        // Variables declaration
        SpeechSynthesizer speech;
        private string UserId;
        AccessPage accessPage;
        bool blancFields;
        bool state = true;


        public Form1()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        // Function To generate a Global Unique Id used to identify each user with a unique id
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        // Function to save the input text in a file
        private void SaveFormatedText()
        {
            // Errors Handling
            try
            {

                // get user directory path
                string path = Directory.GetCurrentDirectory() + "\\" + UserId;

                // If directory does not exist, create it
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Create a file and write the input text in the file
                using (StreamWriter sw = File.AppendText(path + "\\file-" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt"))
                {
                    sw.WriteLine(inputTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // Button click event to format the given input
        private void FormatButton_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {
                string res = Regex.Replace(inputTextBox.Text, " ", "     ").Trim();
                outputTextBox.Text = res.ToUpper();

                // calling the SaveFormatedText function
                SaveFormatedText();
                // calling the LoadFilesIntoGrid function
                LoadFilesIntoGrid();

            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // Button click event to read the input
        private void SpeakButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text != "")
            {
                // select the english Lauguage Voice
                speech.SelectVoice("Microsoft Zira Desktop");
                speech.SpeakAsync(inputTextBox.Text);

                // calling the SaveFormatedText function
                SaveFormatedText();
                // calling the LoadFilesIntoGrid function
                LoadFilesIntoGrid();
            }
        }

        // Button click event to pause the reading
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        // Button click event to resume the reading
        private void ResumeButton_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }
        }

        // Function To change the interface in Home TabPage between the Login and Register interface based on state
        private void Login_Register(bool s)
        {
            // Errors Handling
            try
            {

                if (s)
                {
                    label4.Visible = false;
                    confirmpasstxtbx.Visible = false;
                    LogButton.Text = "Log In";
                    label5.Text = "don’t have an account?";
                    logInHomeLabel.Text = "Register";

                    // readjust position of the controls 
                    label2.Top += 20;
                    label3.Top += 20;
                    usernametxtbx.Top += 20;
                    passwordtextbox.Top += 20;

                    // initialize the state variable
                    state = false;
                }
                else
                {
                    label4.Visible = true;
                    confirmpasstxtbx.Visible = true;
                    LogButton.Text = "Register";
                    label5.Text = "already have an account?";
                    logInHomeLabel.Text = "Log In";

                    // readjust position of the controls
                    label2.Top -= 20;
                    label3.Top -= 20;
                    usernametxtbx.Top -= 20;
                    passwordtextbox.Top -= 20;

                    // initialize the state variable
                    state = true;
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // Function to clear all textBoxes of a given Control
        private void ClearTxtbxFields(Control p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        // Label click event to change between the Login and Register Interfaces
        private void logInHomeLabel_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {
                errorProvider1.Clear();

                // calling the Login_Register
                Login_Register(state);
                // calling the ClearTxtbxFields
                ClearTxtbxFields(tabPage1);

            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // Register Function
        private void Register()
        {
            // Get users.txt file path
            string path = Directory.GetCurrentDirectory() + "\\users.txt";

            errorProvider1.Clear();

            // Confirmation Password
            if (passwordtextbox.Text == confirmpasstxtbx.Text)
            {

                // Loop Home TabPage Controls to check any existing blanc fields and set an error  
                foreach (Control c in panel2.Controls)
                {
                    if (c is TextBox && c.Text == "")
                    {
                        errorProvider1.SetError(c, "Please Fill the field");
                        blancFields = true;
                    }
                }
                // RollBack the function if there's any blanc field left
                if (blancFields == true) return;

                // Write in users.txt file or create if not exist
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(generateID() + ";" + usernametxtbx.Text.Trim() + ";" + passwordtextbox.Text.Trim());

                    // Success Message
                    MessageBox.Show("registered successfully");


                }
                // calling the ClearTxtbxFields
                ClearTxtbxFields(panel2);
            }
            else
            {
                // raise Error
                errorProvider1.SetError(confirmpasstxtbx, "Password Does Not Match");
            }
        }

        // LogIn Function
        private void LogIn()
        {
            // Get user directory path
            string path = Directory.GetCurrentDirectory() + "\\users.txt";

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    // Compare between the given Login and the existing Logins in the file
                    if ((line.Split(';')[1] == usernametxtbx.Text.Trim()) && (line.Split(';')[2] == passwordtextbox.Text.Trim()))
                    {
                        // initialize the UserId variable
                        UserId = line.Split(';')[0];

                        // Calling AccessCheck function
                        AccessCheck(tabPage3);
                        AccessCheck(tabPage4);
                        AccessCheck(tabPage5);

                        // Calling LoadFilesIntoGrid function
                        LoadFilesIntoGrid();

                        // Load the TextBoxes in Account TabPage
                        userNameTxtbxAccount.Text = line.Split(';')[1];
                        passwordTxtBxAccount.Text = line.Split(';')[2];

                        // Success Message
                        MessageBox.Show("logged in successfully");

                        // calling the ClearTxtbxFields
                        ClearTxtbxFields(panel2);
                        return;

                    }

                }
            }
            MessageBox.Show("username or password incorrect, Please try again");
        }

        // Button click event to LogIn or Register
        private void LogButton_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                // variable to handle any blanc field
                blancFields = false;

                // Toogle between the LogIn or Register options based on the state of button
                if (state)
                {
                    Register();
                }
                else
                {
                    LogIn();
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // userControl label Click event
        void UserControl_ButtonClick(object sender, EventArgs e)
        {
            // Select the Home Tab Page
            tabControl1.SelectedTab = tabPage1;
        }

        // function to check if UserID of this session is valid
        private void AccessCheck(TabPage p)
        {
            // Errors Handling
            try
            {

                if (UserId == null)
                {
                    // initialize UserControl 
                    accessPage = new AccessPage();
                    accessPage.Dock = DockStyle.Fill;
                    // Add the UserControl in The TabPage
                    p.Controls.Add(accessPage);
                    accessPage.BringToFront();

                    // Add a click event for the returnToHome label in order to return to the home tabPage
                    accessPage.Controls["panel1"].Controls["label1"].Click += new System.EventHandler(this.UserControl_ButtonClick);
                }
                else
                {
                    // Remove the UserControl From the TabPage if UserId is valid
                    foreach (Control c in p.Controls)
                    {
                        if (c is AccessPage) p.Controls.Remove(c);
                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // function to load files of a user into a datagridview
        private void LoadFilesIntoGrid()
        {
            // Errors Handling
            try
            {

                // get user directory path
                string path = Directory.GetCurrentDirectory() + "\\" + UserId;

                // load the files into an array
                string[] files = Directory.GetFiles(path);

                // fill datable with the data of the array 
                DataTable dt = new DataTable();
                dt.Columns.Add("FileName");
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo f = new FileInfo(files[i]);
                    dt.Rows.Add(f.Name);
                }

                // initialize DataSource of the datagridview
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                //MessageBox.Show(ex.Message);
            }

        }

        // Button click event to refresh the datagridview Data
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                // Calling LoadFilesIntoGrid function
                LoadFilesIntoGrid();
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Errors Handling
            try
            {

                // path of selected file
                string path = Directory.GetCurrentDirectory() + "\\" + UserId + "\\" + dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                // Open the selected file from datagridview
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // Button click event to LogOut
        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                // UserId variable initialization
                UserId = null;

                // Calling AccessCheck function
                AccessCheck(tabPage3);
                AccessCheck(tabPage4);
                AccessCheck(tabPage5);
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                // UserId variable initialization
                UserId = null;

                // Calling AccessCheck function
                AccessCheck(tabPage3);
                AccessCheck(tabPage4);
                AccessCheck(tabPage5);
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        // click event to chow or hide password in account tab page
        private void ShowHidePassword_Click(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                if (passwordTxtBxAccount.PasswordChar == '●')
                {
                    passwordTxtBxAccount.PasswordChar = '\0';
                }
                else
                {
                    passwordTxtBxAccount.PasswordChar = '●';
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Errors Handling
            try
            {

                // To keep Home tab page Controls centered  
                panel2.Location = new Point(this.ClientSize.Width / 2 - panel2.Size.Width / 2, this.ClientSize.Height / 2 - panel2.Size.Height / 2);
                panel2.Anchor = AnchorStyles.None;
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
