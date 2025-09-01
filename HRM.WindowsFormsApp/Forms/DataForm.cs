
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Core.Interfaces.Services;
using TestTask.Core.Models;

namespace TestTask.WindowsFormsApp
{
    public partial class DataForm : Form
    {
        private readonly IPersonService _personService;
        private readonly IDepService _depService;
        private readonly IPostService _postService;
        private readonly IStatusService _stauseService;

        private readonly BindingSource _employersBS = new BindingSource();

        public DataForm(IPersonService personService, IDepService depService, IPostService postService, IStatusService stauseService)
        {
            InitializeComponent();
            _personService = personService;
            _depService = depService;
            _postService = postService;
            _stauseService = stauseService;
            peopleDataGridView.DataSource = _employersBS;
        }

        private async void DataForm_Load(object sender, EventArgs e)
        {
            await GetData();
        }

        private void PeopleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnCell = peopleDataGridView.Columns[e.ColumnIndex];

            var direction = columnCell.HeaderCell.SortGlyphDirection == SortOrder.Ascending
                ? ListSortDirection.Descending
                : ListSortDirection.Ascending;

            peopleDataGridView.Sort(columnCell, direction);

            columnCell.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private async void FilterButton_Click(object sender, EventArgs e)
        {
            int? idStatus = statusComboBox?.SelectedValue == null ? null : (int?)Convert.ToInt32(statusComboBox?.SelectedValue);
            int? idDep = depComboBox?.SelectedValue == null ? null : (int?)Convert.ToInt32(depComboBox?.SelectedValue);
            int? idPost = postComboBox.SelectedValue == null ? null : (int?)Convert.ToInt32(postComboBox?.SelectedValue);
            string lastNamePart = lastNameTextBox.Text;

            var people = await _personService.FilterPeople(idStatus, idDep, idPost, lastNamePart);
            _employersBS.DataSource = new SortableBindingList<PeopleModel>(people);
        }

        private async void ClearFilterbutton_Click(object sender, EventArgs e)
        {
            statusComboBox.SelectedItem = null;
            postComboBox.SelectedItem = null;
            depComboBox.SelectedItem = null;
            lastNameTextBox.Text = null;

            var people = await _personService.GetPeople();
            _employersBS.DataSource = new SortableBindingList<PeopleModel>(people);
        }

        private async void EnterStatisticButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!employRadioButton.Checked && !unEmployRadioButton.Checked)
                {
                    MessageBox.Show("Выберете уволен ли сотрудник или нет", "Ошибка при получении статистики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int? statusId = statisticStatusComboBox?.SelectedValue == null ? null : (int?)Convert.ToInt32(statisticStatusComboBox?.SelectedValue);

                if (statusId == null)
                {
                    MessageBox.Show("Выберете статус сотрудника", "Ошибка при получении статистики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime startDate = statisticStartDateTimePicker.Value.Date;
                DateTime endDate = statisticEndDateTimePicker.Value.Date;
                bool isEmployed = employRadioButton.Checked;

                var statistic = await _personService.GetStatisticPeople(statusId, startDate, endDate, isEmployed);

                statisticDataGridView.DataSource = statistic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении статистики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateDataButton_Click(object sender, EventArgs e)
        {
            await GetData();
        }

        private void PeopleDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (peopleDataGridView.Columns[e.ColumnIndex].Name == "FIO")
            {
                var row = peopleDataGridView.Rows[e.RowIndex];

                if (row.DataBoundItem is PeopleModel person && person.DateUneploy.HasValue)
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private async Task GetData()
        {
            try
            {
                SetComboBoxValues(statusComboBox, await _stauseService.GetStatuses());
                SetComboBoxValues(statisticStatusComboBox, await _stauseService.GetStatuses());
                SetComboBoxValues(postComboBox, await _postService.GetPosts());
                SetComboBoxValues(depComboBox, await _depService.GetDeps());

                var people = await _personService.GetPeople();
                _employersBS.DataSource = new SortableBindingList<PeopleModel>(people);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Не удалось получить всех сотрудников из базе данных.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetComboBoxValues<T>(ComboBox comboBox, List<T> values)
        {
            comboBox.DataSource = values;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedItem = null;
        }
    }
}
