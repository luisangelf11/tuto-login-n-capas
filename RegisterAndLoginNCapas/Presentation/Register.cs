using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.CRUD;
using Domain.Models;
using Common.Attributes;

namespace Presentation
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        DUsers users = new DUsers();
        AttributesUserBD attributes = new AttributesUserBD();
        DExistUser existUser = new DExistUser();
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "" || txtName.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Campos vacios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //..
                attributes.Name = txtName.Text;
                attributes.Lastname = txtLastname.Text;
                attributes.Username = txtUsername.Text;
                attributes.Password = txtPassword.Text;
                var exist = existUser.ValidateUser(txtUsername.Text); //Validar si el usuario existe
                if (exist) MessageBox.Show("Este usuario esta en uso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    users.CreateUser(attributes);
                    MessageBox.Show("Este usuario se registro exitosamente!", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLastname.Text = "";
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
        }
    }
}
