using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja.MVVM.Model
{
    public class ChildQuery
    {
        public string _test { get; set; }
        public ChildQuery Get()
        {
            String test = string.Empty;

            using (var query = new Connection())
            {

                var activeChildren = query.Childrens
                    .Where(c=> c.isActive == 1)
                    .ToList();

                test = String.Join(Environment.NewLine,
                    activeChildren.Select(child =>
                        $"Name: {child.childernFirstName}, LastName: {child.childernLastName}, IsActive: {child.isActive}"));
            }

            return new ChildQuery
            {
                _test = test
            };
        }
    }
}
