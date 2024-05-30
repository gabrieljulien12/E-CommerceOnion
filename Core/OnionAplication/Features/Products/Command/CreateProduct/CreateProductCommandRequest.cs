﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest
    {
        public string Tittle { get; set; }
        public string Desciription { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        public IList<int> CatagoryIds { get; set; }
    }
}
