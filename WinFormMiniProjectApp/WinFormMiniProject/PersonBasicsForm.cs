using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class PersonBasicsForm : Form
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();

        public PersonBasicsForm()
        {
            InitializeComponent();

            BasicInfoDisplay();
        }

        private void BasicInfoDisplay()
        {
            basicInfoListbox.DataSource = people;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();

            if (firstNameTextbox.Text != "")
            {
                person.FirstName = firstNameTextbox.Text;
            }

            if (lastNameTextbox.Text != "")
            {
                person.LastName = lastNameTextbox.Text;
            }

            if (ageTextbox.Text != "")
            {
                person.Age = Int32.Parse(ageTextbox.Text);
            }

            people.Add(person);

            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            ageTextbox.Text = "";

            firstNameTextbox.Focus();
        }

        private void addAddressButton_Click(object sender, EventArgs e)
        {
            PersonAddressForm personAddressForm = new PersonAddressForm();

            personAddressForm.Show();
        }
    }
}
