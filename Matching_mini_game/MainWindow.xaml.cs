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

namespace Matching_mini_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
//Set up a new list and populate it using emoji keyboard (windows key + period key (.))
            List<String> animal_emoji = new List<String>()
            {
                "🦓","🦓",
                "🐒","🐒",
                "🦍","🦍",
                "🐎","🐎",
                "🦌","🦌",
                "🦬","🦬",
                "🐕","🐕",
                "🐖","🐖"
            };
//Create a random number generator.
            Random random = new Random();
//Find every TextBlock in the mainGrid and repeat the following statements for all of them.
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
//Pick a random number between 0 and the numbe of emoji left in the list and call it 'index'.
                int index = random.Next(animal_emoji.Count);
//Use random number called index to get a random emoji from the list.
                string nextEmoji = animal_emoji[index];
//Update the TextBlock with the random emoji from the list.
                textBlock.Text = nextEmoji;
//Remove the random emoji from the list.
                animal_emoji.RemoveAt(index);
            }

        }
    }
}
