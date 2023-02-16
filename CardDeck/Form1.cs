using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDeck
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        // deck of cards
        List<string> deck = new List<string>();
        List<string> playerCards = new List<string>();
        List<string> drawerCards = new List<string>();
        List<string> deckTemp = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
            //fill deck with standard 52 cards
            //H - Hearts, D - Diamonds, C - Clubs, S - Spades
            
            deck.AddRange(new string[] {"2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH", "AH" });
            deck.AddRange(new string[] {"2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AD" });
            deck.AddRange(new string[] {"2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AC" });
            deck.AddRange(new string[] {"2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AS" });

            ShowDeck();
        }

        public void ShowDeck()
        {

        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();

            while (deck.Count > 0)
            {
                int index = randGen.Next(0, deck.Count);                
                deckTemp.Add(deck[index]);
                deck.RemoveAt(index);
            }

            deck = deckTemp;

            outputLabel.Text = $"";
            playerCardsLabel.Text = $"Shuffling...";
            dealerCardsLabel.Text = $"Shuffling...";
            outputLabel.Text = "2H, 3H, 4H, 5H, 6H, 7H, 8H, 9H, 10H, JH, QH, KH, AH, 2D, 3D, 4D, 5D, 6D, 7D, 8D, 9D, 10D, JD, QD, KD, AD, 2C, 3C, 4C, 5C, 6C, 7C, 8C, 9C, 10C, JC, QC, KC, AC, 2S,3S, 4S, 5S, 6S, 7S, 8S, 9S, 10S, JS, QS, KS, AS";

            ShowDeck();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            playerCardsLabel.Text = $"{deckTemp}";
            dealerCardsLabel.Text = $"{deckTemp}";
            outputLabel.Text = $"{deckTemp}";

            ShowDeck();
        }

        private void collectButton_Click(object sender, EventArgs e)
        {
            playerCardsLabel.Text = $"Collecting...";
            dealerCardsLabel.Text = $"Collecting...";
            outputLabel.Text = $"2H, 3H, 4H, 5H, 6H, 7H, 8H, 9H, 10H, JH, QH, KH, AH, 2D, 3D, 4D, 5D, 6D, 7D, 8D, 9D, 10D, JD, QD, KD, AD, 2C, 3C, 4C, 5C, 6C, 7C, 8C, 9C, 10C, JC, QC, KC, AC, 2S,3S, 4S, 5S, 6S, 7S, 8S, 9S, 10S, JS, QS, KS, AS";

            ShowDeck();
        }
    }
}
