using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;

namespace ViewComponentExample.Components
{
    public class PopularNewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<NewModel> newModels = new List<NewModel>();
            for (int i = 1; i <= 12; i++)
            {
                newModels.Add(new NewModel()
                {
                    Title = string.Format("This is title of article {0}", i),
                    Image = string.Format("../images/{0}.jpg", i)
                });
            }
            return View(newModels);
        }
    }
}
