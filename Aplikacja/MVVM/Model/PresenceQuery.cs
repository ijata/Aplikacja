using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class PresenceQuery
    {
        public string presenceSeven { get; set; }
        public string presenceOne { get; set; }

        public PresenceQuery GetPresence7()
        {
            String presence7 = string.Empty;

            using (var query = new Connection())
            {

                var presence = query.Presence
                    .Where(c => c.Date >= DateTimeOffset.UtcNow && c.Date <= DateTimeOffset.UtcNow.AddDays(7))
                    .Where(c => c.ChildId == 1)
                    .ToList();

                presence7 = String.Join(Environment.NewLine,
                        presence.Select(presence =>
                        $" {presence.Date} \n" +
                        $" {presence.Description} \n"));


            }

            return new PresenceQuery
            {
                presenceSeven = presence7
            };
        }

        public PresenceQuery GetPresence1()
        {
            String presence1 = string.Empty;

            using (var query = new Connection())
            {

                var presence = query.Presence
                            .Where(c => c.Date.Date == DateTime.UtcNow.Date)
                            .Where(c => c.ChildId == 1 && c.IsAccepted == 1)
                            .ToList();

                presence1 = String.Join(Environment.NewLine,
                        presence.Select(presence =>
                        //$"{presence.Children.childernFirstName} {presence.Children.childernLastName} \n" +
                        $"{presence.Date.Date} : {presence.Description}"));


            }

            return new PresenceQuery
            {
                presenceOne = presence1
            };
        }

    }
}
