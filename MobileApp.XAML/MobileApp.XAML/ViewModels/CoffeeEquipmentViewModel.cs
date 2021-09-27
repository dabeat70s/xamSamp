using MobileApp.XAML.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.XAML.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public string Coff { get; set; }
        //public Coffee Coffee { get; set; }
     

        public ObservableRangeCollection<Coffee> Coffees { get; set; }
        public ObservableRangeCollection<Grouping<string, Coffee>> CoffeeGroups { get; }

        public AsyncCommand RefreshCommand { get; }

        public CoffeeEquipmentViewModel()
        {

            Title = "Coffee Equipment";

            Coffees = new ObservableRangeCollection<Coffee>();
            CoffeeGroups = new ObservableRangeCollection<Grouping<string, Coffee>>();
            Coff = "MusicLEJ-Coffee";

            //var image = "https://www.yesplz.coffee/app/uploads/2020/11/emptybag-min.png";
            string image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR87nlJAqIRoddX0ei145zyBLF3Eo4m0P0yGK8LDjILlGzVTFcBNg&s";
            Coffees.Add(new Coffee { Roaster = "Music Plz", Name = "Bounty Killer", Image = image });
            Coffees.Add(new Coffee { Roaster = "Music Plz", Name = "Beenie Man", Image = image });
            Coffees.Add(new Coffee { Roaster = "Music Plz", Name = "Ras Shilo", Image = image });
            Coffees.Add(new Coffee { Roaster = "Video Bottle", Name = "Sizzla", Image = image });
            Coffees.Add(new Coffee { Roaster = "Video Bottle", Name = "Shensea", Image = image });
            Coffees.Add(new Coffee { Roaster = "Video Plz", Name = "Nicki Manaj", Image = image });
            Coffees.Add(new Coffee { Roaster = "Video Plz", Name = "Aaliyah", Image = image });
            Coffees.Add(new Coffee { Roaster = "Video Plz", Name = "Junior Kelly", Image = image });
            Coffees.Add(new Coffee { Roaster = "LEJ Bottle", Name = "Freddy McGreggor", Image = image });
            Coffees.Add(new Coffee { Roaster = "LEJ Bottle", Name = "Toni Braxton", Image = image });


            CoffeeGroups.Add(new Grouping<string, Coffee>("Video Bottle", Coffees.Where(c => c.Roaster == "Video Bottle")));
            CoffeeGroups.Add(new Grouping<string, Coffee>("Music Plz", Coffees.Where(c => c.Roaster == "Music Plz")));
            CoffeeGroups.Add(new Grouping<string, Coffee>("Video Plz", Coffees.Where(c => c.Roaster == "Video Plz")));
            CoffeeGroups.Add(new Grouping<string, Coffee>("LEJ Bottle", Coffees.Where(c => c.Roaster == "LEJ Bottle")));

            RefreshCommand = new AsyncCommand(Refresh);
        }

        private async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            IsBusy = false;
        }
    }
}
