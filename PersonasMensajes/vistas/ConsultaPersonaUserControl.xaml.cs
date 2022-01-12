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

namespace PersonasMensajes
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersonaUserControl.xaml
    /// </summary>
    public partial class ConsultaPersonaUserControl : UserControl
    {
        private ConsultaPersonaUserControlVM vm;

        public ConsultaPersonaUserControl()
        {
            InitializeComponent();
            vm = new ConsultaPersonaUserControlVM();
            this.DataContext = vm;
        }
    }
}
