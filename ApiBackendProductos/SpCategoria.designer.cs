﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppBackendProductos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SeriesPeliculasDB")]
	public partial class SpCategoriaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public SpCategoriaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SeriesPeliculasDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SpCategoriaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SpCategoriaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SpCategoriaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SpCategoriaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LIST_CATEGORY")]
		public ISingleResult<SP_LIST_CATEGORYResult> SP_LIST_CATEGORY()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LIST_CATEGORYResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_LIST_CATEGORYResult
	{
		
		private decimal _ID_CATEGORY;
		
		private string _NAME_CATEGORY;
		
		private System.Nullable<byte> _ACTIVE;
		
		public SP_LIST_CATEGORYResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CATEGORY", DbType="Decimal(18,0) NOT NULL")]
		public decimal ID_CATEGORY
		{
			get
			{
				return this._ID_CATEGORY;
			}
			set
			{
				if ((this._ID_CATEGORY != value))
				{
					this._ID_CATEGORY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME_CATEGORY", DbType="NChar(50)")]
		public string NAME_CATEGORY
		{
			get
			{
				return this._NAME_CATEGORY;
			}
			set
			{
				if ((this._NAME_CATEGORY != value))
				{
					this._NAME_CATEGORY = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ACTIVE", DbType="TinyInt")]
		public System.Nullable<byte> ACTIVE
		{
			get
			{
				return this._ACTIVE;
			}
			set
			{
				if ((this._ACTIVE != value))
				{
					this._ACTIVE = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
