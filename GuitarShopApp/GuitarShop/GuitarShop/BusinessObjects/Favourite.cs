﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Infrastructure.Domain;
using Xamarin.Forms;

namespace GuitarShop.BusinessObjects
{
    public class Favourite : IAggregateRoot
    {
        public int ProductNumber { get; set; }
    }
}
