using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class MenuQuery
    {
        public string menuSeven { get; set; }
        public string menuOne { get; set; }

        public MenuQuery GetMenu7()
        {
            String menu7 = string.Empty;

            using (var query = new Connection())
            {

                 var menu = query.Menu
                    .Where(c => c.Date >= DateTimeOffset.UtcNow && c.Date <= DateTimeOffset.UtcNow.AddDays(7))
                    .OrderBy(c => c.Date)
                    .ToList();

                menu7 = String.Join(Environment.NewLine,
                    menu.Select(menu =>
                        $"Dzień: {menu.Date} \n" +
                        $"Śniadanie: {menu.Posilek1} \n" +
                        $"II śniadanie: {menu.Posilek2} \n" +
                        $"Zupa: {menu.Posilek3} \n" + 
                        $"Obiad: {menu.Posilek4} \n \n"));


            }

            return new MenuQuery
            {
                menuSeven = menu7
            };
        }

        public MenuQuery GetMenu1()
        {
            String menu1 = string.Empty;

            using (var query = new Connection())
            {

               // var today = DateTimeOffset.Now;

                var menu = query.Menu
                            .Where(c => c.Date.Date == DateTime.UtcNow.Date)
                            .ToList();

                menu1 = String.Join(Environment.NewLine,
                    menu.Select(menu =>
                        $"\n" +
                        $"Śniadanie: {menu.Posilek1} \n \n" +
                        $"II śniadanie: {menu.Posilek2} \n \n" +
                        $"Zupa: {menu.Posilek3} \n \n" +
                        $"Obiad: {menu.Posilek4} \n \n"));


            }

            return new MenuQuery
            {
                menuOne = menu1
            };
        }
    
    }
}
