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

namespace MoteurDeRecherche
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Mydatabase")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLien(Lien instance);
    partial void UpdateLien(Lien instance);
    partial void DeleteLien(Lien instance);
    partial void InsertMot(Mot instance);
    partial void UpdateMot(Mot instance);
    partial void DeleteMot(Mot instance);
    partial void InsertRecherche(Recherche instance);
    partial void UpdateRecherche(Recherche instance);
    partial void DeleteRecherche(Recherche instance);
    partial void InsertHistorique(Historique instance);
    partial void UpdateHistorique(Historique instance);
    partial void DeleteHistorique(Historique instance);
    #endregion
		
		public DCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MydatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Lien> Liens
		{
			get
			{
				return this.GetTable<Lien>();
			}
		}
		
		public System.Data.Linq.Table<Mot> Mots
		{
			get
			{
				return this.GetTable<Mot>();
			}
		}
		
		public System.Data.Linq.Table<Recherche> Recherches
		{
			get
			{
				return this.GetTable<Recherche>();
			}
		}
		
		public System.Data.Linq.Table<Historique> Historiques
		{
			get
			{
				return this.GetTable<Historique>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lien")]
	public partial class Lien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdLien;
		
		private string _URL;
		
		private string _Titre;
		
		private EntitySet<Recherche> _Recherches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdLienChanging(int value);
    partial void OnIdLienChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnTitreChanging(string value);
    partial void OnTitreChanged();
    #endregion
		
		public Lien()
		{
			this._Recherches = new EntitySet<Recherche>(new Action<Recherche>(this.attach_Recherches), new Action<Recherche>(this.detach_Recherches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLien", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdLien
		{
			get
			{
				return this._IdLien;
			}
			set
			{
				if ((this._IdLien != value))
				{
					this.OnIdLienChanging(value);
					this.SendPropertyChanging();
					this._IdLien = value;
					this.SendPropertyChanged("IdLien");
					this.OnIdLienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titre", DbType="VarChar(500)")]
		public string Titre
		{
			get
			{
				return this._Titre;
			}
			set
			{
				if ((this._Titre != value))
				{
					this.OnTitreChanging(value);
					this.SendPropertyChanging();
					this._Titre = value;
					this.SendPropertyChanged("Titre");
					this.OnTitreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lien_Recherche", Storage="_Recherches", ThisKey="IdLien", OtherKey="IdLien")]
		public EntitySet<Recherche> Recherches
		{
			get
			{
				return this._Recherches;
			}
			set
			{
				this._Recherches.Assign(value);
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
		
		private void attach_Recherches(Recherche entity)
		{
			this.SendPropertyChanging();
			entity.Lien = this;
		}
		
		private void detach_Recherches(Recherche entity)
		{
			this.SendPropertyChanging();
			entity.Lien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mot")]
	public partial class Mot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdMot;
		
		private string _Text;
		
		private EntitySet<Recherche> _Recherches;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdMotChanging(int value);
    partial void OnIdMotChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    #endregion
		
		public Mot()
		{
			this._Recherches = new EntitySet<Recherche>(new Action<Recherche>(this.attach_Recherches), new Action<Recherche>(this.detach_Recherches));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMot", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdMot
		{
			get
			{
				return this._IdMot;
			}
			set
			{
				if ((this._IdMot != value))
				{
					this.OnIdMotChanging(value);
					this.SendPropertyChanging();
					this._IdMot = value;
					this.SendPropertyChanged("IdMot");
					this.OnIdMotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(500)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mot_Recherche", Storage="_Recherches", ThisKey="IdMot", OtherKey="IdMot")]
		public EntitySet<Recherche> Recherches
		{
			get
			{
				return this._Recherches;
			}
			set
			{
				this._Recherches.Assign(value);
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
		
		private void attach_Recherches(Recherche entity)
		{
			this.SendPropertyChanging();
			entity.Mot = this;
		}
		
		private void detach_Recherches(Recherche entity)
		{
			this.SendPropertyChanging();
			entity.Mot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recherche")]
	public partial class Recherche : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdSearch;
		
		private System.Nullable<int> _IdMot;
		
		private System.Nullable<int> _IdLien;
		
		private EntitySet<Historique> _Historiques;
		
		private EntityRef<Lien> _Lien;
		
		private EntityRef<Mot> _Mot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSearchChanging(int value);
    partial void OnIdSearchChanged();
    partial void OnIdMotChanging(System.Nullable<int> value);
    partial void OnIdMotChanged();
    partial void OnIdLienChanging(System.Nullable<int> value);
    partial void OnIdLienChanged();
    #endregion
		
		public Recherche()
		{
			this._Historiques = new EntitySet<Historique>(new Action<Historique>(this.attach_Historiques), new Action<Historique>(this.detach_Historiques));
			this._Lien = default(EntityRef<Lien>);
			this._Mot = default(EntityRef<Mot>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSearch", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdSearch
		{
			get
			{
				return this._IdSearch;
			}
			set
			{
				if ((this._IdSearch != value))
				{
					this.OnIdSearchChanging(value);
					this.SendPropertyChanging();
					this._IdSearch = value;
					this.SendPropertyChanged("IdSearch");
					this.OnIdSearchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMot", DbType="Int")]
		public System.Nullable<int> IdMot
		{
			get
			{
				return this._IdMot;
			}
			set
			{
				if ((this._IdMot != value))
				{
					if (this._Mot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdMotChanging(value);
					this.SendPropertyChanging();
					this._IdMot = value;
					this.SendPropertyChanged("IdMot");
					this.OnIdMotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLien", DbType="Int")]
		public System.Nullable<int> IdLien
		{
			get
			{
				return this._IdLien;
			}
			set
			{
				if ((this._IdLien != value))
				{
					if (this._Lien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdLienChanging(value);
					this.SendPropertyChanging();
					this._IdLien = value;
					this.SendPropertyChanged("IdLien");
					this.OnIdLienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recherche_Historique", Storage="_Historiques", ThisKey="IdSearch", OtherKey="IdSearch")]
		public EntitySet<Historique> Historiques
		{
			get
			{
				return this._Historiques;
			}
			set
			{
				this._Historiques.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lien_Recherche", Storage="_Lien", ThisKey="IdLien", OtherKey="IdLien", IsForeignKey=true)]
		public Lien Lien
		{
			get
			{
				return this._Lien.Entity;
			}
			set
			{
				Lien previousValue = this._Lien.Entity;
				if (((previousValue != value) 
							|| (this._Lien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lien.Entity = null;
						previousValue.Recherches.Remove(this);
					}
					this._Lien.Entity = value;
					if ((value != null))
					{
						value.Recherches.Add(this);
						this._IdLien = value.IdLien;
					}
					else
					{
						this._IdLien = default(Nullable<int>);
					}
					this.SendPropertyChanged("Lien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Mot_Recherche", Storage="_Mot", ThisKey="IdMot", OtherKey="IdMot", IsForeignKey=true)]
		public Mot Mot
		{
			get
			{
				return this._Mot.Entity;
			}
			set
			{
				Mot previousValue = this._Mot.Entity;
				if (((previousValue != value) 
							|| (this._Mot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Mot.Entity = null;
						previousValue.Recherches.Remove(this);
					}
					this._Mot.Entity = value;
					if ((value != null))
					{
						value.Recherches.Add(this);
						this._IdMot = value.IdMot;
					}
					else
					{
						this._IdMot = default(Nullable<int>);
					}
					this.SendPropertyChanged("Mot");
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
		
		private void attach_Historiques(Historique entity)
		{
			this.SendPropertyChanging();
			entity.Recherche = this;
		}
		
		private void detach_Historiques(Historique entity)
		{
			this.SendPropertyChanging();
			entity.Recherche = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Historique")]
	public partial class Historique : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdHist;
		
		private System.Nullable<System.DateTime> _Date;
		
		private System.Nullable<int> _IdSearch;
		
		private EntityRef<Recherche> _Recherche;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdHistChanging(int value);
    partial void OnIdHistChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnIdSearchChanging(System.Nullable<int> value);
    partial void OnIdSearchChanged();
    #endregion
		
		public Historique()
		{
			this._Recherche = default(EntityRef<Recherche>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdHist", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdHist
		{
			get
			{
				return this._IdHist;
			}
			set
			{
				if ((this._IdHist != value))
				{
					this.OnIdHistChanging(value);
					this.SendPropertyChanging();
					this._IdHist = value;
					this.SendPropertyChanged("IdHist");
					this.OnIdHistChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSearch", DbType="Int")]
		public System.Nullable<int> IdSearch
		{
			get
			{
				return this._IdSearch;
			}
			set
			{
				if ((this._IdSearch != value))
				{
					if (this._Recherche.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSearchChanging(value);
					this.SendPropertyChanging();
					this._IdSearch = value;
					this.SendPropertyChanged("IdSearch");
					this.OnIdSearchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recherche_Historique", Storage="_Recherche", ThisKey="IdSearch", OtherKey="IdSearch", IsForeignKey=true)]
		public Recherche Recherche
		{
			get
			{
				return this._Recherche.Entity;
			}
			set
			{
				Recherche previousValue = this._Recherche.Entity;
				if (((previousValue != value) 
							|| (this._Recherche.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Recherche.Entity = null;
						previousValue.Historiques.Remove(this);
					}
					this._Recherche.Entity = value;
					if ((value != null))
					{
						value.Historiques.Add(this);
						this._IdSearch = value.IdSearch;
					}
					else
					{
						this._IdSearch = default(Nullable<int>);
					}
					this.SendPropertyChanged("Recherche");
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
