using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2015 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  : by Liquid XML Data Binder 13.0.6.5773
 * Using Schema: C:\BTS\XSD\KORUS\DESADV_XSD.xsd
 **********************************************************************************************/

namespace DESADV_XSDLib 
{
	public static class ClassFactory
	{
		#region Static Constructor
		private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Type>> _nsMap = null;
		static ClassFactory()
		{
			_nsMap = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Type>>();
			System.Collections.Generic.Dictionary<string, System.Type> itemMap = null;
			itemMap = new System.Collections.Generic.Dictionary<string, System.Type>();
			itemMap.Add("Buyer", typeof(DESADV_XSDLib.Buyer));
			itemMap.Add("Buyer_Group", typeof(DESADV_XSDLib.Buyer_Group));
			itemMap.Add("Consignor", typeof(DESADV_XSDLib.Consignor));
			itemMap.Add("Consignor_Group", typeof(DESADV_XSDLib.Consignor_Group));
			itemMap.Add("DeliveryPoint", typeof(DESADV_XSDLib.DeliveryPoint));
			itemMap.Add("DeliveryPoint_Group", typeof(DESADV_XSDLib.DeliveryPoint_Group));
			itemMap.Add("DespatchAdvice-Consignment", typeof(DESADV_XSDLib.DespatchAdvice_Consignment));
			itemMap.Add("DespatchAdvice-Header", typeof(DESADV_XSDLib.DespatchAdvice_Header));
			itemMap.Add("DespatchAdvice-Header_Group", typeof(DESADV_XSDLib.DespatchAdvice_Header_Group));
			itemMap.Add("DespatchAdvice-Lines", typeof(DESADV_XSDLib.DespatchAdvice_Lines));
			itemMap.Add("DespatchAdvice-Parties", typeof(DESADV_XSDLib.DespatchAdvice_Parties));
			itemMap.Add("DespatchAdvice-Parties_Group", typeof(DESADV_XSDLib.DespatchAdvice_Parties_Group));
			itemMap.Add("DespatchAdvice-Summary", typeof(DESADV_XSDLib.DespatchAdvice_Summary));
			itemMap.Add("DespatchAdvice-Summary_Group", typeof(DESADV_XSDLib.DespatchAdvice_Summary_Group));
			itemMap.Add("DespatchAdvice-Transport", typeof(DESADV_XSDLib.DespatchAdvice_Transport));
			itemMap.Add("DespatchAdvice-Transport_Group", typeof(DESADV_XSDLib.DespatchAdvice_Transport_Group));
			itemMap.Add("Document-DespatchAdvice", typeof(DESADV_XSDLib.Document_DespatchAdvice));
			itemMap.Add("Document-DespatchAdvice_Group", typeof(DESADV_XSDLib.Document_DespatchAdvice_Group));
			itemMap.Add("Importer", typeof(DESADV_XSDLib.Importer));
			itemMap.Add("Importer_Group", typeof(DESADV_XSDLib.Importer_Group));
			itemMap.Add("Line", typeof(DESADV_XSDLib.Line));
			itemMap.Add("Line_Group", typeof(DESADV_XSDLib.Line_Group));
			itemMap.Add("Line-Item", typeof(DESADV_XSDLib.Line_Item));
			itemMap.Add("Line-Item_Group", typeof(DESADV_XSDLib.Line_Item_Group));
			itemMap.Add("Line-Measurements", typeof(DESADV_XSDLib.Line_Measurements));
			itemMap.Add("Line-Measurements_Group", typeof(DESADV_XSDLib.Line_Measurements_Group));
			itemMap.Add("Line-Order", typeof(DESADV_XSDLib.Line_Order));
			itemMap.Add("Line-Order_Group", typeof(DESADV_XSDLib.Line_Order_Group));
			itemMap.Add("Line-Parties", typeof(DESADV_XSDLib.Line_Parties));
			itemMap.Add("Line-Parties_Group", typeof(DESADV_XSDLib.Line_Parties_Group));
			itemMap.Add("Manufacturer", typeof(DESADV_XSDLib.Manufacturer));
			itemMap.Add("Manufacturer_Group", typeof(DESADV_XSDLib.Manufacturer_Group));
			itemMap.Add("Order-Measurement", typeof(DESADV_XSDLib.Order_Measurement));
			itemMap.Add("Order-Measurement_Group", typeof(DESADV_XSDLib.Order_Measurement_Group));
			itemMap.Add("OrderRecipient", typeof(DESADV_XSDLib.OrderRecipient));
			itemMap.Add("Package-Reference", typeof(DESADV_XSDLib.Package_Reference));
			itemMap.Add("Package-Reference_Group", typeof(DESADV_XSDLib.Package_Reference_Group));
			itemMap.Add("Packing-Sequence", typeof(DESADV_XSDLib.Packing_Sequence));
			itemMap.Add("Packing-Sequence_Group", typeof(DESADV_XSDLib.Packing_Sequence_Group));
			itemMap.Add("Payer", typeof(DESADV_XSDLib.Payer));
			itemMap.Add("Payer_Group", typeof(DESADV_XSDLib.Payer_Group));
			itemMap.Add("Seller", typeof(DESADV_XSDLib.Seller));
			itemMap.Add("Seller_Group", typeof(DESADV_XSDLib.Seller_Group));
			itemMap.Add("ShipFrom", typeof(DESADV_XSDLib.ShipFrom));
			itemMap.Add("ShipFrom_Group", typeof(DESADV_XSDLib.ShipFrom_Group));
			itemMap.Add("Transport", typeof(DESADV_XSDLib.Transport));
			itemMap.Add("Transport_Group", typeof(DESADV_XSDLib.Transport_Group));
			itemMap.Add("TransportDetails", typeof(DESADV_XSDLib.TransportDetails));
			itemMap.Add("TransportDetails_Group", typeof(DESADV_XSDLib.TransportDetails_Group));
			itemMap.Add("Transports", typeof(DESADV_XSDLib.Transports));
			itemMap.Add("UltimateCustomer", typeof(DESADV_XSDLib.UltimateCustomer));
			_nsMap.Add("", itemMap);
		}
		#endregion

