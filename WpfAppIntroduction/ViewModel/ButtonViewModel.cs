using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppIntroduction
{
    /// <summary>
    /// 
    /// </summary>
    public class ButtonViewModel : BaseViewModel
    {        

        #region Constructor

        public ButtonViewModel()
        {

            // Create commands
            DelOpgave12Command = new RelayCommand(DelOpgave12);
            DelOpgave13Command = new RelayCommand(DelOpgave13);
            DelOpgave14Command = new RelayCommand(DelOpgave14);

        }
        #region Properties

        public ListBox ListBox { get; set; } 

        #endregion


        #endregion

        #region Commands

        public ICommand DelOpgave12Command { get; set; }

        public ICommand DelOpgave13Command { get; set; }

        public ICommand DelOpgave14Command { get; set; }

        #endregion


        #region Methods

        private void DelOpgave12()
        {
            ListBox = new ListBox();

            for (int i = 4711; i <= 4736; i++)
            {
                ListBox.Items.Add(i.ToString());
            }
        }

        private void DelOpgave13()
        {
            ListBox = new ListBox();

            var random = new Random();           

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                ListBox.Items.Add(randomNumber.ToString());
            }
        }

        private void DelOpgave14()
        {
            ListBox = new ListBox();

            var list = new List<string>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                list.Add(randomNumber.ToString());
            }

            list.Sort();

            ListBox.Items.Add(list);
        }

        #endregion
    }
}
