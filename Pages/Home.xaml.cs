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

namespace WPFModernVerticalMenu.Pages
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }
        Random random= new Random();
        Button btn;
        Button[] buttons;
        bool Start = true;
        Button RandoBTN;
        bool botWhile = true;
        string i;
        bool win = false;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            btnX.IsEnabled = false;
            btnO.IsEnabled = false;

            btn = (Button)sender;
            switch (i)
            {
                case "X":
                    btn.Content = i; 
                    btn.Foreground = Brushes.Red; 
                    btn.IsEnabled = false;
                    break;
                case "O":
                    btn.Content = i; 
                    btn.Foreground = Brushes.Blue;
                    btn.IsEnabled = false;
                    break;
            };
            gg();
            bot();
            gg();
            WinMatch();
        }
        private void gg()
        {
            if (button1.Content == "X" && button2.Content == "X" && button3.Content == "X")  { text_w_l.Text = "Крестики победили"; win = true; botWhile = false; }
            else if  (button1.Content == "O" && button2.Content == "O" && button3.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button4.Content == "X" && button5.Content == "X" && button6.Content == "X") { text_w_l.Text = "Крестики победили"; text_w_l.Visibility = Visibility.Visible; win = true; botWhile = false; }
            else if (button4.Content == "O" && button5.Content == "O" && button6.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button7.Content == "X" && button8.Content == "X" && button9.Content == "X") { text_w_l.Text = "Крестики победили"; text_w_l.Visibility = Visibility.Visible; win = true; botWhile = false; }
            else if (button7.Content == "O" && button8.Content == "O" && button9.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button1.Content == "X" && button5.Content == "X" && button9.Content == "X") { text_w_l.Text = "Крестики победили"; text_w_l.Visibility = Visibility.Visible; win = true; botWhile = false; }
            else if (button1.Content == "O" && button5.Content == "O" && button9.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button3.Content == "X" && button5.Content == "X" && button7.Content == "X") { text_w_l.Text = "Крестики победили"; text_w_l.Visibility = Visibility.Visible; win = true; botWhile = false; }
            else if (button3.Content == "O" && button5.Content == "O" && button7.Content == "O") { text_w_l.Text = "Ноликики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button1.Content == "X" && button4.Content == "X" && button7.Content == "X") { text_w_l.Text = "Крестики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button1.Content == "O" && button4.Content == "O" && button7.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button2.Content == "X" && button5.Content == "X" && button8.Content == "X") { text_w_l.Text = "Крестики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button2.Content == "O" && button5.Content == "O" && button8.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else if (button3.Content == "X" && button6.Content == "X" && button9.Content == "X") { text_w_l.Text = "Крестики победили"; win = true; botWhile = false; }
            else if (button3.Content == "O" && button6.Content == "O" && button9.Content == "O") { text_w_l.Text = "Нолики победили"; win = true; text_w_l.Visibility = Visibility.Visible; botWhile = false; }
            else {
                int count = 0;
                foreach (Button but in buttons) 
                {
                    if (!but.IsEnabled)
                    {
                        count++;
                    }
                    if (count == 9) { text_w_l.Text = "Ничья"; win = true; botWhile = false; }
                }
            }
        }

        private void reserbutton_Click(object sender, RoutedEventArgs e)
        {
            switch (Start)
            {
                case false:
                    i = "";
                    botWhile = true;
                    text_w_l.Text = "";
                    win = false;
                    btnX.IsEnabled = true;
                    btnO.IsEnabled = true;
                    btnX.IsChecked = false;
                    btnO.IsChecked = false;
                    reserbutton.Content = "START";
                    foreach (Button button in buttons)
                    {
                        button.Content = "";
                        button.IsEnabled = false;
                    }
                    break;
                case true:
                    buttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                    foreach (Button button in buttons)
                    {
                        button.IsEnabled = true;
                        reserbutton.Content = "RESET";
                        Start = false;
                    }
                    break;
            }
            if (i == "O")
            {
                bot();
            }
        }

        private void Button_x_o_Click(object sender, RoutedEventArgs e)
        {

            if (btnX.IsChecked == true)
            {
                i = "X";
                reserbutton.IsEnabled = true;
                Start = true;
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

            if (btnO.IsChecked == true)
            {
                i = "O";
                reserbutton.IsEnabled = true;
                Start = true;
            }

        }
        public void WinMatch()
        {
            if (win == true) {
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                }
            } 
        }
        public void bot()
        {
            if (botWhile == true)
            {
                while (true)
                {
                    RandoBTN = buttons[random.Next(9)];
                    if (RandoBTN.IsEnabled) break;
                }
                if (i == "X") { RandoBTN.Content = "O"; RandoBTN.Foreground = Brushes.Blue; RandoBTN.IsEnabled = false; }
                else { RandoBTN.Content = "X"; RandoBTN.Foreground = Brushes.Red; RandoBTN.IsEnabled = false; }
            }
        }
    }
}
