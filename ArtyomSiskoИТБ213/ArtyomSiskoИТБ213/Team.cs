using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtyomSiskoИТБ213
{
    public partial class Team
    {
        public int[] points = new int[5];
        public int[] goals = new int[5];
        public int[] miss = new int[5];
        public string[] foe_names = new string[5];
        public string name;
        public int last_game = 0;
        public int total = 0;

        public void CountPoints(ref Team foe, int ind_1, int ind_2)
        {
            last_game = ind_1 + 1;
            foe.last_game = ind_2 + 1;
            miss[ind_1] = foe.goals[ind_2];
            foe.miss[ind_2] = goals[ind_1];

            foe_names[ind_1] = foe.name;
            foe.foe_names[ind_2] = name;

            if (goals[ind_1] > foe.goals[ind_2])
            {
                points[ind_1] = 2;
                foe.points[ind_2] = 0;
            }
            else if (foe.goals[ind_2] > goals[ind_1])
            {
                foe.points[ind_2] = 2;
                points[ind_1] = 0;
            }
            else if (foe.goals[ind_2] == goals[ind_1])
            {
                foe.points[ind_2] = 1;
                points[ind_1] = 1;
            }
            foe.total += foe.points[ind_2];
            total += points[ind_1];
        }
        public int GetGameDiff(Team foe, int len)
        {
            int count = 0;
            for (int i = 0; i < len; i++)
                if (foe_names[i] == foe.name)
                    if (points[i] == 2)
                        count++;
                    else if (foe.points[i] == 2)
                        count--;
            return count;
        }
        public int GetGoalDiff(int len)
        {
            int max_diff = goals[0] - miss[0];
            for (int i = 1; i < len; i++)
                if (goals[i] - miss[i] > max_diff)
                    max_diff = goals[i] - miss[i];
            return max_diff;
        }
        public int ComparePoints(Team foe, int len)
        {
            if (foe == null)
                return 0;

            if (foe.total != total)
                return foe.total - total;

            int goal_diff = foe.GetGoalDiff(len) - GetGoalDiff(len);
            if (goal_diff != 0)
                return goal_diff;

            int game_results = foe.GetGameDiff(foe, len);
            return game_results;
        }
        
        
    }
}
