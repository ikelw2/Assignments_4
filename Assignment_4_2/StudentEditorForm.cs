using Assignment_4_2.Models;
using System.ComponentModel;

namespace Assignment_4_2;

public partial class StudentEditorForm : Form
{
    private BindingSource _bindingSource = new BindingSource();
    
    //private BindingList<Student> Students { get; set; }
    //private List<Student> mockDataStudents { get; set; }

    public StudentEditorForm()
    {
        InitializeComponent();
        LoadData();
        SetupBindings(); 
    }
    // ------------------------------------------------------------
    private void LoadData()
    {

    }
    // ------------------------------------------------------------
    private void SetupBindings()
    {
        // 1. Generate mock datasource, generated with help from AI, from assignment 3_3
        var mockDataStudents = new List<Student>() {
            new Student(101, "Liam", "Smith", "123 Maple St", Month.January, "3.4"),
            new Student(102, "Noah", "Johnson", "456 Oak Ave", Month.March, "3.3"),
            new Student(103, "Oliver", "Williams", "789 Pine Rd", Month.September, "2.8"),
            new Student(104, "Elijah", "Brown", "321 Cedar Ln", Month.May, "4.0"),
            new Student(105, "James", "Jones", "654 Spruce St", Month.July, "3.8"),
            new Student(106, "Benjamin", "Miller", "987 Birch Blvd", Month.November, "2.6"),
            new Student(107, "Lucas", "Davis", "147 Elm Dr", Month.January, "2.7"),
            new Student(108, "Henry", "Garcia", "258 Willow Ct", Month.September, "3.2"),
            new Student(109, "Alexander", "Rodriguez", "369 Ash Ave", Month.May, "3.1"),
            new Student(110, "Mason", "Wilson", "741 Walnut St", Month.March, "3.9")
            };

        BindingList<Student> students = new BindingList<Student>(mockDataStudents);
        //// 2. Attach your populated list into BindingSource container
        //_bindingSource.DataSource = students;

        // Attach the data collection to the bindingsource
        _bindingSource.DataSource = students;

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