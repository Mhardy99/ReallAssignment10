using Microsoft.AspNetCore.Mvc;
using ReallAssignment10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReallAssignment10.Components
{
    public class BowlerTypeViewComponent :ViewComponent
    {
        private BowlingLeagueContext context;

        public BowlerTypeViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            //returning the view with teamsand ordering the returned info
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
