using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace lab1_konstrPO
{
    public partial class Form1 : Form
    {
        private string connectionString;

        private DataSet dataSet = new DataSet();
        private NpgsqlDataAdapter groupsAdapter;
        private NpgsqlDataAdapter studentsAdapter;
        private NpgsqlCommandBuilder groupsBuilder;
        private NpgsqlCommandBuilder studentsBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (ConfigurationManager.ConnectionStrings["DbConnection"] != null)
                {
                    connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                }
                else
                {
                    MessageBox.Show("Строка подключения 'DbConnection' не найдена в файле App.config!", "Ошибка конфигурации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InitDisconnectedMode();
                FillReportComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 1. ОТКЛЮЧЕННЫЙ СПОСОБ

        private void InitDisconnectedMode()
        {

            groupsAdapter = new NpgsqlDataAdapter(
                "SELECT group_id, direction, number, profile FROM groups ORDER BY group_id;",
                connectionString);


            studentsAdapter = new NpgsqlDataAdapter(
                "SELECT student_id, group_id, full_name, birth_date, registration_address, funding_type, study_form, admission_year FROM students ORDER BY student_id;",
                connectionString);


            groupsBuilder = new NpgsqlCommandBuilder(groupsAdapter);
            studentsBuilder = new NpgsqlCommandBuilder(studentsAdapter);

            groupsAdapter.Fill(dataSet, "groups");
            studentsAdapter.Fill(dataSet, "students");


            dataGridViewGroups.DataSource = dataSet.Tables["groups"];


            bindingSourceStudents.DataSource = dataSet.Tables["students"];
            dataGridViewStudents.DataSource = bindingSourceStudents;
            bindingNavigatorStudents.BindingSource = bindingSourceStudents;


            SetupStudentComboBoxColumns();


            if (dataGridViewGroups.Columns["group_id"] != null)
            {
                dataGridViewGroups.Columns["group_id"].ReadOnly = true;
                dataGridViewGroups.Columns["group_id"].Visible = false;
            }

            if (dataGridViewStudents.Columns["student_id"] != null)
            {
                dataGridViewStudents.Columns["student_id"].ReadOnly = true;
                dataGridViewStudents.Columns["student_id"].Visible = false;
            }
        }

        
        private void SetupStudentComboBoxColumns()
        {

            if (dataGridViewStudents.Columns.Contains("group_id"))
            {
                int index = dataGridViewStudents.Columns["group_id"].Index;
                dataGridViewStudents.Columns.Remove("group_id");

                DataGridViewComboBoxColumn colGroup = new DataGridViewComboBoxColumn
                {
                    Name = "group_id",
                    DataPropertyName = "group_id",         
                    DataSource = dataSet.Tables["groups"], 
                    ValueMember = "group_id",              
                    DisplayMember = "profile",             
                    HeaderText = "Профиль группы",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                };

                dataGridViewStudents.Columns.Insert(index, colGroup);
            }

            
            if (dataGridViewStudents.Columns.Contains("funding_type"))
            {
                int index = dataGridViewStudents.Columns["funding_type"].Index;
                dataGridViewStudents.Columns.Remove("funding_type");

                DataGridViewComboBoxColumn colFunding = new DataGridViewComboBoxColumn
                {
                    Name = "funding_type",
                    DataPropertyName = "funding_type",
                    HeaderText = "funding_type",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                };
                colFunding.Items.AddRange("Бюджет", "Контракт");

                dataGridViewStudents.Columns.Insert(index, colFunding);
            }


            if (dataGridViewStudents.Columns.Contains("study_form"))
            {
                int index = dataGridViewStudents.Columns["study_form"].Index;
                dataGridViewStudents.Columns.Remove("study_form");

                DataGridViewComboBoxColumn colForm = new DataGridViewComboBoxColumn
                {
                    Name = "study_form",
                    DataPropertyName = "study_form",
                    HeaderText = "study_form",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                };
                colForm.Items.AddRange("Очная", "Заочная", "Очно-заочная");

                dataGridViewStudents.Columns.Insert(index, colForm);
            }

           
            if (dataGridViewStudents.Columns.Contains("admission_year"))
            {
                int index = dataGridViewStudents.Columns["admission_year"].Index;
                dataGridViewStudents.Columns.Remove("admission_year");

                DataGridViewComboBoxColumn colYear = new DataGridViewComboBoxColumn
                {
                    Name = "admission_year",
                    DataPropertyName = "admission_year",
                    HeaderText = "admission_year",
                    ValueType = typeof(short),
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                };

                for (short year = 2020; year <= 2030; year++)
                {
                    colYear.Items.Add(year);
                }

                dataGridViewStudents.Columns.Insert(index, colYear);
            }
        }

        private void buttonSaveGroups_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewGroups.EndEdit();
                groupsAdapter.Update(dataSet, "groups");
                MessageBox.Show("Данные групп успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения групп: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveStudents_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewStudents.EndEdit();
                bindingSourceStudents.EndEdit();
                studentsAdapter.Update(dataSet, "students");
                MessageBox.Show("Данные студентов успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                FillReportComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения студентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 2. ПОДКЛЮЧЕННЫЙ СПОСОБ: Raw SQL

        private void FillReportComboBoxes()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT student_id, full_name FROM students ORDER BY full_name;";

                    using (NpgsqlCommand cmd1 = new NpgsqlCommand(sql, conn))
                    using (NpgsqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable dt1 = new DataTable();
                        dt1.Load(reader1);

                        comboBoxReportStudents1.DataSource = dt1;
                        comboBoxReportStudents1.DisplayMember = "full_name";
                        comboBoxReportStudents1.ValueMember = "student_id";
                    }

                    using (NpgsqlCommand cmd2 = new NpgsqlCommand(sql, conn))
                    using (NpgsqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        DataTable dt2 = new DataTable();
                        dt2.Load(reader2);

                        comboBoxReportStudents2.DataSource = dt2;
                        comboBoxReportStudents2.DisplayMember = "full_name";
                        comboBoxReportStudents2.ValueMember = "student_id";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки списка студентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExecuteRawSql_Click(object sender, EventArgs e)
        {
            if (comboBoxReportStudents1.SelectedValue == null) return;

            int selectedStudentId = Convert.ToInt32(comboBoxReportStudents1.SelectedValue);

            string rawSql = @"
                SELECT 
                    d.name AS ""Дисциплина"",
                    s.semester_number AS ""Семестр"",
                    gr.score AS ""Оценка"",
                    gr.submission_date AS ""Дата сдачи""
                FROM grades gr
                JOIN disciplines d ON gr.discipline_id = d.discipline_id
                JOIN semesters s ON gr.semester_id = s.semester_id
                WHERE gr.student_id = @studentId
                ORDER BY s.semester_number, d.name;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(rawSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", selectedStudentId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dtReport = new DataTable();
                            dtReport.Load(reader);

                            dataGridViewReport1.DataSource = dtReport;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения SQL-запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region 3. ПОДКЛЮЧЕННЫЙ СПОСОБ: Вызов Хранимой Функции

        private void buttonExecuteProcedure_Click(object sender, EventArgs e)
        {
            if (comboBoxReportStudents2.SelectedValue == null)
            {
                MessageBox.Show("Выберите студента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(comboBoxReportStudents2.SelectedValue);

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                 
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM get_student_avg(@studentId);", conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dtReport2 = new DataTable();
                            dtReport2.Load(reader);

                            dataGridViewReport2.DataSource = dtReport2;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка вызова хранимой функции: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}