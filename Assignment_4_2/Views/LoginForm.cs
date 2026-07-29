using Assignment_4_2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Assignment_4_2.Models;

namespace Assignment_4_2.Views;

public partial class LoginForm : Form
{
    public bool AuthenticationResult { get; private set; }
    private MockTeacherData myMockTeacherData { get; set; }
    //---------------------------
    public LoginForm()
    {
        AuthenticationResult = false; // initialize this variable to make authentication failure default until user enters valid credentials
        InitializeComponent();
    }
    //---------------------------
    private void btnLogon_Click(object sender, EventArgs e)
    {
        // load data from mock teacher data class
        MockTeacherData myMockTeacherData = new();
        
        foreach (Teacher teach in myMockTeacherData.TeacherList)
        {
            if (String.Compare(txtUsername.Text, teach.Username) == 0) // username exists in List<Teacher>
            {
                // if password matches password, assign true to AuthenticationResult
                AuthenticationResult = teach.VerifyUsernamePassword(txtPassword.Text, txtUsername.Text);
            }
        }
        //if not updated above, AuthenticationResult = false; 
        this.DialogResult = DialogResult.OK;
    }
    //---------------------------
    private void btnExit_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
    //---------------------------
}
