using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdditionalRegistrationFields.Models
{
    public class DataPart : ContentPart<DataRecord>
    {
        [Required]
        public string Name
        {
            get { return Record.Name; }
            set { Record.Name = value; }
        }
    }
}