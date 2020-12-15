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



        /*ELEMENTS -------------------------------------------------------------------------------------*/
        public MainWindow()
        {
            InitializeComponent();
        }



        /*METHODS --------------------------------------------------------------------------------------*/
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxEmployees.ItemsSource = employees;

            FullTimeEmployee f1 = new FullTimeEmployee("Alex", "Jones");
            PartTimeEmployee p1 = new PartTimeEmployee("Peter", "Malark");

            employees.Add(f1);
            employees.Add(p1);
        }


        /*Event Group: .._GotFocus()
                        1) Exists for all TextBox Fields (tbxFirstN, tbxLastN, tbxSalary,
                           tbxHourlyRate and tbxHoursWorked) 
                        2) Clears the existing text */
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

        
    }// end MainWindow partial class
}// end Namespace
