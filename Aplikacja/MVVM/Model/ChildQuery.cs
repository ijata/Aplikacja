using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class ChildQuery
    {
        public string childData { get; set; }

        public ChildQuery Get()
        {
            String childData = string.Empty;

            using (var query = new Connection())
            {

                var activeChildren = query.Childrens
                    .ToList();

                childData = String.Join(Environment.NewLine,
                    activeChildren.Select(child =>
                        $"Imię: {child.childernFirstName} \n" +
                        $"Nazwisko: {child.childernLastName} \n" +  
                        $"Status: {child.isActive} \n \n"));

               
            }

            return new ChildQuery
            {
                childData = childData
            };
        }
    }

}
