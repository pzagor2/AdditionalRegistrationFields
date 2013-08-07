using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using AdditionalRegistrationFields.Models;

namespace AdditionalRegistrationFields {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table DataRecord
			SchemaBuilder.CreateTable("DataRecord", table => table
				.ContentPartRecord()
				.Column("Name", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(
                typeof(DataPart).Name, cfg => cfg.Attachable());



            return 1;
        }
    }
}