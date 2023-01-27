using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Card_Checker
{
    public partial class Form1 : Form
    {
        private readonly ICardService cardService;
        private readonly ISetService setService;

        public Form1(ICardService cardService, ISetService setService)
        {
            InitializeComponent();
            this.cardService = cardService;
            this.setService = setService;

            Sets.DataSource = setService.Get();

            Sets.DisplayMember = nameof(Set.Name);
            Sets.ValueMember = nameof(Set.Id);
            Sets.SelectedValue = 1;

            UpdateCardList();

            TotalInSet.DisplayMember = nameof(Card.Name);
            TotalInSet.ValueMember = nameof(Card.Id);
            TotalInSet.SelectedValue = 1;

            Sets.SelectedIndex = 0;
            TotalInSet.SelectedIndex = 0;

            UpdateCardLabels();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Sets_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCardList();
            UpdateCardLabels();
        }

        private void CardsOfSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCardLabels();
        }

        private void AddSet_Click(object sender, EventArgs e)
        {
            AddSet addSet = new AddSet(this, setService);
            Enabled = false;
            addSet.StartPosition = FormStartPosition.CenterParent;
            addSet.ShowDialog();
            Sets.DataSource = setService.Get();
            UpdateCardList();
        }

        private void DeleteSet_Click(object sender, EventArgs e)
        {
            if (Sets.SelectedIndex > -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this set?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Set set = (Set)Sets.Items[Sets.SelectedIndex];

                    List<Card> cards = cardService.Get().Where(x => x.SetId == set.Id).ToList();
                    foreach (Card item in cards)
                    {
                        cardService.Delete(item.Id);
                    }

                    bool success = setService.Delete(set.Id);

                    if (success)
                    {
                        MessageBox.Show($"{set.Name} Is deleted");
                    }
                    else
                    {
                        MessageBox.Show($"{set.Name} Is not deleted");
                    }

                    setService.SaveChanges();
                    UpdateCardLabels();

                    Sets.DataSource = setService.Get();
                }
            }
        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            AddCard addCard = new AddCard(this, cardService, setService, Sets.SelectedIndex);
            Enabled = false;
            addCard.StartPosition = FormStartPosition.CenterParent;
            addCard.ShowDialog();
            UpdateCardList();
        }

        private void DeleteCard_Click(object sender, EventArgs e)
        {
            if (TotalInSet.SelectedIndex > -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this card?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Card card = (Card)TotalInSet.Items[TotalInSet.SelectedIndex];

                    bool success = cardService.Delete(card.Id);

                    if (success)
                    {
                        MessageBox.Show($"{card.Name} Is deleted");
                    }
                    else
                    {
                        MessageBox.Show($"{card.Name} Is not deleted");
                    }

                    cardService.SaveChanges();
                    UpdateCardLabels();

                    UpdateCardList();
                }
            }
        }

        private void SearchSet_TextChanged(object sender, EventArgs e)
        {
            Sets.DataSource = setService.Search(SearchSet.Text);
        }

        private void SearchCard_TextChanged(object sender, EventArgs e)
        {
            Set set = (Set)Sets.Items[Sets.SelectedIndex];
            TotalInSet.DataSource = cardService.Search(SearchCard.Text).Where(x => x.SetId == set.Id).ToList();
            UpdateCardLabels();
        }

        private void UpdateCard_Click(object sender, EventArgs e)
        {
            Card card = (Card)TotalInSet.Items[TotalInSet.SelectedIndex];
            UpdateCard updateCard = new UpdateCard(this, cardService, setService, card, Sets.SelectedIndex);
            Enabled = false;
            updateCard.StartPosition = FormStartPosition.CenterParent;
            updateCard.ShowDialog();
            UpdateCardList();
        }

        private void UpdateSet_Click(object sender, EventArgs e)
        {
            Set set = (Set)Sets.Items[Sets.SelectedIndex];
            UpdateSet updateSet = new UpdateSet(this, setService, set);
            Enabled = false;
            updateSet.StartPosition = FormStartPosition.CenterParent;
            updateSet.ShowDialog();
            Sets.DataSource = setService.Get();
            UpdateCardList();
        }

        private void UpdateCardLabels()
        {
            if (TotalInSet.SelectedIndex != -1 && TotalInSet.Items.Count > 0)
            {
                Card card = (Card)TotalInSet.Items[TotalInSet.SelectedIndex];
                Set set = setService.Get(card.SetId);

                NameLabel.Text = card.Name;
                SetLabel.Text = set.Name;
                NumberLabel.Text = card.Number.ToString();
                HasCardLabel.Text = card.Owned.ToString();
                ReleaseDateLabel.Text = set.ReleaseDate.Year.ToString();
                InSetLabel.Text = cardService.Get().Where(x => x.SetId == set.Id).Count().ToString();
                OwnedOfTotal.Text = cardService.Get().Where(x => (x.SetId == set.Id) && (x.Owned == true)).Count().ToString();
                CheckOwned.Checked = card.Owned;
            }
            else
            {
                NameLabel.Text = "N/A";
                NumberLabel.Text = "N/A";
                SetLabel.Text = "N/A";
                HasCardLabel.Text = "False";
                ReleaseDateLabel.Text = "N/A";
            }
        }

        private void UpdateCardList()
        {
            Set set = (Set)Sets.Items[Sets.SelectedIndex];

            TotalInSet.DataSource = cardService.Get().Where(x => x.SetId == set.Id).ToList();

            cardService.SaveChanges();
            setService.SaveChanges();

            UpdateListView(set);
        }

        private void CheckOwned_CheckedChanged(object sender, EventArgs e)
        {
            Card card = (Card)TotalInSet.Items[TotalInSet.SelectedIndex];
            card.Owned = CheckOwned.Checked;
            cardService.Update(card);
            cardService.SaveChanges();
            UpdateCardLabels();
            Set set = (Set)Sets.Items[Sets.SelectedIndex];
            UpdateListView(set);
        }

        private void TotalInSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(ConsoleKey.Enter))
            {
                CheckOwned.Checked = !CheckOwned.Checked;
                Card card = (Card)TotalInSet.Items[TotalInSet.SelectedIndex];
                card.Owned = CheckOwned.Checked;
                cardService.Update(card);
                cardService.SaveChanges();
                UpdateCardLabels();
                Set set = (Set)Sets.Items[Sets.SelectedIndex];
                UpdateListView(set);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView(Set set)
        {
            listView1.Clear();
            List<Card> cards = cardService.Get().Where(x => x.SetId == set.Id).ToList(); ;
            foreach (Card card in cards)
            {
                ListViewItem lvi = new ListViewItem();

                if (card.Owned == true)
                {
                    lvi.BackColor = Color.Yellow;
                }
                else
                {
                    lvi.BackColor = Color.White;
                }
                lvi.Text = card.Number.ToString() + ", ";

                listView1.Items.Add(lvi);
            }
        }
    }
}