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
	/// <summary>
	/// This class represents the Element Document-DespatchAdvice_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Document-DespatchAdvice_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Document_DespatchAdvice_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Document_DespatchAdvice_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Document_DespatchAdvice_Group()
		{
			_elementName = "Document-DespatchAdvice_Group";
			Init();
		}
		public Document_DespatchAdvice_Group(string elementName)
		{
			_elementName = elementName;
			Init();
		}
		#endregion

		#region Initialization methods for the class
		/// <summary>
		/// Initializes the class
		/// </summary>
		/// <remarks>
		/// This creates all the mandatory fields (populated with the default data) 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd.
		/// </remarks>
		protected override void Init()
		{
			DESADV_XSDLib.Registration.iRegistrationIndicator = 0; // causes registration to take place
			m_DespatchAdvice_Header = null;
			m_DespatchAdvice_Transport = null;
			m_DespatchAdvice_Parties = null;
			m_DespatchAdvice_Consignment = null;
			m_DespatchAdvice_Lines = null;
			m_DespatchAdvice_Summary = null;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DespatchAdvice_Header = null;
			m_DespatchAdvice_Transport = null;
			m_DespatchAdvice_Parties = null;
			m_DespatchAdvice_Consignment = null;
			m_DespatchAdvice_Lines = null;
			m_DespatchAdvice_Summary = null;
			_validElement = selectedElement;
		}
		#endregion

		#region ICloneable Interface
		/// <summary>
		/// Allows the class to be copied
		/// </summary>
		/// <remarks>
		/// Performs a 'deep copy' of all the data in the class (and its children)
		/// </remarks>
		public override object Clone()
		{
			DESADV_XSDLib.Document_DespatchAdvice_Group newObject = new DESADV_XSDLib.Document_DespatchAdvice_Group(_elementName);
			newObject.m_DespatchAdvice_Header = null;
			if (m_DespatchAdvice_Header != null)
				newObject.m_DespatchAdvice_Header = (DESADV_XSDLib.DespatchAdvice_Header)m_DespatchAdvice_Header.Clone();
			newObject.m_DespatchAdvice_Transport = null;
			if (m_DespatchAdvice_Transport != null)
				newObject.m_DespatchAdvice_Transport = (DESADV_XSDLib.DespatchAdvice_Transport)m_DespatchAdvice_Transport.Clone();
			newObject.m_DespatchAdvice_Parties = null;
			if (m_DespatchAdvice_Parties != null)
				newObject.m_DespatchAdvice_Parties = (DESADV_XSDLib.DespatchAdvice_Parties)m_DespatchAdvice_Parties.Clone();
			newObject.m_DespatchAdvice_Consignment = null;
			if (m_DespatchAdvice_Consignment != null)
				newObject.m_DespatchAdvice_Consignment = (DESADV_XSDLib.DespatchAdvice_Consignment)m_DespatchAdvice_Consignment.Clone();
			newObject.m_DespatchAdvice_Lines = null;
			if (m_DespatchAdvice_Lines != null)
				newObject.m_DespatchAdvice_Lines = (DESADV_XSDLib.DespatchAdvice_Lines)m_DespatchAdvice_Lines.Clone();
			newObject.m_DespatchAdvice_Summary = null;
			if (m_DespatchAdvice_Summary != null)
				newObject.m_DespatchAdvice_Summary = (DESADV_XSDLib.DespatchAdvice_Summary)m_DespatchAdvice_Summary.Clone();

			newObject._validElement = _validElement;
// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override string TargetNamespace
		{
			get { return ""; }
		}

		#region Attribute - DespatchAdvice-Header
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Header", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Header))]
		public DESADV_XSDLib.DespatchAdvice_Header DespatchAdvice_Header
		{
			get
			{ 
				return m_DespatchAdvice_Header;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Header"); // remove selection
				if (value == null)
					m_DespatchAdvice_Header = null;
				else
				{
					m_DespatchAdvice_Header = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Header m_DespatchAdvice_Header;
		
		#endregion

		#region Attribute - DespatchAdvice-Transport
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Transport", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Transport))]
		public DESADV_XSDLib.DespatchAdvice_Transport DespatchAdvice_Transport
		{
			get
			{ 
				return m_DespatchAdvice_Transport;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Transport"); // remove selection
				if (value == null)
					m_DespatchAdvice_Transport = null;
				else
				{
					m_DespatchAdvice_Transport = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Transport m_DespatchAdvice_Transport;
		
		#endregion

		#region Attribute - DespatchAdvice-Parties
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Parties", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Parties))]
		public DESADV_XSDLib.DespatchAdvice_Parties DespatchAdvice_Parties
		{
			get
			{ 
				return m_DespatchAdvice_Parties;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Parties"); // remove selection
				if (value == null)
					m_DespatchAdvice_Parties = null;
				else
				{
					m_DespatchAdvice_Parties = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Parties m_DespatchAdvice_Parties;
		
		#endregion

		#region Attribute - DespatchAdvice-Consignment
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Consignment", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Consignment))]
		public DESADV_XSDLib.DespatchAdvice_Consignment DespatchAdvice_Consignment
		{
			get
			{ 
				return m_DespatchAdvice_Consignment;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Consignment"); // remove selection
				if (value == null)
					m_DespatchAdvice_Consignment = null;
				else
				{
					m_DespatchAdvice_Consignment = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Consignment m_DespatchAdvice_Consignment;
		
		#endregion

		#region Attribute - DespatchAdvice-Lines
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Lines", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Lines))]
		public DESADV_XSDLib.DespatchAdvice_Lines DespatchAdvice_Lines
		{
			get
			{ 
				return m_DespatchAdvice_Lines;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Lines"); // remove selection
				if (value == null)
					m_DespatchAdvice_Lines = null;
				else
				{
					m_DespatchAdvice_Lines = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Lines m_DespatchAdvice_Lines;
		
		#endregion

		#region Attribute - DespatchAdvice-Summary
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DespatchAdvice-Summary", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DespatchAdvice_Summary))]
		public DESADV_XSDLib.DespatchAdvice_Summary DespatchAdvice_Summary
		{
			get
			{ 
				return m_DespatchAdvice_Summary;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DespatchAdvice_Summary"); // remove selection
				if (value == null)
					m_DespatchAdvice_Summary = null;
				else
				{
					m_DespatchAdvice_Summary = value; 
				}
			}
		}
		protected DESADV_XSDLib.DespatchAdvice_Summary m_DespatchAdvice_Summary;
		
		#endregion

		public string ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected string _validElement;
		#region Attribute - Namespace
		public override string Namespace
		{
			get { return ""; }
		}	
		#endregion	

		#region Attribute - GetBase
		public override LiquidTechnologies.Runtime.Net45.XmlObjectBase GetBase()
		{
			return this;
		}
		#endregion
		#endregion


// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}


