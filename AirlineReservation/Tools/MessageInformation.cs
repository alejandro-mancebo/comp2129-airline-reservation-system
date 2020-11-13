using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Presentation.Tools
{
    public static class MessageInformation
    {

        public static void Success(string message)
        {
            string caption = "Modification Access";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result = MessageBox.Show(message, caption, buttons, icon);
        }


        public static void Error(string message)
        {
            string caption = "Modification Access";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBoxResult result = MessageBox.Show(message, caption, buttons, icon);
        }


        public static void Information(string message)
        {
            string caption = "Information";
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result = MessageBox.Show(message, caption, buttons, icon);
        }
    }
}
