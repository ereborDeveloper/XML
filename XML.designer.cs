﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xml
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BuyvolovKR")]
	public partial class XMLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    #endregion
		
		public XMLDataContext() : 
				base(global::Xml.Properties.Settings.Default.BuyvolovKRConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public XMLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public XMLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public XMLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public XMLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vacancies> vacancies
		{
			get
			{
				return this.GetTable<vacancies>();
			}
		}
		
		public System.Data.Linq.Table<R2> R2
		{
			get
			{
				return this.GetTable<R2>();
			}
		}
		
		public System.Data.Linq.Table<R1> R1
		{
			get
			{
				return this.GetTable<R1>();
			}
		}
		
		public System.Data.Linq.Table<R> R
		{
			get
			{
				return this.GetTable<R>();
			}
		}
		
		public System.Data.Linq.Table<org> org
		{
			get
			{
				return this.GetTable<org>();
			}
		}
		
		public System.Data.Linq.Table<applicant> applicant
		{
			get
			{
				return this.GetTable<applicant>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vacancies")]
	public partial class vacancies
	{
		
		private string _position;
		
		private System.Nullable<int> _salary;
		
		private System.Nullable<int> _Idvacant;
		
		private System.Nullable<System.DateTime> _dateopen;
		
		private System.Nullable<System.DateTime> _dateclose;
		
		public vacancies()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="NVarChar(30)")]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this._position = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int")]
		public System.Nullable<int> salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this._salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idvacant", DbType="Int")]
		public System.Nullable<int> Idvacant
		{
			get
			{
				return this._Idvacant;
			}
			set
			{
				if ((this._Idvacant != value))
				{
					this._Idvacant = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateopen", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateopen
		{
			get
			{
				return this._dateopen;
			}
			set
			{
				if ((this._dateopen != value))
				{
					this._dateopen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateclose", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateclose
		{
			get
			{
				return this._dateclose;
			}
			set
			{
				if ((this._dateclose != value))
				{
					this._dateclose = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.R2")]
	public partial class R2
	{
		
		private System.Nullable<int> _Idorg;
		
		private System.Nullable<int> _Idapplicant;
		
		public R2()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idorg", DbType="Int")]
		public System.Nullable<int> Idorg
		{
			get
			{
				return this._Idorg;
			}
			set
			{
				if ((this._Idorg != value))
				{
					this._Idorg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idapplicant", DbType="Int")]
		public System.Nullable<int> Idapplicant
		{
			get
			{
				return this._Idapplicant;
			}
			set
			{
				if ((this._Idapplicant != value))
				{
					this._Idapplicant = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.R1")]
	public partial class R1
	{
		
		private System.Nullable<int> _Idvacant;
		
		private System.Nullable<int> _Idorg;
		
		public R1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idvacant", DbType="Int")]
		public System.Nullable<int> Idvacant
		{
			get
			{
				return this._Idvacant;
			}
			set
			{
				if ((this._Idvacant != value))
				{
					this._Idvacant = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idorg", DbType="Int")]
		public System.Nullable<int> Idorg
		{
			get
			{
				return this._Idorg;
			}
			set
			{
				if ((this._Idorg != value))
				{
					this._Idorg = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.R")]
	public partial class R
	{
		
		private System.Nullable<int> _Idvacant;
		
		private System.Nullable<int> _Idapplicant;
		
		public R()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idvacant", DbType="Int")]
		public System.Nullable<int> Idvacant
		{
			get
			{
				return this._Idvacant;
			}
			set
			{
				if ((this._Idvacant != value))
				{
					this._Idvacant = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idapplicant", DbType="Int")]
		public System.Nullable<int> Idapplicant
		{
			get
			{
				return this._Idapplicant;
			}
			set
			{
				if ((this._Idapplicant != value))
				{
					this._Idapplicant = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.org")]
	public partial class org
	{
		
		private System.Nullable<int> _Idorg;
		
		private string _orgname;
		
		public org()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Idorg", DbType="Int")]
		public System.Nullable<int> Idorg
		{
			get
			{
				return this._Idorg;
			}
			set
			{
				if ((this._Idorg != value))
				{
					this._Idorg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orgname", DbType="NVarChar(30)")]
		public string orgname
		{
			get
			{
				return this._orgname;
			}
			set
			{
				if ((this._orgname != value))
				{
					this._orgname = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.applicant")]
	public partial class applicant
	{
		
		private string _FIO;
		
		private string _position;
		
		private System.Nullable<int> _salary;
		
		private System.Nullable<int> _idapplicant;
		
		private string _Info;
		
		private System.Nullable<bool> _hired;
		
		public applicant()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="NVarChar(20)")]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this._FIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="NVarChar(30)")]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this._position = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Int")]
		public System.Nullable<int> salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this._salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idapplicant", DbType="Int")]
		public System.Nullable<int> idapplicant
		{
			get
			{
				return this._idapplicant;
			}
			set
			{
				if ((this._idapplicant != value))
				{
					this._idapplicant = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Info", DbType="NVarChar(100)")]
		public string Info
		{
			get
			{
				return this._Info;
			}
			set
			{
				if ((this._Info != value))
				{
					this._Info = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hired", DbType="Bit")]
		public System.Nullable<bool> hired
		{
			get
			{
				return this._hired;
			}
			set
			{
				if ((this._hired != value))
				{
					this._hired = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
