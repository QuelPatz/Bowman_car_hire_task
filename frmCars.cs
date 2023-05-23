using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = c:\data\hire.db"); //connects to the Database

        public frmCars()
        {
            InitializeComponent();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter("first"); //go to first position
            getData(); //get data of current position
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            recordCounter("previous"); //go to first position
            getData(); //get data of current position
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            recordCounter("next"); //go to first position
            getData(); //get data of current position
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            recordCounter("last"); //go to first position
            getData(); //get data of current position
        }

        int recordControlNo = 1;
        int totalRecords;

        public void recTotal()
        {
            string findTotal = @"SELECT COUNT(*) FROM tblCar";

            databaseConnection.Open();
            var command = databaseConnection.CreateCommand();
            command.CommandText = findTotal;
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total;
                }
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
            databaseConnection.Close();

        }
        public void recordCounter(string frmBtn)
        {

            if (frmBtn == "next")
            {
                if (recordControlNo < totalRecords)
                { recordControlNo += 1; }
            }

            if (frmBtn == "previous")
            {
                if (recordControlNo > 1)
                { recordControlNo -= 1; }
            }
            if (frmBtn == "first")
            { recordControlNo = 1; }

            if (frmBtn == "last")
            { recordControlNo = totalRecords; }

        }
        private void recordCount_TextChanged_1(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }
        private void frmCars_Load_1(object sender, EventArgs e)
        {//This is what happens when form loads
            try
            {
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load database. Check database connection");
            }

            btnUpdate.Enabled = false; //Update button unusable until use conditions are met
            btnCancel.Enabled = false; //Cancel button unusable until use conditions are met
            updatePanel.Visible = false; //Panel button unusable until use conditions are met

            if (btnUpdate.Enabled == true)
            {
                updatePanel.Visible = true;
            }
        }
        Details details = new Details();
        public void getData()
        {
            int rowPosition = recordControlNo - 1;

            try
            {
                databaseConnection.Open();
                string getDB = $@"SELECT * FROM tblCar LIMIT 1 OFF SET {rowPosition}";
                SQLiteCommand cmd = new SQLiteCommand(getDB, databaseConnection);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                databaseConnection.Close(); //closing connection to database

                frmVehicleRegistrationNumber.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                frmMakeLabel.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                frmEngineSize.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                frmDateReg.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                frmRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                if (available == 1)
                {// If database returns 1 then we check the checkbox
                    frmAvailable.Checked = true;
                }
                else
                {// If databesa returns 0 then we uncheck the checkbox
                    frmAvailable.Checked = false;
                }

                btnUpdate.Enabled = false;
                btnCancel.Enabled = false;
                updatePanel.Visible = false;

                details.VehicleReg = frmVehicleRegistrationNumber.Text;
                details.Make = frmMakeLabel.Text;
                details.Engine = frmEngineSize.Text;
                details.DateReg = frmDateReg.Text;
                details.RentalPerDay = frmRentalPerDay.Text;
                details.Available = available;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Cannot find data"); // If getdata fails to work this message box appears
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch();
            searchForm.ShowDialog();
        }
        private void frmVehicleRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }
        private int availability;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd openAddForm = new frmAdd();
            this.Hide();
            openAddForm.ShowDialog();
            this.Close();
        }
        private void updateRecord()
        {//UPDATES RECORD BASED ON INFORMATION IN TEXT FIELDS
            int offsetNumber = recordControlNo - 1;
            try
            {
                if(frmAvailable.Checked == true)
                {
                    availability = 1;
                }
                if (frmAvailable.Checked == false)
                {
                    availability = 0;
                }
                string updateARecord = $@"UPDATE tblCar SET VehicleRegNo = '" + frmVehicleRegistrationNumber.Text + "', Make = '" + frmMake.Text + "', EngineSize ='" + frmEngineSize.Text + "', DataRegistered = '" + frmDateReg.Text + "', RentalPerDay = '" + frmRentalPerDay.Text + "', Available = '" + availability + "'WHERE VehicleRegNo = (SELECT VehicleRegNo from tblCar limit 1 OFFSET" + offsetNumber + ");";
                databaseConnection.Open();
                SQLiteCommand insertSQL = new SQLiteCommand(databaseConnection);
                insertSQL.CommandText = updateARecord;
                insertSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show($"Are you sure you'd like to delete this record\nVehicle Registration: {details.VehicleReg}\nMake: {details.Make}\nEngine Size: {details.Engine}\nDate Registered: {details.DateReg}\nRental Per Day: {details.RentalPerDay}\nAvailable: {details.Available}", "Delete Record", MessageBoxButtons.YesNo);
            if (toDelete == DialogResult.Yes)
            {
                deleteData();
                MessageBox.Show("Record Deleted");
            }
            else if (toDelete == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
        }
        private void deleteData()
        {//DELETES CURRENT DISPLAYED DATA FROM DATABASE
            try
            {
                string deleteRecord = $@"DELETE FROM tblCar WHERE VehicleRegNo = '{frmVehicleRegistrationNumber.Text}'";

                databaseConnection.Open();
                string sendData2 = deleteRecord;
                SQLiteCommand deleteSQL = new SQLiteCommand(databaseConnection);
                deleteSQL.CommandText = sendData2;
                deleteSQL.ExecuteNonQuery();
                databaseConnection.Close();
                recTotal();
                recordCounter("last");
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete data");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            getData();
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            updatePanel.Visible = false;
            frmMake.BackColor = Color.White;
            frmEngineSize.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult toUpdate = MessageBox.Show("Are you sure you'd like to Update this record?", "Update Record", MessageBoxButtons.YesNo);
            if (toUpdate == DialogResult.Yes)
            {
                updateRecord();
                MessageBox.Show("Record updated.");
            }
            else if (toUpdate == DialogResult.No)
            {
                MessageBox.Show("No record has been deleted.");
            }
            frmMake.BackColor = Color.White;
            frmEngineSize.BackColor = Color.White;
            frmDateReg.BackColor = Color.White;
            frmAvailable.BackColor = Color.White;
            frmRentalPerDay.BackColor = Color.White;
        }
        private void frmMake_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }
        private void frmEngine_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }
        public void frmDateReg_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }
        private void frmRentalPerDay_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }
        private void frmVehicleRegistrationNumber_KeyDown(object sender, KeyEventArgs e)
        {
            frmVehicleRegistrationNumber.BackColor = Color.LightGoldenrodYellow;
        }
        private void frmMake_KeyDown(object sender, KeyEventArgs e)
        {
            frmMake.BackColor = Color.LightGoldenrodYellow;
        }
        private void frmEngineSize_KeyDown(object sender, EventArgs e)
        {
            frmEngineSize.BackColor = Color.LightGoldenrodYellow;
        }
        private void frmDateReg_KeyDown(object sender, EventArgs e)
        {
            frmDateReg.BackColor = Color.LightGoldenrodYellow;
        }
        private void frmRentalPerDay_KeyDown(object sender, KeyEventArgs e)
        {
            frmRentalPerDay.BackColor = Color.LightGoldenrodYellow;
        }
        private void frmAvailable_KeyDown(object sender, EventArgs e)
        {
            frmAvailable.BackColor = Color.LightGoldenrodYellow;
        }
    }
}