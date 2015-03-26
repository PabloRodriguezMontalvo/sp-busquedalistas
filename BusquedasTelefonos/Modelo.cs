//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;



public partial class ModeloDataContext : Microsoft.SharePoint.Linq.DataContext {
	
	#region Extensibility Method Definitions
	partial void OnCreated();
	#endregion
	
	public ModeloDataContext(string requestUrl) : 
			base(requestUrl) {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Contactos")]
	public Microsoft.SharePoint.Linq.EntityList<ContactosContact> Contactos {
		get {
			return this.GetList<ContactosContact>("Contactos");
		}
	}
	
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Documents")]
	public Microsoft.SharePoint.Linq.EntityList<Document> Documents {
		get {
			return this.GetList<Document>("Documents");
		}
	}
	
	/// <summary>
	/// This library contains administrator-approved form templates that were activated to this site collection.
	/// </summary>
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Form Templates")]
	public Microsoft.SharePoint.Linq.EntityList<Item> FormTemplates {
		get {
			return this.GetList<Item>("Form Templates");
		}
	}
	
	/// <summary>
	/// Listado de los distintos modelos de telefono
	/// </summary>
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Lista telefonos")]
	public Microsoft.SharePoint.Linq.EntityList<ListaTelefonosItem> ListaTelefonos {
		get {
			return this.GetList<ListaTelefonosItem>("Lista telefonos");
		}
	}
	
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Notificaciones")]
	public Microsoft.SharePoint.Linq.EntityList<Announcement> Notificaciones {
		get {
			return this.GetList<Announcement>("Notificaciones");
		}
	}
	
	/// <summary>
	/// Use this library to store files which are included on pages within this site, such as images on Wiki pages.
	/// </summary>
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Site Assets")]
	public Microsoft.SharePoint.Linq.EntityList<Document> SiteAssets {
		get {
			return this.GetList<Document>("Site Assets");
		}
	}
	
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Site Pages")]
	public Microsoft.SharePoint.Linq.EntityList<WikiPage> SitePages {
		get {
			return this.GetList<WikiPage>("Site Pages");
		}
	}
	
	/// <summary>
	/// Use the style library to store style sheets, such as CSS or XSL files. The style sheets in this gallery can be used by this site or any of its subsites.
	/// </summary>
	[Microsoft.SharePoint.Linq.ListAttribute(Name="Style Library")]
	public Microsoft.SharePoint.Linq.EntityList<Document> StyleLibrary {
		get {
			return this.GetList<Document>("Style Library");
		}
	}
}

/// <summary>
/// Create a new list item.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01")]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Contact))]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Document))]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(ListaTelefonosItem))]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Announcement))]
public partial class Item : Microsoft.SharePoint.Linq.ITrackEntityState, Microsoft.SharePoint.Linq.ITrackOriginalValues, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
	
	private System.Nullable<int> _id;
	
	private System.Nullable<int> _version;
	
	private string _path;
	
	private Microsoft.SharePoint.Linq.EntityState _entityState;
	
	private System.Collections.Generic.IDictionary<string, object> _originalValues;
	
	private string _title;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion

	Microsoft.SharePoint.Linq.EntityState Microsoft.SharePoint.Linq.ITrackEntityState.EntityState {
		get {
			return this._entityState;
		}
		set {
			if ((value != this._entityState)) {
				this._entityState = value;
			}
		}
	}

	System.Collections.Generic.IDictionary<string, object> Microsoft.SharePoint.Linq.ITrackOriginalValues.OriginalValues {
		get {
			if ((null == this._originalValues)) {
				this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
			}
			return this._originalValues;
		}
	}
	
