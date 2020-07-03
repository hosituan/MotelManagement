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

namespace test
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="nhatro")]
	public partial class DataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertlichsu(lichsu instance);
    partial void Updatelichsu(lichsu instance);
    partial void Deletelichsu(lichsu instance);
    partial void Insertngph(ngph instance);
    partial void Updatengph(ngph instance);
    partial void Deletengph(ngph instance);
    partial void Insertnguoi(nguoi instance);
    partial void Updatenguoi(nguoi instance);
    partial void Deletenguoi(nguoi instance);
    partial void Insertphong(phong instance);
    partial void Updatephong(phong instance);
    partial void Deletephong(phong instance);
    partial void Inserttienno(tienno instance);
    partial void Updatetienno(tienno instance);
    partial void Deletetienno(tienno instance);
    partial void Insertdiennuoc(diennuoc instance);
    partial void Updatediennuoc(diennuoc instance);
    partial void Deletediennuoc(diennuoc instance);
    partial void Insertgiaodich(giaodich instance);
    partial void Updategiaodich(giaodich instance);
    partial void Deletegiaodich(giaodich instance);
    partial void Insertuser1(user1 instance);
    partial void Updateuser1(user1 instance);
    partial void Deleteuser1(user1 instance);
    #endregion
		
		public DataDataContext() : 
				base(global::test.Properties.Settings.Default.nhatroConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<lichsu> lichsus
		{
			get
			{
				return this.GetTable<lichsu>();
			}
		}
		
		public System.Data.Linq.Table<ngph> ngphs
		{
			get
			{
				return this.GetTable<ngph>();
			}
		}
		
		public System.Data.Linq.Table<nguoi> nguois
		{
			get
			{
				return this.GetTable<nguoi>();
			}
		}
		
		public System.Data.Linq.Table<phong> phongs
		{
			get
			{
				return this.GetTable<phong>();
			}
		}
		
		public System.Data.Linq.Table<tienno> tiennos
		{
			get
			{
				return this.GetTable<tienno>();
			}
		}
		
		public System.Data.Linq.Table<diennuoc> diennuocs
		{
			get
			{
				return this.GetTable<diennuoc>();
			}
		}
		
		public System.Data.Linq.Table<giaodich> giaodiches
		{
			get
			{
				return this.GetTable<giaodich>();
			}
		}
		
		public System.Data.Linq.Table<user1> user1s
		{
			get
			{
				return this.GetTable<user1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lichsu")]
	public partial class lichsu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _thoigian;
		
		private string _kwh;
		
		private string _nuoc;
		
		private string _tien;
		
		private string _ngaythem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnthoigianChanging(string value);
    partial void OnthoigianChanged();
    partial void OnkwhChanging(string value);
    partial void OnkwhChanged();
    partial void OnnuocChanging(string value);
    partial void OnnuocChanged();
    partial void OntienChanging(string value);
    partial void OntienChanged();
    partial void OnngaythemChanging(string value);
    partial void OnngaythemChanged();
    #endregion
		
		public lichsu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thoigian", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string thoigian
		{
			get
			{
				return this._thoigian;
			}
			set
			{
				if ((this._thoigian != value))
				{
					this.OnthoigianChanging(value);
					this.SendPropertyChanging();
					this._thoigian = value;
					this.SendPropertyChanged("thoigian");
					this.OnthoigianChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kwh", DbType="NVarChar(45)")]
		public string kwh
		{
			get
			{
				return this._kwh;
			}
			set
			{
				if ((this._kwh != value))
				{
					this.OnkwhChanging(value);
					this.SendPropertyChanging();
					this._kwh = value;
					this.SendPropertyChanged("kwh");
					this.OnkwhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nuoc", DbType="NVarChar(45)")]
		public string nuoc
		{
			get
			{
				return this._nuoc;
			}
			set
			{
				if ((this._nuoc != value))
				{
					this.OnnuocChanging(value);
					this.SendPropertyChanging();
					this._nuoc = value;
					this.SendPropertyChanged("nuoc");
					this.OnnuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tien", DbType="NVarChar(45)")]
		public string tien
		{
			get
			{
				return this._tien;
			}
			set
			{
				if ((this._tien != value))
				{
					this.OntienChanging(value);
					this.SendPropertyChanging();
					this._tien = value;
					this.SendPropertyChanged("tien");
					this.OntienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaythem", DbType="NVarChar(45)")]
		public string ngaythem
		{
			get
			{
				return this._ngaythem;
			}
			set
			{
				if ((this._ngaythem != value))
				{
					this.OnngaythemChanging(value);
					this.SendPropertyChanging();
					this._ngaythem = value;
					this.SendPropertyChanged("ngaythem");
					this.OnngaythemChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ngph")]
	public partial class ngph : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idphong;
		
		private string _hotennguoi1;
		
		private string _hotennguoi2;
		
		private string _ngayvao;
		
		private string _ghichu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidphongChanging(int value);
    partial void OnidphongChanged();
    partial void Onhotennguoi1Changing(string value);
    partial void Onhotennguoi1Changed();
    partial void Onhotennguoi2Changing(string value);
    partial void Onhotennguoi2Changed();
    partial void OnngayvaoChanging(string value);
    partial void OnngayvaoChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public ngph()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idphong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idphong
		{
			get
			{
				return this._idphong;
			}
			set
			{
				if ((this._idphong != value))
				{
					this.OnidphongChanging(value);
					this.SendPropertyChanging();
					this._idphong = value;
					this.SendPropertyChanged("idphong");
					this.OnidphongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotennguoi1", DbType="NVarChar(45)")]
		public string hotennguoi1
		{
			get
			{
				return this._hotennguoi1;
			}
			set
			{
				if ((this._hotennguoi1 != value))
				{
					this.Onhotennguoi1Changing(value);
					this.SendPropertyChanging();
					this._hotennguoi1 = value;
					this.SendPropertyChanged("hotennguoi1");
					this.Onhotennguoi1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotennguoi2", DbType="NVarChar(45)")]
		public string hotennguoi2
		{
			get
			{
				return this._hotennguoi2;
			}
			set
			{
				if ((this._hotennguoi2 != value))
				{
					this.Onhotennguoi2Changing(value);
					this.SendPropertyChanging();
					this._hotennguoi2 = value;
					this.SendPropertyChanged("hotennguoi2");
					this.Onhotennguoi2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayvao", DbType="NVarChar(45)")]
		public string ngayvao
		{
			get
			{
				return this._ngayvao;
			}
			set
			{
				if ((this._ngayvao != value))
				{
					this.OnngayvaoChanging(value);
					this.SendPropertyChanging();
					this._ngayvao = value;
					this.SendPropertyChanged("ngayvao");
					this.OnngayvaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="NVarChar(45)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.nguoi")]
	public partial class nguoi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idnguoi;
		
		private string _hoten;
		
		private string _cmnd;
		
		private string _diachi;
		
		private string _quequan;
		
		private string _tuoi;
		
		private string _sdt;
		
		private string _tennguoithan;
		
		private string _sdtnguoithan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidnguoiChanging(int value);
    partial void OnidnguoiChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OncmndChanging(string value);
    partial void OncmndChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OnquequanChanging(string value);
    partial void OnquequanChanged();
    partial void OntuoiChanging(string value);
    partial void OntuoiChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OntennguoithanChanging(string value);
    partial void OntennguoithanChanged();
    partial void OnsdtnguoithanChanging(string value);
    partial void OnsdtnguoithanChanged();
    #endregion
		
		public nguoi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idnguoi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idnguoi
		{
			get
			{
				return this._idnguoi;
			}
			set
			{
				if ((this._idnguoi != value))
				{
					this.OnidnguoiChanging(value);
					this.SendPropertyChanging();
					this._idnguoi = value;
					this.SendPropertyChanged("idnguoi");
					this.OnidnguoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmnd", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string cmnd
		{
			get
			{
				return this._cmnd;
			}
			set
			{
				if ((this._cmnd != value))
				{
					this.OncmndChanging(value);
					this.SendPropertyChanging();
					this._cmnd = value;
					this.SendPropertyChanged("cmnd");
					this.OncmndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(45)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quequan", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string quequan
		{
			get
			{
				return this._quequan;
			}
			set
			{
				if ((this._quequan != value))
				{
					this.OnquequanChanging(value);
					this.SendPropertyChanging();
					this._quequan = value;
					this.SendPropertyChanged("quequan");
					this.OnquequanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tuoi", DbType="NVarChar(45)")]
		public string tuoi
		{
			get
			{
				return this._tuoi;
			}
			set
			{
				if ((this._tuoi != value))
				{
					this.OntuoiChanging(value);
					this.SendPropertyChanging();
					this._tuoi = value;
					this.SendPropertyChanged("tuoi");
					this.OntuoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tennguoithan", DbType="NVarChar(45)")]
		public string tennguoithan
		{
			get
			{
				return this._tennguoithan;
			}
			set
			{
				if ((this._tennguoithan != value))
				{
					this.OntennguoithanChanging(value);
					this.SendPropertyChanging();
					this._tennguoithan = value;
					this.SendPropertyChanged("tennguoithan");
					this.OntennguoithanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdtnguoithan", DbType="NVarChar(45)")]
		public string sdtnguoithan
		{
			get
			{
				return this._sdtnguoithan;
			}
			set
			{
				if ((this._sdtnguoithan != value))
				{
					this.OnsdtnguoithanChanging(value);
					this.SendPropertyChanging();
					this._sdtnguoithan = value;
					this.SendPropertyChanged("sdtnguoithan");
					this.OnsdtnguoithanChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.phong")]
	public partial class phong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idphong;
		
		private string _gia;
		
		private string _tinhtrang;
		
		private string _ghichu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidphongChanging(int value);
    partial void OnidphongChanged();
    partial void OngiaChanging(string value);
    partial void OngiaChanged();
    partial void OntinhtrangChanging(string value);
    partial void OntinhtrangChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public phong()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idphong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idphong
		{
			get
			{
				return this._idphong;
			}
			set
			{
				if ((this._idphong != value))
				{
					this.OnidphongChanging(value);
					this.SendPropertyChanging();
					this._idphong = value;
					this.SendPropertyChanged("idphong");
					this.OnidphongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tinhtrang", DbType="VarChar(45)")]
		public string tinhtrang
		{
			get
			{
				return this._tinhtrang;
			}
			set
			{
				if ((this._tinhtrang != value))
				{
					this.OntinhtrangChanging(value);
					this.SendPropertyChanging();
					this._tinhtrang = value;
					this.SendPropertyChanged("tinhtrang");
					this.OntinhtrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="VarChar(45)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tienno")]
	public partial class tienno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idphong;
		
		private int _sotienno;
		
		private string _ghichu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidphongChanging(int value);
    partial void OnidphongChanged();
    partial void OnsotiennoChanging(int value);
    partial void OnsotiennoChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public tienno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idphong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idphong
		{
			get
			{
				return this._idphong;
			}
			set
			{
				if ((this._idphong != value))
				{
					this.OnidphongChanging(value);
					this.SendPropertyChanging();
					this._idphong = value;
					this.SendPropertyChanged("idphong");
					this.OnidphongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sotienno", DbType="Int NOT NULL")]
		public int sotienno
		{
			get
			{
				return this._sotienno;
			}
			set
			{
				if ((this._sotienno != value))
				{
					this.OnsotiennoChanging(value);
					this.SendPropertyChanging();
					this._sotienno = value;
					this.SendPropertyChanged("sotienno");
					this.OnsotiennoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="VarChar(100)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.diennuoc")]
	public partial class diennuoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idphong;
		
		private System.Nullable<int> _kwh;
		
		private System.Nullable<int> _nuoc;
		
		private System.Nullable<int> _Tongtien;
		
		private string _ghichu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidphongChanging(int value);
    partial void OnidphongChanged();
    partial void OnkwhChanging(System.Nullable<int> value);
    partial void OnkwhChanged();
    partial void OnnuocChanging(System.Nullable<int> value);
    partial void OnnuocChanged();
    partial void OnTongtienChanging(System.Nullable<int> value);
    partial void OnTongtienChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public diennuoc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idphong", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idphong
		{
			get
			{
				return this._idphong;
			}
			set
			{
				if ((this._idphong != value))
				{
					this.OnidphongChanging(value);
					this.SendPropertyChanging();
					this._idphong = value;
					this.SendPropertyChanged("idphong");
					this.OnidphongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kwh", DbType="Int")]
		public System.Nullable<int> kwh
		{
			get
			{
				return this._kwh;
			}
			set
			{
				if ((this._kwh != value))
				{
					this.OnkwhChanging(value);
					this.SendPropertyChanging();
					this._kwh = value;
					this.SendPropertyChanged("kwh");
					this.OnkwhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nuoc", DbType="Int")]
		public System.Nullable<int> nuoc
		{
			get
			{
				return this._nuoc;
			}
			set
			{
				if ((this._nuoc != value))
				{
					this.OnnuocChanging(value);
					this.SendPropertyChanging();
					this._nuoc = value;
					this.SendPropertyChanged("nuoc");
					this.OnnuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tongtien", DbType="Int")]
		public System.Nullable<int> Tongtien
		{
			get
			{
				return this._Tongtien;
			}
			set
			{
				if ((this._Tongtien != value))
				{
					this.OnTongtienChanging(value);
					this.SendPropertyChanging();
					this._Tongtien = value;
					this.SendPropertyChanged("Tongtien");
					this.OnTongtienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="NVarChar(45)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.giaodich")]
	public partial class giaodich : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idbill;
		
		private int _idphong;
		
		private int _sotien;
		
		private string _ngaythanhtoan;
		
		private string _thoigian;
		
		private string _nguoithanhtoan;
		
		private string _ngaythemvao;
		
		private string _ngaychinhsua;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidbillChanging(int value);
    partial void OnidbillChanged();
    partial void OnidphongChanging(int value);
    partial void OnidphongChanged();
    partial void OnsotienChanging(int value);
    partial void OnsotienChanged();
    partial void OnngaythanhtoanChanging(string value);
    partial void OnngaythanhtoanChanged();
    partial void OnthoigianChanging(string value);
    partial void OnthoigianChanged();
    partial void OnnguoithanhtoanChanging(string value);
    partial void OnnguoithanhtoanChanged();
    partial void OnngaythemvaoChanging(string value);
    partial void OnngaythemvaoChanged();
    partial void OnngaychinhsuaChanging(string value);
    partial void OnngaychinhsuaChanged();
    #endregion
		
		public giaodich()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idbill", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idbill
		{
			get
			{
				return this._idbill;
			}
			set
			{
				if ((this._idbill != value))
				{
					this.OnidbillChanging(value);
					this.SendPropertyChanging();
					this._idbill = value;
					this.SendPropertyChanged("idbill");
					this.OnidbillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idphong", DbType="Int NOT NULL")]
		public int idphong
		{
			get
			{
				return this._idphong;
			}
			set
			{
				if ((this._idphong != value))
				{
					this.OnidphongChanging(value);
					this.SendPropertyChanging();
					this._idphong = value;
					this.SendPropertyChanged("idphong");
					this.OnidphongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sotien", DbType="Int NOT NULL")]
		public int sotien
		{
			get
			{
				return this._sotien;
			}
			set
			{
				if ((this._sotien != value))
				{
					this.OnsotienChanging(value);
					this.SendPropertyChanging();
					this._sotien = value;
					this.SendPropertyChanged("sotien");
					this.OnsotienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaythanhtoan", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string ngaythanhtoan
		{
			get
			{
				return this._ngaythanhtoan;
			}
			set
			{
				if ((this._ngaythanhtoan != value))
				{
					this.OnngaythanhtoanChanging(value);
					this.SendPropertyChanging();
					this._ngaythanhtoan = value;
					this.SendPropertyChanged("ngaythanhtoan");
					this.OnngaythanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thoigian", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string thoigian
		{
			get
			{
				return this._thoigian;
			}
			set
			{
				if ((this._thoigian != value))
				{
					this.OnthoigianChanging(value);
					this.SendPropertyChanging();
					this._thoigian = value;
					this.SendPropertyChanged("thoigian");
					this.OnthoigianChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nguoithanhtoan", DbType="NVarChar(45)")]
		public string nguoithanhtoan
		{
			get
			{
				return this._nguoithanhtoan;
			}
			set
			{
				if ((this._nguoithanhtoan != value))
				{
					this.OnnguoithanhtoanChanging(value);
					this.SendPropertyChanging();
					this._nguoithanhtoan = value;
					this.SendPropertyChanged("nguoithanhtoan");
					this.OnnguoithanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaythemvao", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string ngaythemvao
		{
			get
			{
				return this._ngaythemvao;
			}
			set
			{
				if ((this._ngaythemvao != value))
				{
					this.OnngaythemvaoChanging(value);
					this.SendPropertyChanging();
					this._ngaythemvao = value;
					this.SendPropertyChanged("ngaythemvao");
					this.OnngaythemvaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaychinhsua", DbType="NVarChar(100)")]
		public string ngaychinhsua
		{
			get
			{
				return this._ngaychinhsua;
			}
			set
			{
				if ((this._ngaychinhsua != value))
				{
					this.OnngaychinhsuaChanging(value);
					this.SendPropertyChanging();
					this._ngaychinhsua = value;
					this.SendPropertyChanged("ngaychinhsua");
					this.OnngaychinhsuaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user1")]
	public partial class user1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
		private string _hoten;
		
		private string _pass2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void Onpass2Changing(string value);
    partial void Onpass2Changed();
    #endregion
		
		public user1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(45) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(45)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(45)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass2", DbType="NVarChar(50)")]
		public string pass2
		{
			get
			{
				return this._pass2;
			}
			set
			{
				if ((this._pass2 != value))
				{
					this.Onpass2Changing(value);
					this.SendPropertyChanging();
					this._pass2 = value;
					this.SendPropertyChanged("pass2");
					this.Onpass2Changed();
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
