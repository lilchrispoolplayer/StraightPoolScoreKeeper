using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StraightPoolScoreKeeper
{
    public partial class StraightPoolScoreKeeperUi : Form
    {
        private Player player1;
        private Player player2;

        private const string PLAYER_1 = "Player1";
        private const int SCORE_SERIES = 0;
        private const int AVERAGE_SERIES = 1;

        public StraightPoolScoreKeeperUi()
        {
            InitializeComponent();

            player1 = new Player(1);
            player2 = new Player(2);

            UpdateUiForPlayer1();
            UpdateUiForPlayer2();
        }

        /// <summary>
        /// Saves the name of player when the Enter key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPlayerNameKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Player player =
                textBox.Name.Contains(PLAYER_1)
                    ? player1
                    : player2;

            player.Name = textBox.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                player.SaveName();
            }
        }

        /// <summary>
        /// Saves the name of the player when the player's textbox loses focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPlayerNameLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Player player =
                textBox.Name.Contains(PLAYER_1)
                    ? player1
                    : player2;

            player.Name = textBox.Text;
            player.SaveName();
        }

        /// <summary>
        /// Save the current inning count of the player when their score changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumPlayerCurrentInningCountValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            Player player =
                numericUpDown.Name.Contains(PLAYER_1)
                    ? player1
                    : player2;

            player.CurrentInningCount = (int)numericUpDown.Value;
            player.SaveCurrentInningCount();
        }

        /// <summary>
        /// Ends the inning for the current player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayerEndInningClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Player player =
                button.Name.Contains(PLAYER_1)
                    ? player1
                    : player2;

            if (!player.Name.StartsWith("*"))
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show(string.Format("It's not player {0}'s turn", player.GetId()), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            player.EndInning();
            UpdateUiForPlayer(player);
            SwapPlayerTurnMarker(player);
        }

        /// <summary>
        /// Resets the information for a given player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlayerResetClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Player player =
                button.Name.Contains(PLAYER_1)
                    ? player1
                    : player2;

            using (new CenterWinDialog(this))
            {
                if (MessageBox.Show(
                    string.Format("Are you sure you want to reset player {0}", player.GetId()),
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    player.Reset();
                    UpdateUiForPlayer(player);
                }
            }
        }

        /// <summary>
        /// Updates the UI for a given player
        /// </summary>
        /// <param name="player"></param>
        private void UpdateUiForPlayer(Player player)
        {
            if (player.GetId() == 1)
            {
                UpdateUiForPlayer1();
            }
            else
            {
                UpdateUiForPlayer2();
            }
        }

        /// <summary>
        /// Updates the UI for player 1
        /// </summary>
        private void UpdateUiForPlayer1()
        {
            txtPlayer1Name.Text = player1.Name;
            numPlayer1CurrentInningCount.Value = player1.CurrentInningCount;
            dgPlayer1CurrentScores.Rows.Clear();
            for (int i = 0; i < player1.CurrentInningCountList.Count; i++)
            {
                dgPlayer1CurrentScores.Rows.Add(i + 1, player1.CurrentInningCountList[i]);
            }
            if (dgPlayer1CurrentScores.Rows.Count > 0)
            {
                dgPlayer1CurrentScores.FirstDisplayedScrollingRowIndex = dgPlayer1CurrentScores.Rows.Count - 1;
                dgPlayer1CurrentScores.Rows[dgPlayer1CurrentScores.Rows.Count - 1].Selected = true;
            }
            txtPlayer1TotalCount.Text = player1.TotalCount.ToString();
            txtPlayer1BallsPerInning.Text = player1.BallsPerInning.ToString();

            if (player1.CurrentInningCountList.Count == 0)
            {
                chtPlayer1AveragesScores.Series[SCORE_SERIES].Points.Clear();
                chtPlayer1AveragesScores.Series[AVERAGE_SERIES].Points.Clear();
                return;
            }

            List<int> player1Scores = player1.CurrentInningCountList.ToList();
            player1Scores.Insert(0, 0);
            chtPlayer1AveragesScores.Series[SCORE_SERIES].Points.DataBindXY(Enumerable.Range(0, player1Scores.Count).ToList(), player1Scores);

            List<int> player1Averages = player1.BallsPerInningList.ToList();
            player1Averages.Insert(0, 0);
            chtPlayer1AveragesScores.Series[AVERAGE_SERIES].Points.DataBindXY(Enumerable.Range(0, player1Averages.Count).ToList(), player1Averages);
        }

        /// <summary>
        /// Updates the UI for player 2
        /// </summary>
        private void UpdateUiForPlayer2()
        {
            txtPlayer2Name.Text = player2.Name;
            numPlayer2CurrentInningCount.Value = player2.CurrentInningCount;
            dgPlayer2CurrentScores.Rows.Clear();
            for (int i = 0; i < player2.CurrentInningCountList.Count; i++)
            {
                dgPlayer2CurrentScores.Rows.Add(i + 1, player2.CurrentInningCountList[i]);
            }
            if (dgPlayer2CurrentScores.Rows.Count > 0)
            {
                dgPlayer2CurrentScores.FirstDisplayedScrollingRowIndex = dgPlayer2CurrentScores.Rows.Count - 1;
                dgPlayer2CurrentScores.Rows[dgPlayer2CurrentScores.Rows.Count - 1].Selected = true;
            }
            txtPlayer2TotalCount.Text = player2.TotalCount.ToString();
            txtPlayer2BallsPerInning.Text = player2.BallsPerInning.ToString();

            if (player2.CurrentInningCountList.Count == 0)
            {
                chtPlayer2AveragesScores.Series[SCORE_SERIES].Points.Clear();
                chtPlayer2AveragesScores.Series[AVERAGE_SERIES].Points.Clear();
                return;
            }

            List<int> player2Scores = player2.CurrentInningCountList.ToList();
            player2Scores.Insert(0, 0);
            chtPlayer2AveragesScores.Series[SCORE_SERIES].Points.DataBindXY(Enumerable.Range(0, player2Scores.Count).ToList(), player2Scores);

            List<int> player2Averages = player2.BallsPerInningList.ToList();
            player2Averages.Insert(0, 0);
            chtPlayer2AveragesScores.Series[AVERAGE_SERIES].Points.DataBindXY(Enumerable.Range(0, player2Averages.Count).ToList(), player2Averages);
        }

        /// <summary>
        /// Swaps the player's turn marker
        /// </summary>
        private void SwapPlayerTurnMarker(Player player)
        {
            if (player == player1)
            {
                if (player1.Name.StartsWith("*"))
                {
                    player1.Name = player1.Name.Remove(0, 1);
                }
                player2.Name = player2.Name.Insert(0, "*");
            }
            else 
            {
                if (player2.Name.StartsWith("*"))
                {
                    player2.Name = player2.Name.Remove(0, 1);
                }
                player1.Name = player1.Name.Insert(0, "*");
            }

            player1.SaveName();
            player2.SaveName();

            txtPlayer1Name.Text = player1.Name;
            txtPlayer2Name.Text = player2.Name;
        }
    }
}
