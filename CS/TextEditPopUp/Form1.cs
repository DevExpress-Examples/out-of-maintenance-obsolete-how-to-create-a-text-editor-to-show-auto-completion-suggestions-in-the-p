using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEPopUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = FillDataTable();
            gridControl1.DataSource = table;

            textEditPopUp1.DataSource = table;
            textEditPopUp1.DisplayMember = "Fruit";

            repositoryItemTextEditPopUp1.DataSource = table;
            repositoryItemTextEditPopUp1.DisplayMember = "Fruit";
        }

        DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.ColumnName = "Fruit";
            col.DataType = System.Type.GetType("System.String");
            _dataTable.Columns.Add(col);

            row = _dataTable.NewRow();
            row["Fruit"] = "Apple";
            _dataTable.Rows.Add(row);

            row = _dataTable.NewRow();
            row["Fruit"] = "Apricot";
            _dataTable.Rows.Add(row);

            row = _dataTable.NewRow();
            row["Fruit"] = "Avocado";
            _dataTable.Rows.Add(row);

            return _dataTable;
        }
    }
}
