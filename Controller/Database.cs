using DomnPhil_Construction.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction.Controller
{
    class Database
    {

        String connectionString = "";
        public MySqlConnection db;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["domnphil"].ConnectionString;
            db = new MySqlConnection(connectionString);
        }

        private void checkConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
                this.db.Open();
            }
            else
            {
                this.db.Open();
            }
        }
        private void closeConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
            }
            else
            {
            }
        }


        public bool adminLogin(String username, String password)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,ID FROM users WHERE username = @username OR password = @password AND type = 'admin'";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    try
                    {
                        if (reader.GetString(0) == username && reader.GetString(1) == password)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            command.Dispose();
                            this.db.Close();
                            return true;
                        }
                        else if (reader.GetString(0) == username && reader.GetString(1) != password)
                        {
                            MessageBox.Show("You entered the wrong password");
                            result = false;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        result = false;
                    }


                }
                else
                {
                    MessageBox.Show("User does not exist");
                    result = false;

                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public List<String> getRecipientNames()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("name"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public List<String> getRecipientNumbers()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("contact_number"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public void deleteAttendance(String month, String year, String date_from, String date_to)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `monthly_attendance` WHERE month = @month AND year = @year AND date_from = @date_from AND date_to = @date_to";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@date_from", date_from);
                command.Parameters.AddWithValue("@date_to", date_to);
                command.ExecuteNonQuery();
                MessageBox.Show("Records successfully deleted!");
                command.Dispose();
                this.db.Close();
            }
        }

        public List<String> fillRecipientNumberTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT contact_number AS 'Phone Number' FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public List<String> fillAttendanceTable(ref DataGridView dgv, String month, String year)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type',IF(employees.rate = 0,FORMAT (((employees.operational_rate*days_present) + (employees.shop_rate*days_breakdown) +  ((employees.operational_rate/8)*monthly_attendance.overtime_hours)),2),FORMAT(employees.rate,2)) AS 'Total Receivable to date' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }
        public int getWorkingDays(String month, String year)
        {
            int workingDays = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT working_days FROM monthly_attendance WHERE month = @month AND year = @year GROUP BY working_days";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    workingDays = reader.GetInt32("working_days");
                }

                command.Dispose();
                this.db.Close();
                return workingDays;
            }
        }
        public List<String> fillAttendanceTable(ref DataGridView dgv, String month, String year, String site)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site = @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", site);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public Double getPayrollTotal(ref DataGridView dgv, String month, String year, String site)
        {
            Double result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT FORMAT(SUM(IF(employees.rate = 0,(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), employees.rate - cash_advance - loan - sss - pag_ibig - philhealth)),2) AS 'total' FROM `monthly_attendance` INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", site);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetDouble("total");
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public Double getPayrollTotal(ref DataGridView dgv, String month, String year)
        {
            Double result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                if (this.db.State == ConnectionState.Open)
                {
                    this.db.Close();
                }
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT FORMAT(SUM(IF(employees.rate = 0,(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), employees.rate - cash_advance - loan - sss - pag_ibig - philhealth)),2) AS 'total' FROM `monthly_attendance` INNER JOIN employees ON employee = employees.control_number WHERE month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetDouble("total");
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public DataTable fillAttendanceReportTable(String month, String year, String site)
        {
            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT *, employees.control_number, month , DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present , days_absent, days_breakdown, name, FORMAT(employees.shop_rate,2) AS 'shop_rate', FORMAT(employees.operational_rate,2) AS 'operational_rate',  IF(employees.rate = 0,'Variable','Flat') AS 'rate_type',FORMAT((monthly_attendance.days_breakdown * employees.shop_rate),2) AS 'shop_cost',FORMAT((monthly_attendance.days_present * employees.operational_rate),2) AS 'operational_cost',(monthly_attendance.overtime_hours * (employees.operational_rate/8)) AS 'overtime_cost',IF(employees.rate = 0,FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate)+(monthly_attendance.days_present * employees.operational_rate)),2),FORMAT(employees.rate,2)) AS 'gross_amount',IF(employees.rate = 0,FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate)+(monthly_attendance.days_present * employees.operational_rate)+(monthly_attendance.overtime_hours * (employees.operational_rate/8))),2),FORMAT(employees.rate,2)) AS 'gross_with_overtime',employees.site, cash_advance, loan,sss,pag_ibig,philhealth, IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8)) - (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) AS 'net_amount', IF(IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) >= 0, IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)), 0) AS 'positive_only',month_end_cash_advance AS 'month_end_cash_advance_allocation',IF(IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth), 2), FORMAT(employees.rate - cash_advance - loan - sss - pag_ibig - philhealth, 2)) >= 0, IF(employees.rate = 0, FORMAT(((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth) + month_end_cash_advance), 2), FORMAT((employees.rate - cash_advance - loan - sss - pag_ibig - philhealth + month_end_cash_advance), 2)), 0) AS 'total_receivable_to_date', IF(employees.rate = 0, FORMAT((((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))- (monthly_attendance.undertime_hours * (employees.operational_rate / 8))) - cash_advance - loan - sss - pag_ibig - philhealth - month_end_cash_advance), 2), FORMAT((employees.rate - cash_advance - loan - sss - pag_ibig - philhealth - month_end_cash_advance), 2)) AS 'carried_over_cash_advance' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }

        public List<String> searchAttendanceTable(ref DataGridView dgv, String month, String year, String site, String name)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT employees.control_number AS 'Control Number', month AS 'Month', DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present AS 'Operational days', days_absent AS 'Absent', days_breakdown AS 'Non operating days', name AS 'Employee', employees.shop_rate AS 'Shop Rate', employees.operational_rate AS 'Operational Rate',  IF(employees.rate = 0,'Variable','Flat') AS 'Rate type' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number WHERE employees.site LIKE @site AND last_name LIKE @name OR name LIKE @name  AND employees.name LIKE @name AND month = @month AND year = @year;";
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                command.Parameters.AddWithValue("@name", "%" + name + "%");
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }

        public void fillEmployeesTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', first_name AS 'First Name',last_name AS 'Last Name',name AS 'Full Name',position AS 'Position',status AS 'Status',shop_rate AS 'Shop Rate',operational_rate AS 'Operational Rate',absent AS 'Absent'," +
                    "breakdown_days_present AS 'Non Operational Days'," +
                    "operation_days_present AS 'Operational Days'," +
                    "overtime_hours AS 'Overtime Hours'," +
                    "site AS 'Site'," +
                    "designation AS 'Designation',FORMAT(IF(rate = 0, ((operation_days_present * operational_rate) + (shop_rate * breakdown_days_present) + (overtime_hours * (operational_rate / 8))),rate),2) AS 'Total Receivable to Date'" +
                    "FROM `employees`  " +
                    "ORDER BY `employees`.`last_name`  ASC";
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void fillEquipmentsTable(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                    "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                    " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                    " shipping_weight AS 'Shipping Weight', " +
                    "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                    "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                    "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                    "FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public void fillPurchaseOrders(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', supplier.supplier_name AS 'Supplier', purchase_order.date_created AS 'Date Created', delivered_to AS 'Delivered to', partial_payment AS 'Partial Payment' , remarks AS 'Remarks', mode_of_payment AS 'Mode of Payment', site AS 'Site' FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id = purchase_order.requester_id;";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public DataTable fillPurchaseOrderItems(String PO_control_number,DataGridView dgv)
            //Create a function that loads the purchase order items based
            //On the given control number
            //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', `unit_cost` AS 'Unit Cost', `discount` AS 'Discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number",PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public DataTable fillPurchaseOrderItems(String PO_control_number)
            //Create a function that loads the purchase order items based
            //On the given control number
            //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', CONCAT('PHP ',FORMAT(`unit_cost`,2)) AS 'unit_cost',  CONCAT('PHP ',FORMAT(`discount`,2))  AS 'discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number",PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public double getPurchaseTotal(String PO_control_number)
        {
            Double subtotal = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `item_number` AS 'Item Number', `purchase_order` AS 'Purchase Order', `quantity` AS 'Quantity', `unit` AS 'Unit', `description` AS 'Description', `unit_cost` AS 'Unit Cost', `discount` AS 'Discount', CONCAT('PHP ',FORMAT(`amount`,2)) AS 'Amount',amount FROM `purchase_order_item` INNER JOIN purchase_order ON purchase_order.control_number = purchase_order_item.purchase_order WHERE purchase_order.control_number = @PO_control_number;";
                command.Parameters.AddWithValue("@PO_control_number", PO_control_number);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    subtotal += reader.GetDouble(8);
                }
                command.Dispose();
                this.db.Close();
                return subtotal;
            }
        }
        public void fillRepairTable(DataGridView dgv)
            //Create a function that loads the purchase order items based
            //On the given control number
            //Need to fully implement this function
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `control_number` AS 'Control Number', `shop_repaired` AS 'Shop Repaired', `total_repair_cost` AS 'Total Repair Cost', `date_of_repair` AS 'Date of Repair', `date_repaired` AS 'Date Finished Repairing' FROM `repair_record`";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public DataTable fillEmployeesTable(String site)
        {
            List<String> recipientNames = new List<String>();

            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees WHERE site LIKE @site";
                command.Parameters.AddWithValue("@site", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);

                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }
        public DataTable fillMonthlyAttendanceTable(ref DataGridView dgv)
        {
            List<String> recipientNames = new List<String>();

            DataTable dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT month AS 'Month', date_from AS 'Date From', date_to AS 'Date To', year AS 'Year',working_days  AS 'Working Days' FROM `monthly_attendance` GROUP BY month, year,date_from, date_to;SELECT month AS 'Month', date_from AS 'Date From', date_to AS 'Date To', year AS 'Year',working_days  AS 'Working Days' FROM `monthly_attendance` GROUP BY month, year,date_from, date_to;";
                MySqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
            return dataTable;
        }

        public Employee getEmployeeByID(String id)
        {
            Employee employee = new Employee();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees INNER JOIN monthly_attendance ON employees.control_number = monthly_attendance.employee WHERE control_number = @id";
                command.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee.control_number = reader.GetString("control_number");
                        employee.first_name = reader.GetString("first_name");
                        employee.last_name = reader.GetString("last_name");
                        employee.name = reader.GetString("name");
                        employee.position = reader.GetString("position");
                        employee.status = reader.GetString("status");
                        employee.shop_rate = reader.GetFloat("shop_rate");
                        employee.operational_rate = reader.GetFloat("operational_rate");
                        employee.absent = reader.GetInt32("absent");
                        employee.breakdown_days_present = reader.GetInt32("breakdown_days_present");
                        employee.operation_days_present = reader.GetInt32("operation_days_present");
                        employee.overtime_hours = reader.GetInt32("overtime_hours");
                        employee.overtime_pay = reader.GetFloat("overtime_pay");
                        employee.rate = reader.GetFloat("rate");
                        employee.pay = reader.GetFloat("pay");
                        employee.site = reader.GetString("site");
                        employee.designation = reader.GetString("designation");
                        employee.cash_advance = reader.GetDouble("cash_advance");
                        employee.loan = reader.GetDouble("loan");
                        employee.sss = reader.GetDouble("sss");
                        employee.pag_ibig = reader.GetDouble("pag_ibig");
                        employee.philhealth = reader.GetDouble("philhealth");
                    }
                }
                command.Dispose();
                this.db.Close();
                return employee;
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee = new Employee();
                        employee.control_number = reader.GetString("control_number");
                        employee.first_name = reader.GetString("first_name");
                        employee.last_name = reader.GetString("last_name");
                        employee.name = reader.GetString("name");
                        employee.position = reader.GetString("position");
                        employee.status = reader.GetString("status");
                        employee.shop_rate = reader.GetFloat("shop_rate");
                        employee.operational_rate = reader.GetFloat("operational_rate");
                        employee.absent = reader.GetInt32("absent");
                        employee.breakdown_days_present = reader.GetInt32("breakdown_days_present");
                        employee.operation_days_present = reader.GetInt32("operation_days_present");
                        employee.overtime_hours = reader.GetInt32("overtime_hours");
                        employee.overtime_pay = reader.GetFloat("overtime_pay");
                        employee.rate = reader.GetFloat("rate");
                        employee.pay = reader.GetFloat("pay");
                        employee.site = reader.GetString("site");
                        employee.designation = reader.GetString("designation");
                        employees.Add(employee);
                    }
                }
                command.Dispose();
                this.db.Close();
                return employees;
            }
        }
        public List<String> getEmployeeNames()
        {
            List<String> employees = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employees.Add(reader.GetString("name"));
                    }
                }
                command.Dispose();
                this.db.Close();
                return employees;
            }
        }
        public List<String> getEmployeePositions()
        {
            List<String> employees = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employees.Add(reader.GetString("position"));
                    }
                }
                command.Dispose();
                this.db.Close();
                return employees;
            }
        }
        public void searchEmployee(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', first_name AS 'First Name',last_name AS 'Last Name',name AS 'Full Name',position AS 'Position',status AS 'Status',shop_rate AS 'Shop Rate',operational_rate AS 'Operational Rate',absent AS 'Absent'," +
                "breakdown_days_present AS 'Non Operational Days'," +
                "operation_days_present AS 'Operational Days'," +
                "overtime_hours AS 'Overtime Hours'," +
                "site AS 'Site'," +
                "designation AS 'Designation',FORMAT(IF(rate = 0, ((operation_days_present * operational_rate) + (shop_rate * breakdown_days_present) + (overtime_hours * (operational_rate / 8))),rate),2) AS 'Total Receivable to Date'" +
                "FROM `employees`  " +
                 "WHERE last_name LIKE @searchTerm OR first_name LIKE @searchTerm OR name LIKE @searchTerm " +
                "ORDER BY `employees`.`last_name`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void searchPurchaseOrder(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id  = purchase_order.requester_id " +
                 "WHERE site LIKE @searchTerm OR control_number LIKE @searchTerm;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void searchEquipment(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                " shipping_weight AS 'Shipping Weight', " +
                "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                "FROM `equipment` WHERE cr_number LIKE @searchTerm OR plate_number LIKE @searchTerm  OR chassis_number LIKE @searchTerm  OR control_number LIKE @searchTerm OR make LIKE @searchTerm   OR engine_number LIKE @searchTerm OR series LIKE @searchTerm   OR mv_file_number LIKE @searchTerm OR series LIKE @searchTerm  OR year_model LIKE @searchTerm " +
                "ORDER BY `equipment`.`control_number`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public Equipment getEquipmentByControlNumber(String control_number)
        {
            Equipment equipment = new Equipment();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * " +
                    "FROM `equipment` WHERE control_number = @control_number;";
                command.Parameters.AddWithValue("@control_number", control_number);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    equipment.control_number = reader.GetString("control_number");
                    equipment.cr_number = reader.GetString("cr_number");
                    equipment.plate_number = reader.GetString("plate_number");
                    equipment.mv_file_number = reader.GetString("mv_file_number");
                    equipment.engine_number = reader.GetString("engine_number");
                    equipment.chassis_number = reader.GetString("chassis_number");
                    equipment.denomination = reader.GetString("denomination");
                    equipment.piston_displacement = reader.GetInt32("piston_displacement");
                    equipment.no_of_cylinders = reader.GetString("no_of_cylinders");
                    equipment.fuel = reader.GetString("fuel");
                    equipment.make = reader.GetString("make");
                    equipment.series = reader.GetString("series");
                    equipment.body_type = reader.GetString("body_type");
                    equipment.year_model = reader.GetString("year_model");
                    equipment.gross_weight = reader.GetInt32("gross_weight");
                    equipment.net_weight = reader.GetInt32("net_weight");
                    equipment.shipping_weight = reader.GetInt32("shipping_weight");
                    equipment.net_capacity = reader.GetInt32("net_capacity");
                    equipment.complete_owner_name = reader.GetString("complete_owner_name");
                    equipment.complete_owner_address = reader.GetString("complete_owner_address");
                    equipment.status = reader.GetString("status");
                    equipment.or_no = reader.GetString("or_no");
                    equipment.renewal_date = reader.GetDateTime("renewal_date");
                    equipment.insurance_renewal = reader.GetDateTime("insurance_renewal");
                    equipment.or_date = reader.GetDateTime("or_date");
                    equipment.equipment_price = reader.GetDouble("equipment_price");
                    equipment.serial = reader.GetString("serial");
                    equipment.site = reader.GetString("site");
                    equipment.cr_payment = reader.GetDouble("cr_payment");
                    equipment.image = reader.GetString("image");
                }

                command.Dispose();
                this.db.Close();
            }
            return equipment;
        }
        public void addSupplierData(Supplier supplier)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `supplier`( `supplier_name`, `address`, `account_number`, `contact_number`) " +
                    "VALUES (@supplier_name,@address, @account_number, @contact_number)";
                command.Parameters.AddWithValue("@supplier_name", supplier.supplier_name);
                command.Parameters.AddWithValue("@address", supplier.supplier_address);
                command.Parameters.AddWithValue("@account_number", supplier.account_number);
                command.Parameters.AddWithValue("@contact_number", supplier.contact_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Supplier successfully added.");
                command.Dispose();
                this.db.Close();
            }
        }
        public void addRequesterData(Requester requester)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `requester`(`name`, `position`, `contact_number`,`designation`)" +
                    " VALUES( @name, @position, @contact_number, @designation)";
                command.Parameters.AddWithValue("@name", requester.requester_name);
                command.Parameters.AddWithValue("@position", requester.requester_position);
                command.Parameters.AddWithValue("@contact_number", requester.requester_contact_number);
                command.Parameters.AddWithValue("@designation", requester.requester_designation);
                command.ExecuteNonQuery();
                MessageBox.Show("Requester successfully added.");
                command.Dispose();
                this.db.Close();
            }
        } 
        public void addPurchaseOrder(Purchase_Order purchase_order)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `purchase_order`(`control_number`, `supplier_id`, `charges`,  `delivered_to`, `partial_payment`, `remarks`, `requester_id`, `mode_of_payment`, `site`,`project_id`) VALUES (@control_number, @supplier_id, @charges,  @delivered_to," +
                    " @partial_payment, @remarks, @requester_id, @mode_of_payment, @site,@project_id)";
                command.Parameters.AddWithValue("@control_number", purchase_order.control_number);
                command.Parameters.AddWithValue("@supplier_id", purchase_order.supplier_id);
                command.Parameters.AddWithValue("@charges", purchase_order.charges);
                command.Parameters.AddWithValue("@delivered_to", purchase_order.delivered_to);
                command.Parameters.AddWithValue("@partial_payment", purchase_order.partial_payment);
                command.Parameters.AddWithValue("@remarks", purchase_order.remarks);
                command.Parameters.AddWithValue("@requester_id", purchase_order.requester_id);
                command.Parameters.AddWithValue("@mode_of_payment", purchase_order.mode_of_payment);
                command.Parameters.AddWithValue("@site", purchase_order.site);
                command.Parameters.AddWithValue("@project_id", purchase_order.project_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Purchase Order Successfully Added.");
                command.Dispose();
                this.db.Close();
            }
        }
        public void editPurchaseOrder(Purchase_Order purchase_order)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `purchase_order` SET `supplier_id`= @supplier_id,`charges`= @charges,`date_created`= @date_created,`delivered_to`= @delivered_to, `partial_payment`= @partial_payment,`remarks`=@remarks ,`requester_id`= @requester_id,`mode_of_payment`= @mode_of_payment,`site`= @site,`project_id`= @project_id,`location` = @site WHERE control_number = @control_number";
                command.Parameters.AddWithValue("@supplier_id", purchase_order.supplier_id);
                command.Parameters.AddWithValue("@charges", purchase_order.charges);
                command.Parameters.AddWithValue("@date_created", purchase_order.date_created);
                command.Parameters.AddWithValue("@delivered_to", purchase_order.delivered_to);
                command.Parameters.AddWithValue("@partial_payment", purchase_order.partial_payment);
                command.Parameters.AddWithValue("@remarks", purchase_order.remarks);
                command.Parameters.AddWithValue("@requester_id", purchase_order.requester_id);
                command.Parameters.AddWithValue("@mode_of_payment", purchase_order.mode_of_payment);
                command.Parameters.AddWithValue("@site", purchase_order.site);
                command.Parameters.AddWithValue("@project_id", purchase_order.project_id);
                command.Parameters.AddWithValue("@control_number", purchase_order.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Purchase Order Successfully Updated.");
                command.Dispose();
                this.db.Close();
            }
        }
        public void editRequester(Requester requester)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `requester` SET `name`= @name,`position` = @position,`contact_number` = @contact_number,`designation` = @designation WHERE `requester_id` = @requester_id";
                command.Parameters.AddWithValue("@name", requester.requester_name);
                command.Parameters.AddWithValue("@position", requester.requester_position);
                command.Parameters.AddWithValue("@contact_number", requester.requester_contact_number);
                command.Parameters.AddWithValue("@designation", requester.requester_designation);
                command.Parameters.AddWithValue("@requester_id", requester.requester_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Requester Successfully Updated!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteRequester(Requester requester)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `requester`  WHERE `requester_id` = @requester_id";
                command.Parameters.AddWithValue("@requester_id", requester.requester_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Requester Successfully Deleted!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteSupplier(Supplier supplier)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `supplier`  WHERE `supplier_id` = @supplier_id";
                command.Parameters.AddWithValue("@supplier_id", supplier.supplier_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Supplier Successfully Deleted!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void editSupplier(Supplier supplier)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `supplier` SET `supplier_name`=  @supplier_name,`address`= @address,`account_number`= @account_number,`contact_number`= @contact_number WHERE `supplier_id`= @supplier_id";
                command.Parameters.AddWithValue("@supplier_name", supplier.supplier_name);
                command.Parameters.AddWithValue("@address", supplier.supplier_address);
                command.Parameters.AddWithValue("@account_number", supplier.account_number);
                command.Parameters.AddWithValue("@contact_number", supplier.contact_number);
                command.Parameters.AddWithValue("@supplier_id", supplier.supplier_id);
                command.ExecuteNonQuery();
                MessageBox.Show("Supplier Successfully Updated!");
                command.Dispose();
                this.db.Close();
            }
        }
        public Purchase_Order getPurchaseOrderByID(String control_number)
        {
            Purchase_Order purchase_order = new Purchase_Order();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM purchase_order WHERE control_number = @control_number";
                command.Parameters.AddWithValue("@control_number", control_number);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    purchase_order.control_number = reader.GetString("control_number");
                    purchase_order.supplier_id = reader.GetString("supplier_id");
                    purchase_order.charges = reader.GetString("charges");
                    purchase_order.delivered_to = reader.GetString("delivered_to");
                    purchase_order.partial_payment = reader.GetDouble("partial_payment");
                    purchase_order.remarks = reader.GetString("remarks");
                    purchase_order.requester_id = reader.GetString("requester_id");
                    purchase_order.mode_of_payment = reader.GetString("mode_of_payment");
                    purchase_order.project_id = reader.GetString("project_id");
                    purchase_order.site = reader.GetString("site");
                    purchase_order.date_created = reader.GetDateTime("date_created");

                }
                command.Dispose();
                this.db.Close();
                return purchase_order;
            }
        }
        public Purchase_Order deletePurchaseOrder(String control_number)
        {
            Purchase_Order purchase_order = new Purchase_Order();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM purchase_order WHERE control_number = @control_number";
                command.Parameters.AddWithValue("@control_number", control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted record!");
                command.Dispose();
                this.db.Close();
                return purchase_order;
            }
        }
        public void editEquipment(Equipment equipment)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `equipment` SET   " +
                    " `cr_number` = @cr_number ,`plate_number`= @plate_number ,`mv_file_number`= @mv_file_number,`engine_number`= @engine_number " +
                    ",`chassis_number`= @chassis_number ,`denomination`=@denomination,`piston_displacement`=@piston_displacement,`no_of_cylinders`= " + "@no_of_cylinders,`fuel`= @fuel,`make`= @make,`series`= @series,`body_type`= @body_type,`year_model`= @year_model,`gross_weight`= @gross_weight,`net_weight`= @net_weight,`shipping_weight`= @shipping_weight,`net_capacity`= @net_capacity,`complete_owner_name`= @complete_owner_name,`complete_owner_address`= @complete_owner_address,`status`= @status,`or_no`= @or_no,`renewal_date`= @renewal_date,`insurance_renewal`= @insurance_renewal,`or_date`= @or_date,`equipment_price`= @equipment_price,`serial`= @serial,`site`= @site,`cr_payment`= @cr_payment WHERE  control_number = @control_number";
                command.Parameters.AddWithValue("@cr_number", equipment.cr_number);
                command.Parameters.AddWithValue("@plate_number", equipment.plate_number);
                command.Parameters.AddWithValue("@mv_file_number", equipment.mv_file_number);
                command.Parameters.AddWithValue("@engine_number", equipment.engine_number);
                command.Parameters.AddWithValue("@chassis_number", equipment.chassis_number);
                command.Parameters.AddWithValue("@denomination", equipment.denomination);
                command.Parameters.AddWithValue("@piston_displacement", equipment.piston_displacement);
                command.Parameters.AddWithValue("@no_of_cylinders", equipment.no_of_cylinders);
                command.Parameters.AddWithValue("@fuel", equipment.fuel);
                command.Parameters.AddWithValue("@make", equipment.make);
                command.Parameters.AddWithValue("@series", equipment.series);
                command.Parameters.AddWithValue("@body_type", equipment.body_type);
                command.Parameters.AddWithValue("@year_model", equipment.year_model);
                command.Parameters.AddWithValue("@gross_weight", equipment.gross_weight);
                command.Parameters.AddWithValue("@net_weight", equipment.net_weight);
                command.Parameters.AddWithValue("@shipping_weight", equipment.shipping_weight);
                command.Parameters.AddWithValue("@net_capacity", equipment.net_capacity);
                command.Parameters.AddWithValue("@complete_owner_name", equipment.complete_owner_name);
                command.Parameters.AddWithValue("@complete_owner_address", equipment.complete_owner_address);
                command.Parameters.AddWithValue("@status", equipment.status);
                command.Parameters.AddWithValue("@or_no", equipment.or_no);
                command.Parameters.AddWithValue("@renewal_date", equipment.renewal_date);
                command.Parameters.AddWithValue("@insurance_renewal", equipment.insurance_renewal);
                command.Parameters.AddWithValue("@or_date", equipment.or_date);
                command.Parameters.AddWithValue("@equipment_price", equipment.equipment_price);
                command.Parameters.AddWithValue("@serial", equipment.serial);
                command.Parameters.AddWithValue("@site", equipment.site);
                command.Parameters.AddWithValue("@cr_payment", equipment.cr_payment);
                command.Parameters.AddWithValue("@control_number", equipment.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Equipment Data Edited Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void addEquipment(Equipment equipment)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `equipment`(`control_number`, `cr_number`, `plate_number`, `mv_file_number`, `engine_number`, `chassis_number`, `denomination`, `piston_displacement`, `no_of_cylinders`, `fuel`, `make`, `series`, `body_type`, `year_model`, `gross_weight`, `net_weight`, `shipping_weight`, `net_capacity`, `complete_owner_name`, `complete_owner_address`, `status`, `or_no`, `renewal_date`, `insurance_renewal`, `or_date`,equipment_price,serial,site,cr_payment) VALUES(@control_number,@cr_number,@plate_number,@mv_file_number,@engine_number,@chassis_number,@denomination,@piston_displacement,@no_of_cylinders,@fuel,@make,@series,@body_type,@year_model,@gross_weight,@net_weight,@shipping_weight,@net_capacity,@complete_owner_name,@complete_owner_address,@status,@or_no,@renewal_date,@insurance_renewal,@or_date,@equipment_price,@serial,@site,@cr_payment)";

                command.Parameters.AddWithValue("@cr_number", equipment.cr_number);
                command.Parameters.AddWithValue("@plate_number", equipment.plate_number);
                command.Parameters.AddWithValue("@mv_file_number", equipment.mv_file_number);
                command.Parameters.AddWithValue("@engine_number", equipment.engine_number);
                command.Parameters.AddWithValue("@chassis_number", equipment.chassis_number);
                command.Parameters.AddWithValue("@denomination", equipment.denomination);
                command.Parameters.AddWithValue("@piston_displacement", equipment.piston_displacement);
                command.Parameters.AddWithValue("@no_of_cylinders", equipment.no_of_cylinders);
                command.Parameters.AddWithValue("@fuel", equipment.fuel);
                command.Parameters.AddWithValue("@make", equipment.make);
                command.Parameters.AddWithValue("@series", equipment.series);
                command.Parameters.AddWithValue("@body_type", equipment.body_type);
                command.Parameters.AddWithValue("@year_model", equipment.year_model);
                command.Parameters.AddWithValue("@gross_weight", equipment.gross_weight);
                command.Parameters.AddWithValue("@net_weight", equipment.net_weight);
                command.Parameters.AddWithValue("@shipping_weight", equipment.shipping_weight);
                command.Parameters.AddWithValue("@net_capacity", equipment.net_capacity);
                command.Parameters.AddWithValue("@complete_owner_name", equipment.complete_owner_name);
                command.Parameters.AddWithValue("@complete_owner_address", equipment.complete_owner_address);
                command.Parameters.AddWithValue("@status", equipment.status);
                command.Parameters.AddWithValue("@or_no", equipment.or_no);
                command.Parameters.AddWithValue("@renewal_date", equipment.renewal_date);
                command.Parameters.AddWithValue("@insurance_renewal", equipment.insurance_renewal);
                command.Parameters.AddWithValue("@or_date", equipment.or_date);
                command.Parameters.AddWithValue("@equipment_price", equipment.equipment_price);
                command.Parameters.AddWithValue("@serial", equipment.serial);
                command.Parameters.AddWithValue("@site", equipment.site);
                command.Parameters.AddWithValue("@cr_payment", equipment.cr_payment);
                command.Parameters.AddWithValue("@control_number", equipment.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Equipment Data Added Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void addPurchaseOrderItem(Purchase_Order_Item PO_item)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `purchase_order_item`( `purchase_order`, `quantity`, `unit`, `description`, `unit_cost`, `discount`, `amount`) VALUES ( @purchase_order, @quantity, @unit, @description, @unit_cost, @discount, @amount)";
                command.Parameters.AddWithValue("@purchase_order", PO_item.purchase_order);
                command.Parameters.AddWithValue("@quantity", PO_item.quantity);
                command.Parameters.AddWithValue("@unit", PO_item.unit);
                command.Parameters.AddWithValue("@description", PO_item.description);
                command.Parameters.AddWithValue("@unit_cost", PO_item.unit_cost);
                command.Parameters.AddWithValue("@discount", PO_item.discount);
                command.Parameters.AddWithValue("@amount", PO_item.amount);
                command.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void deleteEquipment(Equipment equipment)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `equipment` WHERE control_number = @control_number";
                command.Parameters.AddWithValue("@control_number", equipment.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Equipment Data Deleted Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void filterEquipmentsBySite(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', cr_number AS 'Certificate of Registration Number', plate_number AS 'Plate Number', mv_file_number AS 'MV File No.', engine_number AS 'Engine Number', chassis_number AS 'Chassis Number', denomination AS 'Denomination', " +
                    "piston_displacement AS 'Piston Displacement', no_of_cylinders AS 'No. of Cylinders', fuel AS 'Fuel', make AS 'Make', series AS 'Series'," +
                    " body_type AS 'Body Type', year_model AS 'Year Model',gross_weight AS 'Gross Weight', net_weight AS 'Net Weight'," +
                    " shipping_weight AS 'Shipping Weight', " +
                    "net_capacity AS 'Net Capacity', complete_owner_name AS 'Complete Owner Name', complete_owner_address AS 'Complete Owner Address'," +
                    "status AS 'Status',or_no AS 'O.R. Number',renewal_date AS 'Renewal Date',insurance_renewal AS 'Insurance Renewal',or_date AS 'O.R. Date'," +
                    "FORMAT(equipment_price, 2)   AS 'Equipment Price', serial AS 'Serial', site AS 'Site', FORMAT(cr_payment, 2)    AS 'Cert. of Registration Payment' " +
                    "FROM `equipment` WHERE site LIKE @searchTerm " +
                "ORDER BY `equipment`.`control_number`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void filterPurchaseOrdersBySite(ref DataGridView dgv, String searchTerm)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', supplier.supplier_name AS 'Supplier', purchase_order.date_created AS 'Date Created', delivered_to AS 'Delivered to', partial_payment AS 'Partial Payment' , remarks AS 'Remarks', mode_of_payment AS 'Mode of Payment', site AS 'Site' FROM `purchase_order` INNER JOIN supplier ON supplier.supplier_id = purchase_order.supplier_id INNER JOIN requester ON requester.requester_id = purchase_order.requester_id  WHERE site LIKE @searchTerm";
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public void filterEmployeesBySite(ref DataGridView dgv, String site)
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT control_number AS 'Control Number', first_name AS 'First Name',last_name AS 'Last Name',name AS 'Full Name',position AS 'Position',status AS 'Status',shop_rate AS 'Shop Rate',operational_rate AS 'Operational Rate',absent AS 'Absent'," +
                    "breakdown_days_present AS 'Non Operational Days'," +
                    "operation_days_present AS 'Operational Days'," +
                    "overtime_hours AS 'Overtime Hours'," +
                    "site AS 'Site'," +
                    "designation AS 'Designation',FORMAT(IF(rate = 0, ((operation_days_present * operational_rate) + (shop_rate * breakdown_days_present) + (overtime_hours * (operational_rate / 8))),rate),2) AS 'Total Receivable to Date'" +
                    "FROM `employees`  " +
                     "WHERE site LIKE @searchTerm " +
                    "ORDER BY `employees`.`last_name`  ASC;";
                command.Parameters.AddWithValue("@searchTerm", "%" + site + "%");
                MySqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }

        public List<String> getSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public List<String> getEquipmentSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM equipment";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public DataTable getEquipmentReport()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM equipment";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);

                command.Dispose();
                this.db.Close();
                return dataTable;
            }
        }
        public List<String> getPurchaseOrderSiteList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM purchase_order";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("site"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public List<String> getDesignationList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT designation FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("designation"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }
        public Dictionary<String, String> getSupplierList()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT supplier_id, supplier_name FROM supplier";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add( reader.GetString("supplier_name"), reader.GetString("supplier_id")) ;
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public Models.Supplier getSupplierByID(String supplier_id)
        {
            Models.Supplier result = new Models.Supplier();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT  * FROM supplier WHERE supplier_id = @supplier_id";
                command.Parameters.AddWithValue("@supplier_id", supplier_id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.supplier_id = reader.GetString(0);
                    result.supplier_name = reader.GetString(1);
                    result.supplier_address = reader.GetString(2);
                    result.account_number = reader.GetString(3);
                    result.contact_number = reader.GetString(4);
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public Models.Requester getRequesterByID(String requester_id)
        {
            Models.Requester result = new Models.Requester();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT  * FROM requester WHERE requester_id = @requester_id";
                command.Parameters.AddWithValue("@requester_id", requester_id);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.requester_id = reader.GetString(0);
                    result.requester_name = reader.GetString(1);
                    result.requester_position = reader.GetString(2);
                    result.requester_contact_number = reader.GetString(3);
                    result.requester_designation = reader.GetString(4);
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public Dictionary<String, String> getRequesterList()
        {
            Dictionary<String, String> result = new Dictionary<String, String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT `requester_id`, `name` FROM requester";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add( reader.GetString("name"), reader.GetString("requester_id")); ;
                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public List<String> getDenominations()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT denomination FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getFuels()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT fuel FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getMakes()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT make FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getSeries()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT series FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getBodyTypes()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT body_type FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getYearModels()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT year_model FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getCON()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT complete_owner_name FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getCOA()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT complete_owner_address FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getStatus()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT status FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getSites()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT site FROM `equipment`";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString(0));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }



        public List<String> getPositionList()
        {
            List<String> sites = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT position FROM employees";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sites.Add(reader.GetString("position"));
                }

                command.Dispose();
                this.db.Close();
                return sites;
            }
        }

        public List<String> getRecipientEmails()
        {
            List<String> recipientNames = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM recipient";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    recipientNames.Add(reader.GetString("email_address"));
                }

                command.Dispose();
                this.db.Close();
                return recipientNames;
            }
        }



        public void fillRecipientTable(ref DataGridView dgv)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT ID AS 'Recipient ID', email_address AS 'Email Address', contact_number AS 'Contact Number', name AS 'Name', position AS 'Position', office AS 'Office'  FROM `recipient` ";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv.DataSource = dataTable;
                command.Dispose();
                this.db.Close();
            }
        }
        public void createMonthlyAttendance(Employee employee, MonthlyAttendance monthlyAttendance)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `monthly_attendance`( `month`, `date_from`, `date_to`, `year`, `working_days`, `employee`, `days_present`, `days_absent`, `days_breakdown`, `overtime_hours`) VALUES (@month,@date_from,@date_to,@year,@working_days,@employee,@days_present,@days_absent,@days_breakdown,@overtime_hours)";
                command.Parameters.AddWithValue("@month", monthlyAttendance.month);
                command.Parameters.AddWithValue("@date_from", monthlyAttendance.dateFrom);
                command.Parameters.AddWithValue("@date_to", monthlyAttendance.dateTo);
                command.Parameters.AddWithValue("@year", monthlyAttendance.year);
                command.Parameters.AddWithValue("@working_days", monthlyAttendance.working_days);
                command.Parameters.AddWithValue("@employee", employee.control_number);
                command.Parameters.AddWithValue("@days_present", monthlyAttendance.days_present);
                command.Parameters.AddWithValue("@days_absent", monthlyAttendance.days_absent);
                command.Parameters.AddWithValue("@days_breakdown", monthlyAttendance.days_breakdown);
                command.Parameters.AddWithValue("@overtime_hours", monthlyAttendance.overtime_hours);
                command.ExecuteNonQuery();
                command.Dispose();
                this.db.Close();
            }
        }

        public void editEmployeeAttendance(Employee employee, String month, String year)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `monthly_attendance` SET days_breakdown = @breakdown_days_present, days_present = @operation_days_present," +
                    " overtime_hours = @overtime_hours, undertime_hours = @undertime_hours WHERE employee = @control_number AND month = @month AND year = @year";
                command.Parameters.AddWithValue("@control_number", employee.control_number);
                command.Parameters.AddWithValue("@breakdown_days_present", employee.breakdown_days_present);
                command.Parameters.AddWithValue("@operation_days_present", employee.operation_days_present);
                command.Parameters.AddWithValue("@overtime_hours", employee.overtime_hours);
                command.Parameters.AddWithValue("@undertime_hours", employee.undertime_hours);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void editEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `employees` SET `first_name`= @first_name,`last_name`= @last_name,`name`= @name,`position`= @position, `shop_rate`= @shop_rate, `operational_rate`= @operational_rate, `rate`= @rate, `site`= @site, `designation`= @designation WHERE  control_number = @control_number ";
                command.Parameters.AddWithValue("@first_name", employee.first_name);
                command.Parameters.AddWithValue("@last_name", employee.last_name);
                command.Parameters.AddWithValue("@name", employee.name);
                command.Parameters.AddWithValue("@position", employee.position);
                command.Parameters.AddWithValue("@shop_rate", employee.shop_rate);
                command.Parameters.AddWithValue("@operational_rate", employee.operational_rate);
                command.Parameters.AddWithValue("@rate", employee.rate);
                command.Parameters.AddWithValue("@site", employee.site);
                command.Parameters.AddWithValue("@designation", employee.designation);
                command.Parameters.AddWithValue("@control_number", employee.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }

        public void deleteEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `employees`  WHERE  control_number = @control_number ";
                command.Parameters.AddWithValue("@control_number", employee.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Deleted Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void addEmployee(Employee employee)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `employees`(`control_number`,`first_name`,`last_name`,`name`,`position`, `shop_rate`, `operational_rate`, `rate`, `site`, `designation`) VALUES(@control_number, @first_name, @last_name, @name, @position, @shop_rate, @operational_rate, @rate, @site, @designation)";
                command.Parameters.AddWithValue("@control_number", employee.control_number);
                command.Parameters.AddWithValue("@first_name", employee.first_name);
                command.Parameters.AddWithValue("@last_name", employee.last_name);
                command.Parameters.AddWithValue("@name", employee.name);
                command.Parameters.AddWithValue("@position", employee.position);
                command.Parameters.AddWithValue("@shop_rate", employee.shop_rate);
                command.Parameters.AddWithValue("@operational_rate", employee.operational_rate);
                command.Parameters.AddWithValue("@rate", employee.rate);
                command.Parameters.AddWithValue("@site", employee.site);
                command.Parameters.AddWithValue("@designation", employee.designation);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void updateDeductibles(Employee employee, String month, String year)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `monthly_attendance` SET cash_advance = @cash_advance, loan = @loan," +
                    " sss = @sss, pag_ibig = @pag_ibig, philhealth = @philhealth, month_end_cash_advance = @month_end_cash_advance WHERE employee = @control_number AND month = @month AND year = @year";
                command.Parameters.AddWithValue("@control_number", employee.control_number);
                command.Parameters.AddWithValue("@cash_advance", employee.cash_advance);
                command.Parameters.AddWithValue("@loan", employee.loan);
                command.Parameters.AddWithValue("@sss", employee.sss);
                command.Parameters.AddWithValue("@pag_ibig", employee.pag_ibig);
                command.Parameters.AddWithValue("@philhealth", employee.philhealth);
                command.Parameters.AddWithValue("@month_end_cash_advance", employee.month_end_cash_advance);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }
        public void editWorkingDays(String month, String year, int workingDays)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `monthly_attendance` SET working_days = @working_days, days_present = @working_days WHERE  month = @month AND year = @year";
                command.Parameters.AddWithValue("@working_days", workingDays);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }     public void setEquipmentImage(Equipment equipment)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "UPDATE `equipment` SET image = @image WHERE  control_number = @control_number";
                command.Parameters.AddWithValue("@image", equipment.image);
                command.Parameters.AddWithValue("@control_number", equipment.control_number);
                command.ExecuteNonQuery();
                MessageBox.Show("Information Saved Successfully!");
                command.Dispose();
                this.db.Close();
            }
        }


    }

}

