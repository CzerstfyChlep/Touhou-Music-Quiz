namespace Touhou_Music_Quiz
{
    partial class TouhouMusicQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch
            {

            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TouhouMusicQuiz));
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.MainMenuThemes = new System.Windows.Forms.CheckBox();
            this.AllowGameClues = new System.Windows.Forms.CheckBox();
            this.DifferentParts = new System.Windows.Forms.CheckBox();
            this.AlternateThemes = new System.Windows.Forms.CheckBox();
            this.FightingCheck = new System.Windows.Forms.CheckBox();
            this.TimeGroup = new System.Windows.Forms.GroupBox();
            this.HalfSecond = new System.Windows.Forms.RadioButton();
            this.OneSecond = new System.Windows.Forms.RadioButton();
            this.TwoSeconds = new System.Windows.Forms.RadioButton();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.OneMinute = new System.Windows.Forms.RadioButton();
            this.FourSeconds = new System.Windows.Forms.RadioButton();
            this.ThirtySeconds = new System.Windows.Forms.RadioButton();
            this.TenSeconds = new System.Windows.Forms.RadioButton();
            this.DuplicateSongsCheck = new System.Windows.Forms.CheckBox();
            this.StartQuizButton = new System.Windows.Forms.Button();
            this.QuizPanel = new System.Windows.Forms.Panel();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.GameClueBox = new System.Windows.Forms.TextBox();
            this.GiveGameClueButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.MoreTimeButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.MusicProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainMenuPanel.SuspendLayout();
            this.TimeGroup.SuspendLayout();
            this.QuizPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.MainMenuThemes);
            this.MainMenuPanel.Controls.Add(this.AllowGameClues);
            this.MainMenuPanel.Controls.Add(this.DifferentParts);
            this.MainMenuPanel.Controls.Add(this.AlternateThemes);
            this.MainMenuPanel.Controls.Add(this.FightingCheck);
            this.MainMenuPanel.Controls.Add(this.TimeGroup);
            this.MainMenuPanel.Controls.Add(this.DuplicateSongsCheck);
            this.MainMenuPanel.Controls.Add(this.StartQuizButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(12, 3);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(363, 305);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // MainMenuThemes
            // 
            this.MainMenuThemes.AutoSize = true;
            this.MainMenuThemes.Location = new System.Drawing.Point(9, 247);
            this.MainMenuThemes.Name = "MainMenuThemes";
            this.MainMenuThemes.Size = new System.Drawing.Size(152, 17);
            this.MainMenuThemes.TabIndex = 11;
            this.MainMenuThemes.Text = "Include main menu themes";
            this.MainMenuThemes.UseVisualStyleBackColor = true;
            // 
            // AllowGameClues
            // 
            this.AllowGameClues.AutoSize = true;
            this.AllowGameClues.Checked = true;
            this.AllowGameClues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllowGameClues.Location = new System.Drawing.Point(9, 224);
            this.AllowGameClues.Name = "AllowGameClues";
            this.AllowGameClues.Size = new System.Drawing.Size(108, 17);
            this.AllowGameClues.TabIndex = 10;
            this.AllowGameClues.Text = "Allow game clues\r\n";
            this.AllowGameClues.UseVisualStyleBackColor = true;
            // 
            // DifferentParts
            // 
            this.DifferentParts.AutoSize = true;
            this.DifferentParts.Location = new System.Drawing.Point(9, 201);
            this.DifferentParts.Name = "DifferentParts";
            this.DifferentParts.Size = new System.Drawing.Size(241, 17);
            this.DifferentParts.TabIndex = 9;
            this.DifferentParts.Text = "Use different parts of songs (Normal or higher)\r\n";
            this.DifferentParts.UseVisualStyleBackColor = true;
            // 
            // AlternateThemes
            // 
            this.AlternateThemes.AutoSize = true;
            this.AlternateThemes.Location = new System.Drawing.Point(9, 178);
            this.AlternateThemes.Name = "AlternateThemes";
            this.AlternateThemes.Size = new System.Drawing.Size(338, 17);
            this.AlternateThemes.TabIndex = 8;
            this.AlternateThemes.Text = "Include alternate themes (mostly SWR - same music, diferent style)";
            this.AlternateThemes.UseVisualStyleBackColor = true;
            // 
            // FightingCheck
            // 
            this.FightingCheck.AutoSize = true;
            this.FightingCheck.Checked = true;
            this.FightingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FightingCheck.Location = new System.Drawing.Point(9, 155);
            this.FightingCheck.Name = "FightingCheck";
            this.FightingCheck.Size = new System.Drawing.Size(132, 17);
            this.FightingCheck.TabIndex = 7;
            this.FightingCheck.Text = "Include fighting games";
            this.FightingCheck.UseVisualStyleBackColor = true;
            // 
            // TimeGroup
            // 
            this.TimeGroup.Controls.Add(this.HalfSecond);
            this.TimeGroup.Controls.Add(this.OneSecond);
            this.TimeGroup.Controls.Add(this.TwoSeconds);
            this.TimeGroup.Controls.Add(this.Manual);
            this.TimeGroup.Controls.Add(this.OneMinute);
            this.TimeGroup.Controls.Add(this.FourSeconds);
            this.TimeGroup.Controls.Add(this.ThirtySeconds);
            this.TimeGroup.Controls.Add(this.TenSeconds);
            this.TimeGroup.Location = new System.Drawing.Point(3, 3);
            this.TimeGroup.Name = "TimeGroup";
            this.TimeGroup.Size = new System.Drawing.Size(352, 114);
            this.TimeGroup.TabIndex = 5;
            this.TimeGroup.TabStop = false;
            this.TimeGroup.Text = "Time";
            // 
            // HalfSecond
            // 
            this.HalfSecond.AutoSize = true;
            this.HalfSecond.Location = new System.Drawing.Point(7, 17);
            this.HalfSecond.Name = "HalfSecond";
            this.HalfSecond.Size = new System.Drawing.Size(193, 17);
            this.HalfSecond.TabIndex = 9;
            this.HalfSecond.Text = "0.5 Second [Are you even human?]";
            this.HalfSecond.UseVisualStyleBackColor = true;
            // 
            // OneSecond
            // 
            this.OneSecond.AutoSize = true;
            this.OneSecond.Location = new System.Drawing.Point(7, 40);
            this.OneSecond.Name = "OneSecond";
            this.OneSecond.Size = new System.Drawing.Size(108, 17);
            this.OneSecond.TabIndex = 8;
            this.OneSecond.Text = "1 Second [Raiko]";
            this.OneSecond.UseVisualStyleBackColor = true;
            // 
            // TwoSeconds
            // 
            this.TwoSeconds.AutoSize = true;
            this.TwoSeconds.Location = new System.Drawing.Point(7, 63);
            this.TwoSeconds.Name = "TwoSeconds";
            this.TwoSeconds.Size = new System.Drawing.Size(120, 17);
            this.TwoSeconds.TabIndex = 7;
            this.TwoSeconds.Text = "2 Seconds [Lunatic]";
            this.TwoSeconds.UseVisualStyleBackColor = true;
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Location = new System.Drawing.Point(207, 86);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(60, 17);
            this.Manual.TabIndex = 6;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            // 
            // OneMinute
            // 
            this.OneMinute.AutoSize = true;
            this.OneMinute.Location = new System.Drawing.Point(207, 63);
            this.OneMinute.Name = "OneMinute";
            this.OneMinute.Size = new System.Drawing.Size(124, 17);
            this.OneMinute.TabIndex = 5;
            this.OneMinute.Text = "1 Minute [Why even]";
            this.OneMinute.UseVisualStyleBackColor = true;
            // 
            // FourSeconds
            // 
            this.FourSeconds.AutoSize = true;
            this.FourSeconds.Location = new System.Drawing.Point(7, 86);
            this.FourSeconds.Name = "FourSeconds";
            this.FourSeconds.Size = new System.Drawing.Size(123, 17);
            this.FourSeconds.TabIndex = 2;
            this.FourSeconds.Text = "4 Seconds [Extreme]";
            this.FourSeconds.UseVisualStyleBackColor = true;
            // 
            // ThirtySeconds
            // 
            this.ThirtySeconds.AutoSize = true;
            this.ThirtySeconds.Location = new System.Drawing.Point(207, 40);
            this.ThirtySeconds.Name = "ThirtySeconds";
            this.ThirtySeconds.Size = new System.Drawing.Size(114, 17);
            this.ThirtySeconds.TabIndex = 4;
            this.ThirtySeconds.Text = "30 Seconds [Easy]";
            this.ThirtySeconds.UseVisualStyleBackColor = true;
            // 
            // TenSeconds
            // 
            this.TenSeconds.AutoSize = true;
            this.TenSeconds.Checked = true;
            this.TenSeconds.Location = new System.Drawing.Point(207, 17);
            this.TenSeconds.Name = "TenSeconds";
            this.TenSeconds.Size = new System.Drawing.Size(124, 17);
            this.TenSeconds.TabIndex = 3;
            this.TenSeconds.TabStop = true;
            this.TenSeconds.Text = "10 Seconds [Normal]";
            this.TenSeconds.UseVisualStyleBackColor = true;
            // 
            // DuplicateSongsCheck
            // 
            this.DuplicateSongsCheck.AutoSize = true;
            this.DuplicateSongsCheck.Checked = true;
            this.DuplicateSongsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DuplicateSongsCheck.Location = new System.Drawing.Point(10, 132);
            this.DuplicateSongsCheck.Name = "DuplicateSongsCheck";
            this.DuplicateSongsCheck.Size = new System.Drawing.Size(303, 17);
            this.DuplicateSongsCheck.TabIndex = 1;
            this.DuplicateSongsCheck.Text = "Include duplicate characters (ex. Aya 9-10 or Yuyuko 7-13)";
            this.DuplicateSongsCheck.UseVisualStyleBackColor = true;
            // 
            // StartQuizButton
            // 
            this.StartQuizButton.Location = new System.Drawing.Point(9, 270);
            this.StartQuizButton.Name = "StartQuizButton";
            this.StartQuizButton.Size = new System.Drawing.Size(346, 29);
            this.StartQuizButton.TabIndex = 0;
            this.StartQuizButton.Text = "Start Quiz";
            this.StartQuizButton.UseVisualStyleBackColor = true;
            this.StartQuizButton.Click += new System.EventHandler(this.StartQuizButton_Click);
            // 
            // QuizPanel
            // 
            this.QuizPanel.Controls.Add(this.BackToMenu);
            this.QuizPanel.Controls.Add(this.GameClueBox);
            this.QuizPanel.Controls.Add(this.GiveGameClueButton);
            this.QuizPanel.Controls.Add(this.SkipButton);
            this.QuizPanel.Controls.Add(this.MoreTimeButton);
            this.QuizPanel.Controls.Add(this.AnswerTextBox);
            this.QuizPanel.Controls.Add(this.StopButton);
            this.QuizPanel.Controls.Add(this.PlayPauseButton);
            this.QuizPanel.Controls.Add(this.MusicProgressBar);
            this.QuizPanel.Location = new System.Drawing.Point(12, 9);
            this.QuizPanel.Name = "QuizPanel";
            this.QuizPanel.Size = new System.Drawing.Size(363, 305);
            this.QuizPanel.TabIndex = 1;
            this.QuizPanel.Visible = false;
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(9, 276);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(346, 23);
            this.BackToMenu.TabIndex = 8;
            this.BackToMenu.Text = "Back to menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // GameClueBox
            // 
            this.GameClueBox.Enabled = false;
            this.GameClueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameClueBox.Location = new System.Drawing.Point(85, 169);
            this.GameClueBox.Name = "GameClueBox";
            this.GameClueBox.ReadOnly = true;
            this.GameClueBox.Size = new System.Drawing.Size(274, 24);
            this.GameClueBox.TabIndex = 7;
            // 
            // GiveGameClueButton
            // 
            this.GiveGameClueButton.Enabled = false;
            this.GiveGameClueButton.Location = new System.Drawing.Point(4, 168);
            this.GiveGameClueButton.Name = "GiveGameClueButton";
            this.GiveGameClueButton.Size = new System.Drawing.Size(75, 25);
            this.GiveGameClueButton.TabIndex = 6;
            this.GiveGameClueButton.Text = "Game clue";
            this.GiveGameClueButton.UseVisualStyleBackColor = true;
            this.GiveGameClueButton.Click += new System.EventHandler(this.GiveGameClueButton_Click);
            // 
            // SkipButton
            // 
            this.SkipButton.Location = new System.Drawing.Point(3, 132);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(356, 23);
            this.SkipButton.TabIndex = 5;
            this.SkipButton.Text = "Show Answer";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // MoreTimeButton
            // 
            this.MoreTimeButton.Enabled = false;
            this.MoreTimeButton.Location = new System.Drawing.Point(3, 103);
            this.MoreTimeButton.Name = "MoreTimeButton";
            this.MoreTimeButton.Size = new System.Drawing.Size(356, 23);
            this.MoreTimeButton.TabIndex = 4;
            this.MoreTimeButton.Text = "More music";
            this.MoreTimeButton.UseVisualStyleBackColor = true;
            this.MoreTimeButton.Click += new System.EventHandler(this.MoreTimeButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnswerTextBox.Location = new System.Drawing.Point(9, 226);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(346, 44);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopButton.Location = new System.Drawing.Point(4, 44);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(175, 53);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "⬛";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayPauseButton.Location = new System.Drawing.Point(185, 44);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(175, 53);
            this.PlayPauseButton.TabIndex = 1;
            this.PlayPauseButton.Text = "▍ ▍";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // MusicProgressBar
            // 
            this.MusicProgressBar.Location = new System.Drawing.Point(4, 3);
            this.MusicProgressBar.Name = "MusicProgressBar";
            this.MusicProgressBar.Size = new System.Drawing.Size(356, 35);
            this.MusicProgressBar.TabIndex = 0;
            // 
            // TouhouMusicQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 323);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.QuizPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TouhouMusicQuiz";
            this.Text = "Touhou Music Quiz";
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.TimeGroup.ResumeLayout(false);
            this.TimeGroup.PerformLayout();
            this.QuizPanel.ResumeLayout(false);
            this.QuizPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.RadioButton ThirtySeconds;
        private System.Windows.Forms.RadioButton TenSeconds;
        private System.Windows.Forms.RadioButton FourSeconds;
        private System.Windows.Forms.CheckBox DuplicateSongsCheck;
        private System.Windows.Forms.Button StartQuizButton;
        private System.Windows.Forms.GroupBox TimeGroup;
        private System.Windows.Forms.CheckBox FightingCheck;
        private System.Windows.Forms.CheckBox AlternateThemes;
        private System.Windows.Forms.RadioButton OneMinute;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.Panel QuizPanel;
        private System.Windows.Forms.ProgressBar MusicProgressBar;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Button MoreTimeButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.TextBox GameClueBox;
        private System.Windows.Forms.Button GiveGameClueButton;
        private System.Windows.Forms.RadioButton TwoSeconds;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.CheckBox DifferentParts;
        private System.Windows.Forms.RadioButton OneSecond;
        private System.Windows.Forms.CheckBox AllowGameClues;
        private System.Windows.Forms.RadioButton HalfSecond;
        private System.Windows.Forms.CheckBox MainMenuThemes;
    }
}

