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
	/// This class represents the Element DespatchAdvice-Parties_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DespatchAdvice-Parties_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DespatchAdvice_Parties_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for DespatchAdvice_Parties_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public DespatchAdvice_Parties_Group()
		{
			_elementName = "DespatchAdvice-Parties_Group";
			Init();
		}
		public DespatchAdvice_Parties_Group(string elementName)
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
			m_Buyer = null;
			m_Seller = null;
			m_DeliveryPoint = null;
			m_UltimateCustomer = null;
			m_OrderRecipient = null;
			m_Payer = null;
			m_Consignor = null;
			m_ShipFrom = null;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Buyer = null;
			m_Seller = null;
			m_DeliveryPoint = null;
			m_UltimateCustomer = null;
			m_OrderRecipient = null;
			m_Payer = null;
			m_Consignor = null;
			m_ShipFrom = null;
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
			DESADV_XSDLib.DespatchAdvice_Parties_Group newObject = new DESADV_XSDLib.DespatchAdvice_Parties_Group(_elementName);
			newObject.m_Buyer = null;
			if (m_Buyer != null)
				newObject.m_Buyer = (DESADV_XSDLib.Buyer)m_Buyer.Clone();
			newObject.m_Seller = null;
			if (m_Seller != null)
				newObject.m_Seller = (DESADV_XSDLib.Seller)m_Seller.Clone();
			newObject.m_DeliveryPoint = null;
			if (m_DeliveryPoint != null)
				newObject.m_DeliveryPoint = (DESADV_XSDLib.DeliveryPoint)m_DeliveryPoint.Clone();
			newObject.m_UltimateCustomer = null;
			if (m_UltimateCustomer != null)
				newObject.m_UltimateCustomer = (DESADV_XSDLib.UltimateCustomer)m_UltimateCustomer.Clone();
			newObject.m_OrderRecipient = null;
			if (m_OrderRecipient != null)
				newObject.m_OrderRecipient = (DESADV_XSDLib.OrderRecipient)m_OrderRecipient.Clone();
			newObject.m_Payer = null;
			if (m_Payer != null)
				newObject.m_Payer = (DESADV_XSDLib.Payer)m_Payer.Clone();
			newObject.m_Consignor = null;
			if (m_Consignor != null)
				newObject.m_Consignor = (DESADV_XSDLib.Consignor)m_Consignor.Clone();
			newObject.m_ShipFrom = null;
			if (m_ShipFrom != null)
				newObject.m_ShipFrom = (DESADV_XSDLib.ShipFrom)m_ShipFrom.Clone();

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

		#region Attribute - Buyer
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Buyer", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Buyer))]
		public DESADV_XSDLib.Buyer Buyer
		{
			get
			{ 
				return m_Buyer;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Buyer"); // remove selection
				if (value == null)
					m_Buyer = null;
				else
				{
					m_Buyer = value; 
				}
			}
		}
		protected DESADV_XSDLib.Buyer m_Buyer;
		
		#endregion

		#region Attribute - Seller
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Seller", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Seller))]
		public DESADV_XSDLib.Seller Seller
		{
			get
			{ 
				return m_Seller;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Seller"); // remove selection
				if (value == null)
					m_Seller = null;
				else
				{
					m_Seller = value; 
				}
			}
		}
		protected DESADV_XSDLib.Seller m_Seller;
		
		#endregion

		#region Attribute - DeliveryPoint
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DeliveryPoint", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.DeliveryPoint))]
		public DESADV_XSDLib.DeliveryPoint DeliveryPoint
		{
			get
			{ 
				return m_DeliveryPoint;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DeliveryPoint"); // remove selection
				if (value == null)
					m_DeliveryPoint = null;
				else
				{
					m_DeliveryPoint = value; 
				}
			}
		}
		protected DESADV_XSDLib.DeliveryPoint m_DeliveryPoint;
		
		#endregion

		#region Attribute - UltimateCustomer
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("UltimateCustomer", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.UltimateCustomer))]
		public DESADV_XSDLib.UltimateCustomer UltimateCustomer
		{
			get
			{ 
				return m_UltimateCustomer;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"UltimateCustomer"); // remove selection
				if (value == null)
					m_UltimateCustomer = null;
				else
				{
					m_UltimateCustomer = value; 
				}
			}
		}
		protected DESADV_XSDLib.UltimateCustomer m_UltimateCustomer;
		
		#endregion

		#region Attribute - OrderRecipient
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("OrderRecipient", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.OrderRecipient))]
		public DESADV_XSDLib.OrderRecipient OrderRecipient
		{
			get
			{ 
				return m_OrderRecipient;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"OrderRecipient"); // remove selection
				if (value == null)
					m_OrderRecipient = null;
				else
				{
					m_OrderRecipient = value; 
				}
			}
		}
		protected DESADV_XSDLib.OrderRecipient m_OrderRecipient;
		
		#endregion

		#region Attribute - Payer
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Payer", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Payer))]
		public DESADV_XSDLib.Payer Payer
		{
			get
			{ 
				return m_Payer;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Payer"); // remove selection
				if (value == null)
					m_Payer = null;
				else
				{
					m_Payer = value; 
				}
			}
		}
		protected DESADV_XSDLib.Payer m_Payer;
		
		#endregion

		#region Attribute - Consignor
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Consignor", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Consignor))]
		public DESADV_XSDLib.Consignor Consignor
		{
			get
			{ 
				return m_Consignor;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Consignor"); // remove selection
				if (value == null)
					m_Consignor = null;
				else
				{
					m_Consignor = value; 
				}
			}
		}
		protected DESADV_XSDLib.Consignor m_Consignor;
		
		#endregion

		#region Attribute - ShipFrom
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("ShipFrom", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.ShipFrom))]
		public DESADV_XSDLib.ShipFrom ShipFrom
		{
			get
			{ 
				return m_ShipFrom;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ShipFrom"); // remove selection
				if (value == null)
					m_ShipFrom = null;
				else
				{
					m_ShipFrom = value; 
				}
			}
		}
		protected DESADV_XSDLib.ShipFrom m_ShipFrom;
		
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


