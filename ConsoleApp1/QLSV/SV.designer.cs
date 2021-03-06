﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSV
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SV")]
	public partial class SVDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSinhVien(SinhVien instance);
    partial void UpdateSinhVien(SinhVien instance);
    partial void DeleteSinhVien(SinhVien instance);
    #endregion
		
		public SVDataContext() : 
				base(global::QLSV.Properties.Settings.Default.SVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SVDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SVDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SVDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SVDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SinhVien> SinhViens
		{
			get
			{
				return this.GetTable<SinhVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SinhVien")]
	public partial class SinhVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSV;
		
		private string _HoTenSV;
		
		private string _NgaySinh;
		
		private string _Diem;
		
		private string _MaMH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnHoTenSVChanging(string value);
    partial void OnHoTenSVChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnDiemChanging(string value);
    partial void OnDiemChanged();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    #endregion
		
		public SinhVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTenSV", DbType="NVarChar(50)")]
		public string HoTenSV
		{
			get
			{
				return this._HoTenSV;
			}
			set
			{
				if ((this._HoTenSV != value))
				{
					this.OnHoTenSVChanging(value);
					this.SendPropertyChanging();
					this._HoTenSV = value;
					this.SendPropertyChanged("HoTenSV");
					this.OnHoTenSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(10)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diem", DbType="NVarChar(10)")]
		public string Diem
		{
			get
			{
				return this._Diem;
			}
			set
			{
				if ((this._Diem != value))
				{
					this.OnDiemChanging(value);
					this.SendPropertyChanging();
					this._Diem = value;
					this.SendPropertyChanged("Diem");
					this.OnDiemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="NVarChar(10)")]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
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
}
#pragma warning restore 1591
