using AdditionalRegistrationFields.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdditionalRegistrationFields.Drivers
{
    public class DataDriver : ContentPartDriver<DataPart>
    {
        protected override DriverResult Display(
            DataPart part, string displayType, dynamic shapeHelper)
        {

            return ContentShape("Parts_Data", () => shapeHelper.Parts_Data(Name: part.Name));
        }

        //GET
        protected override DriverResult Editor(DataPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_Data_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/Data",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(DataPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}