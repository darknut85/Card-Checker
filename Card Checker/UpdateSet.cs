using Domain;
using Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace Card_Checker
{
    public partial class UpdateSet : Form
    {
        private readonly Form1 form;
        private readonly ISetService setService;
        private Set set;
        public UpdateSet(Form1 form, ISetService setService, Set set)
        {
            InitializeComponent();
            this.form = form;
            this.setService = setService;
            this.set = set;
            NameOfSet.Text = set.Name;
        }

        private void UpdateSet_Load(object sender, EventArgs e) { }

        private void UpdateNameOfSet_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            bool checkDate = DateTime.TryParse(UpdateRelease.Text, out dateTime);
            if (UpdateText.Text.Length > 0 && checkDate)
            {
                set.Name = UpdateText.Text.ToString();
                set.ReleaseDate = dateTime;
                setService.Update(set);
                setService.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("The set has one or more empty fields");
            }
        }

        private void CancelNewName_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSet_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }
    }
}