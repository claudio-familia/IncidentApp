﻿using IncidentApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncidentApp.Models
{
    public class IncidentHistory : EntityBase
    {
        public int IncidentId { get; set; }
        public string Comment { get; set; }

        #region relations

        public Incident Incident { get; set; }

        #endregion
    }
}
