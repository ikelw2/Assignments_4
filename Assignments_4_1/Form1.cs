using Assignments_4_1.Models;
using System.ComponentModel;
using System.Xml.Linq;

namespace Assignments_4_1
{
    public partial class Form1 : Form
    {

        // Assignment 4_1
        //
        // Design a personal phone /address book using Dictionary
        // collection.Write a person class to store details of
        // person like : FirstName , LastName , Mobile Phone, Work
        // Phone and Address.
        //
        // Provide a grid to display all, add more, delete (with
        // confirmation message) and search by name.
        //
        // Search should show details of person searched. You may
        // use the key as name of person.
        //
        // part 1: creat objects/classes
        // part 2: display
        // part 3: add/delete
        // part 4: search functionality

        //================================================================
        private BindingSource _bindingSource = new BindingSource();
        private BindingList<Person> Persons { get; set; } // = new BindingList<Person>(); // create this upon instantiation of class
        //================================================================
        public Form1()
        {
            InitializeComponent();
            LoadData(); // use this
            SetupBindings(); // use this
        }
        //================================================================
        private void LoadData()
        {
            Persons = new() // I used AI to produce this data quickly for testing purposes
            {
                // add sample data to the BindingList
                new Person { FirstName = "John", LastName = "Doe", MobilePhone = "555-555-0192", WorkPhone = "555-555-0193", StreetAddress = "123 Main Street", City = "Springfield", Zipcode = "62701" },
                new Person { FirstName = "Jane", LastName = "Smith", MobilePhone = "555-555-0144", WorkPhone = "555-555-0145", StreetAddress = "456 Oak Avenue", City = "Metropolis", Zipcode = "54401" },
                new Person { FirstName = "Alice", LastName = "Johnson", MobilePhone = "555-555-0178", WorkPhone = "555-555-0179", StreetAddress = "789 Pine Road", City = "Gotham", Zipcode = "10001" },
                new Person { FirstName = "Bob", LastName = "Brown", MobilePhone = "555-555-0112", WorkPhone = "555-555-0113", StreetAddress = "321 Maple Drive", City = "Star City", Zipcode = "97201" },
                new Person { FirstName = "Charlie", LastName = "Davis", MobilePhone = "555-555-0165", WorkPhone = "555-555-0166", StreetAddress = "654 Elm Court", City = "Central City", Zipcode = "90210" }
            };
        }
        //================================================================
        private void SetupBindings()
        {
            // Attach the data collection to the bindingsource
            _bindingSource.DataSource = Persons;

            // bind a complex control (like dataGridView1, assuming it exists on your form)
            dataGridView1.DataSource = _bindingSource;
        }
        //================================================================
        private void txtNameSearch_TextChanged(object sender, EventArgs e) // handle filter whenever searchbox changes
        {
            // Use the pattern matching syntax to cast the sender safely
            if (sender is TextBox txtNameSearch)
            {
                // Extract the text content
                string searchText = txtNameSearch.Text;

                if (searchText.Length == 0)
                {
                    if (_bindingSource.SupportsFiltering == false) // if _bindingSource does not support filtering... 
                    {
                        _bindingSource.DataSource = Persons;
                    }
                    else
                    {
                        // remove filter
                        _bindingSource.Filter = null;
                    }
                }
                else
                {
                    if (_bindingSource.SupportsFiltering == false) // if _bindingSource does not support filtering...
                    {
                        //MessageBox.Show("_bindingSource.SupportsFiltering == false", "Information");

                        // Among other recommended fixes, AI recommended using LINQ to create a different list
                        // use LINQ
                        var filteredList = Persons // AI generated 
                            .Where(p => p.SearchName != null && p.SearchName.Contains(searchText, StringComparison.OrdinalIgnoreCase)) // AI generated
                            .ToList(); // AI generated

                        // Reassign the filtered list to update the grid
                        _bindingSource.DataSource = new BindingList<Person>(filteredList);
                    }
                    else
                    {
                        //// enable filter
                        _bindingSource.Filter = $"SearchName LIKE '{searchText}'";
                    }
                    // Display the text in a MessageBox if it is not empty
                    //if (!string.IsNullOrWhiteSpace(searchText))
                    //{
                    //    MessageBox.Show($"You typed: {searchText}", "Text Changed Event");
                    //}
                }
            }
        }
        //================================================================
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            if (dataGridView1.CurrentRow.DataBoundItem is not Person selected)
            {
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete the entire record for {selected.SearchName}?",
                "Confirm Delete", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                Persons.Remove(selected); // remove record from actual Persons Bindinglist

                // update if filter is active
                string searchText = txtNameSearch.Text;
                if (searchText.Length != 0) // if filter mode is active, need to update the datagridView view
                { // re-do a filter operation here to reflect the updated source
                    var filteredList = Persons 
                        .Where(p => p.SearchName != null && p.SearchName.Contains(searchText, StringComparison.OrdinalIgnoreCase)) // AI generated
                        .ToList(); // AI generated

                    _bindingSource.DataSource = new BindingList<Person>(filteredList);
                }

                //_bindingSource.RemoveCurrent(); // does not work if we are in "filter" mode, because 
                                                  // filtered results are of a separate filteredList...
            }
        }
        //================================================================
    }
}
