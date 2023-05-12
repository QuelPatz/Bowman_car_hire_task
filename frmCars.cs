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
using Microsoft.Data.Sqlite;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"datasource = c:\Projects\it_course\Jennifer_2_C#\data\hire.db"); //conncts to the Database

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

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            recordCounter("last"); //go to first position
            getData(); //get data of current position
        }
        int recordControlNo = 1;
        int totalRecords;

        public void recTotal()
        {
            string findTotal = @"SELECT COUNT(*) FROM tblCar"; //SQL Query to find the 

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
            recordCount.Text = $"{recordControlNo} of {findTotal}";
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

            recordCount.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void recordCount_TextChanged(object sender, EventArgs e)
        {
            recordCount.Text = $"{recordContolNo} of {totalRecords}";
        }

        private void Form1_load(object sender, EventArgs e)
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

            btnUpdate.Enable = false; //Update button unusable until use conditions are met
            btnCancel.Enable = false; //Cancel button unusable until use conditions are met
            updatePanel.Visible = false; //Panel button unusable until use conditions are met


            if (btnUpdate.Enable == true)
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
                string getDB = $@"SELECT * FROM (SELECT * FROM tblCar LIMIT 1 OFF SET {rowPosition})";
                SQLiteCommand cmd = new SQLiteCommand(getDB, databaseConnection);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                frmDataGrid.DataSourde = dt;
                databaseConnection.Close();

                frmVehicleReg.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
                frmMake.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
                frmEngine.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);
                frmDateReg.Text = Convert.ToString(dt.Rows[0].ItemArray[4]);
                frmRentalPerDay.Text = Convert.ToString(dt.Rows[0].ItemArray[5]);
                int available = Convert.ToInt32(dt.Rows[0].ItemArray[6]);
                if (available == 1)
                {
                    frmAvailable.Checked = true;
                }
                else
                {
                    frmAvailable.Checked = false;
                }

                btnUpadate.Enable = false;
                btnCancel.Enable = false;
                updatePanel.Visible = false;

                details.VehicleReg = frmVehicleReg.Text;
                details.Make = frmMake.Text;
                details.Engine = frmEngine.Text;
                details.DateReg = frmDateReg.Text;
                details.RentalPerDay = frmRentalPerDay.Text;
                details.Available = Available;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find data");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void vehicleTooltip_Popup(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSeach();
            searchForm.ShowDialog();
        }

        private void frmVehicleReg_TextChange(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            updatePanel.Visible = true;
        }

        private void deleteData()
        {
            {//DELETES CURRENT DISPLAYED DATA FROM DATABASE
                try
                {
                    string deleteRecord = $@"DELETE FROM btnCar WHERE VehicleRegNo = '{frmVehicleReg.Text}'";

                    databaseConnection.Open();
                    string sendDara2 = deleteARecord;
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}