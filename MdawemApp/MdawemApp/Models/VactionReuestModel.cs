﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MdawemApp.Models
{
    public class VactionReuestModel
    {
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }

        public string _status { get; set; }


        public String Dateofrequest { get; set; }

        public VactionReuestModel()
        {
            _status = "Awaiting";
            Dateofrequest = DateTime.Today.ToString("dd/MM/yyyy");

        }

    }
}
