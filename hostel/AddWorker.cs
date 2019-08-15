using hostel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel
{
    public partial class AddWorker : Form
    {
        hostelDBEntities db = new hostelDBEntities();
        public AddWorker()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string fullname = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string[] checkedInput = new string[] {
            fullname,email,phone,password
            };
            if (Extensions.CheckInput(checkedInput,string.Empty))
            {
                lblError.Visible = false;
                if (phone.Length < 15)
                {
                    if(password.Length > 7)
                    {
                        if(password == confirmPassword)
                        {
                            Worker wk = db.Workers.FirstOrDefault(c => c.Email == email);
                            if(wk == null)
                            {
                                db.Workers.Add(new Worker()
                                {
                                    Fullname = fullname,
                                    Email = email,
                                    Password = password.hashPassword(),
                                });
                                db.SaveChanges();
                                MessageBox.Show("Worker Succsessufully Add", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            lblError.Text = "Password and Confirm Password is not correct";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Password lenght 8 character";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Phone lenght 15 Character";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Pleas All The Fill";
                lblError.Visible = true;
            }
        }
    }
}

