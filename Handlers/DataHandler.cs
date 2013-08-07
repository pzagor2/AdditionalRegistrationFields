using AdditionalRegistrationFields.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdditionalRegistrationFields.Handlers
{
    public class DataHandler : ContentHandler
    {

        public DataHandler(IRepository<DataRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}