using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using ES.Library.DataMapper;

namespace Probityx.Framework.Data
{
	/// <summary>
	/// SINGLE OBJECT CODE GENERATOR FOR Club
	/// </summary>
	/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
	#region Single Class (NON-EDITABLE)
	public partial class Club
	{
		/// <summary>
		/// Private declarations set to default values.
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Declarations
		private int _clubid = -1;
		private string _clubname = "";
		private string _country = "";
		private string _stadium = "";
		private int _yearfounded = -1;
		private object _clublogo = new object();
		private bool _ispopulated=false;

		#endregion

		/// <summary>
		/// Property declarations.
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Properties
		public int ClubId{get{return _clubid;}set{_clubid=value;}}
		public string ClubName{get{return _clubname;}set{_clubname=value;}}
		public string Country{get{return _country;}set{_country=value;}}
		public string Stadium{get{return _stadium;}set{_stadium=value;}}
		public int YearFounded{get{return _yearfounded;}set{_yearfounded=value;}}
		public object ClubLogo{get{return _clublogo;}set{_clublogo=value;}}
		public bool isPopulated{get{return _ispopulated;}}

		#endregion

		/// <summary>
		/// Class constructors.
		/// </summary>
		#region Constructors

		/// <summary>
		/// Create a new instance of Club.
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		public Club()
		{
		}

		/// <summary>
		/// Create a populated instance of Club based on Primary Keys.
		/// </summary>
		/// <param name="p_ClubId">Primary key ClubId/</param>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		public Club(int p_ClubId)
		{
			DataLayer dLayer = new DataLayer(Utils.Connection);
			DbCommand dbc = dLayer.getWrapper("sProc_Club_Read");
			dLayer.AddInParameter(dbc,"@ClubId",DbType.Int32,p_ClubId);
			DataTable dtObjPopulate = dLayer.execute(dbc);

			if(dtObjPopulate!=null)
				BuildObject(dtObjPopulate.Rows[0]);
			else
			{
				_ispopulated=false;

			}
		}
		#endregion

		/// <summary>
		/// Passes data from a datarow to the object.
		/// </summary>
		/// <param name="dr">The datarow that contains the data to use to build the object</param>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Build Object
		public void BuildObject(DataRow dr){
			if(dr["ClubId"]!=DBNull.Value)_clubid=(int)dr["ClubId"];
			if(dr["ClubName"]!=DBNull.Value)_clubname=(string)dr["ClubName"];
			if(dr["Country"]!=DBNull.Value)_country=(string)dr["Country"];
			if(dr["Stadium"]!=DBNull.Value)_stadium=(string)dr["Stadium"];
			if(dr["YearFounded"]!=DBNull.Value)_yearfounded=(int)dr["YearFounded"];
			if(dr["ClubLogo"]!=DBNull.Value)_clublogo=(object)dr["ClubLogo"];
			_ispopulated=true;

		}
		#endregion

		/// <summary>
		/// Factory method for creating populated Club.
		/// </summary>
		/// <param name="dr">The datarow that contains the data to use to build the object</param>
		/// <returns>Populated Club object.</returns>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Create
		public static Club Create(DataRow dr)
		{
			Club obj = new Club();
			obj.BuildObject(dr);
			return obj;
		}
		#endregion

		/// <summary>
		/// Inserts or updates the values into the underlying datasource.
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Save
		public void Save()
		{
			DataLayer dLayer = new DataLayer(Utils.Connection);
			Save(dLayer);
		}

