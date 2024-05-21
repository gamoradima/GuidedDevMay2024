namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c69316b-9796-45ec-b6d0-b6af9394a57c");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c6b7df2c-601c-4180-8af0-32732a87ced1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,219,64,16,189,11,250,31,6,209,131,4,102,73,174,117,27,136,93,183,4,66,91,34,57,151,210,195,122,53,86,182,172,118,197,206,202,169,91,252,223,187,31,118,98,217,9,237,156,164,217,55,111,222,27,158,230,29,82,207,5,66,141,214,114,50,107,199,230,70,175,101,59,88,238,164,209,217,159,12,124,13,36,117,11,213,150,28,118,211,163,206,241,84,215,25,253,218,155,69,182,208,78,58,137,244,31,16,182,216,160,118,123,228,247,216,221,198,214,173,244,2,52,218,162,18,15,216,241,47,94,61,124,128,124,73,246,14,185,114,219,188,252,17,103,250,97,165,164,0,161,56,17,164,167,23,88,224,29,204,56,225,11,47,145,36,57,63,162,51,27,47,87,54,8,27,35,27,248,170,43,190,241,38,10,179,250,137,194,1,161,110,208,78,32,209,205,112,237,29,69,210,107,219,18,96,249,196,246,204,27,106,229,21,176,39,174,3,9,150,211,17,42,145,130,141,86,188,229,34,53,202,132,31,99,27,20,178,227,10,122,43,69,56,79,26,98,159,209,213,219,30,155,185,81,67,167,239,185,26,240,253,30,122,85,132,19,126,11,248,101,245,49,63,217,45,215,80,36,174,43,184,188,56,84,57,194,140,61,133,66,118,67,115,174,5,42,108,188,8,103,7,156,102,103,40,114,54,228,192,135,144,120,139,53,118,189,226,46,136,214,248,8,183,70,112,37,127,243,149,194,42,226,138,189,149,37,161,245,41,213,254,236,62,162,236,14,201,12,86,120,144,177,158,101,242,230,108,77,168,231,148,164,116,229,19,200,207,54,16,139,135,185,161,218,152,153,108,211,95,94,178,218,236,21,148,255,52,225,197,167,6,251,100,108,199,93,113,98,206,175,189,100,23,179,183,167,103,14,229,30,172,121,140,222,23,191,4,246,193,221,97,252,4,189,203,198,95,187,108,151,253,5,212,7,162,154,205,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d8eb02cc-53f2-2888-e566-639848125ae8"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("c6b7df2c-601c-4180-8af0-32732a87ced1"),
				CreatedInSchemaUId = new Guid("8c69316b-9796-45ec-b6d0-b6af9394a57c"),
				ModifiedInSchemaUId = new Guid("8c69316b-9796-45ec-b6d0-b6af9394a57c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c69316b-9796-45ec-b6d0-b6af9394a57c"));
		}

		#endregion

	}

	#endregion

}

