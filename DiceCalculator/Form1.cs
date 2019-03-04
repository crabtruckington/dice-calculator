using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceCalculator
{
    public partial class diceCalc : Form
    {
        public diceCalc()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int dice = Convert.ToInt32(diceEntryBox.Value);
            List<bool> resultList = new List<bool>();
            List<int> diceRollResultsList = new List<int>();
            int diceResult = 0;
            Random random = new Random();

            for (int j = 0; j < 1000000; j++)
            {
                diceRollResultsList.Clear();
                for (int i = 0; i < dice; i++)
                {
                    diceResult = random.Next(1, Convert.ToInt32(diceSidesBox.Value) + 1);
                    diceRollResultsList.Add(diceResult);
                }
                List<int> totalSuccessList = diceRollResultsList.Where(x => x >= Convert.ToInt32(minSuccValueBox.Value)).ToList();
                List<int> totalFailureList = diceRollResultsList.Where(x => x <= Convert.ToInt32(minFailValueBox.Value)).ToList();

                if (totalSuccessList.Count >= Convert.ToInt32(hitsValBox.Value))
                {
                    resultList.Add(true);
                }
                else if (totalFailureList.Count >= Convert.ToInt32(failValBox.Value))
                {
                    resultList.Add(false);
                }
            }

            int totalSucc = resultList.Count(x => x);
            int totalFail = resultList.Count(x => !x);

            resultsTextBox.Text += "Rolling " + Convert.ToString(diceEntryBox.Value) + " " + Convert.ToString(diceSidesBox.Value) + " sided dice 1,000,000 times, you received a result of " +
               Convert.ToString(hitsValBox.Value) + " or more " + Convert.ToString(minSuccValueBox.Value) + "'s or higher " +
               Convert.ToString(Convert.ToDecimal(totalSucc) / 10000) + "% of the time." + Environment.NewLine;

            resultsTextBox.Text += "Rolling " + Convert.ToString(diceEntryBox.Value) + " " + Convert.ToString(diceSidesBox.Value) + " sided dice 1,000,000 times, you received a result of " +
              Convert.ToString(failValBox.Value) + " or more " + Convert.ToString(minFailValueBox.Value) + "'s or lower " +
              Convert.ToString(Convert.ToDecimal(totalFail) / 10000) + "% of the time." + Environment.NewLine;

            resultsTextBox.Text += "Total successes: " + Convert.ToString(totalSucc) + Environment.NewLine;
            resultsTextBox.Text += "Total fails : " + Convert.ToString(totalFail) + Environment.NewLine + Environment.NewLine;

            resultsTextBox.SelectionStart = resultsTextBox.Text.Length;
            resultsTextBox.ScrollToCaret();

        }

        private void diceSidesBox_ValueChanged(object sender, EventArgs e)
        {
            hitsValBox.Maximum = diceEntryBox.Value;
            failValBox.Maximum = diceEntryBox.Value;
        }
    }
}



//unfilteredEquipList.Where(x => x.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
