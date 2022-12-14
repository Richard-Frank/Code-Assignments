#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RF.VehicleTracker.PL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="rfrankdb")]
	public partial class VehiclesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblColor(tblColor instance);
    partial void UpdatetblColor(tblColor instance);
    partial void DeletetblColor(tblColor instance);
    partial void InserttblMake(tblMake instance);
    partial void UpdatetblMake(tblMake instance);
    partial void DeletetblMake(tblMake instance);
    partial void InserttblModel(tblModel instance);
    partial void UpdatetblModel(tblModel instance);
    partial void DeletetblModel(tblModel instance);
    partial void InserttblVehicle(tblVehicle instance);
    partial void UpdatetblVehicle(tblVehicle instance);
    partial void DeletetblVehicle(tblVehicle instance);
    #endregion
		
		public VehiclesDataContext() : 
				base(global::RF.VehicleTracker.PL.Properties.Settings.Default.rfrankdbConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public VehiclesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehiclesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehiclesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VehiclesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblColor> tblColors
		{
			get
			{
				return this.GetTable<tblColor>();
			}
		}
		
		public System.Data.Linq.Table<tblMake> tblMakes
		{
			get
			{
				return this.GetTable<tblMake>();
			}
		}
		
		public System.Data.Linq.Table<tblModel> tblModels
		{
			get
			{
				return this.GetTable<tblModel>();
			}
		}
		
		public System.Data.Linq.Table<tblVehicle> tblVehicles
		{
			get
			{
				return this.GetTable<tblVehicle>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spGetVehicles")]
		public ISingleResult<spGetVehiclesResult> spGetVehicles()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<spGetVehiclesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spGetVehiclesByColor")]
		public ISingleResult<spGetVehiclesByColorResult> spGetVehiclesByColor([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(32)")] string colorname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), colorname);
			return ((ISingleResult<spGetVehiclesByColorResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblColor")]
	public partial class tblColor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblColor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMake")]
	public partial class tblMake : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblMake()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblModel")]
	public partial class tblModel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblModel()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblVehicle")]
	public partial class tblVehicle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _ColorId;
		
		private System.Guid _MakeId;
		
		private System.Guid _ModelId;
		
		private string _VIN;
		
		private int _Year;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnColorIdChanging(System.Guid value);
    partial void OnColorIdChanged();
    partial void OnMakeIdChanging(System.Guid value);
    partial void OnMakeIdChanged();
    partial void OnModelIdChanging(System.Guid value);
    partial void OnModelIdChanged();
    partial void OnVINChanging(string value);
    partial void OnVINChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    #endregion
		
		public tblVehicle()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ColorId
		{
			get
			{
				return this._ColorId;
			}
			set
			{
				if ((this._ColorId != value))
				{
					this.OnColorIdChanging(value);
					this.SendPropertyChanging();
					this._ColorId = value;
					this.SendPropertyChanged("ColorId");
					this.OnColorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid MakeId
		{
			get
			{
				return this._MakeId;
			}
			set
			{
				if ((this._MakeId != value))
				{
					this.OnMakeIdChanging(value);
					this.SendPropertyChanging();
					this._MakeId = value;
					this.SendPropertyChanged("MakeId");
					this.OnMakeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ModelId
		{
			get
			{
				return this._ModelId;
			}
			set
			{
				if ((this._ModelId != value))
				{
					this.OnModelIdChanging(value);
					this.SendPropertyChanging();
					this._ModelId = value;
					this.SendPropertyChanged("ModelId");
					this.OnModelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VIN", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string VIN
		{
			get
			{
				return this._VIN;
			}
			set
			{
				if ((this._VIN != value))
				{
					this.OnVINChanging(value);
					this.SendPropertyChanging();
					this._VIN = value;
					this.SendPropertyChanged("VIN");
					this.OnVINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class spGetVehiclesResult
	{
		
		private System.Guid _Id;
		
		private System.Guid _ColorId;
		
		private System.Guid _MakeId;
		
		private System.Guid _ModelId;
		
		private string _ColorName;
		
		private string _MakeName;
		
		private string _ModelName;
		
		private string _VIN;
		
		private int _Year;
		
		public spGetVehiclesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ColorId
		{
			get
			{
				return this._ColorId;
			}
			set
			{
				if ((this._ColorId != value))
				{
					this._ColorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid MakeId
		{
			get
			{
				return this._MakeId;
			}
			set
			{
				if ((this._MakeId != value))
				{
					this._MakeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ModelId
		{
			get
			{
				return this._ModelId;
			}
			set
			{
				if ((this._ModelId != value))
				{
					this._ModelId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string ColorName
		{
			get
			{
				return this._ColorName;
			}
			set
			{
				if ((this._ColorName != value))
				{
					this._ColorName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string MakeName
		{
			get
			{
				return this._MakeName;
			}
			set
			{
				if ((this._MakeName != value))
				{
					this._MakeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string ModelName
		{
			get
			{
				return this._ModelName;
			}
			set
			{
				if ((this._ModelName != value))
				{
					this._ModelName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VIN", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string VIN
		{
			get
			{
				return this._VIN;
			}
			set
			{
				if ((this._VIN != value))
				{
					this._VIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
	}
	
	public partial class spGetVehiclesByColorResult
	{
		
		private System.Guid _Id;
		
		private System.Guid _ColorId;
		
		private System.Guid _MakeId;
		
		private System.Guid _ModelId;
		
		private string _ColorName;
		
		private string _MakeName;
		
		private string _ModelName;
		
		private string _VIN;
		
		private int _Year;
		
		public spGetVehiclesByColorResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ColorId
		{
			get
			{
				return this._ColorId;
			}
			set
			{
				if ((this._ColorId != value))
				{
					this._ColorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid MakeId
		{
			get
			{
				return this._MakeId;
			}
			set
			{
				if ((this._MakeId != value))
				{
					this._MakeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ModelId
		{
			get
			{
				return this._ModelId;
			}
			set
			{
				if ((this._ModelId != value))
				{
					this._ModelId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string ColorName
		{
			get
			{
				return this._ColorName;
			}
			set
			{
				if ((this._ColorName != value))
				{
					this._ColorName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string MakeName
		{
			get
			{
				return this._MakeName;
			}
			set
			{
				if ((this._MakeName != value))
				{
					this._MakeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelName", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string ModelName
		{
			get
			{
				return this._ModelName;
			}
			set
			{
				if ((this._ModelName != value))
				{
					this._ModelName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VIN", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string VIN
		{
			get
			{
				return this._VIN;
			}
			set
			{
				if ((this._VIN != value))
				{
					this._VIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
