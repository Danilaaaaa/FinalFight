using FinalFight.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalFight.Pages
{
    /// <summary>
    /// Логика взаимодействия для pStart.xaml
    /// </summary>
    public partial class pStart : Page
    {
        public pStart()
        {
            InitializeComponent();
        }

        private void bLstMat_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new pListMaterials());
        }

        private void bMtrWork_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
