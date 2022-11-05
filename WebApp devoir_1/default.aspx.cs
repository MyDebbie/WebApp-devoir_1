using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_devoir_1
{
    public partial class _default : System.Web.UI.Page
    {

        DatabaseClass databaseClass = new DatabaseClass();


        /// <summary>
        /// Save Information to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == String.Empty)
            {
                Message.Text = "Nom cannot be empty";
                txtNom.Focus();
                return;
            }
            if (txtPrenom1.Text.Trim() == String.Empty)
            {
                Message.Text = "Prenom1 cannot be empty";
                txtPrenom1.Focus();
                return;
            }
            if (txtPrenom2.Text.Trim() == String.Empty)
            {
                Message.Text = "Prenom2 cannot be empty";
                txtPrenom2.Focus();
                return;
            }
            if (txtAge.Text.Trim() == String.Empty)
            {
                Message.Text = "Age cannot be empty";
                txtAge.Focus();
                return;
            }
            if (txtTelephone.Text.Trim() == String.Empty)
            {
                Message.Text = "Telephone cannot be empty";
                txtTelephone.Focus();
                return;
            }
            if (txtAdresse.Text.Trim() == String.Empty)
            {
                Message.Text = "Adresse cannot be empty";
                txtAdresse.Focus();
                return;
            }
            if (txtVille.Text.Trim() == String.Empty)
            {
                Message.Text = "Ville cannot be empty";
                txtVille.Focus();
                return;
            }
            if (txtPays.Text.Trim() == String.Empty)
            {
                Message.Text = "Pays cannot be empty";
                txtPays.Focus();
                return;
            }
            if (txtNationalite.Text.Trim() == String.Empty)
            {
                Message.Text = "Nationalite cannot be empty";
                txtNationalite.Focus();
                return;
            }
           

            List<Personne> Personnes = new List<Personne> { };


            Personne personne = new Personne(txtNom.Text, txtPrenom1.Text, txtPrenom2.Text, int.Parse(txtAge.Text), txtTelephone.Text, txtAdresse.Text, txtVille.Text, txtPays.Text, txtNationalite.Text, DateTime.Now.ToString("d"));

            Personnes.Add(personne);

            databaseClass.InsertIntoDatabase(personne);

            DataTable dataTable = DatabaseClass.SelectIntoDatabase();
            if (dataTable.Rows.Count > 0)
            {
                gvPersonne.DataSource = dataTable;
                gvPersonne.DataBind();
            }

        }

        /// <summary>
        /// Clear all the boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtNom.Text = String.Empty;
            txtPrenom1.Text = String.Empty;
            txtPrenom2.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtTelephone.Text = String.Empty;
            txtAdresse.Text = String.Empty;
            txtVille.Text = String.Empty;
            txtPays.Text = String.Empty;
            txtNationalite.Text = String.Empty;
            Message.Text = String.Empty;
           

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseClass.CreateDatabase();

            DataTable dataTable = DatabaseClass.SelectIntoDatabase();
            if (dataTable.Rows.Count > 0)
            {
                gvPersonne.DataSource = dataTable;
                gvPersonne.DataBind();
            }

        }
    }
}