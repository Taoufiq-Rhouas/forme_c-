using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Form_Brif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //les variables pour les validation des champs
        int validname = 0;
        int validprenom = 0;
        int validtele = 0;
        int validemail = 0;
        int validpays = 0;
        int validville = 0;
        int specialite = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valid_name(textBox1.Text);
            valid_prenom(textBox2.Text);
            isvalid_telephone(textBox3.Text);
            isvalid_email(textBox4.Text);

            //valitation de champs pays
            if (comboBox_pays.Text == "")
            {
                validpays++;
                label_err_pays.Text = "merci de sélectionner un pays";
            }
            else
            {
                label_err_pays.Text = "";
                validpays = 0;
            }

            //valitation de champs ville

            if (comboBox_ville.Text == "")
            {
                label_err_ville.Text = "merci de sélectionner une ville";
                validville++;

            }
            else
            {
                label_err_ville.Text = "";
                validville = 0;
            }

            //valitation de champs spécialite
            if (comboBox_specialite.Text == "")
            {
                label_err_specialite.Text = "merci de sélectionner une spécialité";
                specialite++;
            }
            else
            {
                label_err_specialite.Text = "";
                specialite = 0;
            }


            //message de validation
            if (validname == 0 && validprenom == 0 && validtele == 0 && validemail == 0 && validpays == 0 && validville == 0 && specialite == 0)
            {

                label_succes.Text = "vous information est validé avec succès";
                MessageBox.Show("vous information est validé avec succès");
            }

        }

        public bool valid_name(string nom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(nom);
            if (valid == true)
            {
                validname = 0;
                label_err_name.Text ="";
                return valid;
            }
            else
            {
                validname++;
                label_err_name.Text = "nom est incorrect";
                return valid;

            }
        }
        public bool valid_prenom(string prenom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(prenom);
            if (valid == true)
            {
                validprenom = 0;
                label_err_prenom.Text = "";
                return valid;
            }
            else
            {
                validprenom++;
                label_err_prenom.Text = "prenom est incorrect";
                return valid;

            }
        }

        public bool isvalid_telephone(string n)
        {
            Regex check = new Regex(@"^([0-9]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                validtele = 0;
                label_err_tel.Text = "";
                return valid;
            }
            else
            {
                validtele++;
                label_err_tel.Text = "telephone est incorrect";
                return valid;
            }
        }

        public bool isvalid_email(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valide = false;
            valide = check.IsMatch(email);
            if (valide == true)
            {
                validemail = 0;
                label_err_email.Text = "";
                return valide;
            }
            else
            {
                validemail++;
                label_err_email.Text = "email est incorrect";
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pays.Text == "Maroc")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Safi");
                comboBox_ville.Items.Add("Agadir");
                comboBox_ville.Items.Add("Esaouira");
                comboBox_ville.Items.Add("Titouan");
            }
            else if (comboBox_pays.Text == "France")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Paris");
                comboBox_ville.Items.Add("Lyon");
                comboBox_ville.Items.Add("Toulouse");
                comboBox_ville.Items.Add("Tours");
            }
            else if (comboBox_pays.Text == "Allemand")
            {
                comboBox_ville.Items.Clear();
                comboBox_ville.Items.Add("Bonn");
                comboBox_ville.Items.Add("Berlin");
            }
        }

        private void label_err_prenom_Click(object sender, EventArgs e)
        {

        }

        private void label_err_tel_Click(object sender, EventArgs e)
        {

        }

        private void label_err_email_Click(object sender, EventArgs e)
        {

        }

        private void label_err_pays_Click(object sender, EventArgs e)
        {

        }

        private void label_err_ville_Click(object sender, EventArgs e)
        {

        }

        private void label_err_name_Click(object sender, EventArgs e)
        {

        }

        private void label_err_specialite_Click(object sender, EventArgs e)
        {

        }
    }
}
