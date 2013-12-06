using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericViewModel.Web.Models.Home
{
    public class HomeModel
    {
        public GenericModel<SubModel1> SpecificControl1 { get; set; }
        public GenericModel<SubModel2> SpecificControl2 { get; set; }
    }
}
