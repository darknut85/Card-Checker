using Domain;
using Domain.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Card_Checker
{
    public partial class AddCard : Form
    {
        private readonly Form1 form;
        private readonly ICardService cardService;
        private readonly ISetService setService;

        public AddCard(Form1 form, ICardService cardService, ISetService setService, int setEntry)
        {
            InitializeComponent();
            this.form = form;
            this.cardService = cardService;
            this.setService = setService;

            CBSets.DataSource = setService.Get();
            CBSets.DisplayMember = nameof(Set.Name);
            CBSets.ValueMember = nameof(Set.Id);
            CBSets.SelectedValue = 1;
            CBSets.SelectedIndex = setEntry;
        }

        private void AddCard_Load(object sender, EventArgs e) 
        {
            string text = CBSets.Text;
            var set = setService.Get().Where(x => x.Name == text).FirstOrDefault();
            var a = cardService.Get().Where(x => x.SetId == set.Id).ToList();
            if (a.Count > 0)
            {
                TBNumber.Text = Convert.ToInt32(a.Max(x => x.Number) + 1).ToString();
            }
        }

        private void AddThisCard_Click(object sender, EventArgs e)
        {
            int number;
            bool check = int.TryParse(TBNumber.Text, out number);
            int good = Convert.ToInt32(CBSets.SelectedValue);

            if (check && number >= 0 && CardNameText.TextLength > 0)
            {
                Card card = new Card()
                {
                    Name = CardNameText.Text,
                    SetId = good,
                    Number = number,
                    Owned = OwnedCheckbox.Checked
                };
                cardService.Add(card);
                cardService.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("One or more fields are empty.");
            }
        }

        private void CancelThisCard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }
    }
}
