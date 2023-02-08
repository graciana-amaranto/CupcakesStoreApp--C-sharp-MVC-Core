using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupcakes.Models
{
    public enum CupcakeType
    {
        Birthday,
        Turquoise,
        Chocolate,
        Strawberry
    }
}
