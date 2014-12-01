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

namespace ARM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variables
        //ObservableCollection<Instruction> Instructions = new ObservableCollection<Instruction>();
        int dirCount = 0;
        int dataCount = 16;
        List<Instruction> instructions;

        public MainWindow()
        {
            InitializeComponent();
            instructions = new List<Instruction>();
            /*for (var i = 0; i <= 15; i++) {
                Instruction _this = new Instruction() { memPath1 = i };
                grdInstructions.Items.Add(_this);
            }
            for (var i = 16; i <= 32; i++)
            {
                Instruction _this2 = new Instruction() { memPath2 = i };
                grdData.Items.Add(_this2);
            } */
        }
        
        private void btnAddInstruction_Click(object sender, RoutedEventArgs e)
        {
            string cbi = ((ComboBoxItem)cboOperator.SelectedItem).Content.ToString();
            Instruction _this = new Instruction() { memPath1 = dirCount, memPath2 = dataCount, Operator = cbi, Operand = txtOperand.Text, Value = 0 };
            //instructions.Add(_this);
            //grdInstructions.ItemsSource = instructions;
            grdInstructions.Items.Add(_this);
            grdData.Items.Add( _this);
            dirCount++; dataCount++;

            //grdData.ItemsSource = data;
        }

        public class Instruction 
        {
            public int memPath1 { get; set; }
            public int memPath2 { get; set; }
            public string Operator { get; set; }
            public string Operand { get; set;}
            public int Value { get; set; }
        }

       

    }
}