	public Item() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ID", Storage="_id", ReadOnly=true, FieldType="Counter")]
	public System.Nullable<int> Id {
		get {
			return this._id;
		}
		set {
			if ((value != this._id)) {
				this.OnPropertyChanging("Id", this._id);
				this._id = value;
				this.OnPropertyChanged("Id");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="owshiddenversion", Storage="_version", ReadOnly=true, FieldType="Integer")]
	public System.Nullable<int> Version {
		get {
			return this._version;
		}
		set {
			if ((value != this._version)) {
				this.OnPropertyChanging("Version", this._version);
				this._version = value;
				this.OnPropertyChanged("Version");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileDirRef", Storage="_path", ReadOnly=true, FieldType="Lookup", IsLookupValue=true)]
	public string Path {
		get {
			return this._path;
		}
		set {
			if ((value != this._path)) {
				this.OnPropertyChanging("Path", this._path);
				this._path = value;
				this.OnPropertyChanged("Path");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Title", Storage="_title", Required=true, FieldType="Text")]
	public virtual string Title {
		get {
			return this._title;
		}
		set {
			if ((value != this._title)) {
				this.OnPropertyChanging("Title", this._title);
				this._title = value;
				this.OnPropertyChanged("Title");
			}
		}
	}
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	protected virtual void OnPropertyChanged(string propertyName) {
		if ((null != this.PropertyChanged)) {
			this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	protected virtual void OnPropertyChanging(string propertyName, object value) {
		if ((null == this._originalValues)) {
			this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
		}
		if ((false == this._originalValues.ContainsKey(propertyName))) {
			this._originalValues.Add(propertyName, value);
		}
		if ((null != this.PropertyChanging)) {
			this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
		}
	}
}

/// <summary>
/// Store information about a business or personal contact.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Contact", Id="0x0106")]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(ContactosContact))]
public partial class Contact : Item {
	
	private string _lastName;
	
	private string _lastName0;
	
	private string _firstName;
	
	private string _fullName;
	
	protected string _eMail;
	
	private string _company;
	
	private string _jobTitle;
	
	private string _businessPhone;
	
	private string _homePhone;
	
	private string _mobileNumber;
	
	private string _faxNumber;
	
	private string _address;
	
	private string _city;
	
	private string _stateProvince;
	
	private string _zIPPostalCode;
	
	private string _countryRegion;
	
	private string _webPage;
	
	private string _comments;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public Contact() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="LinkTitle", Storage="_lastName", ReadOnly=true, FieldType="Computed")]
	public string LastName {
		get {
			return this._lastName;
		}
		set {
			if ((value != this._lastName)) {
				this.OnPropertyChanging("LastName", this._lastName);
				this._lastName = value;
				this.OnPropertyChanged("LastName");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="LinkTitleNoMenu", Storage="_lastName0", ReadOnly=true, FieldType="Computed")]
	public string LastName0 {
		get {
			return this._lastName0;
		}
		set {
			if ((value != this._lastName0)) {
				this.OnPropertyChanging("LastName0", this._lastName0);
				this._lastName0 = value;
				this.OnPropertyChanged("LastName0");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FirstName", Storage="_firstName", FieldType="Text")]
	public string FirstName {
		get {
			return this._firstName;
		}
		set {
			if ((value != this._firstName)) {
				this.OnPropertyChanging("FirstName", this._firstName);
				this._firstName = value;
				this.OnPropertyChanged("FirstName");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FullName", Storage="_fullName", FieldType="Text")]
	public string FullName {
		get {
			return this._fullName;
		}
		set {
			if ((value != this._fullName)) {
				this.OnPropertyChanging("FullName", this._fullName);
				this._fullName = value;
				this.OnPropertyChanged("FullName");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="EMail", Storage="_eMail", FieldType="Text")]
	public virtual string EMail {
		get {
			return this._eMail;
		}
		set {
			if ((value != this._eMail)) {
				this.OnPropertyChanging("EMail", this._eMail);
				this._eMail = value;
				this.OnPropertyChanged("EMail");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Company", Storage="_company", FieldType="Text")]
	public string Company {
		get {
			return this._company;
		}
		set {
			if ((value != this._company)) {
				this.OnPropertyChanging("Company", this._company);
				this._company = value;
				this.OnPropertyChanged("Company");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="JobTitle", Storage="_jobTitle", FieldType="Text")]
	public string JobTitle {
		get {
			return this._jobTitle;
		}
		set {
			if ((value != this._jobTitle)) {
				this.OnPropertyChanging("JobTitle", this._jobTitle);
				this._jobTitle = value;
				this.OnPropertyChanged("JobTitle");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkPhone", Storage="_businessPhone", FieldType="Text")]
	public string BusinessPhone {
		get {
			return this._businessPhone;
		}
		set {
			if ((value != this._businessPhone)) {
				this.OnPropertyChanging("BusinessPhone", this._businessPhone);
				this._businessPhone = value;
				this.OnPropertyChanged("BusinessPhone");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="HomePhone", Storage="_homePhone", FieldType="Text")]
	public string HomePhone {
		get {
			return this._homePhone;
		}
		set {
			if ((value != this._homePhone)) {
				this.OnPropertyChanging("HomePhone", this._homePhone);
				this._homePhone = value;
				this.OnPropertyChanged("HomePhone");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="CellPhone", Storage="_mobileNumber", FieldType="Text")]
	public string MobileNumber {
		get {
			return this._mobileNumber;
		}
		set {
			if ((value != this._mobileNumber)) {
				this.OnPropertyChanging("MobileNumber", this._mobileNumber);
				this._mobileNumber = value;
				this.OnPropertyChanged("MobileNumber");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkFax", Storage="_faxNumber", FieldType="Text")]
	public string FaxNumber {
		get {
			return this._faxNumber;
		}
		set {
			if ((value != this._faxNumber)) {
				this.OnPropertyChanging("FaxNumber", this._faxNumber);
				this._faxNumber = value;
				this.OnPropertyChanged("FaxNumber");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkAddress", Storage="_address", FieldType="Note")]
	public string Address {
		get {
			return this._address;
		}
		set {
			if ((value != this._address)) {
				this.OnPropertyChanging("Address", this._address);
				this._address = value;
				this.OnPropertyChanged("Address");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkCity", Storage="_city", FieldType="Text")]
	public string City {
		get {
			return this._city;
		}
		set {
			if ((value != this._city)) {
				this.OnPropertyChanging("City", this._city);
				this._city = value;
				this.OnPropertyChanged("City");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkState", Storage="_stateProvince", FieldType="Text")]
	public string StateProvince {
		get {
			return this._stateProvince;
		}
		set {
			if ((value != this._stateProvince)) {
				this.OnPropertyChanging("StateProvince", this._stateProvince);
				this._stateProvince = value;
				this.OnPropertyChanged("StateProvince");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkZip", Storage="_zIPPostalCode", FieldType="Text")]
	public string ZIPPostalCode {
		get {
			return this._zIPPostalCode;
		}
		set {
			if ((value != this._zIPPostalCode)) {
				this.OnPropertyChanging("ZIPPostalCode", this._zIPPostalCode);
				this._zIPPostalCode = value;
				this.OnPropertyChanged("ZIPPostalCode");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WorkCountry", Storage="_countryRegion", FieldType="Text")]
	public string CountryRegion {
		get {
			return this._countryRegion;
		}
		set {
			if ((value != this._countryRegion)) {
				this.OnPropertyChanging("CountryRegion", this._countryRegion);
				this._countryRegion = value;
				this.OnPropertyChanged("CountryRegion");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WebPage", Storage="_webPage", FieldType="Url")]
	public string WebPage {
		get {
			return this._webPage;
		}
		set {
			if ((value != this._webPage)) {
				this.OnPropertyChanging("WebPage", this._webPage);
				this._webPage = value;
				this.OnPropertyChanged("WebPage");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Comments", Storage="_comments", FieldType="Note")]
	public string Comments {
		get {
			return this._comments;
		}
		set {
			if ((value != this._comments)) {
				this.OnPropertyChanging("Comments", this._comments);
				this._comments = value;
				this.OnPropertyChanged("Comments");
			}
		}
	}
}

/// <summary>
/// Create a new document.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Document", Id="0x0101")]
[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(WikiPage))]
public partial class Document : Item {
	
	private string _name;
	
	private string _documentModifiedBy;
	
	private string _documentCreatedBy;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public Document() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileLeafRef", Storage="_name", Required=true, FieldType="File")]
	public string Name {
		get {
			return this._name;
		}
		set {
			if ((value != this._name)) {
				this.OnPropertyChanging("Name", this._name);
				this._name = value;
				this.OnPropertyChanged("Name");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Modified_x0020_By", Storage="_documentModifiedBy", ReadOnly=true, FieldType="Text")]
	public string DocumentModifiedBy {
		get {
			return this._documentModifiedBy;
		}
		set {
			if ((value != this._documentModifiedBy)) {
				this.OnPropertyChanging("DocumentModifiedBy", this._documentModifiedBy);
				this._documentModifiedBy = value;
				this.OnPropertyChanged("DocumentModifiedBy");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Created_x0020_By", Storage="_documentCreatedBy", ReadOnly=true, FieldType="Text")]
	public string DocumentCreatedBy {
		get {
			return this._documentCreatedBy;
		}
		set {
			if ((value != this._documentCreatedBy)) {
				this.OnPropertyChanging("DocumentCreatedBy", this._documentCreatedBy);
				this._documentCreatedBy = value;
				this.OnPropertyChanged("DocumentCreatedBy");
			}
		}
	}
}

/// <summary>
/// Create a new news item, status or other short piece of information.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Announcement", Id="0x0104")]
public partial class Announcement : Item {
	
	private string _body;
	
	private System.Nullable<System.DateTime> _expires;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public Announcement() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Body", Storage="_body", FieldType="Note")]
	public string Body {
		get {
			return this._body;
		}
		set {
			if ((value != this._body)) {
				this.OnPropertyChanging("Body", this._body);
				this._body = value;
				this.OnPropertyChanged("Body");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Expires", Storage="_expires", FieldType="DateTime")]
	public System.Nullable<System.DateTime> Expires {
		get {
			return this._expires;
		}
		set {
			if ((value != this._expires)) {
				this.OnPropertyChanging("Expires", this._expires);
				this._expires = value;
				this.OnPropertyChanged("Expires");
			}
		}
	}
}

/// <summary>
/// Create a new wiki page.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Wiki Page", Id="0x010108")]
public partial class WikiPage : Document {
	
	private string _wikiContent;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public WikiPage() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="WikiField", Storage="_wikiContent", FieldType="Note")]
	public string WikiContent {
		get {
			return this._wikiContent;
		}
		set {
			if ((value != this._wikiContent)) {
				this.OnPropertyChanging("WikiContent", this._wikiContent);
				this._wikiContent = value;
				this.OnPropertyChanged("WikiContent");
			}
		}
	}
	
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
	[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
	public override string Title {
		get {
			throw new System.InvalidOperationException("Field Title was removed from content type Wiki Page.");
		}
		set {
			throw new System.InvalidOperationException("Field Title was removed from content type Wiki Page.");
		}
	}
}

/// <summary>
/// Create a new list item.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01", List="Lista telefonos")]
public partial class ListaTelefonosItem : Item {
	
	private string _modelo;
	
	private System.Nullable<System.DateTime> _lanzamiento;
	
	private System.Nullable<double> _precio;
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public ListaTelefonosItem() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ywsi", Storage="_modelo", FieldType="Text")]
	public string Modelo {
		get {
			return this._modelo;
		}
		set {
			if ((value != this._modelo)) {
				this.OnPropertyChanging("Modelo", this._modelo);
				this._modelo = value;
				this.OnPropertyChanged("Modelo");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="wgmu", Storage="_lanzamiento", FieldType="DateTime")]
	public System.Nullable<System.DateTime> Lanzamiento {
		get {
			return this._lanzamiento;
		}
		set {
			if ((value != this._lanzamiento)) {
				this.OnPropertyChanging("Lanzamiento", this._lanzamiento);
				this._lanzamiento = value;
				this.OnPropertyChanged("Lanzamiento");
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="hk1r", Storage="_precio", FieldType="Currency")]
	public System.Nullable<double> Precio {
		get {
			return this._precio;
		}
		set {
			if ((value != this._precio)) {
				this.OnPropertyChanging("Precio", this._precio);
				this._precio = value;
				this.OnPropertyChanged("Precio");
			}
		}
	}
}

/// <summary>
/// Store information about a business or personal contact.
/// </summary>
[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Contact", Id="0x0106", List="Contactos")]
public partial class ContactosContact : Contact {
	
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate();
	partial void OnCreated();
	#endregion
	
	public ContactosContact() {
		this.OnCreated();
	}
	
	[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Email", Storage="_eMail", FieldType="Text")]
	public override string EMail {
		get {
			return this._eMail;
		}
		set {
			if ((value != this._eMail)) {
				this.OnPropertyChanging("EMail", this._eMail);
				this._eMail = value;
				this.OnPropertyChanged("EMail");
			}
		}
	}
}