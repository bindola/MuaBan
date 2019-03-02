using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "54fa0b4e88afdc28")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BrandProduct1
		///</summary>
		[ImplementPropertyType("brandProduct1")]
		public string BrandProduct1
		{
			get { return this.GetPropertyValue<string>("brandProduct1"); }
		}

		///<summary>
		/// BrandProduct2
		///</summary>
		[ImplementPropertyType("brandProduct2")]
		public string BrandProduct2
		{
			get { return this.GetPropertyValue<string>("brandProduct2"); }
		}

		///<summary>
		/// BrandProduct3
		///</summary>
		[ImplementPropertyType("brandProduct3")]
		public string BrandProduct3
		{
			get { return this.GetPropertyValue<string>("brandProduct3"); }
		}

		///<summary>
		/// BrandProduct4
		///</summary>
		[ImplementPropertyType("brandProduct4")]
		public string BrandProduct4
		{
			get { return this.GetPropertyValue<string>("brandProduct4"); }
		}

		///<summary>
		/// BrandProduct5
		///</summary>
		[ImplementPropertyType("brandProduct5")]
		public string BrandProduct5
		{
			get { return this.GetPropertyValue<string>("brandProduct5"); }
		}

		///<summary>
		/// BrandProduct6
		///</summary>
		[ImplementPropertyType("brandProduct6")]
		public string BrandProduct6
		{
			get { return this.GetPropertyValue<string>("brandProduct6"); }
		}

		///<summary>
		/// BrandProduct7
		///</summary>
		[ImplementPropertyType("brandProduct7")]
		public string BrandProduct7
		{
			get { return this.GetPropertyValue<string>("brandProduct7"); }
		}

		///<summary>
		/// BrandProduct8
		///</summary>
		[ImplementPropertyType("brandProduct8")]
		public string BrandProduct8
		{
			get { return this.GetPropertyValue<string>("brandProduct8"); }
		}

		///<summary>
		/// BrandProduct9
		///</summary>
		[ImplementPropertyType("brandProduct9")]
		public string BrandProduct9
		{
			get { return this.GetPropertyValue<string>("brandProduct9"); }
		}

		///<summary>
		/// Check1
		///</summary>
		[ImplementPropertyType("check1")]
		public bool Check1
		{
			get { return this.GetPropertyValue<bool>("check1"); }
		}

		///<summary>
		/// Check2
		///</summary>
		[ImplementPropertyType("check2")]
		public bool Check2
		{
			get { return this.GetPropertyValue<bool>("check2"); }
		}

		///<summary>
		/// Check3
		///</summary>
		[ImplementPropertyType("check3")]
		public bool Check3
		{
			get { return this.GetPropertyValue<bool>("check3"); }
		}

		///<summary>
		/// Check4
		///</summary>
		[ImplementPropertyType("check4")]
		public bool Check4
		{
			get { return this.GetPropertyValue<bool>("check4"); }
		}

		///<summary>
		/// Check5
		///</summary>
		[ImplementPropertyType("check5")]
		public bool Check5
		{
			get { return this.GetPropertyValue<bool>("check5"); }
		}

		///<summary>
		/// Check6
		///</summary>
		[ImplementPropertyType("check6")]
		public bool Check6
		{
			get { return this.GetPropertyValue<bool>("check6"); }
		}

		///<summary>
		/// Check7
		///</summary>
		[ImplementPropertyType("check7")]
		public bool Check7
		{
			get { return this.GetPropertyValue<bool>("check7"); }
		}

		///<summary>
		/// Check8
		///</summary>
		[ImplementPropertyType("check8")]
		public bool Check8
		{
			get { return this.GetPropertyValue<bool>("check8"); }
		}

		///<summary>
		/// Check9
		///</summary>
		[ImplementPropertyType("check9")]
		public bool Check9
		{
			get { return this.GetPropertyValue<bool>("check9"); }
		}

		///<summary>
		/// Decription1
		///</summary>
		[ImplementPropertyType("decription1")]
		public string Decription1
		{
			get { return this.GetPropertyValue<string>("decription1"); }
		}

		///<summary>
		/// Decription2
		///</summary>
		[ImplementPropertyType("decription2")]
		public string Decription2
		{
			get { return this.GetPropertyValue<string>("decription2"); }
		}

		///<summary>
		/// Decription3
		///</summary>
		[ImplementPropertyType("decription3")]
		public string Decription3
		{
			get { return this.GetPropertyValue<string>("decription3"); }
		}

		///<summary>
		/// Decription4
		///</summary>
		[ImplementPropertyType("decription4")]
		public string Decription4
		{
			get { return this.GetPropertyValue<string>("decription4"); }
		}

		///<summary>
		/// Decription5
		///</summary>
		[ImplementPropertyType("decription5")]
		public string Decription5
		{
			get { return this.GetPropertyValue<string>("decription5"); }
		}

		///<summary>
		/// Decription6
		///</summary>
		[ImplementPropertyType("decription6")]
		public string Decription6
		{
			get { return this.GetPropertyValue<string>("decription6"); }
		}

		///<summary>
		/// Decription7
		///</summary>
		[ImplementPropertyType("decription7")]
		public string Decription7
		{
			get { return this.GetPropertyValue<string>("decription7"); }
		}

		///<summary>
		/// Decription8
		///</summary>
		[ImplementPropertyType("decription8")]
		public string Decription8
		{
			get { return this.GetPropertyValue<string>("decription8"); }
		}

		///<summary>
		/// Decription9
		///</summary>
		[ImplementPropertyType("decription9")]
		public string Decription9
		{
			get { return this.GetPropertyValue<string>("decription9"); }
		}

		///<summary>
		/// ImageProductDetail11
		///</summary>
		[ImplementPropertyType("imageProductDetail11")]
		public string ImageProductDetail11
		{
			get { return this.GetPropertyValue<string>("imageProductDetail11"); }
		}

		///<summary>
		/// ImageProductDetail12
		///</summary>
		[ImplementPropertyType("imageProductDetail12")]
		public string ImageProductDetail12
		{
			get { return this.GetPropertyValue<string>("imageProductDetail12"); }
		}

		///<summary>
		/// ImageProductDetail13
		///</summary>
		[ImplementPropertyType("imageProductDetail13")]
		public string ImageProductDetail13
		{
			get { return this.GetPropertyValue<string>("imageProductDetail13"); }
		}

		///<summary>
		/// ImageProductDetail14
		///</summary>
		[ImplementPropertyType("imageProductDetail14")]
		public string ImageProductDetail14
		{
			get { return this.GetPropertyValue<string>("imageProductDetail14"); }
		}

		///<summary>
		/// ImageProductDetail15
		///</summary>
		[ImplementPropertyType("imageProductDetail15")]
		public string ImageProductDetail15
		{
			get { return this.GetPropertyValue<string>("imageProductDetail15"); }
		}

		///<summary>
		/// ImageProductDetail16
		///</summary>
		[ImplementPropertyType("imageProductDetail16")]
		public string ImageProductDetail16
		{
			get { return this.GetPropertyValue<string>("imageProductDetail16"); }
		}

		///<summary>
		/// ImageProductDetail17
		///</summary>
		[ImplementPropertyType("imageProductDetail17")]
		public string ImageProductDetail17
		{
			get { return this.GetPropertyValue<string>("imageProductDetail17"); }
		}

		///<summary>
		/// ImageProductDetail18
		///</summary>
		[ImplementPropertyType("imageProductDetail18")]
		public string ImageProductDetail18
		{
			get { return this.GetPropertyValue<string>("imageProductDetail18"); }
		}

		///<summary>
		/// ImageProductDetail19
		///</summary>
		[ImplementPropertyType("imageProductDetail19")]
		public string ImageProductDetail19
		{
			get { return this.GetPropertyValue<string>("imageProductDetail19"); }
		}

		///<summary>
		/// ImageProductDetail21
		///</summary>
		[ImplementPropertyType("imageProductDetail21")]
		public string ImageProductDetail21
		{
			get { return this.GetPropertyValue<string>("imageProductDetail21"); }
		}

		///<summary>
		/// ImageProductDetail22
		///</summary>
		[ImplementPropertyType("imageProductDetail22")]
		public string ImageProductDetail22
		{
			get { return this.GetPropertyValue<string>("imageProductDetail22"); }
		}

		///<summary>
		/// ImageProductDetail23
		///</summary>
		[ImplementPropertyType("imageProductDetail23")]
		public string ImageProductDetail23
		{
			get { return this.GetPropertyValue<string>("imageProductDetail23"); }
		}

		///<summary>
		/// ImageProductDetail24
		///</summary>
		[ImplementPropertyType("imageProductDetail24")]
		public string ImageProductDetail24
		{
			get { return this.GetPropertyValue<string>("imageProductDetail24"); }
		}

		///<summary>
		/// ImageProductDetail25
		///</summary>
		[ImplementPropertyType("imageProductDetail25")]
		public string ImageProductDetail25
		{
			get { return this.GetPropertyValue<string>("imageProductDetail25"); }
		}

		///<summary>
		/// ImageProductDetail26
		///</summary>
		[ImplementPropertyType("imageProductDetail26")]
		public string ImageProductDetail26
		{
			get { return this.GetPropertyValue<string>("imageProductDetail26"); }
		}

		///<summary>
		/// ImageProductDetail27
		///</summary>
		[ImplementPropertyType("imageProductDetail27")]
		public string ImageProductDetail27
		{
			get { return this.GetPropertyValue<string>("imageProductDetail27"); }
		}

		///<summary>
		/// ImageProductDetail28
		///</summary>
		[ImplementPropertyType("imageProductDetail28")]
		public string ImageProductDetail28
		{
			get { return this.GetPropertyValue<string>("imageProductDetail28"); }
		}

		///<summary>
		/// ImageProductDetail29
		///</summary>
		[ImplementPropertyType("imageProductDetail29")]
		public string ImageProductDetail29
		{
			get { return this.GetPropertyValue<string>("imageProductDetail29"); }
		}

		///<summary>
		/// ImageProductDetail31
		///</summary>
		[ImplementPropertyType("imageProductDetail31")]
		public string ImageProductDetail31
		{
			get { return this.GetPropertyValue<string>("imageProductDetail31"); }
		}

		///<summary>
		/// ImageProductDetail32
		///</summary>
		[ImplementPropertyType("imageProductDetail32")]
		public string ImageProductDetail32
		{
			get { return this.GetPropertyValue<string>("imageProductDetail32"); }
		}

		///<summary>
		/// ImageProductDetail33
		///</summary>
		[ImplementPropertyType("imageProductDetail33")]
		public string ImageProductDetail33
		{
			get { return this.GetPropertyValue<string>("imageProductDetail33"); }
		}

		///<summary>
		/// ImageProductDetail34
		///</summary>
		[ImplementPropertyType("imageProductDetail34")]
		public string ImageProductDetail34
		{
			get { return this.GetPropertyValue<string>("imageProductDetail34"); }
		}

		///<summary>
		/// ImageProductDetail35
		///</summary>
		[ImplementPropertyType("imageProductDetail35")]
		public string ImageProductDetail35
		{
			get { return this.GetPropertyValue<string>("imageProductDetail35"); }
		}

		///<summary>
		/// ImageProductDetail36
		///</summary>
		[ImplementPropertyType("imageProductDetail36")]
		public string ImageProductDetail36
		{
			get { return this.GetPropertyValue<string>("imageProductDetail36"); }
		}

		///<summary>
		/// ImageProductDetail37
		///</summary>
		[ImplementPropertyType("imageProductDetail37")]
		public string ImageProductDetail37
		{
			get { return this.GetPropertyValue<string>("imageProductDetail37"); }
		}

		///<summary>
		/// ImageProductDetail38
		///</summary>
		[ImplementPropertyType("imageProductDetail38")]
		public string ImageProductDetail38
		{
			get { return this.GetPropertyValue<string>("imageProductDetail38"); }
		}

		///<summary>
		/// ImageProductDetail39
		///</summary>
		[ImplementPropertyType("imageProductDetail39")]
		public string ImageProductDetail39
		{
			get { return this.GetPropertyValue<string>("imageProductDetail39"); }
		}

		///<summary>
		/// ImageProductShow
		///</summary>
		[ImplementPropertyType("imageProductShow")]
		public string ImageProductShow
		{
			get { return this.GetPropertyValue<string>("imageProductShow"); }
		}

		///<summary>
		/// ImageProductShow1
		///</summary>
		[ImplementPropertyType("imageProductShow1")]
		public string ImageProductShow1
		{
			get { return this.GetPropertyValue<string>("imageProductShow1"); }
		}

		///<summary>
		/// ImageProductShow2
		///</summary>
		[ImplementPropertyType("imageProductShow2")]
		public string ImageProductShow2
		{
			get { return this.GetPropertyValue<string>("imageProductShow2"); }
		}

		///<summary>
		/// ImageProductShow3
		///</summary>
		[ImplementPropertyType("imageProductShow3")]
		public string ImageProductShow3
		{
			get { return this.GetPropertyValue<string>("imageProductShow3"); }
		}

		///<summary>
		/// ImageProductShow4
		///</summary>
		[ImplementPropertyType("imageProductShow4")]
		public string ImageProductShow4
		{
			get { return this.GetPropertyValue<string>("imageProductShow4"); }
		}

		///<summary>
		/// ImageProductShow5
		///</summary>
		[ImplementPropertyType("imageProductShow5")]
		public string ImageProductShow5
		{
			get { return this.GetPropertyValue<string>("imageProductShow5"); }
		}

		///<summary>
		/// ImageProductShow6
		///</summary>
		[ImplementPropertyType("imageProductShow6")]
		public string ImageProductShow6
		{
			get { return this.GetPropertyValue<string>("imageProductShow6"); }
		}

		///<summary>
		/// ImageProductShow8
		///</summary>
		[ImplementPropertyType("imageProductShow8")]
		public string ImageProductShow8
		{
			get { return this.GetPropertyValue<string>("imageProductShow8"); }
		}

		///<summary>
		/// ImageProductShow9
		///</summary>
		[ImplementPropertyType("imageProductShow9")]
		public string ImageProductShow9
		{
			get { return this.GetPropertyValue<string>("imageProductShow9"); }
		}

		///<summary>
		/// NameProduct1
		///</summary>
		[ImplementPropertyType("nameProduct1")]
		public string NameProduct1
		{
			get { return this.GetPropertyValue<string>("nameProduct1"); }
		}

		///<summary>
		/// NameProduct2
		///</summary>
		[ImplementPropertyType("nameProduct2")]
		public string NameProduct2
		{
			get { return this.GetPropertyValue<string>("nameProduct2"); }
		}

		///<summary>
		/// NameProduct3
		///</summary>
		[ImplementPropertyType("nameProduct3")]
		public string NameProduct3
		{
			get { return this.GetPropertyValue<string>("nameProduct3"); }
		}

		///<summary>
		/// NameProduct4
		///</summary>
		[ImplementPropertyType("nameProduct4")]
		public string NameProduct4
		{
			get { return this.GetPropertyValue<string>("nameProduct4"); }
		}

		///<summary>
		/// NameProduct5
		///</summary>
		[ImplementPropertyType("nameProduct5")]
		public string NameProduct5
		{
			get { return this.GetPropertyValue<string>("nameProduct5"); }
		}

		///<summary>
		/// NameProduct6
		///</summary>
		[ImplementPropertyType("nameProduct6")]
		public string NameProduct6
		{
			get { return this.GetPropertyValue<string>("nameProduct6"); }
		}

		///<summary>
		/// NameProduct7
		///</summary>
		[ImplementPropertyType("nameProduct7")]
		public string NameProduct7
		{
			get { return this.GetPropertyValue<string>("nameProduct7"); }
		}

		///<summary>
		/// NameProduct8
		///</summary>
		[ImplementPropertyType("nameProduct8")]
		public string NameProduct8
		{
			get { return this.GetPropertyValue<string>("nameProduct8"); }
		}

		///<summary>
		/// NameProduct9
		///</summary>
		[ImplementPropertyType("nameProduct9")]
		public string NameProduct9
		{
			get { return this.GetPropertyValue<string>("nameProduct9"); }
		}

		///<summary>
		/// Price1
		///</summary>
		[ImplementPropertyType("price1")]
		public string Price1
		{
			get { return this.GetPropertyValue<string>("price1"); }
		}

		///<summary>
		/// Price2
		///</summary>
		[ImplementPropertyType("price2")]
		public string Price2
		{
			get { return this.GetPropertyValue<string>("price2"); }
		}

		///<summary>
		/// Price3
		///</summary>
		[ImplementPropertyType("price3")]
		public string Price3
		{
			get { return this.GetPropertyValue<string>("price3"); }
		}

		///<summary>
		/// Price4
		///</summary>
		[ImplementPropertyType("price4")]
		public string Price4
		{
			get { return this.GetPropertyValue<string>("price4"); }
		}

		///<summary>
		/// Price5
		///</summary>
		[ImplementPropertyType("price5")]
		public string Price5
		{
			get { return this.GetPropertyValue<string>("price5"); }
		}

		///<summary>
		/// Price6
		///</summary>
		[ImplementPropertyType("price6")]
		public string Price6
		{
			get { return this.GetPropertyValue<string>("price6"); }
		}

		///<summary>
		/// Price7
		///</summary>
		[ImplementPropertyType("price7")]
		public string Price7
		{
			get { return this.GetPropertyValue<string>("price7"); }
		}

		///<summary>
		/// Price8
		///</summary>
		[ImplementPropertyType("price8")]
		public string Price8
		{
			get { return this.GetPropertyValue<string>("price8"); }
		}

		///<summary>
		/// Price9
		///</summary>
		[ImplementPropertyType("price9")]
		public string Price9
		{
			get { return this.GetPropertyValue<string>("price9"); }
		}

		///<summary>
		/// TopSell1
		///</summary>
		[ImplementPropertyType("topSell1")]
		public bool TopSell1
		{
			get { return this.GetPropertyValue<bool>("topSell1"); }
		}

		///<summary>
		/// TopSell2
		///</summary>
		[ImplementPropertyType("topSell2")]
		public bool TopSell2
		{
			get { return this.GetPropertyValue<bool>("topSell2"); }
		}

		///<summary>
		/// TopSell3
		///</summary>
		[ImplementPropertyType("topSell3")]
		public bool TopSell3
		{
			get { return this.GetPropertyValue<bool>("topSell3"); }
		}

		///<summary>
		/// TopSell4
		///</summary>
		[ImplementPropertyType("topSell4")]
		public bool TopSell4
		{
			get { return this.GetPropertyValue<bool>("topSell4"); }
		}

		///<summary>
		/// TopSell5
		///</summary>
		[ImplementPropertyType("topSell5")]
		public bool TopSell5
		{
			get { return this.GetPropertyValue<bool>("topSell5"); }
		}

		///<summary>
		/// TopSell6
		///</summary>
		[ImplementPropertyType("topSell6")]
		public bool TopSell6
		{
			get { return this.GetPropertyValue<bool>("topSell6"); }
		}

		///<summary>
		/// TopSell7
		///</summary>
		[ImplementPropertyType("topSell7")]
		public bool TopSell7
		{
			get { return this.GetPropertyValue<bool>("topSell7"); }
		}

		///<summary>
		/// TopSell8
		///</summary>
		[ImplementPropertyType("topSell8")]
		public bool TopSell8
		{
			get { return this.GetPropertyValue<bool>("topSell8"); }
		}

		///<summary>
		/// TopSell9
		///</summary>
		[ImplementPropertyType("topSell9")]
		public bool TopSell9
		{
			get { return this.GetPropertyValue<bool>("topSell9"); }
		}
	}

	/// <summary>AboutUs</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>ProductDetail</summary>
	[PublishedContentModel("productDetail")]
	public partial class ProductDetail : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "productDetail";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProductDetail(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductDetail, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
