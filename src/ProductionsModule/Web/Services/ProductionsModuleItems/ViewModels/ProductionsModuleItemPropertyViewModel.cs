using System;
using System.Linq;
using System.Runtime.Serialization;

namespace ProductionsModule.Web.Services.ProductionsModuleItems.ViewModels
{
    /// <summary>
    /// A view model for the productionsModuleItem properties.
    /// This view model is used by the services.
    /// </summary>
    [DataContract]
    public class ProductionsModuleItemPropertyViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name
        {
            get;
            set;
        }
    }
}