//SELECT *, employees.control_number, month , DATE_FORMAT(date_from, ' %M %d') AS 'From',  DATE_FORMAT(date_to, ' %M %d') AS 'To', days_present , days_absent, days_breakdown, name, FORMAT(employees.shop_rate, 2) AS 'shop_rate', FORMAT(employees.operational_rate, 2) AS 'operational_rate',  IF(employees.rate = 0, 'Variable', 'Flat') AS 'rate_type',FORMAT((monthly_attendance.days_breakdown * employees.shop_rate), 2) AS 'shop_cost',FORMAT((monthly_attendance.days_present * employees.operational_rate), 2) AS 'operational_cost',(monthly_attendance.overtime_hours * (employees.operational_rate / 8)) AS 'overtime_cost',IF(employees.rate = 0, FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate)), 2), FORMAT(employees.rate, 2)) AS 'gross_amount',IF(employees.rate = 0, FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))), 2), FORMAT(employees.rate, 2)) AS 'gross_with_overtime',employees.site, cash_advance, loan,sss,pag_ibig,philhealth,IF(employees.rate = 0, FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2), FORMAT((employees.rate) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2)) AS 'net_amount',IF(IF(employees.rate = 0, FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2), FORMAT((employees.rate) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2)) >= 0, IF(employees.rate = 0, FORMAT(((monthly_attendance.days_breakdown * employees.shop_rate) + (monthly_attendance.days_present * employees.operational_rate) + (monthly_attendance.overtime_hours * (employees.operational_rate / 8))) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2), FORMAT((employees.rate) - (cash_advance) - (loan) - (sss) - (pag_ibig) - (philhealth), 2)), 0) AS 'positive_only' FROM monthly_attendance INNER JOIN employees ON employee = employees.control_number;