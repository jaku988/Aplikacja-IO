﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Aplikacja")]
	public partial class BazaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPotrawa(Potrawa instance);
    partial void UpdatePotrawa(Potrawa instance);
    partial void DeletePotrawa(Potrawa instance);
    partial void Insertuzytkownicy(uzytkownicy instance);
    partial void Updateuzytkownicy(uzytkownicy instance);
    partial void Deleteuzytkownicy(uzytkownicy instance);
    #endregion
		
		public BazaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BazaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Potrawa> Potrawa
		{
			get
			{
				return this.GetTable<Potrawa>();
			}
		}
		
		public System.Data.Linq.Table<uzytkownicy> uzytkownicy
		{
			get
			{
				return this.GetTable<uzytkownicy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Potrawa")]
	public partial class Potrawa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nazwa;
		
		private int _UzytkownikId;
		
		private EntityRef<uzytkownicy> _uzytkownicy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNazwaChanging(string value);
    partial void OnNazwaChanged();
    partial void OnUzytkownikIdChanging(int value);
    partial void OnUzytkownikIdChanged();
    #endregion
		
		public Potrawa()
		{
			this._uzytkownicy = default(EntityRef<uzytkownicy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwa", DbType="NVarChar(100)")]
		public string Nazwa
		{
			get
			{
				return this._Nazwa;
			}
			set
			{
				if ((this._Nazwa != value))
				{
					this.OnNazwaChanging(value);
					this.SendPropertyChanging();
					this._Nazwa = value;
					this.SendPropertyChanged("Nazwa");
					this.OnNazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UzytkownikId", DbType="Int NOT NULL")]
		public int UzytkownikId
		{
			get
			{
				return this._UzytkownikId;
			}
			set
			{
				if ((this._UzytkownikId != value))
				{
					if (this._uzytkownicy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUzytkownikIdChanging(value);
					this.SendPropertyChanging();
					this._UzytkownikId = value;
					this.SendPropertyChanged("UzytkownikId");
					this.OnUzytkownikIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownicy_Potrawa", Storage="_uzytkownicy", ThisKey="UzytkownikId", OtherKey="id_uzytkownika", IsForeignKey=true)]
		public uzytkownicy uzytkownicy
		{
			get
			{
				return this._uzytkownicy.Entity;
			}
			set
			{
				uzytkownicy previousValue = this._uzytkownicy.Entity;
				if (((previousValue != value) 
							|| (this._uzytkownicy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._uzytkownicy.Entity = null;
						previousValue.Potrawa.Remove(this);
					}
					this._uzytkownicy.Entity = value;
					if ((value != null))
					{
						value.Potrawa.Add(this);
						this._UzytkownikId = value.id_uzytkownika;
					}
					else
					{
						this._UzytkownikId = default(int);
					}
					this.SendPropertyChanged("uzytkownicy");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.uzytkownicy")]
	public partial class uzytkownicy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_uzytkownika;
		
		private string _imie;
		
		private string _nazwisko;
		
		private System.DateTime _data_urodzenia;
		
		private string _login;
		
		private string _haslo;
		
		private char _plec;
		
		private string _email;
		
		private EntitySet<Potrawa> _Potrawa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_uzytkownikaChanging(int value);
    partial void Onid_uzytkownikaChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void Ondata_urodzeniaChanging(System.DateTime value);
    partial void Ondata_urodzeniaChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnhasloChanging(string value);
    partial void OnhasloChanged();
    partial void OnplecChanging(char value);
    partial void OnplecChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public uzytkownicy()
		{
			this._Potrawa = new EntitySet<Potrawa>(new Action<Potrawa>(this.attach_Potrawa), new Action<Potrawa>(this.detach_Potrawa));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_uzytkownika", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_uzytkownika
		{
			get
			{
				return this._id_uzytkownika;
			}
			set
			{
				if ((this._id_uzytkownika != value))
				{
					this.Onid_uzytkownikaChanging(value);
					this.SendPropertyChanging();
					this._id_uzytkownika = value;
					this.SendPropertyChanged("id_uzytkownika");
					this.Onid_uzytkownikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_urodzenia", DbType="Date NOT NULL")]
		public System.DateTime data_urodzenia
		{
			get
			{
				return this._data_urodzenia;
			}
			set
			{
				if ((this._data_urodzenia != value))
				{
					this.Ondata_urodzeniaChanging(value);
					this.SendPropertyChanging();
					this._data_urodzenia = value;
					this.SendPropertyChanged("data_urodzenia");
					this.Ondata_urodzeniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haslo", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string haslo
		{
			get
			{
				return this._haslo;
			}
			set
			{
				if ((this._haslo != value))
				{
					this.OnhasloChanging(value);
					this.SendPropertyChanging();
					this._haslo = value;
					this.SendPropertyChanged("haslo");
					this.OnhasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plec", DbType="Char(1) NOT NULL")]
		public char plec
		{
			get
			{
				return this._plec;
			}
			set
			{
				if ((this._plec != value))
				{
					this.OnplecChanging(value);
					this.SendPropertyChanging();
					this._plec = value;
					this.SendPropertyChanged("plec");
					this.OnplecChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownicy_Potrawa", Storage="_Potrawa", ThisKey="id_uzytkownika", OtherKey="UzytkownikId")]
		public EntitySet<Potrawa> Potrawa
		{
			get
			{
				return this._Potrawa;
			}
			set
			{
				this._Potrawa.Assign(value);
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
		
		private void attach_Potrawa(Potrawa entity)
		{
			this.SendPropertyChanging();
			entity.uzytkownicy = this;
		}
		
		private void detach_Potrawa(Potrawa entity)
		{
			this.SendPropertyChanging();
			entity.uzytkownicy = null;
		}
	}
}
#pragma warning restore 1591