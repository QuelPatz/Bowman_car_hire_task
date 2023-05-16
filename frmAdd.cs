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
    public partial class frmAdd : Form
    {
        SQLiteConnection connect = new SQLiteConnection(@"datasource = c:\Projects\it_course\Jennifer_2_C#\data\hire.db"); //connects to the Database

        public frmAdd()
        {
            InitializeComponent();
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
        private int Availability;
        private string returnedReg;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmVehicleReg.Text != "" && frmMake.Text != "" && frmDateReg.Text != "" && frmEngine.Text != "" && frmRentalPerDay.Value != 0)
            {
                try
                {
                    //STRING USED FOR DB
                    string isRegInDb = $@"SELECT VahicleRegNo FROM tblCar WHERE VehicleRegNo = '" + frmVehicleReg.Text + "'";
                    connect.Open();

                    var command = connect.CreateCommand();
                    command.CommandText = isRegInDb;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reg = reader.GetString(0);
                            returnedReg = reg;
                        }
                        if (frmVehicleReg.Text == returnedReg)
                        {
                            MessageBox.Show("Vehicle Registration Number may already exist in the database.");
                        }
                        if (frmVehicleReg.Text != returnedReg)
                        {
                            if (frmAvailable.Checked == true)
                            {
                                Availability = 1;
                            }

                            if (frmAvailable.Checked == false)
                            {
                                Availability = 0;
                            }
                            string addRecord = $@"INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES
                                            ('" + frmVehicleReg.Text + "', '" + frmMake.Text + "', '" + frmEngine.Text + "', '" + frmDateReg.Text + "', '" + frmRentalPerDay.Text + "', '" + availability + "')";
                            SQLiteCommand insertSQL = new SQLiteCommand(addRecord, connect);
                            insertSQL.ExecuteNonQuery();
                            MessageBox.Show("You have succesfully added a new record to the database");
                            connect.Close();
                        }

                    }
                } 
                catch (Exception)
                {
                    MessageBox.Show("Cannot add data");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please make sure all fields are completed");
            }
        }

        private void frmVehicleReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEngineSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDateRegistered_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmRentalPerDay_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmAvailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVehicleReg.Text = "";
            frmEngineSize.Text = "";
            frmDateReg.Text = "";
            frmMake.Text = "";
            frmRentalPerDayLabel.Text = 0;
            frmAvailable.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCars goTofrmCars = new frmCars();
            this.Hide();
            goTofrmCars.ShowDialog();
            this.Close();
        }

        private void frmRentalPerDay_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
