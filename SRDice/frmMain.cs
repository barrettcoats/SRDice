using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SrDice
{
    public partial class FrmMain : Form
    {
        private const int NumberOfDiceSides = 6;
        private readonly Random _random = new Random();

        private bool _modeIsShadowRun3 = true;

        public FrmMain()
        {
            InitializeComponent();
            Text = "Shadowrun Dice Roller v" + GetVersionNumber();
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
        private void BtnChangeMode_Click(object sender, EventArgs e)
        {
            _modeIsShadowRun3 = !_modeIsShadowRun3;

            lblCurrentMode.Text = _modeIsShadowRun3 ? "SR3" : "SR4";
            chkRuleOfSix.Enabled = _modeIsShadowRun3;
            lblTarget.Text = _modeIsShadowRun3 ? "Target Number:" : "Threshold:";
        }

        private void BtnRollDice_Click(object sender, EventArgs e)
        {
            var diceRolls = RollDice();
            txtOutput.Text = GenerateOutput(diceRolls);
        }

        private static string GetVersionNumber()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private List<int> RollDice()
        {
            var diceRolls = new List<int>();
            for (var i = 0; i < nudNumberOfDice.Value; i++)
            {
                var currentRoll = _random.Next(1, NumberOfDiceSides + 1);
                if (chkRuleOfSix.Checked && currentRoll == NumberOfDiceSides)
                {
                    // Continue rolling until 6 is no longer thrown.
                    for (var j = 1; currentRoll == j * NumberOfDiceSides; j++)
                    {
                        currentRoll += _random.Next(1, NumberOfDiceSides + 1);
                    }
                }
                diceRolls.Add(currentRoll);
            }

            return diceRolls;
        }

        private string GenerateOutput(List<int> diceRolls)
        {
            var targetNumber = nudTargetNumber.Value;
            var numberOfDice = nudNumberOfDice.Value;

            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"Rolling _{numberOfDice}_ d6:\r\n");

            stringBuilder.Append(string.Join("\r\n", diceRolls.Select(r => r.ToString()).ToArray()));

            stringBuilder.Append("\r\n\r\n");

            var numberOfOnesRolled = diceRolls.Count(x => x == 1);

            if (_modeIsShadowRun3)
            {
                if (numberOfOnesRolled == numberOfDice)
                {
                    stringBuilder.Append("You rolled all 1s. You glitched, drekhead.\r\n\r\n");
                }

                if (targetNumber != 0)
                {
                    var numberOfSuccesses = diceRolls.Count(x => x >= targetNumber);
                    stringBuilder.Append($"Successes: {numberOfSuccesses}");
                }
            }
            else
            {
                if (numberOfOnesRolled > numberOfDice / 2)
                {
                    stringBuilder.Append("You rolled 1/2 your dice as 1s. You glitched, drekhead.\r\n\r\n");
                }

                var numberOfHits = diceRolls.Count(x => x >= 5);
                stringBuilder.Append($"# of hits: {numberOfHits}");

                var thresholdStatus = numberOfHits >= targetNumber ? "Passed" : "Failed";
                stringBuilder.Append($"\r\nThreshold {thresholdStatus}");
            }

            return stringBuilder.ToString();
        }

    }
}
