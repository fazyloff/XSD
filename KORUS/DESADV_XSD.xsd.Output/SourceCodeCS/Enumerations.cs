using System;
using System.Collections;
using System.Xml;
using System.Diagnostics;
using System.Collections.Specialized;

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
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'DocumentFunctionCode'
		#region Enumeration Declaration
		/// <summary>
		/// </summary>
		public enum DocumentFunctionCode
		{
        	O,
        	CHG
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// Converts a string to a DocumentFunctionCode enumeration
		/// </summary>
		public static String DocumentFunctionCodeToString(DESADV_XSDLib.Enumerations.DocumentFunctionCode enumValue)
		{
		    switch(enumValue)
		    {
		    case DESADV_XSDLib.Enumerations.DocumentFunctionCode.O:
	    		return "O";
		    case DESADV_XSDLib.Enumerations.DocumentFunctionCode.CHG:
	    		return "CHG";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for DESADV_XSDLib.Enumerations.DocumentFunctionCode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// Converts a DocumentFunctionCode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static DESADV_XSDLib.Enumerations.DocumentFunctionCode DocumentFunctionCodeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "O":
	    		return DESADV_XSDLib.Enumerations.DocumentFunctionCode.O;
			case "CHG":
	    		return DESADV_XSDLib.Enumerations.DocumentFunctionCode.CHG;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum DESADV_XSDLib.Enumerations.DocumentFunctionCode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for DESADV_XSDLib.Enumerations.DocumentFunctionCode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum DESADV_XSDLib.Enumerations.DocumentFunctionCode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection DocumentFunctionCodeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(DocumentFunctionCode);
			foreach (DocumentFunctionCode e in Enum.GetValues(t))
				ret.Add(DocumentFunctionCodeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'TaxCategoryCode'
		#region Enumeration Declaration
		/// <summary>
		/// </summary>
		public enum TaxCategoryCode
		{
        	S,
        	Z,
        	E
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// Converts a string to a TaxCategoryCode enumeration
		/// </summary>
		public static String TaxCategoryCodeToString(DESADV_XSDLib.Enumerations.TaxCategoryCode enumValue)
		{
		    switch(enumValue)
		    {
		    case DESADV_XSDLib.Enumerations.TaxCategoryCode.S:
	    		return "S";
		    case DESADV_XSDLib.Enumerations.TaxCategoryCode.Z:
	    		return "Z";
		    case DESADV_XSDLib.Enumerations.TaxCategoryCode.E:
	    		return "E";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for DESADV_XSDLib.Enumerations.TaxCategoryCode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// Converts a TaxCategoryCode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static DESADV_XSDLib.Enumerations.TaxCategoryCode TaxCategoryCodeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "S":
	    		return DESADV_XSDLib.Enumerations.TaxCategoryCode.S;
			case "Z":
	    		return DESADV_XSDLib.Enumerations.TaxCategoryCode.Z;
			case "E":
	    		return DESADV_XSDLib.Enumerations.TaxCategoryCode.E;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum DESADV_XSDLib.Enumerations.TaxCategoryCode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for DESADV_XSDLib.Enumerations.TaxCategoryCode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum DESADV_XSDLib.Enumerations.TaxCategoryCode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection TaxCategoryCodeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(TaxCategoryCode);
			foreach (TaxCategoryCode e in Enum.GetValues(t))
				ret.Add(TaxCategoryCodeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace b 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
	
namespace DESADV_XSDLib 
{
	internal class Registration
	{
		private static int RegisterLicense()
		{
			LiquidTechnologies.Runtime.Net45.XmlObjectBase.Register("Trial 28/03/2015", "DESADV_XSD.xsd", "TXNVV5NTW7089CF0000000AA");
			
// ##HAND_CODED_BLOCK_START ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
// Add Additional namespace declarations here...
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.SchemaType = LiquidTechnologies.Runtime.Net45.SchemaType.XSD;
//			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.DefaultNamespaceURI = "http://www.fpml.org/2003/FpML-4-0";
//			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("dsig", "http://www.w3.org/2000/09/xmldsig#");

			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("xs", "http://www.w3.org/2001/XMLSchema-instance");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("b", "urn:schemas-microsoft-com:BizTalkServer");

// ##HAND_CODED_BLOCK_END ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			
			return 1;
		}
		static public int iRegistrationIndicator = RegisterLicense();
	}
}




