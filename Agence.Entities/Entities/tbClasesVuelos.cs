﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Agence.Entities.Entities
{
    public partial class tbClasesVuelos
    {
        public tbClasesVuelos()
        {
            tbBilletesAvion = new HashSet<tbBilletesAvion>();
        }

        public int clasvuel_Id { get; set; }
        public string clasvuel_Nombre { get; set; }

        public virtual ICollection<tbBilletesAvion> tbBilletesAvion { get; set; }
    }
}