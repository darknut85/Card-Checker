using Business;
using Business.Services;
using Domain;
using Domain.Interfaces;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HtmlCardReader
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceCollection = new ServiceCollection()
                .AddDbContext<DataContext>(x => { x.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); }, ServiceLifetime.Transient)
                .AddScoped<ISetService, SetService>()
                .AddScoped<ICardService, CardService>()
                .AddScoped<Read>()
                .BuildServiceProvider();
            var read = serviceCollection.GetRequiredService<Read>();

            read.Scrape();
        }
    }
    class Read
    {
        private readonly ICardService cardService;
        private readonly ISetService setService;

        public Read(ICardService cardService, ISetService setService)
        {
            this.cardService = cardService;
            this.setService = setService;
        }

        public void Scrape()
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load(@"wepages\Photon Shockwave Yu-Gi-Oh! Wiki Fandom.htm");

            Set set = new Set();
            List<Card> cards = new List<Card>();
            Card card = new Card();

            foreach (HtmlNode item in doc.DocumentNode.SelectNodes("//div [@id='mw-content-text']/div/aside/section/div [@data-source= 'na_release_date']/div"))
            {
                set.ReleaseDate = Convert.ToDateTime(item.InnerHtml);
            }


            foreach (HtmlNode item in doc.DocumentNode.SelectNodes("//h1 [@id='firstHeading']/i"))
            {
                set.Name = item.InnerHtml;
                set.OwnedCards = 0;
                set.TotalCards = 0;
            }

            bool setAdded = setService.Add(set);
            setService.SaveChanges();
            if (setAdded)
            {
                Console.WriteLine("set was added");
            }

            int setId = setService.Get().Where(x => x.Name == set.Name).FirstOrDefault().Id;

            int count = 0;
                                                                                                                                                                                                                    //table [@id='Top_table']  [@class='wikitable sortable card-list jquery-tablesorter']
            foreach (HtmlNode item in doc.DocumentNode.SelectNodes("//div [@id='mw-content-text']/div [@class='mw-parser-output']/div/div [@class='tabber wds-tabber']/div [@class='wds-tab__content wds-is-current']/table[@id='Top_table']/tbody"))
            {
                count++;
                if (count > 1)
                {
                    break;
                }
                int innercount = 0;
                foreach (var i in item.SelectNodes("//td/a"))
                {
                    if (i.InnerHtml.Contains("-EN"))
                    {
                        card = new Card();
                        Console.WriteLine(i.InnerHtml);
                        string a = i.InnerHtml;
                        innercount++;
                        card.Number = Convert.ToInt32(a.Substring(a.Length - 3));
                        Console.WriteLine(card.Number);
                    }
                    else if (innercount == 1)
                    {
                        Console.WriteLine(i.InnerHtml);
                        innercount = 0;
                        card.Name = i.InnerHtml;
                        card.SetId = setId;
                        card.Owned = false;
                        bool added = cardService.Add(card);
                        cardService.SaveChanges();
                        if (!added)
                        {
                            Card update = cardService.Search(card.Name).FirstOrDefault();
                            if (update != null)
                            {
                                update.Number = card.Number;
                                cardService.Update(update);
                            }
                        }
                        cardService.SaveChanges();
                    }
                }
            }
        }
    }
}
