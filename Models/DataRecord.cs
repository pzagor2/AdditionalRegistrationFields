using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdditionalRegistrationFields.Models
{
    public class DataRecord : ContentPartRecord
    {
        public virtual string Name { get; set; }
    }
}