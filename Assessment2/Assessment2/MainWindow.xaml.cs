/*##################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 15/12/20
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedProgramming/blob/main/Assessment2/Assessment2/MainWindow.xaml.cs

 Description: A partial class of type Window and  the interaction definitions of all other elements 
              contained within
 Elements: Interactive
             cbxFullTime, cbxPartTime, tbxFirstN, tbxLastN, tbxSalary, tbxHourlyRate, 
             tbxHoursWorked, rbnFullTime, rbnPartTime, btnClear, btnAddEmp, btnUpdateEmp, btnDeleteEmp
          
           Static
             lbxEmployees, tblkListTitle, tblkFirstN, tblkLastN, tblkTypeEmpFT, tblkTypeEmpPT,
             tblkSalary, tblkHourlyRate, tblkHoursWorked, tblkMontlyPayTitle, tblkMontlyPayCalculation
 Methods: Grid_Loaded(), 
 ##################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assessment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*PROPERTIES -----------------------------------------------------------------------------------*/
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        List<TextBox> fields = new List<TextBox>();


        /*ELEMENTS -------------------------------------------------------------------------------------*/
        public MainWindow()
        {
            InitializeComponent();
        }



        /*METHODS --------------------------------------------------------------------------------------*/
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


            FullTimeEmployee f1 = new FullTimeEmployee("Alex", "Jones", 135000);
            PartTimeEmployee p1 = new PartTimeEmployee("Peter", "Malark");

            employees.Add(f1);
            employees.Add(p1);
            
        }// end Window_Loaded()



        /*Event Group: ListBox Selection Process */
        #region Showing Employee Details
        /*Method: lbxEmployees_SelectionChanged()
                  1) Executes once as the Window element is being loaded and each time a new
                     item is selected
                  2) Calls the Clear() method
                  3) Creates two temporary objects, one FullTimeEmployee and one PartTimeEmployee
                  4) Checks the type of the selected item from the ListBox
                  5) Passes the appropriate temp object to the ShowDetails() method */
        private void lbxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee SelectedEmp = lbxEmployees.SelectedItem as Employee;
            FullTimeEmployee tempF = new FullTimeEmployee();
            PartTimeEmployee tempP = new PartTimeEmployee();

            Clear();
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



        /*Method: Clear()
                  1) Itterates through the List fields
                  2) Clears the text for each TextBox field */
        private void Clear()
        {
            foreach (TextBox field in fields)
            {
                field.Clear();
            }
        }// end Clear()



        /*Method: ShowDetails() (overloaded)
                  1) Takes in a FullTimeEmployee object
                  2) Updates the approproate Text Box fields */
        private void ShowDetails(FullTimeEmployee temp)
        {
                tbxFirstN.Text = temp.FirstName;
                tbxLastN.Text = temp.LastName;
                tbxSalary.Text = string.Format($"{temp.Salary: ###,##0}");
        }// end ShowDetails() (FullTimeEmployee)


        /*Method: ShowDetails() (overloaded)
                  1) Takes in a PartTimeEmployee object
                  2) Updates the approproate Text Box fields */
        private void ShowDetails(PartTimeEmployee temp)
        {
            tbxFirstN.Text = temp.FirstName;
            tbxLastN.Text = temp.LastName;
            tbxHourlyRate.Text = string.Format($"{temp.HourlyRate: ##0.00}");
            tbxHoursWorked.Text = string.Format($"{temp.HoursWorked: ##0.00}");
        }// end ShowDetails() (PartTimeEmployee)
        #endregion



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
                  1) Calls the Clear() method */
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }// end btnClear_Click()


        /*Method: btnAddEmp_Click()
                  1) 
                  2) 
                  3) */
        private void btnAddEmp_Click(object sender, RoutedEventArgs e)
        {

        }// end btnAddEmp_Click()


        /*Method: btnUpdateEmp_Click()
                  1) 
                  2) 
                  3) */
        private void btnUpdateEmp_Click(object sender, RoutedEventArgs e)
        {

        }// end btnUpdateEmp_Click()



        /*Method: btnDeleteEmp_Click()
                  1) 
                  2) 
                  3) */
        private void btnDeleteEmp_Click(object sender, RoutedEventArgs e)
        {

        }// end btnDeleteEmp_Click()
        #endregion

        
    }// end MainWindow partial class
}// end Namespace
