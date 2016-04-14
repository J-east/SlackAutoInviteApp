namespace CoLabSignIn {
    partial class SignInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastNameField = new System.Windows.Forms.TextBox();
            this.tbFirstNameField = new System.Windows.Forms.TextBox();
            this.tbEmailField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.bSubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.lblThanks);
            this.MainPanel.Controls.Add(this.lblLastNameError);
            this.MainPanel.Controls.Add(this.lblFirstNameError);
            this.MainPanel.Controls.Add(this.lblEmailError);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.bSubmit);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.tbLastNameField);
            this.MainPanel.Controls.Add(this.tbFirstNameField);
            this.MainPanel.Controls.Add(this.tbEmailField);
            this.MainPanel.Location = new System.Drawing.Point(238, 52);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(540, 505);
            this.MainPanel.TabIndex = 0;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(132, 277);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(294, 29);
            this.lblThanks.TabIndex = 11;
            this.lblThanks.Text = "Thank you for Registering!";
            this.lblThanks.Visible = false;
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLastNameError.Location = new System.Drawing.Point(20, 369);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(130, 13);
            this.lblLastNameError.TabIndex = 10;
            this.lblLastNameError.Text = "Please Enter a Last Name";
            this.lblLastNameError.Visible = false;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFirstNameError.Location = new System.Drawing.Point(21, 312);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(129, 13);
            this.lblFirstNameError.TabIndex = 9;
            this.lblFirstNameError.Text = "Please Enter a First Name";
            this.lblFirstNameError.Visible = false;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmailError.Location = new System.Drawing.Point(29, 258);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(121, 13);
            this.lblEmailError.TabIndex = 8;
            this.lblEmailError.Text = "Please Enter Valid Email";
            this.lblEmailError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Address";
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.bSubmit.Controls.Add(this.label2);
            this.bSubmit.Location = new System.Drawing.Point(152, 405);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(246, 29);
            this.bSubmit.TabIndex = 4;
            this.bSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bSubmit_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(94, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "SUBMIT";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bSubmit_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please sign up";
            // 
            // tbLastNameField
            // 
            this.tbLastNameField.BackColor = System.Drawing.SystemColors.Control;
            this.tbLastNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbLastNameField.Location = new System.Drawing.Point(152, 361);
            this.tbLastNameField.Name = "tbLastNameField";
            this.tbLastNameField.Size = new System.Drawing.Size(247, 29);
            this.tbLastNameField.TabIndex = 2;
            this.tbLastNameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignInForm_KeyDown);
            this.tbLastNameField.Leave += new System.EventHandler(this.tbLastNameField_Leave);
            // 
            // tbFirstNameField
            // 
            this.tbFirstNameField.BackColor = System.Drawing.SystemColors.Control;
            this.tbFirstNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbFirstNameField.Location = new System.Drawing.Point(152, 304);
            this.tbFirstNameField.Name = "tbFirstNameField";
            this.tbFirstNameField.Size = new System.Drawing.Size(247, 29);
            this.tbFirstNameField.TabIndex = 1;
            this.tbFirstNameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignInForm_KeyDown);
            this.tbFirstNameField.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbEmailField
            // 
            this.tbEmailField.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmailField.CausesValidation = false;
            this.tbEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbEmailField.Location = new System.Drawing.Point(152, 250);
            this.tbEmailField.Name = "tbEmailField";
            this.tbEmailField.Size = new System.Drawing.Size(247, 29);
            this.tbEmailField.TabIndex = 0;
            this.tbEmailField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignInForm_KeyDown);
            this.tbEmailField.Leave += new System.EventHandler(this.tbEmailField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(152, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 666);
            this.Controls.Add(this.MainPanel);
            this.Name = "SignInForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.MainPanel_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignInForm_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.bSubmit.ResumeLayout(false);
            this.bSubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox tbEmailField;
        private System.Windows.Forms.Panel bSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastNameField;
        private System.Windows.Forms.TextBox tbFirstNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

