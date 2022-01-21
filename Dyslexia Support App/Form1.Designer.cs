namespace Dyslexia_Support_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logInHomeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.confirmpasstxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.FormatButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.SpeakButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.passwordTxtBxAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userNameTxtbxAccount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logInHomeLabel
            // 
            this.logInHomeLabel.AutoSize = true;
            this.logInHomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInHomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logInHomeLabel.Location = new System.Drawing.Point(493, 376);
            this.logInHomeLabel.Name = "logInHomeLabel";
            this.logInHomeLabel.Size = new System.Drawing.Size(85, 29);
            this.logInHomeLabel.TabIndex = 10;
            this.logInHomeLabel.Text = "Log In";
            this.logInHomeLabel.Click += new System.EventHandler(this.logInHomeLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(250, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account ? ";
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.LogButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(304, 298);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(220, 54);
            this.LogButton.TabIndex = 8;
            this.LogButton.Text = "Register";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // confirmpasstxtbx
            // 
            this.confirmpasstxtbx.Location = new System.Drawing.Point(378, 215);
            this.confirmpasstxtbx.Name = "confirmpasstxtbx";
            this.confirmpasstxtbx.PasswordChar = '●';
            this.confirmpasstxtbx.Size = new System.Drawing.Size(314, 34);
            this.confirmpasstxtbx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm password :";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(378, 165);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '●';
            this.passwordtextbox.Size = new System.Drawing.Size(314, 34);
            this.passwordtextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter password  :";
            // 
            // usernametxtbx
            // 
            this.usernametxtbx.Location = new System.Drawing.Point(378, 115);
            this.usernametxtbx.Name = "usernametxtbx";
            this.usernametxtbx.Size = new System.Drawing.Size(314, 34);
            this.usernametxtbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the dyslexia support app";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Who are we?";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 538);
            this.panel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.outputTextBox);
            this.tabPage3.Controls.Add(this.FormatButton);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.ResumeButton);
            this.tabPage3.Controls.Add(this.PauseButton);
            this.tabPage3.Controls.Add(this.SpeakButton);
            this.tabPage3.Controls.Add(this.inputTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1016, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Services";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(33, 319);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(963, 217);
            this.outputTextBox.TabIndex = 18;
            this.outputTextBox.Text = "";
            // 
            // FormatButton
            // 
            this.FormatButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FormatButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FormatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormatButton.ForeColor = System.Drawing.Color.White;
            this.FormatButton.Location = new System.Drawing.Point(33, 268);
            this.FormatButton.Name = "FormatButton";
            this.FormatButton.Size = new System.Drawing.Size(221, 45);
            this.FormatButton.TabIndex = 17;
            this.FormatButton.Text = "Format my text ";
            this.FormatButton.UseVisualStyleBackColor = false;
            this.FormatButton.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter your text here";
            // 
            // ResumeButton
            // 
            this.ResumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResumeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ResumeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResumeButton.ForeColor = System.Drawing.Color.White;
            this.ResumeButton.Location = new System.Drawing.Point(838, 163);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(158, 55);
            this.ResumeButton.TabIndex = 12;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = false;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.PauseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.ForeColor = System.Drawing.Color.White;
            this.PauseButton.Location = new System.Drawing.Point(838, 102);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(158, 55);
            this.PauseButton.TabIndex = 13;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // SpeakButton
            // 
            this.SpeakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeakButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SpeakButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SpeakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeakButton.ForeColor = System.Drawing.Color.White;
            this.SpeakButton.Location = new System.Drawing.Point(838, 41);
            this.SpeakButton.Name = "SpeakButton";
            this.SpeakButton.Size = new System.Drawing.Size(158, 55);
            this.SpeakButton.TabIndex = 14;
            this.SpeakButton.Text = "Speak";
            this.SpeakButton.UseVisualStyleBackColor = false;
            this.SpeakButton.Click += new System.EventHandler(this.SpeakButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(33, 41);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(799, 221);
            this.inputTextBox.TabIndex = 11;
            this.inputTextBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.refreshButton);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1016, 544);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "My Files";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(852, 17);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(155, 45);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.logOutButton);
            this.tabPage5.Controls.Add(this.passwordTxtBxAccount);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.userNameTxtbxAccount);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1016, 544);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "My account";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(709, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Show/Hide";
            this.label10.Click += new System.EventHandler(this.ShowHidePassword_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(408, 312);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(201, 55);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // passwordTxtBxAccount
            // 
            this.passwordTxtBxAccount.Location = new System.Drawing.Point(387, 167);
            this.passwordTxtBxAccount.Name = "passwordTxtBxAccount";
            this.passwordTxtBxAccount.PasswordChar = '●';
            this.passwordTxtBxAccount.ReadOnly = true;
            this.passwordTxtBxAccount.Size = new System.Drawing.Size(316, 34);
            this.passwordTxtBxAccount.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "password :";
            // 
            // userNameTxtbxAccount
            // 
            this.userNameTxtbxAccount.Location = new System.Drawing.Point(387, 111);
            this.userNameTxtbxAccount.Name = "userNameTxtbxAccount";
            this.userNameTxtbxAccount.ReadOnly = true;
            this.userNameTxtbxAccount.Size = new System.Drawing.Size(316, 34);
            this.userNameTxtbxAccount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "username :";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 38);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1016, 544);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Help";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogButton);
            this.panel2.Controls.Add(this.logInHomeLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.usernametxtbx);
            this.panel2.Controls.Add(this.confirmpasstxtbx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passwordtextbox);
            this.panel2.Location = new System.Drawing.Point(91, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 440);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 586);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label logInHomeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox confirmpasstxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox passwordTxtBxAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userNameTxtbxAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button FormatButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResumeButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button SpeakButton;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
    }
}

