using Domain;
using Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace Card_Checker
{
    public partial class AddSet : Form
    {
        private readonly Form1 form;
        private readonly ISetService setService;

        public AddSet(Form1 form, ISetService setService)
        {
            InitializeComponent();
            this.form = form;
            this.setService = setService;
        }

        private void AddSet_Load(object sender, EventArgs e) { }

        private void AddThisSet_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            bool checkDate = DateTime.TryParse(SetRelease.Text, out dateTime);
            if (checkDate)
            {
                Set set = new Set()
                { Name = SetName.Text, OwnedCards = 0, TotalCards = 0, ReleaseDate = dateTime };
                setService.Add(set);
                setService.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("The total amount of cards in a set must be a positive number.");
            }
        }

        private void CancelThisSet_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSet_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