		public void Save(DataLayer dLayer)
		{
			try
			{
				doValidation();

				DbCommand dbc = dLayer.getWrapper("sProc_Club_Write");
				dLayer.AddInParameter(dbc,"@ClubId",DbType.Int32,this.ClubId);
				dLayer.AddInParameter(dbc,"@ClubName",DbType.VarNumeric,this.ClubName);
				if(this.Country=="")
					dLayer.AddInParameter(dbc,"@Country",DbType.VarNumeric,null);
				else
					dLayer.AddInParameter(dbc,"@Country",DbType.VarNumeric,this.Country);
				if(this.Stadium=="")
					dLayer.AddInParameter(dbc,"@Stadium",DbType.VarNumeric,null);
				else
					dLayer.AddInParameter(dbc,"@Stadium",DbType.VarNumeric,this.Stadium);
				if(this.YearFounded==-1)
					dLayer.AddInParameter(dbc,"@YearFounded",DbType.Int32,null);
				else
					dLayer.AddInParameter(dbc,"@YearFounded",DbType.Int32,this.YearFounded);
				if(this.ClubLogo==new object())
					dLayer.AddInParameter(dbc,"@ClubLogo",DbType.Object,null);
				else
					dLayer.AddInParameter(dbc,"@ClubLogo",DbType.Object,this.ClubLogo);
				DataTable dt = dLayer.execute(dbc);
				if(dt != null)
				{
						_clubid = int.Parse(dt.Rows[0][0].ToString());
						_ispopulated=true;
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		#endregion

		/// <summary>
		/// Validates that in information does not fail insertion based on the underlying
		/// datasource table design. (Nullable, Length)
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Do Validation
		public void doValidation()
		{
			try
			{
				if(_clubname==null||_clubname=="")throw new Exception("Field 'ClubName' is mandatory (No value Supplied)");
				if(_clubname.Length>100)throw new Exception("Field 'ClubName' exceeded maximum character limitation(100)");
				if(_country.Length>100)throw new Exception("Field 'Country' exceeded maximum character limitation(100)");
				if(_stadium.Length>100)throw new Exception("Field 'Stadium' exceeded maximum character limitation(100)");
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		#endregion

		/// <summary>
		/// Deletes the record for the underlying datasource based on primary keys.
		/// </summary>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Delete
		public void Delete()
		{
				DataLayer dLayer = new DataLayer(Utils.Connection);
			Delete(dLayer);
		}

		public void Delete(DataLayer dLayer)
		{
			try
			{
				DbCommand dbc = dLayer.getWrapper("sProc_Club_Delete");
				dLayer.AddInParameter(dbc,"@ClubId",DbType.Int32,this.ClubId);
				dLayer.execute(dbc);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		#endregion
}
	#endregion

	/// <summary>
	/// COLLECTION OBJECT CODE GENERATOR FOR THE Club object.
	/// </summary>
	/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
	#region Collection Class
	public partial class ClubCollection:CollectionBase
	{
		#region Collection Base Code
		public void Add(Club GenericObject)
		{
			InnerList.Add(GenericObject);
		}

		public void Remove(int index)
		{
			InnerList.RemoveAt(index);
		}

		public Club Item(int index)
		{
			return (Club)InnerList[index];
		}
		#endregion

		#region Get All - Based on Active Field/Flag
		#endregion

		/// <summary>
		/// Gets all the records from the underlying datasource returning a collection.
		/// </summary>
		/// <returns>A collection of Club objects.</returns>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Get Everything
		public static ClubCollection getEverything()
		{
			ClubCollection retCol = new ClubCollection();
			DataLayer dLayer = new DataLayer(Utils.Connection);
			DbCommand dbc = dLayer.getWrapper("sProc_Club_ReadEverything");
			retCol.buildObjects(dLayer.execute(dbc));

			return retCol;
		}
		/// <summary>
		/// Gets all the records from the underlying datasource returning a datatable.
		/// </summary>
		/// <returns>A DataTable of Club.</returns>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		public static DataTable getEverythingDT()
		{
			DataLayer dLayer = new DataLayer(Utils.Connection);
			DbCommand dbc = dLayer.getWrapper("sProc_Club_ReadEverything");

			return dLayer.execute(dbc);
		}
		/// <summary>
		/// Gets all the records from the underlying datasource returning a datatable.
		/// DEVELOPER MUST IMPLEMENT STORED PROC MANUALLY
		/// </summary>
		/// <returns>A DataTable of Club.</returns>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		public static DataTable getEverythingCustomDT()
		{
			DataLayer dLayer = new DataLayer(Utils.Connection);
			DbCommand dbc = dLayer.getWrapper("sProc_Club_ReadEverything_Custom");

			return dLayer.execute(dbc);
		}
		#endregion

		/// <summary>
		/// Builds the collection of Club objects one for each row in the underlying 
		/// datasource table.
		/// </summary>
		/// <param name="dtObjPopulate">Table to build the objects from.</param>
		/// <remarks>Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)</remarks>
		#region Build Objects
		public void buildObjects(DataTable dtObjPopulate)
		{
			if (dtObjPopulate != null)
				foreach (DataRow dr in dtObjPopulate.Rows)
					this.Add(Club.Create(dr));
		}

		#endregion
	}
	#endregion
}
