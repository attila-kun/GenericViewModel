using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericViewModel.Web.Models.Home
{    
    public abstract class GenericModel
    {
        public string Name { get; set; }
        public object SubModel { get { return GetSubModel(); } }
        protected abstract object GetSubModel();
    }

    public class GenericModel<TSubModel> : GenericModel
    {
        /// <summary>
        /// This needs to have the same name as the base class' SubModel property (otherwise model instantiation at post wouldn't work).
        /// </summary>
        public TSubModel SubModel { get; set; }

        protected override object GetSubModel()
        {
            return (object)SubModel;
        }
    }

    public class SubModel1
    {
        public int Age { get; set; }
    }

    public class SubModel2
    {
        public bool IsVisible { get; set; }
    }
}