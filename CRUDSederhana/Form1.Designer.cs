using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-PGJ5QLQ\\ANNISADIANAMARTA;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ClearForm()
        {
            txtNIM.Clear();
            

