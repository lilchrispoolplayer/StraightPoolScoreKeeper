using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StraightPoolScoreKeeper
{
    public class Player
    {
        public String Name { get; set; }
        public int CurrentInningCount { get; set; }
        public int TotalCount { get; set; }
        public int BallsPerInning { get; set; }

        public List<int> CurrentInningCountList { get; set; }
        public List<int> BallsPerInningList { get; set; }

        private const string ZERO = "0";
        private readonly int ID;
        private readonly string PLAYER_NAME_TXT;
        private readonly string PLAYER_CURRENT_INNING_COUNT_TXT;
        private readonly string PLAYER_TOTAL_COUNT_TXT;
        private readonly string PLAYER_BALLS_PER_INNING_TXT;
        private readonly string PLAYER_SCORES_TXT;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="id">Id number for player</param>
        public Player(int id)
        {
            ID = id;

            CurrentInningCountList = new List<int>();
            BallsPerInningList = new List<int>();

            PLAYER_NAME_TXT = string.Format("Player{0}Name.txt", ID);
            PLAYER_CURRENT_INNING_COUNT_TXT = string.Format("Player{0}CurrentInningCount.txt", ID);
            PLAYER_TOTAL_COUNT_TXT = string.Format("Player{0}TotalCount.txt", ID);
            PLAYER_BALLS_PER_INNING_TXT = string.Format("Player{0}BallsPerInning.txt", ID);
            PLAYER_SCORES_TXT = string.Format("Player{0}Scores.txt", ID);

            InitFiles();
            LoadFiles();
        }

        /// <summary>
        /// Returns the ID of the player
        /// </summary>
        /// <returns>ID of the player</returns>
        public int GetId()
        {
            return ID;
        }

        /// <summary>
        /// Saves the player's name to their file
        /// </summary>
        public void SaveName()
        {
            SaveField(Name, PLAYER_NAME_TXT);
        }

        /// <summary>
        /// Saves the player's current inning count to their file
        /// </summary>
        public void SaveCurrentInningCount()
        {
            SaveField(CurrentInningCount.ToString(), PLAYER_CURRENT_INNING_COUNT_TXT);
        }

        /// <summary>
        /// Ends the current inning and saves all data to their appropriate files
        /// </summary>
        public void EndInning()
        {
            CurrentInningCountList.Add(CurrentInningCount);
            SaveScores();

            TotalCount = CurrentInningCountList.Sum();
            BallsPerInning = (int)CurrentInningCountList.Average();
            BallsPerInningList.Add(BallsPerInning);

            SaveField(CurrentInningCount.ToString(), PLAYER_CURRENT_INNING_COUNT_TXT);
            SaveField(TotalCount.ToString(), PLAYER_TOTAL_COUNT_TXT);
            SaveField(BallsPerInning.ToString(), PLAYER_BALLS_PER_INNING_TXT);
            CurrentInningCount = 0;
        }

        /// <summary>
        /// Resets the player's stats
        /// </summary>
        public void Reset()
        {
            CurrentInningCount = 0;
            CurrentInningCountList.Clear();
            TotalCount = 0;
            BallsPerInning = 0;

            SaveScores();
            SaveField(CurrentInningCount.ToString(), PLAYER_CURRENT_INNING_COUNT_TXT);
            SaveField(TotalCount.ToString(), PLAYER_TOTAL_COUNT_TXT);
            SaveField(BallsPerInning.ToString(), PLAYER_BALLS_PER_INNING_TXT);
        }

        /// <summary>
        /// Initializes the files associated to the player
        /// </summary>
        private void InitFiles()
        {
            CreateFile(string.Empty, PLAYER_NAME_TXT);
            CreateFile(ZERO, PLAYER_CURRENT_INNING_COUNT_TXT);
            CreateFile(string.Empty, PLAYER_SCORES_TXT);
            CreateFile(ZERO, PLAYER_TOTAL_COUNT_TXT);
            CreateFile(ZERO, PLAYER_BALLS_PER_INNING_TXT);
        }

        /// <summary>
        /// Loads the player's information from their files
        /// </summary>
        private void LoadFiles()
        {
            Name = LoadField(PLAYER_NAME_TXT);
            CurrentInningCount = Convert.ToInt32(LoadField(PLAYER_CURRENT_INNING_COUNT_TXT));

            LoadScores();
            TotalCount = Convert.ToInt32(LoadField(PLAYER_TOTAL_COUNT_TXT));
            BallsPerInning = Convert.ToInt32(LoadField(PLAYER_BALLS_PER_INNING_TXT));
        }

        /// <summary>
        /// Creates a file with a given default line
        /// </summary>
        /// <param name="value">First line of the file</param>
        /// <param name="file">File path</param>
        private void CreateFile(string value, string file)
        {
            if (!File.Exists(file))
            {
                if (string.IsNullOrEmpty(value))
                {
                    File.Create(file).Close();
                }
                else
                {
                    SaveField(value, file);
                }
            }
        }

        /// <summary>
        /// Saves a value to a given file
        /// </summary>
        /// <param name="value">Value to save</param>
        /// <param name="file">File path</param>
        private void SaveField(string value, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(value);
            }
        }

        /// <summary>
        /// Loads a value from a file to its given field
        /// </summary>
        /// <param name="value"></param>
        /// <param name="file"></param>
        private string LoadField(string file)
        {
            if (!File.Exists(file))
                return string.Empty;

            string value = string.Empty;
            using (StreamReader sr = new StreamReader(file))
            {
                value = sr.ReadLine();
            }
            return value;
        }

        /// <summary>
        /// Saves all scores to a file
        /// </summary>
        private void SaveScores()
        {
            File.WriteAllLines(PLAYER_SCORES_TXT,
                CurrentInningCountList.Select(cic => cic.ToString()));
        }

        /// <summary>
        /// Loads all scores from a player's file
        /// </summary>
        private void LoadScores()
        {
            if (!File.Exists(PLAYER_SCORES_TXT) || new FileInfo(PLAYER_SCORES_TXT).Length == 0)
                return;

            CurrentInningCountList.Clear();
            CurrentInningCountList = File.ReadAllLines(PLAYER_SCORES_TXT).Select(cic => Convert.ToInt32(cic)).ToList();
            for (int i = 0; i < CurrentInningCountList.Count; i++)
            {
                BallsPerInningList.Add((int)CurrentInningCountList.Take(i + 1).Average());
            }
        }
    }
}