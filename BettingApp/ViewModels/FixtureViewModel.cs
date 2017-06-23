using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BettingApp.ViewModels
{
    public class FixtureViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name too long", MinimumLength = 1)]
        public string HomeTeam { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Name too long", MinimumLength = 1)]
        public string AwayTeam { get; set; }
    }
}