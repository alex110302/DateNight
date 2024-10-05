using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class MoviePage : ContentPage
{
    public MoviePage()
    {
        InitializeComponent();
        Title = "Total Cost Of Movie";
    }
    
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.DateCalc.MovieCost = txtMovie.Text;
    }
}