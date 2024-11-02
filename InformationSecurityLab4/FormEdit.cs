using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InformationSecurityLab4
{
    public partial class FormEdit : Form
    {
        private List<string> _users;
        private List<Text> _objects;
        private List<List<int>> _accesses;
        private List<int> _privilegesUser;
        private List<int> _privilegesObject;

        private int pickedUser;
        private int pickedObject;
        private int pickedDataGrid;

        public FormEdit(List<string> users, List<Text> objects, List<List<int>> accesses, List<int> privilegesUser, List<int> privilegesObject)
        {
            InitializeComponent();
            _users = users;
            _objects = objects;
            _accesses = accesses;
            _privilegesUser = privilegesUser;
            _privilegesObject = privilegesObject;

            UIElementsUpdate();

            comboBoxUserPick.SelectedIndex = pickedUser = 0;
            comboBoxObjectPick.SelectedIndex = pickedObject = 0;
            pickedDataGrid = 0;
        }

        private void UIElementsUpdate()
        {

            UpdateComboboxes();
            UpdateDataGridViewAccesses();
            UpdateDataGridViewUserPrivilages();
            UpdateDataGridViewObjectPrivilages();
        }

        private void UpdateDataGridViewObjectPrivilages()
        {
            dataGridViewObjectPrivilages.Columns.Clear();

            for (int i = 0; i < _objects.Count; i++)
            {
                dataGridViewObjectPrivilages.Columns.Add(_objects[i].GetName(), _objects[i].GetName());
                dataGridViewObjectPrivilages.Columns[i].Width = 55;
            }
            for (int i = 0; i < _objects.Count; i++)
            {
                dataGridViewObjectPrivilages.Rows[0].Cells[i].Value = _privilegesObject[i];
            }
            dataGridViewObjectPrivilages.CurrentCell = dataGridViewObjectPrivilages.Rows[0].Cells[pickedObject];
        }

        private void UpdateDataGridViewUserPrivilages()
        {
            dataGridViewUsersPrivilages.Columns.Clear();

            for (int i = 0; i < _users.Count; i++)
            {
                dataGridViewUsersPrivilages.Columns.Add(_users[i], _users[i]);
                dataGridViewUsersPrivilages.Columns[i].Width = 55;
            }
            for (int i = 0; i < _users.Count; i++)
            {
                dataGridViewUsersPrivilages.Rows[0].Cells[i].Value = _privilegesUser[i];
            }
            dataGridViewUsersPrivilages.CurrentCell = dataGridViewUsersPrivilages.Rows[0].Cells[pickedUser];
        }

        private void UpdateDataGridViewAccesses()
        {
            dataGridViewAccesses.Columns.Clear();

            dataGridViewAccesses.Columns.Add("Админ", "Админ");
            dataGridViewAccesses.Columns[0].Width = 55;
            for (int i = 0; i < _objects.Count; i++)
            {
                dataGridViewAccesses.Columns.Add(_objects[i].GetName(), _objects[i].GetName());
                dataGridViewAccesses.Columns[i + 1].Width = 55;
            }

            dataGridViewAccesses.Rows.Clear();
            int pointer = 0;
            for (int i = 1; i < _accesses.Count; i++)
                dataGridViewAccesses.Rows.Add(_accesses[i - 1]);

            foreach (List<int> list in _accesses)
            {
                for (int i = 0; i < list.Count; i++)
                    dataGridViewAccesses.Rows[pointer].Cells[i].Value = list[i];
                pointer++;
            }
            dataGridViewAccesses.CurrentCell = dataGridViewAccesses.Rows[pickedUser].Cells[pickedObject];
        }

        private void UpdateComboboxes()
        {
            comboBoxUserPick.Items.Clear();
            comboBoxObjectPick.Items.Clear();
            foreach (string user in _users)
                comboBoxUserPick.Items.Add(user);
            foreach (Text text in _objects)
                comboBoxObjectPick.Items.Add(text.GetName());
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text != "")
            {
                _users.Add(textBoxUserName.Text);
                _privilegesUser.Add(0);
                List<int> list = new List<int>(_objects.Count + 1);
                _accesses.Add(list);
                for (int i = 0; i < list.Capacity; i++)
                    _accesses[_accesses.Count - 1].Add(0);
                UIElementsUpdate();
                textBoxUserName.Text = "";
            }
        }

        private void buttonObjectAdd_Click(object sender, EventArgs e)
        {
            if (textBoxObjectName.Text != "")
            {
                _objects.Add(new Text(textBoxObjectName.Text, ""));
                _privilegesObject.Add(0);
                foreach (List<int> list in _accesses)
                    list.Add(0);
                UIElementsUpdate();
                textBoxObjectName.Text = "";
            }
        }

        private void comboBoxUserPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickedUser = comboBoxUserPick.SelectedIndex;
        }

        private void comboBoxObjectPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickedObject = comboBoxObjectPick.SelectedIndex + 1;
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            if(_users.Count == 0)
                return;

            _users.Remove(_users.ElementAt(pickedUser));
            _privilegesUser.Remove(_privilegesUser.ElementAt(pickedUser));
            _accesses.Remove(_accesses.ElementAt(pickedUser));
            comboBoxUserPick.SelectedIndex = 0;
            UIElementsUpdate();
        }
        
        private void buttonObjectDelete_Click(object sender, EventArgs e)
        {
            if (_objects.Count == 0)
                return;

            _objects.Remove(_objects.ElementAt(pickedObject - 1));
            _privilegesObject.Remove(_privilegesObject.ElementAt(pickedObject));
            foreach (List<int> list in _accesses)
                list.Remove(list.ElementAt(pickedObject - 1));
            comboBoxObjectPick.SelectedIndex = 0;
            UIElementsUpdate();
        }

        private void buttonAccessAdd_Click(object sender, EventArgs e)
        {
            if (pickedDataGrid == 0 && (int)numericUpDownAccessPick.Value <= 2)
            {
                if (pickedObject == 0 && (int)numericUpDownAccessPick.Value <= 1)
                {
                    _accesses[pickedUser][pickedObject] = (int)numericUpDownAccessPick.Value;
                }
                else if (pickedObject != 0)
                {
                    _accesses[pickedUser][pickedObject] = (int)numericUpDownAccessPick.Value;
                }
                UpdateDataGridViewAccesses();
                dataGridViewAccesses.Select();
            }
            else if (pickedDataGrid == 1)
            {
                _privilegesUser[pickedUser] = (int)numericUpDownAccessPick.Value;
                UpdateDataGridViewUserPrivilages();
                dataGridViewUsersPrivilages.Select();
            }
            else if (pickedDataGrid == 2)
            {
                _privilegesObject[pickedObject] = (int)numericUpDownAccessPick.Value;
                UpdateDataGridViewObjectPrivilages();
                dataGridViewObjectPrivilages.Select();
            }
        }

        private void AccessAdd()
        {
                
        }

        private void dataGridViewAccesses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pickedDataGrid = 0;

            pickedUser = dataGridViewAccesses.SelectedCells[0].RowIndex;
            pickedObject = dataGridViewAccesses.SelectedCells[0].ColumnIndex;

            comboBoxUserPick.SelectedIndex = pickedUser;
            if(pickedObject != 0)
                comboBoxObjectPick.SelectedIndex = pickedObject - 1;
        }

        private void dataGridViewUsersPrivilages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pickedDataGrid = 1;
            pickedUser = dataGridViewUsersPrivilages.SelectedCells[0].ColumnIndex;
        }

        private void dataGridViewObjectPrivilages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pickedDataGrid = 2;
            pickedObject = dataGridViewObjectPrivilages.SelectedCells[0].ColumnIndex;
        }

        public List<string> GetUsers() => _users;

        public List<Text> GetObjects() => _objects;

        public List<List<int>> GetAccesses() => _accesses;
    }
}
