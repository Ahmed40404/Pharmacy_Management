using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PharmacyManagement
{
    /// <summary>
    /// Interaction logic for create_user.xaml
    /// </summary>
    public partial class create_user : Window
    {
        PharmacyEntities PharmacyEntities = new PharmacyEntities();
        public create_user()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.user_name = usernamet.Text;
            user.Pathological_condition = Pathological_condition.Text;
            if (radio.IsChecked == true)
            {
                user.Loyalty_Card = true;
            }

            else 
            { 
            user.Loyalty_Card= false;   
            }
            PharmacyEntities.Users.Add(user);
            PharmacyEntities.SaveChanges();
            this.Close();
        }

    }
}
