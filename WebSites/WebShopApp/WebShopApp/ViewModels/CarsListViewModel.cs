﻿using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
