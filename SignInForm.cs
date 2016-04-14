using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Threading;


namespace CoLabSignIn {
    public partial class SignInForm : Form {
        // enter a custom path or the path will default to directory that the exe is run from
        string path;
        // found in the slack web api page (https://api.slack.com/web)
        string slackAuthToken = "xoxs-7742096768-11388699776-15082752321-d77c142de7";
        // your slack address (e.g. https://colabjax.slack.com)
        string slackAddress = "https://colabjax.slack.com";
        public SignInForm() {
            InitializeComponent();
            this.Controls.Add(this.MainPanel);
            this.GoFullscreen();
            string appPath = Application.StartupPath;
            if (path != null) {
                path = $"{appPath}\\Signups{DateTime.Now.ToShortDateString()}.csv";
            }            
            if (!File.Exists(path)) {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path)) {
                    tw.WriteLine("Email,FirstName,LastName");
                    tw.Close();
                }
            }
        }

        private void MainPanel_SizeChanged(object sender, EventArgs e) {
            MainPanel.Left = (this.ClientSize.Width - MainPanel.Width) / 2;
            MainPanel.Top = (this.ClientSize.Height - MainPanel.Height) / 2;
        }

        private void bSubmit_MouseClick(object sender, MouseEventArgs e, bool logToExcel = true) {
            tbEmailField_Leave(null, null);
            tbLastNameField_Leave(null, null);
            tbFirstName_Leave(null, null);

            if (isReadyToSave) {
                // add name to the csv
                if (logToExcel) {
                    try {
                        using (TextWriter tw = new StreamWriter(path, true)) {
                            tw.WriteLine($"{emailString},{firstName},{lastName}");
                            tw.Close();
                        }
                    }
                    catch {
                        if (DialogResult.Retry == MessageBox.Show("Please close the signins csv file or open in 'read only' mode, cannot save to open file", "Error writing to file", MessageBoxButtons.RetryCancel)) {
                            bSubmit_MouseClick(null, null);
                        }
                    }
                }

                try {
                    // handle slack invite
                    Uri target = new Uri($@"{slackAddress}/api/users.admin.invite?t={(int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds}");
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(target);
                    var postData = $@"email={HttpUtility.UrlPathEncode(emailString.Replace("@", "%40"))}&channels=C0BGZEXC0%2CC07MUKEHK&extra_message={HttpUtility.UrlPathEncode("Slack is how the CoLabJax community communicates. Please create an account and join the conversation.")}&first_name={HttpUtility.UrlPathEncode(firstName)}&last_name={HttpUtility.UrlPathEncode(lastName)}&token={slackAuthToken}&set_active=true&_attempts=1";
                    var data = Encoding.ASCII.GetBytes(postData);

                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.Accept = "*/*";
                    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.103 Safari/537.36";
                    request.ContentLength = data.Length;
                    request.Headers.Add("Accept-Encoding: gzip, deflate");
                    request.Headers.Add("Accept-Language: en-US,en;q=0.8");

                    using (var stream = request.GetRequestStream()) {
                        stream.Write(data, 0, data.Length);
                    }

                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }
                catch {
                    if (DialogResult.Retry == MessageBox.Show("Please check your internet connection to continue", "Error submitting information to slack", MessageBoxButtons.RetryCancel)) {
                        // retry but don't log to excel
                        bSubmit_MouseClick(null, null, false);
                    }
                }

                this.showThankYouMessage();
            }
        }

        public async void showThankYouMessage() {
            this.lblEmailError.Visible = false;
            this.lblFirstNameError.Visible = false;
            this.lblLastNameError.Visible = false;
            this.tbEmailField.Visible = false;
            this.tbFirstNameField.Visible = false;
            this.tbLastNameField.Visible = false;
            this.bSubmit.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;

            this.lblThanks.Visible = true;
            Task taskList = Task.Run(() => {
                Thread.Sleep(2500);
            });

            await Task.WhenAll(taskList);

            this.lblEmailError.Visible = false;
            this.lblFirstNameError.Visible = false;
            this.lblLastNameError.Visible = false;
            this.tbEmailField.Visible = true;
            this.tbFirstNameField.Visible = true;
            this.tbLastNameField.Visible = true;
            this.bSubmit.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;

            this.tbEmailField.Text = "";
            this.tbFirstNameField.Text = "";
            this.tbLastNameField.Text = "";
            this.tbEmailField.Focus();

            this.lblThanks.Visible = false;
        }

        string emailString;
        private void tbEmailField_Leave(object sender, EventArgs e) {
            char[] arr = tbEmailField.Text.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-'
                                              || c == '@'
                                              || c == '.')));
            emailString = new string(arr);
            lblEmailError.Visible = !Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (tbEmailField.Text.Length == 0 && tbLastNameField.Text.Length == 0 && tbFirstNameField.Text.Length == 0) {
                lblFirstNameError.Visible = false;
                lblEmailError.Visible = false;
                lblLastNameError.Visible = false;
            }
        }

        string firstName;
        private void tbFirstName_Leave(object sender, EventArgs e) {
            char[] arr = tbFirstNameField.Text.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-'
                                              || c == '@'
                                              || c == '.')));
            firstName = new string(arr);
            lblFirstNameError.Visible = Regex.IsMatch(firstName.Trim(), @"^\d$", RegexOptions.IgnoreCase) || firstName.Trim().Length == 0;
            if (tbEmailField.Text.Length == 0 && tbLastNameField.Text.Length == 0 && tbFirstNameField.Text.Length == 0) {
                lblFirstNameError.Visible = false;
                lblEmailError.Visible = false;
                lblLastNameError.Visible = false;
            }
        }

        string lastName;
        private void tbLastNameField_Leave(object sender, EventArgs e) {
            char[] arr = tbLastNameField.Text.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '-'
                                              || c == '@'
                                              || c == '.')));
            lastName = new string(arr);
            lblLastNameError.Visible = Regex.IsMatch(lastName.Trim(), @"^\d$", RegexOptions.IgnoreCase) || lastName.Trim().Length == 0;
            if (tbEmailField.Text.Length == 0 && tbLastNameField.Text.Length == 0 && tbFirstNameField.Text.Length == 0) {
                lblFirstNameError.Visible = false;
                lblEmailError.Visible = false;
                lblLastNameError.Visible = false;
            }
        }

        public bool isReadyToSave {
            get {
                if (string.IsNullOrWhiteSpace(emailString) || lblEmailError.Visible
                    || string.IsNullOrWhiteSpace(firstName) || lblFirstNameError.Visible
                    || string.IsNullOrWhiteSpace(lastName) || lblLastNameError.Visible) {
                    return false;
                }
                return true;
            }
        }

        private void GoFullscreen() {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void SignInForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                bSubmit_MouseClick(null, null);
            }
        }
    }
}
