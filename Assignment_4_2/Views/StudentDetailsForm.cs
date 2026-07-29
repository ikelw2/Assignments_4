using Assignment_4_2.Models;
using Assignment_4_2.Services;
using System.ComponentModel;
using Assignment_4_2.Views;

namespace Assignment_4_2;


//
// This is the StudentEditorForm, it represents the MAIN location where users (Teacher) will use the app.
// 
// 
public partial class StudentDetailsForm : Form
{
    private BindingSource _bindingSource;// = new BindingSource();
    MockStudentData myMockStudentData;
    public StudentDetailsForm() // perhaps more secure for this to take some sort of auth token, but that I don't know about
    {
        InitializeComponent();
        LoadDataAndSetupBindings();
    }
    // ------------------------------------------------------------
    //    InitializeComponent();
    //
    //    The below section is left indented because it contains the 'basic' method of running this
    //    essentially if user does not authenticate the main form loads but no data is loaded...
    //    The current app runs the login dialog box from the Program.cs main function, and ONLY if 
    //    the user logs in successfully, then the main form StudentDetailsForm is loaded...
    //
    //    using (LoginForm loginForm = new LoginForm()) // use LoginForm safely with 'using' statement
    //    {
    //        // pauses execution until login form closes
    //        DialogResult result = loginForm.ShowDialog();

    //        // check how the user exited the form
    //        if (result == DialogResult.OK)
    //        {
    //            // safely read the value from the form before it is destroyed
    //            bool authSuccess = loginForm.AuthenticationResult;
    //            if (authSuccess)
    //            {
    //                // only load data if user successfully logged in 
    //                this.Visible = true;
    //                //this.Opacity = 100;
    //                LoadDataAndSetupBindings();
    //            }
    //            else
    //            {
    //                MessageBox.Show("Authentication Failed.");
    //                //this.Close(); // close app if can't authenticate
    //                //Console.Beep();
    //                //Application.Exit();
    //            }
    //        }
    //        else
    //        {
    //            MessageBox.Show("Login cancelled by user.");
    //            //this.Close(); // close app if can't authenticate
    //            //Console.Beep();
    //            //Application.Exit();
    //        }
    //    } // loginForm is automatically destroyed here
    //}
    // ------------------------------------------------------------
    private void LoadDataAndSetupBindings()
    {
        // load data from mock data class
        myMockStudentData = new();
        // and bind it to _bindingSource
        _bindingSource = new BindingSource();
        _bindingSource.DataSource = myMockStudentData.StudentsBindingList;

        // 3. Bind properties of your list object to the textbox controls    
        // update: added "true, DataSourceUpdateMode.OnPropertyChanged" 
        // DataSourceUpdateMode.OnPropertyChanged ensures the grid updates instantly as you type!
        // figured this out with help from AI and also https://www.youtube.com/watch?v=U1eypjtM8JI which talks about 
        // updating individual fields, and also implementing event handling for when user updates them on the form
        // ...
        // controlName.DataBindings.Add("field in control to update", _bindingSource, "sourceProperty", two-way?, OnPropertyChanged means will update immediately);//
        txtStudentID.DataBindings.Add("Text", _bindingSource, "StudentID", true, DataSourceUpdateMode.OnPropertyChanged);
        txtFirstName.DataBindings.Add("Text", _bindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
        txtLastName.DataBindings.Add("Text", _bindingSource, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
        txtAddress.DataBindings.Add("Text", _bindingSource, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
        txtGrade.DataBindings.Add("Text", _bindingSource, "StudentGPA", true, DataSourceUpdateMode.OnPropertyChanged);
        txtMonthOfAdmission.DataBindings.Add("Text", _bindingSource, "MonthOfAdmission", true, DataSourceUpdateMode.OnPropertyChanged);

        // 4. Bind the DataGridView to the SAME BindingSource container for it to work and update with other textbox controls
        // in order for updates to show on the individual textbox controls, need to use BindingList, here we just use it 
        // to keep the datasource on the same page, also allows for the record user is at to be selected, per next code line
        // ...
        // bind a complex control (like dataGridView1, assuming it exists on your form)
        dataGridView1.DataSource = _bindingSource;
        // //\\//\\ var viewablelist = new BindingList<Student>(Students); // previous method only showed the gridview
        // //\\//\\ dataGridView1.DataSource = viewablelist;

        // forces whole row selection - how it knows to select the record the user is on in textboxes is probably automatic
        // since we are using same datasource for textbox as we are for the dataGridView1
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = false;

        /// for the reactivity of dataGridView1 to work, Student.cs must inherit? from INotifyPropertyChanged object
        /// so edits to textboxes immediately reflect on dataGridView1, and vice versa?
    }
    // ------------------------------------------------------------
    private void btnValedictorian_Click(object sender, EventArgs e)
    {
        // to access data, use myMockStudentData.StudentsBindingList
        if (myMockStudentData.StudentsBindingList == null)
            return;
        
        Student valedictorian;
        if (myMockStudentData.StudentsBindingList.Any()) // if there is a Student in the StudentBindingList
        {
            // Gets the entire student object with the highest grade
            valedictorian = myMockStudentData.StudentsBindingList.MaxBy(s => s.StudentGPA);
            // 3. Output the result
            if (valedictorian != null)
            {
                MessageBox.Show(valedictorian.ToString());
            }

        }
        else
        {
            MessageBox.Show("There are no students available");
        }
    }
    // ------------------------------------------------------------
    private void btnPrev_Click(object sender, EventArgs e)
    {
        _bindingSource.MovePrevious();
    }
    // ------------------------------------------------------------
    private void btnNext_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveNext();
    }
    // ------------------------------------------------------------
    // below add and delete functions with help from AI...
    // I decided to include them because I can study these elements in order to implement
    // them in the future if I want to create an unbound data source that is based off an
    // object in my application.
    private void btnAddNew_Click(object sender, EventArgs e)
    {
        // AI: Creates a new blank student object, adds it to the grid, and selects it
        _bindingSource.AddNew();

        // AI: Optional enhancement: Automatically shift input focus to the first editable text box
        txtStudentID.Focus();
    }
    // ------------------------------------------------------------
    private void btnDelete_Click(object sender, EventArgs e)
    {
        // AI: Ensure there is actually a record available to delete
        if (_bindingSource.Current != null) // if null means no records in _bindingSource
        {
            // AI: Prompt user for confirmation before wiping out data records, demonstrates quick message box with prompt
            DialogResult result = MessageBox.Show(
                "Are you sure you want to permanently delete this student record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // AI: Erases the active item from the collection and cleans up the grid view
                _bindingSource.RemoveCurrent();
            }
        }
        else // AI: if no records in _bindingSource, no records available to delete
        {
            MessageBox.Show("There are no student records left to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    // ------------------------------------------------------------
}