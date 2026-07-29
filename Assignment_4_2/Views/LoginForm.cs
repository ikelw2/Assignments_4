using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_4_2.Views;

public partial class LoginForm : Form
{
    public bool AuthenticationResult { get; private set; }

    public LoginForm()
    {
        
        
        AuthenticationResult = false; // initialize this variable to make authentication failure default until user enters valid credentials
        InitializeComponent();
    }

    private void btnLogon_Click(object sender, EventArgs e)
    {
        
        
        
        AuthenticationResult = true; 

        this.DialogResult = DialogResult.OK;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}
