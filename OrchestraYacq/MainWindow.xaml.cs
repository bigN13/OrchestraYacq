using MahApps.Metro.Controls;
using OrchestraYacq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XSpect.Yacq;

namespace OrchestraYacq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        MainWindowViewModel mv;


        #region INotifyPropertyChanged Members
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public MainWindow()
        {
            mv = new MainWindowViewModel();
            DataContext = mv;
            InitializeComponent();

            dgr_Persons.ItemsSource = mv.Persons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                System.Linq.Expressions.Expression expr = YacqServices.Parse(txt_expr1.Text);

                txt_Evaluate1.Text = expr.ToString();

                // Create a lambda expression.
                Expression<Func<int>> le = System.Linq.Expressions.Expression.Lambda<Func<int>>(expr);

                // Compile the lambda expression.
                Func<int> compiledExpression = le.Compile();

                // Execute the lambda expression. 
                int result = compiledExpression();


                // Display the result.
                txt_Result1.Text = result.ToString();
                //Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "try again", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                Expression<Func<string, string>> lambda =
                                        YacqServices.ParseFunc<string, string>(txt_expr2.Text);

                txt_Evaluate2.Text = lambda.ToString();

                Func<string, string> func = lambda.Compile();
                string myResult = func("foooo");

                txt_Result2.Text = myResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Try again", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            try
            {
                //Expression<Func<Person, bool>> lambda =
                //        YacqServices.ParseFunc<Person, bool>("(==(it.Sex) 'male')");

                Expression<Func<Person, bool>> lambda =
                        YacqServices.ParseFunc<Person, bool>(txt_Expression.Text);

                dgr_Persons.ItemsSource = mv.Persons.Yacq().Where(lambda);

                //persons.Where(x => x.Age < 50);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Try again", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
