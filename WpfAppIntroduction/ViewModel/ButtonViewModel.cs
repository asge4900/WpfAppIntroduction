using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
            DelOpgave15Command = new RelayCommand(DelOpgave15);
            DelOpgave16Command = new RelayCommand(DelOpgave16);
            DelOpgave17Command = new RelayCommand(DelOpgave17);
            DelOpgave19Command = new RelayCommand(DelOpgave19);
        }
        #region Properties

        public ListBox ListBox { get; set; } 

        #endregion


        #endregion

        #region Commands

        /// <summary>
        /// Command for opage 1.2
        /// </summary>
        public ICommand DelOpgave12Command { get; set; }

        /// <summary>
        /// Command for opgave 1.3
        /// </summary>
        public ICommand DelOpgave13Command { get; set; }

        /// <summary>
        /// Command for opgave 1.4
        /// </summary>
        public ICommand DelOpgave14Command { get; set; }

        /// <summary>
        /// Command for opgave 1.5
        /// </summary>
        public ICommand DelOpgave15Command { get; set; }

        /// <summary>
        /// Command for opgave 1.6
        /// </summary>
        public ICommand DelOpgave16Command { get; set; }

        /// <summary>
        /// Command for opgave 1.7
        /// </summary>
        public ICommand DelOpgave17Command { get; set; }

        /// <summary>
        /// Command for opgave 1.9
        /// </summary>
        public ICommand DelOpgave19Command { get; set; }

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

            var list = new List<int>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                list.Add(randomNumber);
            }

            list.Sort();

            foreach (var item in list)
            {
                ListBox.Items.Add(item.ToString()); 
            }
        }

        private void DelOpgave15()
        {
            ListBox = new ListBox();

            var unsortedList = new List<int>();
            var sortedList = new List<int>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                unsortedList.Add(randomNumber);
                sortedList.Add(randomNumber);
            }

            sortedList.Sort();

            for (int i = 0; i < sortedList.Count; i++)
            {
                ListBox.Items.Add($"{unsortedList[i].ToString()} - {sortedList[i].ToString()}");
            }
        }


        private void DelOpgave16()
        {
            ListBox = new ListBox();

            var list = new List<int>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                ListBox.Items.Add(randomNumber.ToString());
                list.Add(randomNumber);
            }

            ListBox.Items.Add(string.Empty);

            ListBox.Items.Add($"Gennemsnitværdi: {GetAverageValue(list)}");
        }

        private void DelOpgave17()
        {
            ListBox = new ListBox();

            var sortedList = new List<int>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);                
                sortedList.Add(randomNumber);
            }

            sortedList.Sort();

            foreach (var number in sortedList)
            {
                ListBox.Items.Add($"{number} - {GetAverageValue(sortedList)} = {number - GetAverageValue(sortedList)}");
            }         
        }

        private void DelOpgave19()
        {
            ListBox = new ListBox();           

            var sortedList = new List<int>();

            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                sortedList.Add(randomNumber);
            }

            sortedList.Sort();

            foreach (var number in sortedList)
            {
                var listBoxItem = new ListBoxItem();

                if (number % 2 != 0)
                {
                    listBoxItem.Background = Brushes.HotPink;
                }

                else
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }

                listBoxItem.Content = ($"{number} - {GetAverageValue(sortedList)} = {number - GetAverageValue(sortedList)}");

                ListBox.Items.Add(listBoxItem);
            }           
        }

        #endregion

        #region Private Helper Methods

        private int GetAverageValue (List<int> list)
        {
            return (int)list.Average();
        }

        #endregion
    }
}
