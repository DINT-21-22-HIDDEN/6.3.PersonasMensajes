using System;
using System.Collections.Generic;
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

namespace PersonasMensajes
{
    /// <summary>
    /// Lógica de interacción para NuevaPersonaUserControl.xaml
    /// </summary>
    public partial class NuevaPersonaUserControl : UserControl
    {
        private NuevaPersonaUserControlVM vm;
        public NuevaPersonaUserControl()
        {
            InitializeComponent();
            vm = new NuevaPersonaUserControlVM();
            this.DataContext = vm;
        }
    }
}
