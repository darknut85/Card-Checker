using Domain;
using Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace Card_Checker
{
    public partial class UpdateCard : Form
    {
        private readonly Form1 form;
        private readonly ICardService cardService;
        private readonly Card card;

        public UpdateCard(Form1 form, ICardService cardService, ISetService setService, Card card, int setIndex)
        {
            InitializeComponent();
            this.form = form;
            this.cardService = cardService;
            this.card = card;

            OldNameOfCard.Text = card.Name;
            UpdateNameOfCard.Text = card.Name;
            UpdateSetOfCard.DataSource = setService.Get();
            UpdateSetOfCard.DisplayMember = nameof(Set.Name);
            UpdateSetOfCard.ValueMember = nameof(Set.Id);
            UpdateSetOfCard.SelectedValue = 1;
            UpdateNumberOfCard.Text = card.Number.ToString();

            UpdateOwnedOfCard.Checked = card.Owned;
            UpdateSetOfCard.SelectedIndex = setIndex;
        }

        private void UpdateCard_Load(object sender, EventArgs e) { }

        private void UpdateAllOfCard_Click(object sender, EventArgs e)
        {
            int number;
            bool check = int.TryParse(UpdateNumberOfCard.Text, out number);
            int good = Convert.ToInt32(UpdateSetOfCard.SelectedValue);
            if (check && number >= 0 && UpdateNameOfCard.TextLength > 0)
            {
                card.Name = UpdateNameOfCard.Text;
                card.SetId = good;
                card.Number = number;
                card.Owned = UpdateOwnedOfCard.Checked;
                cardService.Update(card);
                cardService.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("One or more fields are empty.");
            }
        }

        private void CancelSetUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
