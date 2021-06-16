using FinalFight.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для pListMaterials.xaml
    /// </summary>
    public partial class pListMaterials : Page
    {
        public ObservableCollection<Material> Materials;
        public pListMaterials()
        {

            InitializeComponent();
            AppData.entObj.Material.Load();
            Materials = AppData.entObj.Material.Local;
            lvMaterials.ItemsSource = Materials;
        }
    }
}
