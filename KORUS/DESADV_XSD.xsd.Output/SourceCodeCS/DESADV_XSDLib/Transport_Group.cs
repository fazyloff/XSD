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
	/// This class represents the Element Transport_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Transport_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Transport_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Transport_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Transport_Group()
		{
			_elementName = "Transport_Group";
			Init();
		}
		public Transport_Group(string elementName)
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
			m_LocationName = "";
			m_IsValidLocationName = false;
			m_DepartureDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDepartureDate = false;
			m_DepartureTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidDepartureTime = false;
			m_ArrivalDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidArrivalDate = false;
			m_ArrivalTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidArrivalTime = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_LocationName = "";
			m_IsValidLocationName = false;
			m_DepartureDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDepartureDate = false;
			m_DepartureTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidDepartureTime = false;
			m_ArrivalDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidArrivalDate = false;
			m_ArrivalTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidArrivalTime = false;
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
			DESADV_XSDLib.Transport_Group newObject = new DESADV_XSDLib.Transport_Group(_elementName);
			newObject.m_LocationName = m_LocationName;
			newObject.m_IsValidLocationName = m_IsValidLocationName;
			newObject.m_DepartureDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DepartureDate.Clone();
			newObject.m_IsValidDepartureDate = m_IsValidDepartureDate;
			newObject.m_DepartureTime = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DepartureTime.Clone();
			newObject.m_IsValidDepartureTime = m_IsValidDepartureTime;
			newObject.m_ArrivalDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_ArrivalDate.Clone();
			newObject.m_IsValidArrivalDate = m_IsValidArrivalDate;
			newObject.m_ArrivalTime = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_ArrivalTime.Clone();
			newObject.m_IsValidArrivalTime = m_IsValidArrivalTime;

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

		#region Attribute - LocationName
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("LocationName", "", "IsValidLocationName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "256", "", "", "", "", "-1")]
		public string LocationName
		{
			get 
			{ 
				if (m_IsValidLocationName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property LocationName is not valid. Set LocationNameValid = true");
				return m_LocationName;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("LocationName"); // remove selection
				m_IsValidLocationName = true;
				m_LocationName = value;
			}
		}
		/// <summary>
		/// Indicates if LocationName contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for LocationName is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get LocationName
		/// will raise an exception.
		/// </remarks>
		public bool IsValidLocationName
		{
			get
			{
				return m_IsValidLocationName;
			}
			set 
			{ 
				if (value != m_IsValidLocationName)
				{
					LocationName = "";
					m_IsValidLocationName = value;
				}
			}
		}
		protected bool m_IsValidLocationName;
		protected string m_LocationName;
		#endregion

		#region Attribute - DepartureDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DepartureDate", "", "IsValidDepartureDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DepartureDate
		{
			get 
			{ 
				if (m_IsValidDepartureDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DepartureDate is not valid. Set DepartureDateValid = true");
				return m_DepartureDate;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DepartureDate"); // remove selection
				m_IsValidDepartureDate = true;
				m_DepartureDate.SetDateTime(value, m_DepartureDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if DepartureDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DepartureDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get DepartureDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDepartureDate
		{
			get
			{
				return m_IsValidDepartureDate;
			}
			set 
			{ 
				if (value != m_IsValidDepartureDate)
				{
					DepartureDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidDepartureDate = value;
				}
			}
		}
		protected bool m_IsValidDepartureDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DepartureDate;
		#endregion

		#region Attribute - DepartureTime
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DepartureTime", "", "IsValidDepartureTime", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_time, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d\\d:\\d\\d(:\\d\\d)?", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DepartureTime
		{
			get 
			{ 
				if (m_IsValidDepartureTime == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DepartureTime is not valid. Set DepartureTimeValid = true");
				return m_DepartureTime;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DepartureTime"); // remove selection
				m_IsValidDepartureTime = true;
				m_DepartureTime.SetDateTime(value, m_DepartureTime.Type); 
			}
		}
		/// <summary>
		/// Indicates if DepartureTime contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DepartureTime is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time)).
		/// If its set to false then its made invalid, and subsequent calls to get DepartureTime
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDepartureTime
		{
			get
			{
				return m_IsValidDepartureTime;
			}
			set 
			{ 
				if (value != m_IsValidDepartureTime)
				{
					DepartureTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
					m_IsValidDepartureTime = value;
				}
			}
		}
		protected bool m_IsValidDepartureTime;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DepartureTime;
		#endregion

		#region Attribute - ArrivalDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ArrivalDate", "", "IsValidArrivalDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime ArrivalDate
		{
			get 
			{ 
				if (m_IsValidArrivalDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ArrivalDate is not valid. Set ArrivalDateValid = true");
				return m_ArrivalDate;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ArrivalDate"); // remove selection
				m_IsValidArrivalDate = true;
				m_ArrivalDate.SetDateTime(value, m_ArrivalDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if ArrivalDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ArrivalDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get ArrivalDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidArrivalDate
		{
			get
			{
				return m_IsValidArrivalDate;
			}
			set 
			{ 
				if (value != m_IsValidArrivalDate)
				{
					ArrivalDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidArrivalDate = value;
				}
			}
		}
		protected bool m_IsValidArrivalDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_ArrivalDate;
		#endregion

		#region Attribute - ArrivalTime
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ArrivalTime", "", "IsValidArrivalTime", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_time, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d\\d:\\d\\d(:\\d\\d)?", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime ArrivalTime
		{
			get 
			{ 
				if (m_IsValidArrivalTime == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ArrivalTime is not valid. Set ArrivalTimeValid = true");
				return m_ArrivalTime;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ArrivalTime"); // remove selection
				m_IsValidArrivalTime = true;
				m_ArrivalTime.SetDateTime(value, m_ArrivalTime.Type); 
			}
		}
		/// <summary>
		/// Indicates if ArrivalTime contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ArrivalTime is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time)).
		/// If its set to false then its made invalid, and subsequent calls to get ArrivalTime
		/// will raise an exception.
		/// </remarks>
		public bool IsValidArrivalTime
		{
			get
			{
				return m_IsValidArrivalTime;
			}
			set 
			{ 
				if (value != m_IsValidArrivalTime)
				{
					ArrivalTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
					m_IsValidArrivalTime = value;
				}
			}
		}
		protected bool m_IsValidArrivalTime;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_ArrivalTime;
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