		#region FromXml
		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXml(String xmlIn)
		{
			return FromXml(xmlIn, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a string.
		/// </summary>
		/// <param name="xmlIn">The data to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXml(String xmlIn, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			XmlDocument xmlDoc = LiquidTechnologies.Runtime.Net45.XmlObjectBase.LoadXmlDocument(xmlIn, context);
			return FromXmlElement(xmlDoc.DocumentElement, context);
		}
		#endregion

		#region FromXmlFile
		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlFile(String FileName)
		{
			return FromXmlFile(FileName, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a File
		/// </summary>
		/// <param name="FileName">The file to be loaded</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlFile(String FileName, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			using (System.IO.Stream stream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read,System.IO.FileShare.Read))
			{
				return FromXmlStream(stream, context);
			}
		}
		#endregion

		#region FromXmlStream
		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlStream(System.IO.Stream stream)
		{
			return FromXmlStream(stream, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from XML data held in a stream.
		/// </summary>
		/// <param name="stream">The data to be loaded</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlStream(System.IO.Stream stream, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			XmlDocument xmlDoc = LiquidTechnologies.Runtime.Net45.XmlObjectBase.LoadXmlDocument(stream, context);
			return FromXmlElement(xmlDoc.DocumentElement, context);
		}
		#endregion
		
		#region FromXmlElement
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlElement(XmlElement xmlParent)
		{
			return FromXmlElement(xmlParent, LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default);
		}
		/// <summary>
		/// Creates an object from an XML Element.
		/// </summary>
		/// <param name="xmlParent">The data that needs loading</param>
		/// <param name="context">The context to use when loading the data</param>
		/// <returns>The wrapper object, loaded with the supplied data</returns>
		/// <remarks>Throws an exception if the XML data is not compatible with the schema</remarks>
		public static LiquidTechnologies.Runtime.Net45.XmlObjectBase FromXmlElement(XmlElement xmlParent, LiquidTechnologies.Runtime.Net45.XmlSerializationContext context)
		{
			LiquidTechnologies.Runtime.Net45.XmlObjectBase retVal = null;
			String elementName;
			String elementNamespaceUri;

			// Get the type name this is either 
			// from the element i.e. <Parent>... = Parent
			// or from the type i.e. <Parent xsi:type="someNS:SomeElement">... = SomeElement
			if (LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementType(xmlParent) == "")
			{
				elementName = xmlParent.LocalName;
				elementNamespaceUri = xmlParent.NamespaceURI;
			}
			else
			{
				elementName = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementType(xmlParent);
				elementNamespaceUri = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.GetElementTypeNamespaceUri(xmlParent);
			}

			// create the appropriate object
			retVal = LiquidTechnologies.Runtime.Net45.ClassFactoryHelper.CreateObject(_nsMap, elementName, elementNamespaceUri, context);
			if (retVal == null)
				throw new LiquidTechnologies.Runtime.Net45.LtException(string.Format("Failed load the element {0}:{1}. No appropriate class exists to load the data into. Ensure that the XML document complies with the schema.", elementName, elementNamespaceUri));
			
			// load the data into the object
			retVal.FromXmlElement(xmlParent, context);

			return retVal;
		}
		#endregion
	}
}
namespace b 
{
	public static class ClassFactory
	{
		#region Static Constructor
		static ClassFactory()
		{
		}
		#endregion
	}
}

