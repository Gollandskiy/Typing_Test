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

namespace Typing_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button activeButton;
        public MainWindow()
        {
            InitializeComponent();
            PreviewTextInput += MainWindow_PreviewTextInput;
        }
        private void MainWindow_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char keyChar = e.Text[0];

            Button button = GetButtonByKeyChar(keyChar);

            if (button != null)
            {
                HighlightButton(button);
                lab1.Text += keyChar.ToString();
            }
        }
        private Button GetButtonByKeyChar(char keyChar) // я знаю что этот код такое говно которое даже стажер высрать не способен, но
        {                                               // у меня ничего не получается со списком который я хотел сделать, типо список кнопок, короче я заспамлю здесь элсифы и все
            if (keyChar == '`')
                return but1;
            else if (keyChar == '1')
                return but2;
            else if (keyChar == '2')
                return but3;
            else if (keyChar == '3')
                return but4;
            else if (keyChar == '4')
                return but5;
            else if (keyChar == '5')
                return but6;
            else if (keyChar == '6')
                return but7;
            else if (keyChar == '7')
                return but8;
            else if (keyChar == '8')
                return but9;
            else if (keyChar == '9')
                return but10;
            else if (keyChar == '0')
                return but11;
            else if (keyChar == '-')
                return but12;
            else if (keyChar == '=')
                return but13;
            else if (keyChar == 'Q')
                return but16;
            else if (keyChar == 'W')
                return but17;
            else if (keyChar == 'E')
                return but18;
            else if (keyChar == 'R')
                return but19;
            else if (keyChar == 'T')
                return but20;
            else if (keyChar == 'Y')
                return but21;
            else if (keyChar == 'U')
                return but22;
            else if (keyChar == 'I')
                return but23;
            else if (keyChar == 'O')
                return but24;
            else if (keyChar == 'P')
                return but25;
            else if (keyChar == '[')
                return but26;
            else if (keyChar == ']')
                return but27;
            else if (keyChar == '\\')
                return but28;
            else if (keyChar == 'A')
                return but30;
            else if (keyChar == 'S')
                return but31;
            else if (keyChar == 'D')
                return but32;
            else if (keyChar == 'F')
                return but33;
            else if (keyChar == 'G')
                return but34;
            else if (keyChar == 'H')
                return but35;
            else if (keyChar == 'J')
                return but36;
            else if (keyChar == 'K')
                return but37;
            else if (keyChar == 'L')
                return but38;
            else if (keyChar == ';')
                return but39;
            else if (keyChar == '\'')
                return but40;
            else if (keyChar == 'Z')
                return but43;
            else if (keyChar == 'X')
                return but44;
            else if (keyChar == 'C')
                return but45;
            else if (keyChar == 'V')
                return but46;
            else if (keyChar == 'B')
                return but47;
            else if (keyChar == 'N')
                return but48;
            else if (keyChar == 'M')
                return but49;
            else if (keyChar == ',')
                return but50;
            else if (keyChar == '.')
                return but51;
            else if (keyChar == '/')
                return but52;
            return null;
        }
        private void ResetButtonHighlight()
        {
            but1.Background = SystemColors.ControlBrush; // и здесь тоже
            but2.Background = SystemColors.ControlBrush;
            but3.Background = SystemColors.ControlBrush;
            but4.Background = SystemColors.ControlBrush;
            but5.Background = SystemColors.ControlBrush;
            but6.Background = SystemColors.ControlBrush;
            but7.Background = SystemColors.ControlBrush;
            but8.Background = SystemColors.ControlBrush;
            but9.Background = SystemColors.ControlBrush;
            but10.Background = SystemColors.ControlBrush;
            but11.Background = SystemColors.ControlBrush;
            but12.Background = SystemColors.ControlBrush;
            but13.Background = SystemColors.ControlBrush;
            but16.Background = SystemColors.ControlBrush;
            but17.Background = SystemColors.ControlBrush;
            but18.Background = SystemColors.ControlBrush;
            but19.Background = SystemColors.ControlBrush;
            but20.Background = SystemColors.ControlBrush;
            but21.Background = SystemColors.ControlBrush;
            but22.Background = SystemColors.ControlBrush;
            but23.Background = SystemColors.ControlBrush;
            but24.Background = SystemColors.ControlBrush;
            but25.Background = SystemColors.ControlBrush;
            but26.Background = SystemColors.ControlBrush;
            but27.Background = SystemColors.ControlBrush;
            but28.Background = SystemColors.ControlBrush;
            but30.Background = SystemColors.ControlBrush;
            but31.Background = SystemColors.ControlBrush;
            but32.Background = SystemColors.ControlBrush;
            but33.Background = SystemColors.ControlBrush;
            but34.Background = SystemColors.ControlBrush;
            but35.Background = SystemColors.ControlBrush;
            but36.Background = SystemColors.ControlBrush;
            but37.Background = SystemColors.ControlBrush;
            but38.Background = SystemColors.ControlBrush;
            but39.Background = SystemColors.ControlBrush;
            but40.Background = SystemColors.ControlBrush;
            but43.Background = SystemColors.ControlBrush;
            but44.Background = SystemColors.ControlBrush;
            but45.Background = SystemColors.ControlBrush;
            but46.Background = SystemColors.ControlBrush;
            but47.Background = SystemColors.ControlBrush;
            but48.Background = SystemColors.ControlBrush;
            but49.Background = SystemColors.ControlBrush;
            but50.Background = SystemColors.ControlBrush;
            but51.Background = SystemColors.ControlBrush;
            but52.Background = SystemColors.ControlBrush;
        }
        private void HighlightButton(Button button)
        {
            ResetButtonHighlight();

            button.Background = Brushes.Yellow;
        }
    }
}
