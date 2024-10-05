using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class CoffeePage : ContentPage
{
    public CoffeePage()
    {
        InitializeComponent();
        Title = "Total Cost Of Coffee";
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.DateCalc.CoffeeCost = txtCoffee.Text;
    }
}