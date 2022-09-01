using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace Touhou_Music_Quiz
{
    public partial class TouhouMusicQuiz : Form
    {
        public TouhouMusicQuiz()
        {
            InitializeComponent();
            if(!Directory.Exists("Music MP3"))
            {
                MessageBox.Show("Music folder was not found! Check if you downloaded folder \"Music MP3\" and if it's located in the same directory as the Quiz!");
                Close();
            }
            this.Icon = Properties.Resources.iconforquiz;
            FormClosing += OnExitMethod;
            string wrongfiles = "";
            foreach (string s in Directory.GetFiles("Music MP3"))
            {
                try
                {
                    if (s.Contains(".mp3"))
                    {
                        string[] ssplit = s.Replace(".mp3", "").Replace("Music MP3\\", "").Split('-');
                        Music m = null;
                        if (GameNames.Keys.Contains(ssplit[1]))
                            m = new Music(GameNames[ssplit[1]], ssplit[0].Split(' ').ToList(), s, s.Contains("-Alt"), s.Contains("-Fig"), s.Contains("-Dup"), s.Contains("-Mai"));
                        else
                            m = new Music(ssplit[1], ssplit[0].Split(' ').ToList(), s, s.Contains("-Alt"), s.Contains("-Fig"), s.Contains("-Dup"), s.Contains("-Mai"));
                    }
                }
                catch
                {
                    wrongfiles += "\n" + s;
                }
            }
            if(wrongfiles != "")
            {
                MessageBox.Show("Music MP3 folder contained some files that were formated in a wrong way. The correct way is \"CorrectAnswersSeparatedWithSpacebar-GameName\nWrong files: " + wrongfiles);
                Close();
            }
            if(MusicList.Count() < 5)
            {
                MessageBox.Show("There are less than 5 music tracks in the folder, as such, the program cannot function normally.");
                Close();
            }
            CheckForIllegalCrossThreadCalls = false;
            Player.settings.enableErrorDialogs = false;
        }
        public static int Points = 0;
        public static bool ExitApp = false;
        public static Random randomGenerator = new Random();

        public static List<Music> MusicList = new List<Music>();
        public static List<int> FilteredMusicList = new List<int>();
        public static List<int> Occurances = new List<int>();

        public static Dictionary<string, string> GameNames = new Dictionary<string, string>
        {
            {"6","Embodiment of Scarlet Devil"},
            {"7","Perfect Cherry Blossom"},
            {"7.5","Immaterial and Missing Power"},
            {"8","Imperishable Night"},
            {"9","Phantasmagoria of Flower View"},
            {"9.5","Shoot the Bullet"},
            {"10","Mountain of Faith"},
            {"10.5","Scarlet Weather Rhapsody"},
            {"11","Subterrean Animism"},
            {"12","Undefined Fantastic Object"},
            {"12.3","Touhou Hisoutensoku"},
            {"12.5","Double Spoiler"},
            {"12.8","Great Fairy Wars"},
            {"13","Ten Desires"},
            {"13.5","Hopeless Masquerade"},
            {"14","Double Dealing Character"},
            {"14.3","Impossible Spell Card"},
            {"14.5","Urban Legend in Limbo"},
            {"15","Legacy of Lunatic Kingdom"},
            {"15.5","Antinomy of Common Flowers"},
            {"16","Hidden Star in Four Seasons"},
            {"16.5","Violet Detector"},
            {"17","Willy Beast and Weakest Creature"},
        };
        public bool ThreadsInitialized = false;

        public void OnExitMethod(object sender, EventArgs e)
        {
            ExitApp = true;
        }

        public void InitializeQuiz()
        {
        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            MainMenuPanel.Enabled = false;

            if (FourSeconds.Checked)
                TimeLimit = 40;
            else if (TenSeconds.Checked)
                TimeLimit = 100;
            else if (ThirtySeconds.Checked)
                TimeLimit = 300;
            else if (OneMinute.Checked)
                TimeLimit = 560;
            else if (TwoSeconds.Checked)
                TimeLimit = 20;
            else if (OneSecond.Checked)
                TimeLimit = 10;
            else if (HalfSecond.Checked)
                TimeLimit = 5;
            else if (Manual.Checked)
            {
                TimeLimit = 40;
                ManualTimeLimit = true;
            }

            QuizPanel.Visible = true;
            QuizPanel.Enabled = true;
            FilteredMusicList.Clear();
            int n = -1;
            foreach (Music m in MusicList)
            {
                n++;
                if (m.Duplicate && !DuplicateSongsCheck.Checked)
                    continue;
                if (m.Alt && !AlternateThemes.Checked)
                    continue;
                if (m.Fighting && !FightingCheck.Checked)
                    continue;
                if (m.MainMenu && !MainMenuThemes.Checked)
                    continue;
                FilteredMusicList.Add(n);
            }
            if (!ThreadsInitialized)
            {
                Thread t = new Thread(TimeLimitLoop);
                t.Start();
                Thread t2 = new Thread(GameLoop);
                t2.Start();
                ThreadsInitialized = true;
            }

            for (int a = 0; a < Occurances.Count; a++)
            {
                Occurances[a] = 0;
            }

            if (AllowGameClues.Checked)
                GiveGameClueButton.Enabled = true;
            MusicProgressBar.Maximum = TimeLimit;

            ChangeMusic();
        }

        public static bool Paused = false;
        public static bool PausedChanged = false;
        public static bool AnswerShown = false;

        public static int StartingPoint = 0;

        public static bool Stopped = false;
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        public static int TimeLimit = 10;
        public static bool ManualTimeLimit = false;

        public void PlayMusic()
        {
            Player.controls.play();          
        }
        public void PauseMusic()
        {
            Player.controls.pause();
        }
        public void StopMusic()
        {
            bool playing = Player.playState == WMPLib.WMPPlayState.wmppsPlaying;
            Player.controls.stop();
            if (DifferentParts.Checked)
                Player.controls.currentPosition = StartingPoint;
            if (playing)
                Player.controls.play();
            else
            {
                Player.controls.play();
                Player.controls.pause();
            }
        }
        public void ChangeMusic()
        {
            if (Player.playState != WMPLib.WMPPlayState.wmppsStopped)
                Player.controls.stop();

            for (int a = 0; a < Occurances.Count; a++)
            {
                if (Occurances[a] > 0)
                    Occurances[a]--;
            }

            if (ManualTimeLimit)
            {
                TimeLimit = 40;
                MusicProgressBar.Maximum = 40;
            }
            int index = -1;

            do
            {
                index = FilteredMusicList[randomGenerator.Next(0, FilteredMusicList.Count())];
            }
            while (Occurances[index] != 0);
            CurrentMusic = MusicList[index];
            Occurances[index] = 10;

           

            Player.URL = CurrentMusic.Path;
            if (DifferentParts.Checked)
            {
                StartingPoint = randomGenerator.Next(0, 41);
                Player.controls.currentPosition = StartingPoint;
            }
            Player.controls.play();


            AnswerTextBox.Text = "";
            PlayPauseButton.Text = "▍ ▍";
            GameClueBox.Text = "";
            if(AllowGameClues.Checked)
                GiveGameClueButton.Enabled = true;
            
        }
        
        public int GetMusicPosition()
        {
            tryagain:
            try
            {
                int x = (int)(Player.controls.currentPosition * 10) - (StartingPoint * 10);
                if (x < 0)
                    return 0;
                else
                    return x;
            }
            catch
            {
                goto tryagain;            
            }
        }

        public void TimeLimitLoop()
        {
            while (true)
            {                
                Thread.Sleep(10);                  
                if (ExitApp)
                    break;
                if (GetMusicPosition() < MusicProgressBar.Maximum)
                {
                    MusicProgressBar.Value = MusicProgressBar.Maximum;
                    MusicProgressBar.Value = GetMusicPosition();
                }
                else if(MusicProgressBar.Value != MusicProgressBar.Maximum)
                {
                    MusicProgressBar.Maximum += 1;
                    MusicProgressBar.Value = MusicProgressBar.Maximum;
                    MusicProgressBar.Value = GetMusicPosition();
                    MusicProgressBar.Maximum -= 1;
                }

                if(GetMusicPosition() >= TimeLimit)
                {
                    PauseMusic();
                    PlayPauseButton.Text = "▶️";
                }
            }
        }

        public static Music CurrentMusic = null;


        public void GameLoop()
        {
            while (true)
            {
                Thread.Sleep(10);
                try
                {
                    if (!AnswerShown)
                    {
                        if (CurrentMusic.Answers.Any(x => x.ToLower() == AnswerTextBox.Text.ToLower()))
                        {
                            Points++;
                            ChangeMusic();
                        }
                    }
                }
                catch
                {

                }
                if (ExitApp)
                    break;
            }

        }


        public class Music
        {
            public string GameTitle = "";
            public List<string> Answers = new List<string>() { };
            public string Path = "";
            public bool Alt = false;
            public bool Fighting = false;
            public bool Duplicate = false;
            public bool MainMenu = false;
            /// <summary>
            /// Creating new music entry
            /// </summary>
            /// <param name="t">Title - Name of game from which this theme was taken</param>
            /// <param name="ans">Answers - correct answers for question, name or surename (or title, in case of Shikieiki)</param>
            /// <param name="a">Alternate - indicates if theme is not the original (first one) of the character, only exception are Reimu and Marisa, as they had themes in PC-98 Era as well as themes in IaMP but their original in Quiz are the ones from IN</param>
            /// <param name="f">Fighting - indicates if it was from a fighting game</param>
            /// <param name="d">Duplicate - example: Aya from MoF and PoFV or Yuyuko from PCB and TD</param>
            /// <param name="p">Path - path to the music</param>
            /// <param name="m">Main Menu - indicates if it is a main menu theme</param>
            public Music(string t, List<string> ans, string p, bool a = false, bool f = false, bool d = false, bool m = false)
            {
                GameTitle = t;
                Answers = ans;
                Alt = a;
                Fighting = f;
                Duplicate = d;
                Path = p;
                MainMenu = m;
                MusicList.Add(this);
                Occurances.Add(0);
            }

        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            if (GetMusicPosition() < TimeLimit)
            {
                if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    PlayMusic();
                    PlayPauseButton.Text = "▍ ▍";
                }
                else
                {
                    PauseMusic();
                    PlayPauseButton.Text = "▶️";
                }
            }
            else
            {
                PlayPauseButton.Text = "▍ ▍";
                Player.controls.stop();
                if (DifferentParts.Checked)
                    Player.controls.currentPosition = StartingPoint;
                PlayMusic();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        private void GiveGameClueButton_Click(object sender, EventArgs e)
        {
            GiveGameClueButton.Enabled = false;
            if(!CurrentMusic.MainMenu)
                GameClueBox.Text = CurrentMusic.GameTitle;
            else
                GameClueBox.Text = "Main menu theme";
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            if (AnswerShown)
            {            
                AnswerTextBox.Enabled = true;
                AnswerTextBox.ReadOnly = false;
                SkipButton.Text = "Show answer";
                ChangeMusic();
                AnswerShown = false;
            }
            else
            {
                AnswerShown = true;
                string a = "";
                CurrentMusic.Answers.ForEach(x => a += x + " ");
                AnswerTextBox.Text = a;
                AnswerTextBox.Enabled = false;
                AnswerTextBox.ReadOnly = true;
                SkipButton.Text = "Skip";
            }
        }

        private void MoreTimeButton_Click(object sender, EventArgs e)
        {
            TimeLimit = 0;
            Paused = false;
            PausedChanged = true;
            PlayPauseButton.Text = "▍ ▍";            
            MoreTimeButton.Enabled = false;
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            PauseMusic();
            QuizPanel.Visible = false;
            QuizPanel.Enabled = false;
            MainMenuPanel.Visible = true;
            MainMenuPanel.Enabled = true;
        }

       
    }
}


