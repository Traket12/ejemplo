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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjectFenix")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertComentario(Comentario instance);
    partial void UpdateComentario(Comentario instance);
    partial void DeleteComentario(Comentario instance);
    partial void InsertNoticia(Noticia instance);
    partial void UpdateNoticia(Noticia instance);
    partial void DeleteNoticia(Noticia instance);
    partial void InsertSeccion(Seccion instance);
    partial void UpdateSeccion(Seccion instance);
    partial void DeleteSeccion(Seccion instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertValoracion(Valoracion instance);
    partial void UpdateValoracion(Valoracion instance);
    partial void DeleteValoracion(Valoracion instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProjectFenixConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Comentario> Comentario
		{
			get
			{
				return this.GetTable<Comentario>();
			}
		}
		
		public System.Data.Linq.Table<Noticia> Noticia
		{
			get
			{
				return this.GetTable<Noticia>();
			}
		}
		
		public System.Data.Linq.Table<Seccion> Seccion
		{
			get
			{
				return this.GetTable<Seccion>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Valoracion> Valoracion
		{
			get
			{
				return this.GetTable<Valoracion>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comentario")]
	public partial class Comentario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDComentario;
		
		private string _Comentario1;
		
		private long _IDNoticia;
		
		private long _IDUsuario;
		
		private EntityRef<Noticia> _Noticia;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDComentarioChanging(long value);
    partial void OnIDComentarioChanged();
    partial void OnComentario1Changing(string value);
    partial void OnComentario1Changed();
    partial void OnIDNoticiaChanging(long value);
    partial void OnIDNoticiaChanged();
    partial void OnIDUsuarioChanging(long value);
    partial void OnIDUsuarioChanged();
    #endregion
		
		public Comentario()
		{
			this._Noticia = default(EntityRef<Noticia>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDComentario", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDComentario
		{
			get
			{
				return this._IDComentario;
			}
			set
			{
				if ((this._IDComentario != value))
				{
					this.OnIDComentarioChanging(value);
					this.SendPropertyChanging();
					this._IDComentario = value;
					this.SendPropertyChanged("IDComentario");
					this.OnIDComentarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Comentario", Storage="_Comentario1", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Comentario1
		{
			get
			{
				return this._Comentario1;
			}
			set
			{
				if ((this._Comentario1 != value))
				{
					this.OnComentario1Changing(value);
					this.SendPropertyChanging();
					this._Comentario1 = value;
					this.SendPropertyChanged("Comentario1");
					this.OnComentario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNoticia", DbType="BigInt NOT NULL")]
		public long IDNoticia
		{
			get
			{
				return this._IDNoticia;
			}
			set
			{
				if ((this._IDNoticia != value))
				{
					if (this._Noticia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDNoticiaChanging(value);
					this.SendPropertyChanging();
					this._IDNoticia = value;
					this.SendPropertyChanged("IDNoticia");
					this.OnIDNoticiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="BigInt NOT NULL")]
		public long IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IDUsuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Noticia_Comentario", Storage="_Noticia", ThisKey="IDNoticia", OtherKey="IDNoticia", IsForeignKey=true)]
		public Noticia Noticia
		{
			get
			{
				return this._Noticia.Entity;
			}
			set
			{
				Noticia previousValue = this._Noticia.Entity;
				if (((previousValue != value) 
							|| (this._Noticia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Noticia.Entity = null;
						previousValue.Comentario.Remove(this);
					}
					this._Noticia.Entity = value;
					if ((value != null))
					{
						value.Comentario.Add(this);
						this._IDNoticia = value.IDNoticia;
					}
					else
					{
						this._IDNoticia = default(long);
					}
					this.SendPropertyChanged("Noticia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Comentario", Storage="_Usuario", ThisKey="IDUsuario", OtherKey="IDUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Comentario.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Comentario.Add(this);
						this._IDUsuario = value.IDUsuario;
					}
					else
					{
						this._IDUsuario = default(long);
					}
					this.SendPropertyChanged("Usuario");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Noticia")]
	public partial class Noticia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDNoticia;
		
		private System.DateTime _Fecha;
		
		private string _Titulo;
		
		private string _Contenido;
		
		private string _Foto;
		
		private long _IDSeccion;
		
		private long _IDUsuario;
		
		private EntitySet<Comentario> _Comentario;
		
		private EntitySet<Valoracion> _Valoracion;
		
		private EntityRef<Seccion> _Seccion;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNoticiaChanging(long value);
    partial void OnIDNoticiaChanged();
    partial void OnFechaChanging(System.DateTime value);
    partial void OnFechaChanged();
    partial void OnTituloChanging(string value);
    partial void OnTituloChanged();
    partial void OnContenidoChanging(string value);
    partial void OnContenidoChanged();
    partial void OnFotoChanging(string value);
    partial void OnFotoChanged();
    partial void OnIDSeccionChanging(long value);
    partial void OnIDSeccionChanged();
    partial void OnIDUsuarioChanging(long value);
    partial void OnIDUsuarioChanged();
    #endregion
		
		public Noticia()
		{
			this._Comentario = new EntitySet<Comentario>(new Action<Comentario>(this.attach_Comentario), new Action<Comentario>(this.detach_Comentario));
			this._Valoracion = new EntitySet<Valoracion>(new Action<Valoracion>(this.attach_Valoracion), new Action<Valoracion>(this.detach_Valoracion));
			this._Seccion = default(EntityRef<Seccion>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNoticia", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDNoticia
		{
			get
			{
				return this._IDNoticia;
			}
			set
			{
				if ((this._IDNoticia != value))
				{
					this.OnIDNoticiaChanging(value);
					this.SendPropertyChanging();
					this._IDNoticia = value;
					this.SendPropertyChanged("IDNoticia");
					this.OnIDNoticiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this.OnTituloChanging(value);
					this.SendPropertyChanging();
					this._Titulo = value;
					this.SendPropertyChanged("Titulo");
					this.OnTituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contenido", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Contenido
		{
			get
			{
				return this._Contenido;
			}
			set
			{
				if ((this._Contenido != value))
				{
					this.OnContenidoChanging(value);
					this.SendPropertyChanging();
					this._Contenido = value;
					this.SendPropertyChanged("Contenido");
					this.OnContenidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Foto", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Foto
		{
			get
			{
				return this._Foto;
			}
			set
			{
				if ((this._Foto != value))
				{
					this.OnFotoChanging(value);
					this.SendPropertyChanging();
					this._Foto = value;
					this.SendPropertyChanged("Foto");
					this.OnFotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSeccion", DbType="BigInt NOT NULL")]
		public long IDSeccion
		{
			get
			{
				return this._IDSeccion;
			}
			set
			{
				if ((this._IDSeccion != value))
				{
					if (this._Seccion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDSeccionChanging(value);
					this.SendPropertyChanging();
					this._IDSeccion = value;
					this.SendPropertyChanged("IDSeccion");
					this.OnIDSeccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="BigInt NOT NULL")]
		public long IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IDUsuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Noticia_Comentario", Storage="_Comentario", ThisKey="IDNoticia", OtherKey="IDNoticia")]
		public EntitySet<Comentario> Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				this._Comentario.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Noticia_Valoracion", Storage="_Valoracion", ThisKey="IDNoticia", OtherKey="IDNoticia")]
		public EntitySet<Valoracion> Valoracion
		{
			get
			{
				return this._Valoracion;
			}
			set
			{
				this._Valoracion.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Seccion_Noticia", Storage="_Seccion", ThisKey="IDSeccion", OtherKey="IDSeccion", IsForeignKey=true)]
		public Seccion Seccion
		{
			get
			{
				return this._Seccion.Entity;
			}
			set
			{
				Seccion previousValue = this._Seccion.Entity;
				if (((previousValue != value) 
							|| (this._Seccion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Seccion.Entity = null;
						previousValue.Noticia.Remove(this);
					}
					this._Seccion.Entity = value;
					if ((value != null))
					{
						value.Noticia.Add(this);
						this._IDSeccion = value.IDSeccion;
					}
					else
					{
						this._IDSeccion = default(long);
					}
					this.SendPropertyChanged("Seccion");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Noticia", Storage="_Usuario", ThisKey="IDUsuario", OtherKey="IDUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Noticia.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Noticia.Add(this);
						this._IDUsuario = value.IDUsuario;
					}
					else
					{
						this._IDUsuario = default(long);
					}
					this.SendPropertyChanged("Usuario");
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
		
		private void attach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Noticia = this;
		}
		
		private void detach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Noticia = null;
		}
		
		private void attach_Valoracion(Valoracion entity)
		{
			this.SendPropertyChanging();
			entity.Noticia = this;
		}
		
		private void detach_Valoracion(Valoracion entity)
		{
			this.SendPropertyChanging();
			entity.Noticia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Seccion")]
	public partial class Seccion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDSeccion;
		
		private string _Seccion1;
		
		private EntitySet<Noticia> _Noticia;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDSeccionChanging(long value);
    partial void OnIDSeccionChanged();
    partial void OnSeccion1Changing(string value);
    partial void OnSeccion1Changed();
    #endregion
		
		public Seccion()
		{
			this._Noticia = new EntitySet<Noticia>(new Action<Noticia>(this.attach_Noticia), new Action<Noticia>(this.detach_Noticia));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDSeccion", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDSeccion
		{
			get
			{
				return this._IDSeccion;
			}
			set
			{
				if ((this._IDSeccion != value))
				{
					this.OnIDSeccionChanging(value);
					this.SendPropertyChanging();
					this._IDSeccion = value;
					this.SendPropertyChanged("IDSeccion");
					this.OnIDSeccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Seccion", Storage="_Seccion1", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Seccion1
		{
			get
			{
				return this._Seccion1;
			}
			set
			{
				if ((this._Seccion1 != value))
				{
					this.OnSeccion1Changing(value);
					this.SendPropertyChanging();
					this._Seccion1 = value;
					this.SendPropertyChanged("Seccion1");
					this.OnSeccion1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Seccion_Noticia", Storage="_Noticia", ThisKey="IDSeccion", OtherKey="IDSeccion")]
		public EntitySet<Noticia> Noticia
		{
			get
			{
				return this._Noticia;
			}
			set
			{
				this._Noticia.Assign(value);
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
		
		private void attach_Noticia(Noticia entity)
		{
			this.SendPropertyChanging();
			entity.Seccion = this;
		}
		
		private void detach_Noticia(Noticia entity)
		{
			this.SendPropertyChanging();
			entity.Seccion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDUsuario;
		
		private string _Usuario1;
		
		private string _Contraseña;
		
		private string _Correo;
		
		private int _Roll;
		
		private string _Passadmin;
		
		private string _Nombre;
		
		private string _App;
		
		private string _Apm;
		
		private string _Carrera;
		
		private System.Nullable<int> _Celular;
		
		private EntitySet<Comentario> _Comentario;
		
		private EntitySet<Noticia> _Noticia;
		
		private EntitySet<Valoracion> _Valoracion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDUsuarioChanging(long value);
    partial void OnIDUsuarioChanged();
    partial void OnUsuario1Changing(string value);
    partial void OnUsuario1Changed();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnRollChanging(int value);
    partial void OnRollChanged();
    partial void OnPassadminChanging(string value);
    partial void OnPassadminChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnAppChanging(string value);
    partial void OnAppChanged();
    partial void OnApmChanging(string value);
    partial void OnApmChanged();
    partial void OnCarreraChanging(string value);
    partial void OnCarreraChanged();
    partial void OnCelularChanging(System.Nullable<int> value);
    partial void OnCelularChanged();
    #endregion
		
		public Usuario()
		{
			this._Comentario = new EntitySet<Comentario>(new Action<Comentario>(this.attach_Comentario), new Action<Comentario>(this.detach_Comentario));
			this._Noticia = new EntitySet<Noticia>(new Action<Noticia>(this.attach_Noticia), new Action<Noticia>(this.detach_Noticia));
			this._Valoracion = new EntitySet<Valoracion>(new Action<Valoracion>(this.attach_Valoracion), new Action<Valoracion>(this.detach_Valoracion));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IDUsuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Usuario", Storage="_Usuario1", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Usuario1
		{
			get
			{
				return this._Usuario1;
			}
			set
			{
				if ((this._Usuario1 != value))
				{
					this.OnUsuario1Changing(value);
					this.SendPropertyChanging();
					this._Usuario1 = value;
					this.SendPropertyChanged("Usuario1");
					this.OnUsuario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Roll", DbType="Int NOT NULL")]
		public int Roll
		{
			get
			{
				return this._Roll;
			}
			set
			{
				if ((this._Roll != value))
				{
					this.OnRollChanging(value);
					this.SendPropertyChanging();
					this._Roll = value;
					this.SendPropertyChanged("Roll");
					this.OnRollChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passadmin", DbType="NVarChar(30)")]
		public string Passadmin
		{
			get
			{
				return this._Passadmin;
			}
			set
			{
				if ((this._Passadmin != value))
				{
					this.OnPassadminChanging(value);
					this.SendPropertyChanging();
					this._Passadmin = value;
					this.SendPropertyChanged("Passadmin");
					this.OnPassadminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(100)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_App", DbType="NVarChar(100)")]
		public string App
		{
			get
			{
				return this._App;
			}
			set
			{
				if ((this._App != value))
				{
					this.OnAppChanging(value);
					this.SendPropertyChanging();
					this._App = value;
					this.SendPropertyChanged("App");
					this.OnAppChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apm", DbType="NVarChar(100)")]
		public string Apm
		{
			get
			{
				return this._Apm;
			}
			set
			{
				if ((this._Apm != value))
				{
					this.OnApmChanging(value);
					this.SendPropertyChanging();
					this._Apm = value;
					this.SendPropertyChanged("Apm");
					this.OnApmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Carrera", DbType="NVarChar(20)")]
		public string Carrera
		{
			get
			{
				return this._Carrera;
			}
			set
			{
				if ((this._Carrera != value))
				{
					this.OnCarreraChanging(value);
					this.SendPropertyChanging();
					this._Carrera = value;
					this.SendPropertyChanged("Carrera");
					this.OnCarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Celular", DbType="Int")]
		public System.Nullable<int> Celular
		{
			get
			{
				return this._Celular;
			}
			set
			{
				if ((this._Celular != value))
				{
					this.OnCelularChanging(value);
					this.SendPropertyChanging();
					this._Celular = value;
					this.SendPropertyChanged("Celular");
					this.OnCelularChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Comentario", Storage="_Comentario", ThisKey="IDUsuario", OtherKey="IDUsuario")]
		public EntitySet<Comentario> Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				this._Comentario.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Noticia", Storage="_Noticia", ThisKey="IDUsuario", OtherKey="IDUsuario")]
		public EntitySet<Noticia> Noticia
		{
			get
			{
				return this._Noticia;
			}
			set
			{
				this._Noticia.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Valoracion", Storage="_Valoracion", ThisKey="IDUsuario", OtherKey="IDUsuario")]
		public EntitySet<Valoracion> Valoracion
		{
			get
			{
				return this._Valoracion;
			}
			set
			{
				this._Valoracion.Assign(value);
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
		
		private void attach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		
		private void attach_Noticia(Noticia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Noticia(Noticia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		
		private void attach_Valoracion(Valoracion entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Valoracion(Valoracion entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Valoracion")]
	public partial class Valoracion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _IDValor;
		
		private decimal _Valor;
		
		private long _IDNoticia;
		
		private long _IDUsuario;
		
		private EntityRef<Noticia> _Noticia;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDValorChanging(long value);
    partial void OnIDValorChanged();
    partial void OnValorChanging(decimal value);
    partial void OnValorChanged();
    partial void OnIDNoticiaChanging(long value);
    partial void OnIDNoticiaChanged();
    partial void OnIDUsuarioChanging(long value);
    partial void OnIDUsuarioChanged();
    #endregion
		
		public Valoracion()
		{
			this._Noticia = default(EntityRef<Noticia>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDValor", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long IDValor
		{
			get
			{
				return this._IDValor;
			}
			set
			{
				if ((this._IDValor != value))
				{
					this.OnIDValorChanging(value);
					this.SendPropertyChanging();
					this._IDValor = value;
					this.SendPropertyChanged("IDValor");
					this.OnIDValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Valor", DbType="Decimal(2,2) NOT NULL")]
		public decimal Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNoticia", DbType="BigInt NOT NULL")]
		public long IDNoticia
		{
			get
			{
				return this._IDNoticia;
			}
			set
			{
				if ((this._IDNoticia != value))
				{
					if (this._Noticia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDNoticiaChanging(value);
					this.SendPropertyChanging();
					this._IDNoticia = value;
					this.SendPropertyChanged("IDNoticia");
					this.OnIDNoticiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUsuario", DbType="BigInt NOT NULL")]
		public long IDUsuario
		{
			get
			{
				return this._IDUsuario;
			}
			set
			{
				if ((this._IDUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IDUsuario = value;
					this.SendPropertyChanged("IDUsuario");
					this.OnIDUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Noticia_Valoracion", Storage="_Noticia", ThisKey="IDNoticia", OtherKey="IDNoticia", IsForeignKey=true)]
		public Noticia Noticia
		{
			get
			{
				return this._Noticia.Entity;
			}
			set
			{
				Noticia previousValue = this._Noticia.Entity;
				if (((previousValue != value) 
							|| (this._Noticia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Noticia.Entity = null;
						previousValue.Valoracion.Remove(this);
					}
					this._Noticia.Entity = value;
					if ((value != null))
					{
						value.Valoracion.Add(this);
						this._IDNoticia = value.IDNoticia;
					}
					else
					{
						this._IDNoticia = default(long);
					}
					this.SendPropertyChanged("Noticia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Valoracion", Storage="_Usuario", ThisKey="IDUsuario", OtherKey="IDUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Valoracion.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Valoracion.Add(this);
						this._IDUsuario = value.IDUsuario;
					}
					else
					{
						this._IDUsuario = default(long);
					}
					this.SendPropertyChanged("Usuario");
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