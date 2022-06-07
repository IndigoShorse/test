

        private Team[] all_teams = new Team[n];
        private Team[] half_final = new Team[4];
        private Team[] final = new Team[2];


        // В момент запуска программы
        public index()
        {
            InitializeComponent();
            for (int i = 0; i < n; i++)
            {
                all_teams[i] = new();
                all_teams[i].name = "Team " + (i + 1).ToString();
            }
            team1Box.Text = all_teams[0].name;
            team2Box.Text = all_teams[1].name;
        }
        // Функция глубокого копирования команды
        private void CloneTeamData(Team team1, ref Team team2)
        {
            if (team1 == null)
                return;
            team2 = new();

            Array.Copy(team1.points, team2.points, 5);
            Array.Copy(team1.goals, team2.goals, 5);
            Array.Copy(team1.miss, team2.miss, 5);
            Array.Copy(team1.foe_names, team2.foe_names, 5);
            team2.name = (string)team1.name.Clone();
            team2.last_game = team1.last_game;
            team2.total = team1.total;
        }
        private void GoToHalfFinal()
        {
            game = 2;
            ind_1 = 0;
            ind_2 = 1;
            gameLabel.Text = "Полуфинал";
            for (int i = 0; i < x; i++)
            {
                Team buffer = null;
                for (int j = 0; j < x; j++)
                    if (all_teams[i + j * x].ComparePoints(buffer, 3) >= 0)
                        buffer = all_teams[i + j * x];
                CloneTeamData(buffer, ref half_final[i]);
            }
            team1Box.Text = half_final[0].name;
            team2Box.Text = half_final[1].name;
        }
        private void GoToFinal()
        {
            game = 3;
            ind_1 = 0;
            ind_2 = 1;
            gameLabel.Text = "Финал";
            Team buf_1 = null, buf_2 = null;
            for (int i = 0; i < x; i++)
            {
                if (half_final[i].ComparePoints(buf_1, 3) >= 0)
                {
                    buf_2 = buf_1;
                    buf_1 = half_final[i];
                }
                else if (half_final[i].ComparePoints(buf_2, 3) >= 0)
                    buf_2 = half_final[i];
            }
            CloneTeamData(buf_1, ref final[0]);
            CloneTeamData(buf_2, ref final[1]);
            team1Box.Text = final[0].name;
            team2Box.Text = final[1].name;
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            if (game == 1)
            {
                match_1 = all_teams[ind_1].last_game;
                match_2 = all_teams[ind_2].last_game;
                all_teams[ind_0 + ind_1 * x].goals[match_1] = (int)team1UpDown.Value;
                all_teams[ind_0 + ind_2 * x].goals[match_2] = (int)team2UpDown.Value;
                all_teams[ind_0 + ind_1 * x].CountPoints(ref all_teams[ind_0 + ind_2 * x], match_1, match_2);

                if (ind_2 < x - 1)
                    ind_2++;
                else if (ind_1 < x - 2)
                {
                    ind_1++;
                    ind_2 = ind_1 + 1;
                }
                else if (ind_0 < x - 1)
                {
                    ind_1 = 0;
                    ind_2 = 1;
                    ind_0++;
                }
                else
                {
                    GoToHalfFinal();
                    return;
                }
                team1Box.Text = all_teams[ind_0 + ind_1 * x].name;
                team2Box.Text = all_teams[ind_0 + ind_2 * x].name;
                team1UpDown.Value = 0;
                team2UpDown.Value = 0;
            }
            else if (game == 2)
            {
                half_final[ind_1].goals[3] = (int)team1UpDown.Value;
                half_final[ind_2].goals[3] = (int)team2UpDown.Value;
                half_final[ind_1].CountPoints(ref half_final[ind_2], 3, 3);

                if (ind_1 < 1)
                {
                    ind_1 += 2;
                    ind_2 += 2;
                }
                else
                    GoToFinal();

                team1Box.Text = all_teams[ind_1].name;
                team2Box.Text = all_teams[ind_2].name;
                team1UpDown.Value = 0;
                team2UpDown.Value = 0;
            }
            else if (game == 3)
            {
                final[0].goals[4] = (int)team1UpDown.Value;
                final[1].goals[4] = (int)team2UpDown.Value;
                final[0].CountPoints(ref final[1], 4, 4);

                resForm results = new();
                results.Show();
                results.Finish(final, half_final);
                this.Enabled = false;

                team1UpDown.Value = 0;
                team2UpDown.Value = 0;
            }
        }
    }
}