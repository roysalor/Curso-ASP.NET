﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace galeriaImagenes.Models
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class TestClassEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto TestClassEntities usando la cadena de conexión encontrada en la sección 'TestClassEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public TestClassEntities() : base("name=TestClassEntities", "TestClassEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto TestClassEntities.
        /// </summary>
        public TestClassEntities(string connectionString) : base(connectionString, "TestClassEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto TestClassEntities.
        /// </summary>
        public TestClassEntities(EntityConnection connection) : base(connection, "TestClassEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<imagenes> imagenes
        {
            get
            {
                if ((_imagenes == null))
                {
                    _imagenes = base.CreateObjectSet<imagenes>("imagenes");
                }
                return _imagenes;
            }
        }
        private ObjectSet<imagenes> _imagenes;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet imagenes. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToimagenes(imagenes imagenes)
        {
            base.AddObject("imagenes", imagenes);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestClassModel", Name="imagenes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class imagenes : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto imagenes.
        /// </summary>
        /// <param name="id_imagen">Valor inicial de la propiedad id_imagen.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        /// <param name="ruta">Valor inicial de la propiedad ruta.</param>
        /// <param name="tam">Valor inicial de la propiedad tam.</param>
        /// <param name="alto">Valor inicial de la propiedad alto.</param>
        /// <param name="ancho">Valor inicial de la propiedad ancho.</param>
        /// <param name="categoria">Valor inicial de la propiedad categoria.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        /// <param name="palabrasClaves">Valor inicial de la propiedad palabrasClaves.</param>
        public static imagenes Createimagenes(global::System.Int32 id_imagen, global::System.String nombre, global::System.String ruta, global::System.Int32 tam, global::System.Int16 alto, global::System.Int16 ancho, global::System.String categoria, global::System.String descripcion, global::System.String palabrasClaves)
        {
            imagenes imagenes = new imagenes();
            imagenes.id_imagen = id_imagen;
            imagenes.nombre = nombre;
            imagenes.ruta = ruta;
            imagenes.tam = tam;
            imagenes.alto = alto;
            imagenes.ancho = ancho;
            imagenes.categoria = categoria;
            imagenes.descripcion = descripcion;
            imagenes.palabrasClaves = palabrasClaves;
            return imagenes;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_imagen
        {
            get
            {
                return _id_imagen;
            }
            set
            {
                if (_id_imagen != value)
                {
                    Onid_imagenChanging(value);
                    ReportPropertyChanging("id_imagen");
                    _id_imagen = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_imagen");
                    Onid_imagenChanged();
                }
            }
        }
        private global::System.Int32 _id_imagen;
        partial void Onid_imagenChanging(global::System.Int32 value);
        partial void Onid_imagenChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ruta
        {
            get
            {
                return _ruta;
            }
            set
            {
                OnrutaChanging(value);
                ReportPropertyChanging("ruta");
                _ruta = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ruta");
                OnrutaChanged();
            }
        }
        private global::System.String _ruta;
        partial void OnrutaChanging(global::System.String value);
        partial void OnrutaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tam
        {
            get
            {
                return _tam;
            }
            set
            {
                OntamChanging(value);
                ReportPropertyChanging("tam");
                _tam = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tam");
                OntamChanged();
            }
        }
        private global::System.Int32 _tam;
        partial void OntamChanging(global::System.Int32 value);
        partial void OntamChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 alto
        {
            get
            {
                return _alto;
            }
            set
            {
                OnaltoChanging(value);
                ReportPropertyChanging("alto");
                _alto = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("alto");
                OnaltoChanged();
            }
        }
        private global::System.Int16 _alto;
        partial void OnaltoChanging(global::System.Int16 value);
        partial void OnaltoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 ancho
        {
            get
            {
                return _ancho;
            }
            set
            {
                OnanchoChanging(value);
                ReportPropertyChanging("ancho");
                _ancho = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ancho");
                OnanchoChanged();
            }
        }
        private global::System.Int16 _ancho;
        partial void OnanchoChanging(global::System.Int16 value);
        partial void OnanchoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String categoria
        {
            get
            {
                return _categoria;
            }
            set
            {
                OncategoriaChanging(value);
                ReportPropertyChanging("categoria");
                _categoria = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("categoria");
                OncategoriaChanged();
            }
        }
        private global::System.String _categoria;
        partial void OncategoriaChanging(global::System.String value);
        partial void OncategoriaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String palabrasClaves
        {
            get
            {
                return _palabrasClaves;
            }
            set
            {
                OnpalabrasClavesChanging(value);
                ReportPropertyChanging("palabrasClaves");
                _palabrasClaves = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("palabrasClaves");
                OnpalabrasClavesChanged();
            }
        }
        private global::System.String _palabrasClaves;
        partial void OnpalabrasClavesChanging(global::System.String value);
        partial void OnpalabrasClavesChanged();

        #endregion

    
    }

    #endregion

    
}
