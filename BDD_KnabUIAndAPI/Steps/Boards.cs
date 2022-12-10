using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace BDD_KnabUIAndAPI.Steps
{
    public class Boards
    {
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public object idOrganization { get; set; }
        public object idEnterprise { get; set; }
        public object limits { get; set; }
    }

} 
  