using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample3_LinqWindowsForm
{
    public static class GetRowId
    {
        public static List<int> ForProductID(DataGridView dataGridView)
        {
            List<int> selected = new List<int>();

            if (dataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    selected.Add((int)dataGridView.SelectedRows[i].Cells["ProductID"].Value);
                }
            }
            else
            {
                List<int> rowIndex = new List<int>();

                for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
                {
                    int value = dataGridView.SelectedCells[i].RowIndex;

                    if (!rowIndex.Contains(value))
                    {
                        rowIndex.Add(value);
                    }
                }

                foreach (int value in rowIndex)
                {
                    selected.Add((int)dataGridView.Rows[value].Cells["ProductID"].Value);
                }
            }

            return selected;
        }
    }
}
