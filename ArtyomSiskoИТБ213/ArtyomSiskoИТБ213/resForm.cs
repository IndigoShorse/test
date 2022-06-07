using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtyomSiskoИТБ213
{
    public partial class resForm : Form
    {
        public resForm()
        {
            InitializeComponent();
        }
        public void Finish(Team[] final, Team[] half_final)
        {
            DataGridViewRow row1;
            if (final[0].ComparePoints(final[1], 5) < 0)
            {
                row1 = (DataGridViewRow)resultsGrid.Rows[0].Clone();
                row1.Cells[0].Value = 1;
                row1.Cells[1].Value = final[1].name;
                row1.Cells[2].Value = final[1].total;
                resultsGrid.Rows.Add(row1);

                row1 = (DataGridViewRow)resultsGrid.Rows[0].Clone();
                row1.Cells[0].Value = 2;
                row1.Cells[1].Value = final[0].name;
                row1.Cells[2].Value = final[0].total;
                resultsGrid.Rows.Add(row1);
            }
            else
            {
                row1 = (DataGridViewRow)resultsGrid.Rows[0].Clone();
                row1.Cells[0].Value = 1;
                row1.Cells[1].Value = final[0].name;
                row1.Cells[2].Value = final[0].total;
                resultsGrid.Rows.Add(row1);

                row1 = (DataGridViewRow)resultsGrid.Rows[0].Clone();
                row1.Cells[0].Value = 2;
                row1.Cells[1].Value = final[1].name;
                row1.Cells[2].Value = final[1].total;
                resultsGrid.Rows.Add(row1);
            }

            Team buff = null;
            for (int i = 0; i < 4; i++)
            {
                if (half_final[i].name != final[0].name && half_final[i].name != final[1].name)
                    if (half_final[i].ComparePoints(buff, 4) >= 0)
                        buff = half_final[i];
            }
            row1 = (DataGridViewRow)resultsGrid.Rows[0].Clone();
            row1.Cells[0].Value = 3;
            row1.Cells[1].Value = buff.name;
            row1.Cells[2].Value = buff.total;
            resultsGrid.Rows.Add(row1);
        }
    }
}
