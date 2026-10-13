using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;



namespace Lab1_ADO_NET
{
    public partial class Form1 : Form
    {

        private string connectionString;
        private DataSet ds;
        private NpgsqlDataAdapter adapterTypes;
        private NpgsqlDataAdapter adapterEquipment;
        private NpgsqlCommandBuilder builderTypes;
        private NpgsqlCommandBuilder builderEquipment;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["PgConnection"].ConnectionString;
            ds = new DataSet();
        }

        private void btnLoadTypes_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("equipment_type"))
                ds.Tables["equipment_type"].Remove("equipment_type");

            adapterTypes = new NpgsqlDataAdapter(
               @"SELECT equipment_type_id,
                             type_name_eq,
                             description_eq
                      FROM equipment_type
                      ORDER BY equipment_type_id",connectionString);

            builderTypes = new NpgsqlCommandBuilder(adapterTypes);
            dgvTypes.AutoGenerateColumns = true;
            dgvTypes.DataSource = null;

            adapterTypes.Fill(ds, "equipment_type");

            dgvTypes.DataSource = ds.Tables["equipment_type"];

            if (dgvTypes.Columns.Contains("equipment_type"))
            {
                dgvTypes.Columns["equipment_type_id"].ReadOnly = true;
                dgvTypes.Columns["equipment_type_id"].HeaderText = "ID";
            }
            if (dgvTypes.Columns.Contains("type_name_eq"))
                dgvTypes.Columns["type_name_eq"].HeaderText = "Название типа";
            if (dgvTypes.Columns.Contains("description_eq"))
                dgvTypes.Columns["description_eq"].HeaderText = "Описание";
        }

        private void btnSaveTypes_Click(object sender, EventArgs e)
        {
            if (adapterTypes == null)
            {
                MessageBox.Show("Сначала нажмите Загрузить");
                return;
            }

            foreach (DataRow row in ds.Tables["equipment_type"].Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                if (row["type_name_eq"]==DBNull.Value|| string.IsNullOrWhiteSpace(row["type_name_eq"].ToString())){
                    MessageBox.Show("Поле <<Название типа>> обязаельно для заполнения");
                    return;
                }
            }
            adapterTypes.Update(ds, "equipment_type");
            MessageBox.Show("Справочник обновлён");
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (adapterTypes == null)
            {
                MessageBox.Show("Сначала нажмите Загрузить");
                return;
            }

            DataRow row = ds.Tables["equipment_type"].NewRow();
            ds.Tables["equipment_type"].Rows.Add(row);
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (dgvTypes.CurrentRow != null && !dgvTypes.CurrentRow.IsNewRow)
                dgvTypes.Rows.Remove(dgvTypes.CurrentRow);
        }

        private void btnLoadEquipment_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("equipment"))
                ds.Tables["equipment"].Remove("equipment");

            adapterEquipment = new NpgsqlDataAdapter(
                @"SELECT e.equipment_id,
                     e.name_eq,
                     e.equipment_type_id,
                     e.model,
                     e.manufacturer,
                     e.eq_cost
              FROM equipment AS e
              ORDER BY e.equipment_id",
                connectionString);

            builderEquipment = new NpgsqlCommandBuilder(adapterEquipment);

            dgvEquipment.AutoGenerateColumns = true;
            dgvEquipment.DataSource = null;
            adapterEquipment.Fill(ds, "equipment");

            dgvEquipment.DataSource = ds.Tables["equipment"];

            if (dgvEquipment.Columns.Contains("equipment_id"))
            {
                dgvEquipment.Columns["equipment_id"].ReadOnly = true;
                dgvEquipment.Columns["equipment_id"].HeaderText = "ID";
            }
            if (dgvEquipment.Columns.Contains("name_eq"))
                dgvEquipment.Columns["name_eq"].HeaderText = "Название";
            if (dgvEquipment.Columns.Contains("equipment_type_id"))
                dgvEquipment.Columns["equipment_type_id"].HeaderText = "ID типа";
            if (dgvEquipment.Columns.Contains("model"))
                dgvEquipment.Columns["model"].HeaderText = "Модель";
            if (dgvEquipment.Columns.Contains("manufacturer"))
                dgvEquipment.Columns["manufacturer"].HeaderText = "Производитель";
            if (dgvEquipment.Columns.Contains("eq_cost"))
                dgvEquipment.Columns["eq_cost"].HeaderText = "Стоимость";
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            if (adapterEquipment == null)
            {
                MessageBox.Show("Сначала нажмите «Загрузить»");
                return;
            }

            foreach (DataRow row in ds.Tables["equipment"].Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                if (row["name_eq"] == DBNull.Value ||
                    string.IsNullOrWhiteSpace(row["name_eq"].ToString()))
                {
                    MessageBox.Show("Поле «Название» обязательно!");
                    return;
                }
                if (row["equipment_type_id"] == DBNull.Value)
                {
                    MessageBox.Show("Укажите ID типа оборудования из справочника!");
                    return;
                }
                if (row["eq_cost"] == DBNull.Value)
                {
                    MessageBox.Show("Поле «Стоимость» обязательно!");
                    return;
                }
            }

            adapterEquipment.Update(ds, "equipment");
            MessageBox.Show("Оборудование сохранено");
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
        if (!ds.Tables.Contains("equipment"))
        {
            MessageBox.Show("Сначала загрузите данные");
            return;
        }

        DataRow row = ds.Tables["equipment"].NewRow();
        ds.Tables["equipment"].Rows.Add(row);
    }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.CurrentRow != null && !dgvEquipment.CurrentRow.IsNewRow)
                dgvEquipment.Rows.Remove(dgvEquipment.CurrentRow);
        }

        private void btnExecuteSql_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
                        SELECT e.equipment_id,
                               e.name_eq,
                               t.type_name_eq,
                               e.model,
                               e.manufacturer,
                               e.eq_cost
                        FROM equipment e
                        JOIN equipment_type t ON e.equipment_type_id = t.equipment_type_id
                        WHERE e.eq_cost >= @minCost
                          AND (@typeId = 0 OR e.equipment_type_id = @typeId)
                        ORDER BY e.eq_cost DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn)) { 
              
                    cmd.Parameters.AddWithValue("@minCost", nudMinCost.Value);
                    cmd.Parameters.AddWithValue("@typeId",Convert.ToInt32(cmbTypeFilter.SelectedValue));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dgvRawSql.DataSource = table;
                    }
                }
            }
        }

        private void btnExecuteProc_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open(); 

                string sql = "SELECT * FROM get_equipment_by_type(@p_type_id)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p_type_id",Convert.ToInt32(cmbProcType.SelectedValue));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dgvProc.DataSource = table;
                    }
                }
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTypeLists();
        }

        private void LoadTypeLists()
        {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql =
                        @"SELECT equipment_type_id, type_name_eq
                          FROM equipment_type
                          ORDER BY type_name_eq";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow all = dt.NewRow();
                    all["equipment_type_id"] = 0;
                    all["type_name_eq"] = "— Все типы —";
                    dt.Rows.InsertAt(all, 0);

                    cmbTypeFilter.DataSource = dt.Copy();
                    cmbTypeFilter.DisplayMember = "type_name_eq";
                    cmbTypeFilter.ValueMember = "equipment_type_id";

                    cmbProcType.DataSource = dt.Copy();
                    cmbProcType.DisplayMember = "type_name_eq";
                    cmbProcType.ValueMember = "equipment_type_id";
                }
            
        }
    }
}
