/*##################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20 - 16/12/20
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedProgramming/blob/main/Assessment2/Assessment2/MainWindow.xaml.cs

 Description: A partial class of type Window and  the interaction definitions of all other elements 
              contained within
 Elements: Interactive
             cbxFullTime, cbxPartTime, tbxFirstN, tbxLastN, tbxSalary, tbxHourlyRate, 
             tbxHoursWorked, rbFullTime, rbPartTime, btnClear, btnAddEmp, btnUpdateEmp, btnDeleteEmp
          
           Static
             lbxEmployees, tblkListTitle, tblkFirstN, tblkLastN, tblkTypeEmpFT, tblkTypeEmpPT,
             tblkSalary, tblkHourlyRate, tblkHoursWorked, tblkMontlyPayTitle, tblkMontlyPayCalculation
 Methods:  
 ##################################################################################################################################*/
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Assessment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Employee> filteredEmployees = new ObservableCollection<Employee>();
        List<TextBox> fields = new List<TextBox>();

        public MainWindow()
        {
            InitializeComponent();
        }



        /*EVENT BASED METHODS: -------------------------------------------------------------------------*/
        #region Event Methods
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Populating Class Properties
                // Giving the ListBox lbxEmployees an item source
            lbxEmployees.ItemsSource = employees;

                // Adding all TextBox elements to the fields List
            fields.Add(tbxFirstN);
            fields.Add(tbxLastN);
            fields.Add(tbxSalary);
            fields.Add(tbxHourlyRate);
            fields.Add(tbxHoursWorked);

            // Creating dummy Employee objects
            FullTimeEmployee f1 = new FullTimeEmployee("Alex", "Jones", 135000);
            PartTimeEmployee p1 = new PartTimeEmployee("Peter", "Malark");

            // Adding dummy Employees to employees ObservableCollection
            employees.Add(f1);
            employees.Add(p1);

            // Sorting employees collection in alphabetical order by LastName
            employees = SortCollection(employees);
        }// end Window_Loaded()


        /*Method: cbx_Checked()
                  1) Executes when either cbxFullTime or cbxPart time are checked or unchecked
                  2) Determines which Check Box elements are checked
                  3) Itterates through the employees Observable Collection
                  4) Adds the appropriate objects in the Collection to the
                     filtered collection (based on the EmpType property) */
        private void cbx_Checked(object sender, RoutedEventArgs e)
        {
            string empGroup = "?";
            filteredEmployees.Clear();
            lbxEmployees.ItemsSource = null;

            // All list
            if ((cbxFullTime.IsChecked == true) && (cbxPartTime.IsChecked == true))
                lbxEmployees.ItemsSource = employees;
            else
            {
                if (cbxFullTime.IsChecked == true)
                {
                    empGroup = "Full Time";
                }
                else if (cbxPartTime.IsChecked == true)
                {
                    empGroup = "Part Time";
                }
                
                foreach(Employee emp in employees)
                {
                    if (emp.EmpType == empGroup)
                        filteredEmployees.Add(emp);
                }
                lbxEmployees.ItemsSource = filteredEmployees;
            }// end if/else block            
        }// end cbx_Checked()


        /*Method: lbxEmployees_SelectionChanged()
                  1) Executes once as the Window element is being loaded and each time a new
                     item is selected
                  2) Calls the ClearFields() method
                  3) Creates two temporary objects, one FullTimeEmployee and one PartTimeEmployee
                  4) Checks the type of the selected item from the ListBox
                  5) Passes the appropriate temp object to the ShowDetails() method */
        private void lbxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // setup
            Employee SelectedEmp = lbxEmployees.SelectedItem as Employee;
            FullTimeEmployee tempF = new FullTimeEmployee();
            PartTimeEmployee tempP = new PartTimeEmployee();

            ClearFields();
            if (SelectedEmp != null) // ensuring selected item is not null
            {
                if(SelectedEmp.GetType() == typeof(FullTimeEmployee))
                {
                    tempF = SelectedEmp as FullTimeEmployee;
                    ShowDetails(tempF);
                }
                else
                {
                    tempP = SelectedEmp as PartTimeEmployee;
                    ShowDetails(tempP);
                }
            }// end if block
        }// end lbxEmployees_SelectionChanged()


        /*Event Group: .._GotFocus()
                        1) Exists for all TextBox Fields (tbxFirstN, tbxLastN, tbxSalary,
                           tbxHourlyRate and tbxHoursWorked) 
                        2) Clears the existing text (for individual fields) */
        #region .._GotFocus()
        private void tbxFirstN_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxFirstN.Clear();
        }// end tbxFirstN_GotFocus()

        private void tbxLastN_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxLastN.Clear();
        }// end tbxLastN_GotFocus()

        private void tbxSalary_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxSalary.Clear();
        }// end tbxSalary_GotFocus()

        private void tbxHourlyRate_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxHourlyRate.Clear();
        }// end tbxHourlyRate_GotFocus()

        private void tbxHoursWorked_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxHoursWorked.Clear();
        }// end tbxHoursWorked_GotFocus()
        #endregion



        /*Event Group: .._Click()
                        1) Exists for all Button Fields (btnClear, btnAddEmp, btnUpdateEmp
                           and btnDeleteEmp
                        2) Executes when each Button is clicked */
        #region .._Click()
        /*Method: btnClear_Click()
                  1) Calls the ClearFields() method */
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }// end btnClear_Click()


        /*Method: btnAddEmp_Click()
                  1) Executes when btnAddEmp is clicked
                  2) Determines whether rbFullTime or rbPartTime is checked
                  3) Launches a MessageBox asking the user to select a Radio Button
                     if one isn't already chosen, and highlights tblkEmpTypeFT and
                     tblkEmpTypePT in yellow
                  4) Executes either the CreateEmpFT() or CreatEmpPT() method */
        private void btnAddEmp_Click(object sender, RoutedEventArgs e)
        {
            if((rbFullTime.IsChecked == false) && (rbPartTime.IsChecked == false))
            {
                MessageBox.Show("Please select either FT or PT to add");
                tblkEmpTypeFT.Background = Brushes.Yellow;
                tblkEmpTypePT.Background = Brushes.Yellow;
            }
            else
            {
                if (rbFullTime.IsChecked == true)
                    CreateEmpFT();
                if (rbPartTime.IsChecked == true)
                    CreateEmpPT();
            }

            // refreshing ListBox
            lbxEmployees.ItemsSource = null;
            lbxEmployees.ItemsSource = SortCollection(employees);
        }// end btnAddEmp_Click()


        /*Method: btnUpdateEmp_Click()
                  1) Executes when btnUpdateEmp is clicked
                  2) Determines whether an item from the ListBox has been selected
                     (gives the ListBox a warning background colour of Yellow if not)
                  3) Creates an object based on which Radio Button is selected with the properties
                     contained in the TextBox fields at the time
                  4) Replaces the employees object at the selected index with new object*/
        private void btnUpdateEmp_Click(object sender, RoutedEventArgs e)
        {
            if(lbxEmployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee to update");
                lbxEmployees.Background = Brushes.Yellow;
            }
            else
            {
                if(rbFullTime.IsChecked == true) // FullTimeEmployee object
                {
                    FullTimeEmployee emp = new FullTimeEmployee(tbxFirstN.Text, tbxLastN.Text,
                                               decimal.Parse(tbxSalary.Text));
                    employees[lbxEmployees.SelectedIndex] = emp;
                }
                if(rbPartTime.IsChecked == true) // PartTimeEmployee object
                {
                    PartTimeEmployee emp = new PartTimeEmployee(tbxFirstN.Text, tbxLastN.Text,
                                               decimal.Parse(tbxHourlyRate.Text),
                                           double.Parse(tbxHoursWorked.Text));
                    employees[lbxEmployees.SelectedIndex] = emp;
                }

                // refreshing ListBox
                lbxEmployees.ItemsSource = null;
                lbxEmployees.ItemsSource = SortCollection(employees);
            }// end if/else block
        }// end btnUpdateEmp_Click()



        /*Method: btnDeleteEmp_Click()
                  1) Executes when btnUpdateEmp is clicked
                  2) Determines whether an item from the ListBox has been selected
                     (gives the ListBox a warning background colour of Yellow if not) 
                  3) Removes the object from employees at the selected index */
        private void btnDeleteEmp_Click(object sender, RoutedEventArgs e)
        {
            if (lbxEmployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee to delete");
                lbxEmployees.Background = Brushes.Yellow;
            }
            else
            {
                employees.Remove(employees[lbxEmployees.SelectedIndex]);
            }

            // refreshing ListBox
            lbxEmployees.ItemsSource = null;
            lbxEmployees.ItemsSource = SortCollection(employees);
        }// end btnDeleteEmp_Click()
        #endregion


        /*Method: rb_Checked()
                  1) Executes when either rbFullTime or rbPartTime is checked
                  2) Resets the background colours of tblkEmpTypeFT and tblkEmpTypePT
                     time to white */
        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            tblkEmpTypeFT.Background = Brushes.White;
            tblkEmpTypePT.Background = Brushes.White;
        }// end rb_Checked()


        /*Method: UpdatePay()
                  1) Executes when either tbxHourlyRate or tbxHoursWorked
                     lose focus
                  2) Updates the tlbkMontlyPayCalculation field in real time */
        private void UpdatePay(object sender, RoutedEventArgs e)
        {
            decimal hrlyR = 0;
            double hrsW = 0;

            if(tbxHourlyRate.Text != "")
                hrlyR = decimal.Parse(tbxHourlyRate.Text);
            if(tbxHoursWorked.Text != "")
            hrsW = double.Parse(tbxHoursWorked.Text);

            tblkMonthlyPayCalculation.Text = string.Format($"{(hrlyR * (decimal)hrsW):C2}");
        }// end UpdatePay
        #endregion


        /*LOGIC BASED METHODS: -------------------------------------------------------------------------*/
        #region Logic Methods
        /*Method: ClearFields()
                 1) Itterates through the List fields
                 2) Clears the text for each TextBox field, the Radio Button choice
                    and the TextBlock containing the Montly Pay Calculation */
        private void ClearFields()
        {

            // Clearing TextBoxes
            foreach (TextBox field in fields)
            {
                field.Clear();
            }

            // clearing Radio Buttons
            if (rbFullTime.IsChecked == true)
                rbFullTime.IsChecked = false;
            if (rbPartTime.IsChecked == true)
                rbPartTime.IsChecked = false;

            // clearing any warning colours
            tblkEmpTypeFT.Background = Brushes.White;
            tblkEmpTypePT.Background = Brushes.White;
            lbxEmployees.Background = Brushes.White;

            // clearing Monthly Pay Calculation
            tblkMonthlyPayCalculation.Text = null;

        }// end ClearFields()


        /*Method: ShowDetails() (overloaded)
                  1) Takes in a FullTimeEmployee object
                  2) Updates the approproate TextBox, Radio and Calculation fields */
        private void ShowDetails(FullTimeEmployee temp)
        {
            tbxFirstN.Text = temp.FirstName;
            tbxLastN.Text = temp.LastName;
            rbFullTime.IsChecked = true;
            tbxSalary.Text = string.Format($"{temp.Salary: ###,##0}");
            tblkMonthlyPayCalculation.Text = string.Format($"{temp.CalculateMonthlyPay():C0}");

        }// end ShowDetails() (FullTimeEmployee)


        /*Method: ShowDetails() (overloaded)
                  1) Takes in a PartTimeEmployee object
                  2) Updates the approproate TextBox, Radio and Calculation fields */
        private void ShowDetails(PartTimeEmployee temp)
        {
            tbxFirstN.Text = temp.FirstName;
            tbxLastN.Text = temp.LastName;
            rbPartTime.IsChecked = true;
            tbxHourlyRate.Text = string.Format($"{temp.HourlyRate: ##0.00}");
            tbxHoursWorked.Text = string.Format($"{temp.HoursWorked: ##0.00}");
            tblkMonthlyPayCalculation.Text = string.Format($"{temp.CalculateMonthlyPay():C0}");
        }// end ShowDetails() (PartTimeEmployee)


        /*Method: CreateEmpFT()
                  1) Initialises a blank FullTimeEmployee object
                  2) Updates the blank object's properties based on the 
                     appropriate TextBox fields 
                  3) Adds new object to the employees Observable Collection 
                  4) Sorts the Observable Collection */
        private void CreateEmpFT()
        {
            FullTimeEmployee emp = new FullTimeEmployee();

            if (tbxFirstN.Text != "")
                emp.FirstName = tbxFirstN.Text;
            if (tbxLastN.Text != "")
                emp.LastName = tbxLastN.Text;
            if (tbxSalary.Text != "")
                emp.Salary = decimal.Parse(tbxSalary.Text);

            employees.Add(emp);
        }// end CreateEmpFT()

        /*Method: CreateEmpFT()
                  1) Initialises a blank PartTimeEmployee object
                  2) Updates the blank object's properties based on the 
                     appropriate TextBox fields 
                  3) Adds new object to the employees Observable Collection 
                  4) Sorts the Observable Collection */
        private void CreateEmpPT()
        {
            PartTimeEmployee emp = new PartTimeEmployee();

            if (tbxFirstN.Text != "")
                emp.FirstName = tbxFirstN.Text;
            if (tbxLastN.Text != "")
                emp.LastName = tbxLastN.Text;
            if (tbxHourlyRate.Text != "")
                emp.HourlyRate = decimal.Parse(tbxHourlyRate.Text);
            if (tbxHoursWorked.Text != "")
                emp.HoursWorked = double.Parse(tbxHoursWorked.Text);

            employees.Add(emp);
        }// end CreateEmpFT()



        /*===================================================================================
          NOTE: I wasn't entierly sure how to sort a collection, but I found a way to do
                it from here:
                https://kiwigis.blogspot.com/2010/03/how-to-sort-obversablecollection.html 
        ===================================================================================*/
        /*Method: SortCollection()
                  1) Takes in an ObservableCollection of Employee objects
                  2) Creates a temporary ObservableCollection
                  3) Initialises the temporary collection with Employee objects as they are
                     being compared in the original collection
                  4) Returns the temporary collection */
        private ObservableCollection<Employee> SortCollection(ObservableCollection<Employee> group)
        {
            ObservableCollection<Employee> sortedEmployees = new ObservableCollection<Employee>
                                                                 (group.OrderBy(employee => employee));
            return sortedEmployees;
        }// end SortCollection()
        #endregion
    }// end MainWindow partial class
}// end Namespace
