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
	/// This class represents the Element DespatchAdvice-Header_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DespatchAdvice-Header_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DespatchAdvice_Header_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for DespatchAdvice_Header_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public DespatchAdvice_Header_Group()
		{
			_elementName = "DespatchAdvice-Header_Group";
			Init();
		}
		public DespatchAdvice_Header_Group(string elementName)
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
			m_DespatchAdviceNumber = "";
			m_IsValidDespatchAdviceNumber = false;
			m_DespatchAdviceDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDespatchAdviceDate = false;
			m_DespatchAdviceTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidDespatchAdviceTime = false;
			m_EstimatedDeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidEstimatedDeliveryDate = false;
			m_EstimatedDeliveryTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidEstimatedDeliveryTime = false;
			m_DeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDeliveryDate = false;
			m_CollectionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidCollectionDate = false;
			m_DeliveryScheduledDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDeliveryScheduledDate = false;
			m_BuyerOrderNumber = "";
			m_IsValidBuyerOrderNumber = false;
			m_BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBuyerOrderDate = false;
			m_SupplierOrderNumber = "";
			m_IsValidSupplierOrderNumber = false;
			m_SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidSupplierOrderDate = false;
			m_DespatchNumber = "";
			m_IsValidDespatchNumber = false;
			m_DespatchDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDespatchDate = false;
			m_InvoiceNumber = "";
			m_IsValidInvoiceNumber = false;
			m_ContractNumber = "";
			m_IsValidContractNumber = false;
			m_ContractDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidContractDate = false;
			m_PromotionReference = "";
			m_IsValidPromotionReference = false;
			m_DocumentFunctionCode = DESADV_XSDLib.Enumerations.DocumentFunctionCode.O;
			m_IsValidDocumentFunctionCode = false;
			m_Currency = "";
			m_IsValidCurrency = false;
			m_Remarks = "";
			m_IsValidRemarks = false;
			m_TransportDetails = null;
			m_Order_Measurement = null;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DespatchAdviceNumber = "";
			m_IsValidDespatchAdviceNumber = false;
			m_DespatchAdviceDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDespatchAdviceDate = false;
			m_DespatchAdviceTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidDespatchAdviceTime = false;
			m_EstimatedDeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidEstimatedDeliveryDate = false;
			m_EstimatedDeliveryTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
			m_IsValidEstimatedDeliveryTime = false;
			m_DeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDeliveryDate = false;
			m_CollectionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidCollectionDate = false;
			m_DeliveryScheduledDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDeliveryScheduledDate = false;
			m_BuyerOrderNumber = "";
			m_IsValidBuyerOrderNumber = false;
			m_BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBuyerOrderDate = false;
			m_SupplierOrderNumber = "";
			m_IsValidSupplierOrderNumber = false;
			m_SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidSupplierOrderDate = false;
			m_DespatchNumber = "";
			m_IsValidDespatchNumber = false;
			m_DespatchDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidDespatchDate = false;
			m_InvoiceNumber = "";
			m_IsValidInvoiceNumber = false;
			m_ContractNumber = "";
			m_IsValidContractNumber = false;
			m_ContractDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidContractDate = false;
			m_PromotionReference = "";
			m_IsValidPromotionReference = false;
			m_DocumentFunctionCode = DESADV_XSDLib.Enumerations.DocumentFunctionCode.O;
			m_IsValidDocumentFunctionCode = false;
			m_Currency = "";
			m_IsValidCurrency = false;
			m_Remarks = "";
			m_IsValidRemarks = false;
			m_TransportDetails = null;
			m_Order_Measurement = null;
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
			DESADV_XSDLib.DespatchAdvice_Header_Group newObject = new DESADV_XSDLib.DespatchAdvice_Header_Group(_elementName);
			newObject.m_DespatchAdviceNumber = m_DespatchAdviceNumber;
			newObject.m_IsValidDespatchAdviceNumber = m_IsValidDespatchAdviceNumber;
			newObject.m_DespatchAdviceDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DespatchAdviceDate.Clone();
			newObject.m_IsValidDespatchAdviceDate = m_IsValidDespatchAdviceDate;
			newObject.m_DespatchAdviceTime = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DespatchAdviceTime.Clone();
			newObject.m_IsValidDespatchAdviceTime = m_IsValidDespatchAdviceTime;
			newObject.m_EstimatedDeliveryDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_EstimatedDeliveryDate.Clone();
			newObject.m_IsValidEstimatedDeliveryDate = m_IsValidEstimatedDeliveryDate;
			newObject.m_EstimatedDeliveryTime = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_EstimatedDeliveryTime.Clone();
			newObject.m_IsValidEstimatedDeliveryTime = m_IsValidEstimatedDeliveryTime;
			newObject.m_DeliveryDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DeliveryDate.Clone();
			newObject.m_IsValidDeliveryDate = m_IsValidDeliveryDate;
			newObject.m_CollectionDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_CollectionDate.Clone();
			newObject.m_IsValidCollectionDate = m_IsValidCollectionDate;
			newObject.m_DeliveryScheduledDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DeliveryScheduledDate.Clone();
			newObject.m_IsValidDeliveryScheduledDate = m_IsValidDeliveryScheduledDate;
			newObject.m_BuyerOrderNumber = m_BuyerOrderNumber;
			newObject.m_IsValidBuyerOrderNumber = m_IsValidBuyerOrderNumber;
			newObject.m_BuyerOrderDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_BuyerOrderDate.Clone();
			newObject.m_IsValidBuyerOrderDate = m_IsValidBuyerOrderDate;
			newObject.m_SupplierOrderNumber = m_SupplierOrderNumber;
			newObject.m_IsValidSupplierOrderNumber = m_IsValidSupplierOrderNumber;
			newObject.m_SupplierOrderDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_SupplierOrderDate.Clone();
			newObject.m_IsValidSupplierOrderDate = m_IsValidSupplierOrderDate;
			newObject.m_DespatchNumber = m_DespatchNumber;
			newObject.m_IsValidDespatchNumber = m_IsValidDespatchNumber;
			newObject.m_DespatchDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_DespatchDate.Clone();
			newObject.m_IsValidDespatchDate = m_IsValidDespatchDate;
			newObject.m_InvoiceNumber = m_InvoiceNumber;
			newObject.m_IsValidInvoiceNumber = m_IsValidInvoiceNumber;
			newObject.m_ContractNumber = m_ContractNumber;
			newObject.m_IsValidContractNumber = m_IsValidContractNumber;
			newObject.m_ContractDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_ContractDate.Clone();
			newObject.m_IsValidContractDate = m_IsValidContractDate;
			newObject.m_PromotionReference = m_PromotionReference;
			newObject.m_IsValidPromotionReference = m_IsValidPromotionReference;
			newObject.m_DocumentFunctionCode = m_DocumentFunctionCode;
			newObject.m_IsValidDocumentFunctionCode = m_IsValidDocumentFunctionCode;
			newObject.m_Currency = m_Currency;
			newObject.m_IsValidCurrency = m_IsValidCurrency;
			newObject.m_Remarks = m_Remarks;
			newObject.m_IsValidRemarks = m_IsValidRemarks;
			newObject.m_TransportDetails = null;
			if (m_TransportDetails != null)
				newObject.m_TransportDetails = (DESADV_XSDLib.TransportDetails)m_TransportDetails.Clone();
			newObject.m_Order_Measurement = null;
			if (m_Order_Measurement != null)
				newObject.m_Order_Measurement = (DESADV_XSDLib.Order_Measurement)m_Order_Measurement.Clone();

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

		#region Attribute - DespatchAdviceNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchAdviceNumber", "", "IsValidDespatchAdviceNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "25", "", "", "", "", "-1")]
		public string DespatchAdviceNumber
		{
			get 
			{ 
				if (m_IsValidDespatchAdviceNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchAdviceNumber is not valid. Set DespatchAdviceNumberValid = true");
				return m_DespatchAdviceNumber;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchAdviceNumber"); // remove selection
				m_IsValidDespatchAdviceNumber = true;
				m_DespatchAdviceNumber = value;
			}
		}
		/// <summary>
		/// Indicates if DespatchAdviceNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchAdviceNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DespatchAdviceNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchAdviceNumber
		{
			get
			{
				return m_IsValidDespatchAdviceNumber;
			}
			set 
			{ 
				if (value != m_IsValidDespatchAdviceNumber)
				{
					DespatchAdviceNumber = "";
					m_IsValidDespatchAdviceNumber = value;
				}
			}
		}
		protected bool m_IsValidDespatchAdviceNumber;
		protected string m_DespatchAdviceNumber;
		#endregion

		#region Attribute - DespatchAdviceDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchAdviceDate", "", "IsValidDespatchAdviceDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DespatchAdviceDate
		{
			get 
			{ 
				if (m_IsValidDespatchAdviceDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchAdviceDate is not valid. Set DespatchAdviceDateValid = true");
				return m_DespatchAdviceDate;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchAdviceDate"); // remove selection
				m_IsValidDespatchAdviceDate = true;
				m_DespatchAdviceDate.SetDateTime(value, m_DespatchAdviceDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if DespatchAdviceDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchAdviceDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchAdviceDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchAdviceDate
		{
			get
			{
				return m_IsValidDespatchAdviceDate;
			}
			set 
			{ 
				if (value != m_IsValidDespatchAdviceDate)
				{
					DespatchAdviceDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidDespatchAdviceDate = value;
				}
			}
		}
		protected bool m_IsValidDespatchAdviceDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DespatchAdviceDate;
		#endregion

		#region Attribute - DespatchAdviceTime
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchAdviceTime", "", "IsValidDespatchAdviceTime", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_time, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d\\d:\\d\\d(:\\d\\d)?", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DespatchAdviceTime
		{
			get 
			{ 
				if (m_IsValidDespatchAdviceTime == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchAdviceTime is not valid. Set DespatchAdviceTimeValid = true");
				return m_DespatchAdviceTime;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchAdviceTime"); // remove selection
				m_IsValidDespatchAdviceTime = true;
				m_DespatchAdviceTime.SetDateTime(value, m_DespatchAdviceTime.Type); 
			}
		}
		/// <summary>
		/// Indicates if DespatchAdviceTime contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchAdviceTime is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time)).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchAdviceTime
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchAdviceTime
		{
			get
			{
				return m_IsValidDespatchAdviceTime;
			}
			set 
			{ 
				if (value != m_IsValidDespatchAdviceTime)
				{
					DespatchAdviceTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
					m_IsValidDespatchAdviceTime = value;
				}
			}
		}
		protected bool m_IsValidDespatchAdviceTime;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DespatchAdviceTime;
		#endregion

		#region Attribute - EstimatedDeliveryDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("EstimatedDeliveryDate", "", "IsValidEstimatedDeliveryDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime EstimatedDeliveryDate
		{
			get 
			{ 
				if (m_IsValidEstimatedDeliveryDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property EstimatedDeliveryDate is not valid. Set EstimatedDeliveryDateValid = true");
				return m_EstimatedDeliveryDate;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("EstimatedDeliveryDate"); // remove selection
				m_IsValidEstimatedDeliveryDate = true;
				m_EstimatedDeliveryDate.SetDateTime(value, m_EstimatedDeliveryDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if EstimatedDeliveryDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for EstimatedDeliveryDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get EstimatedDeliveryDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidEstimatedDeliveryDate
		{
			get
			{
				return m_IsValidEstimatedDeliveryDate;
			}
			set 
			{ 
				if (value != m_IsValidEstimatedDeliveryDate)
				{
					EstimatedDeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidEstimatedDeliveryDate = value;
				}
			}
		}
		protected bool m_IsValidEstimatedDeliveryDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_EstimatedDeliveryDate;
		#endregion

		#region Attribute - EstimatedDeliveryTime
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("EstimatedDeliveryTime", "", "IsValidEstimatedDeliveryTime", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_time, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d\\d:\\d\\d(:\\d\\d)?", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime EstimatedDeliveryTime
		{
			get 
			{ 
				if (m_IsValidEstimatedDeliveryTime == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property EstimatedDeliveryTime is not valid. Set EstimatedDeliveryTimeValid = true");
				return m_EstimatedDeliveryTime;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("EstimatedDeliveryTime"); // remove selection
				m_IsValidEstimatedDeliveryTime = true;
				m_EstimatedDeliveryTime.SetDateTime(value, m_EstimatedDeliveryTime.Type); 
			}
		}
		/// <summary>
		/// Indicates if EstimatedDeliveryTime contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for EstimatedDeliveryTime is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time)).
		/// If its set to false then its made invalid, and subsequent calls to get EstimatedDeliveryTime
		/// will raise an exception.
		/// </remarks>
		public bool IsValidEstimatedDeliveryTime
		{
			get
			{
				return m_IsValidEstimatedDeliveryTime;
			}
			set 
			{ 
				if (value != m_IsValidEstimatedDeliveryTime)
				{
					EstimatedDeliveryTime = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.time);
					m_IsValidEstimatedDeliveryTime = value;
				}
			}
		}
		protected bool m_IsValidEstimatedDeliveryTime;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_EstimatedDeliveryTime;
		#endregion

		#region Attribute - DeliveryDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DeliveryDate", "", "IsValidDeliveryDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DeliveryDate
		{
			get 
			{ 
				if (m_IsValidDeliveryDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DeliveryDate is not valid. Set DeliveryDateValid = true");
				return m_DeliveryDate;  
			}
			set 
			{ 
				CheckElementRestriction(5, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DeliveryDate"); // remove selection
				m_IsValidDeliveryDate = true;
				m_DeliveryDate.SetDateTime(value, m_DeliveryDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if DeliveryDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DeliveryDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get DeliveryDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDeliveryDate
		{
			get
			{
				return m_IsValidDeliveryDate;
			}
			set 
			{ 
				if (value != m_IsValidDeliveryDate)
				{
					DeliveryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidDeliveryDate = value;
				}
			}
		}
		protected bool m_IsValidDeliveryDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DeliveryDate;
		#endregion

		#region Attribute - CollectionDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CollectionDate", "", "IsValidCollectionDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime CollectionDate
		{
			get 
			{ 
				if (m_IsValidCollectionDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CollectionDate is not valid. Set CollectionDateValid = true");
				return m_CollectionDate;  
			}
			set 
			{ 
				CheckElementRestriction(6, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CollectionDate"); // remove selection
				m_IsValidCollectionDate = true;
				m_CollectionDate.SetDateTime(value, m_CollectionDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if CollectionDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CollectionDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get CollectionDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCollectionDate
		{
			get
			{
				return m_IsValidCollectionDate;
			}
			set 
			{ 
				if (value != m_IsValidCollectionDate)
				{
					CollectionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidCollectionDate = value;
				}
			}
		}
		protected bool m_IsValidCollectionDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_CollectionDate;
		#endregion

		#region Attribute - DeliveryScheduledDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DeliveryScheduledDate", "", "IsValidDeliveryScheduledDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DeliveryScheduledDate
		{
			get 
			{ 
				if (m_IsValidDeliveryScheduledDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DeliveryScheduledDate is not valid. Set DeliveryScheduledDateValid = true");
				return m_DeliveryScheduledDate;  
			}
			set 
			{ 
				CheckElementRestriction(7, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DeliveryScheduledDate"); // remove selection
				m_IsValidDeliveryScheduledDate = true;
				m_DeliveryScheduledDate.SetDateTime(value, m_DeliveryScheduledDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if DeliveryScheduledDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DeliveryScheduledDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get DeliveryScheduledDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDeliveryScheduledDate
		{
			get
			{
				return m_IsValidDeliveryScheduledDate;
			}
			set 
			{ 
				if (value != m_IsValidDeliveryScheduledDate)
				{
					DeliveryScheduledDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidDeliveryScheduledDate = value;
				}
			}
		}
		protected bool m_IsValidDeliveryScheduledDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DeliveryScheduledDate;
		#endregion

		#region Attribute - BuyerOrderNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BuyerOrderNumber", "", "IsValidBuyerOrderNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string BuyerOrderNumber
		{
			get 
			{ 
				if (m_IsValidBuyerOrderNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BuyerOrderNumber is not valid. Set BuyerOrderNumberValid = true");
				return m_BuyerOrderNumber;  
			}
			set 
			{ 
				CheckElementRestriction(8, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BuyerOrderNumber"); // remove selection
				m_IsValidBuyerOrderNumber = true;
				m_BuyerOrderNumber = value;
			}
		}
		/// <summary>
		/// Indicates if BuyerOrderNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BuyerOrderNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get BuyerOrderNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBuyerOrderNumber
		{
			get
			{
				return m_IsValidBuyerOrderNumber;
			}
			set 
			{ 
				if (value != m_IsValidBuyerOrderNumber)
				{
					BuyerOrderNumber = "";
					m_IsValidBuyerOrderNumber = value;
				}
			}
		}
		protected bool m_IsValidBuyerOrderNumber;
		protected string m_BuyerOrderNumber;
		#endregion

		#region Attribute - BuyerOrderDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BuyerOrderDate", "", "IsValidBuyerOrderDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime BuyerOrderDate
		{
			get 
			{ 
				if (m_IsValidBuyerOrderDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BuyerOrderDate is not valid. Set BuyerOrderDateValid = true");
				return m_BuyerOrderDate;  
			}
			set 
			{ 
				CheckElementRestriction(9, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BuyerOrderDate"); // remove selection
				m_IsValidBuyerOrderDate = true;
				m_BuyerOrderDate.SetDateTime(value, m_BuyerOrderDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if BuyerOrderDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BuyerOrderDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get BuyerOrderDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBuyerOrderDate
		{
			get
			{
				return m_IsValidBuyerOrderDate;
			}
			set 
			{ 
				if (value != m_IsValidBuyerOrderDate)
				{
					BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidBuyerOrderDate = value;
				}
			}
		}
		protected bool m_IsValidBuyerOrderDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_BuyerOrderDate;
		#endregion

		#region Attribute - SupplierOrderNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierOrderNumber", "", "IsValidSupplierOrderNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string SupplierOrderNumber
		{
			get 
			{ 
				if (m_IsValidSupplierOrderNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierOrderNumber is not valid. Set SupplierOrderNumberValid = true");
				return m_SupplierOrderNumber;  
			}
			set 
			{ 
				CheckElementRestriction(10, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierOrderNumber"); // remove selection
				m_IsValidSupplierOrderNumber = true;
				m_SupplierOrderNumber = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierOrderNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierOrderNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierOrderNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierOrderNumber
		{
			get
			{
				return m_IsValidSupplierOrderNumber;
			}
			set 
			{ 
				if (value != m_IsValidSupplierOrderNumber)
				{
					SupplierOrderNumber = "";
					m_IsValidSupplierOrderNumber = value;
				}
			}
		}
		protected bool m_IsValidSupplierOrderNumber;
		protected string m_SupplierOrderNumber;
		#endregion

		#region Attribute - SupplierOrderDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierOrderDate", "", "IsValidSupplierOrderDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime SupplierOrderDate
		{
			get 
			{ 
				if (m_IsValidSupplierOrderDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierOrderDate is not valid. Set SupplierOrderDateValid = true");
				return m_SupplierOrderDate;  
			}
			set 
			{ 
				CheckElementRestriction(11, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierOrderDate"); // remove selection
				m_IsValidSupplierOrderDate = true;
				m_SupplierOrderDate.SetDateTime(value, m_SupplierOrderDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if SupplierOrderDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierOrderDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get SupplierOrderDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierOrderDate
		{
			get
			{
				return m_IsValidSupplierOrderDate;
			}
			set 
			{ 
				if (value != m_IsValidSupplierOrderDate)
				{
					SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidSupplierOrderDate = value;
				}
			}
		}
		protected bool m_IsValidSupplierOrderDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_SupplierOrderDate;
		#endregion

		#region Attribute - DespatchNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchNumber", "", "IsValidDespatchNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string DespatchNumber
		{
			get 
			{ 
				if (m_IsValidDespatchNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchNumber is not valid. Set DespatchNumberValid = true");
				return m_DespatchNumber;  
			}
			set 
			{ 
				CheckElementRestriction(12, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchNumber"); // remove selection
				m_IsValidDespatchNumber = true;
				m_DespatchNumber = value;
			}
		}
		/// <summary>
		/// Indicates if DespatchNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DespatchNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchNumber
		{
			get
			{
				return m_IsValidDespatchNumber;
			}
			set 
			{ 
				if (value != m_IsValidDespatchNumber)
				{
					DespatchNumber = "";
					m_IsValidDespatchNumber = value;
				}
			}
		}
		protected bool m_IsValidDespatchNumber;
		protected string m_DespatchNumber;
		#endregion

		#region Attribute - DespatchDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchDate", "", "IsValidDespatchDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime DespatchDate
		{
			get 
			{ 
				if (m_IsValidDespatchDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchDate is not valid. Set DespatchDateValid = true");
				return m_DespatchDate;  
			}
			set 
			{ 
				CheckElementRestriction(13, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchDate"); // remove selection
				m_IsValidDespatchDate = true;
				m_DespatchDate.SetDateTime(value, m_DespatchDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if DespatchDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchDate
		{
			get
			{
				return m_IsValidDespatchDate;
			}
			set 
			{ 
				if (value != m_IsValidDespatchDate)
				{
					DespatchDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidDespatchDate = value;
				}
			}
		}
		protected bool m_IsValidDespatchDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_DespatchDate;
		#endregion

		#region Attribute - InvoiceNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("InvoiceNumber", "", "IsValidInvoiceNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string InvoiceNumber
		{
			get 
			{ 
				if (m_IsValidInvoiceNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property InvoiceNumber is not valid. Set InvoiceNumberValid = true");
				return m_InvoiceNumber;  
			}
			set 
			{ 
				CheckElementRestriction(14, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("InvoiceNumber"); // remove selection
				m_IsValidInvoiceNumber = true;
				m_InvoiceNumber = value;
			}
		}
		/// <summary>
		/// Indicates if InvoiceNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for InvoiceNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get InvoiceNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidInvoiceNumber
		{
			get
			{
				return m_IsValidInvoiceNumber;
			}
			set 
			{ 
				if (value != m_IsValidInvoiceNumber)
				{
					InvoiceNumber = "";
					m_IsValidInvoiceNumber = value;
				}
			}
		}
		protected bool m_IsValidInvoiceNumber;
		protected string m_InvoiceNumber;
		#endregion

		#region Attribute - ContractNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ContractNumber", "", "IsValidContractNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "70", "", "", "", "", "-1")]
		public string ContractNumber
		{
			get 
			{ 
				if (m_IsValidContractNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ContractNumber is not valid. Set ContractNumberValid = true");
				return m_ContractNumber;  
			}
			set 
			{ 
				CheckElementRestriction(15, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ContractNumber"); // remove selection
				m_IsValidContractNumber = true;
				m_ContractNumber = value;
			}
		}
		/// <summary>
		/// Indicates if ContractNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ContractNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ContractNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidContractNumber
		{
			get
			{
				return m_IsValidContractNumber;
			}
			set 
			{ 
				if (value != m_IsValidContractNumber)
				{
					ContractNumber = "";
					m_IsValidContractNumber = value;
				}
			}
		}
		protected bool m_IsValidContractNumber;
		protected string m_ContractNumber;
		#endregion

		#region Attribute - ContractDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ContractDate", "", "IsValidContractDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime ContractDate
		{
			get 
			{ 
				if (m_IsValidContractDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ContractDate is not valid. Set ContractDateValid = true");
				return m_ContractDate;  
			}
			set 
			{ 
				CheckElementRestriction(16, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ContractDate"); // remove selection
				m_IsValidContractDate = true;
				m_ContractDate.SetDateTime(value, m_ContractDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if ContractDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ContractDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get ContractDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidContractDate
		{
			get
			{
				return m_IsValidContractDate;
			}
			set 
			{ 
				if (value != m_IsValidContractDate)
				{
					ContractDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidContractDate = value;
				}
			}
		}
		protected bool m_IsValidContractDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_ContractDate;
		#endregion

		#region Attribute - PromotionReference
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PromotionReference", "", "IsValidPromotionReference", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string PromotionReference
		{
			get 
			{ 
				if (m_IsValidPromotionReference == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PromotionReference is not valid. Set PromotionReferenceValid = true");
				return m_PromotionReference;  
			}
			set 
			{ 
				CheckElementRestriction(17, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PromotionReference"); // remove selection
				m_IsValidPromotionReference = true;
				m_PromotionReference = value;
			}
		}
		/// <summary>
		/// Indicates if PromotionReference contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PromotionReference is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PromotionReference
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPromotionReference
		{
			get
			{
				return m_IsValidPromotionReference;
			}
			set 
			{ 
				if (value != m_IsValidPromotionReference)
				{
					PromotionReference = "";
					m_IsValidPromotionReference = value;
				}
			}
		}
		protected bool m_IsValidPromotionReference;
		protected string m_PromotionReference;
		#endregion

		#region Attribute - DocumentFunctionCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. Set DocumentFunctionCodeValid = false to de-select this element
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceEnumOpt("DocumentFunctionCode", "", "IsValidDocumentFunctionCode", null, typeof(DESADV_XSDLib.Enumerations), "DocumentFunctionCodeFromString", "DocumentFunctionCodeToString")]
		public DESADV_XSDLib.Enumerations.DocumentFunctionCode DocumentFunctionCode
		{
			get
			{
				if (m_IsValidDocumentFunctionCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DocumentFunctionCode is not valid. Set DocumentFunctionCodeValid = true");
				return m_DocumentFunctionCode;
			}
			set
			{
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DocumentFunctionCode"); // remove selection
				m_DocumentFunctionCode = value;
				m_IsValidDocumentFunctionCode = true;
			}
		}
		/// <summary>
		/// Indicates if DocumentFunctionCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DocumentFunctionCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (DESADV_XSDLib.Enumerations.DocumentFunctionCode.O).
		/// If its set to false then its made invalid, and subsequent calls to get DocumentFunctionCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDocumentFunctionCode
		{
			get { return m_IsValidDocumentFunctionCode;  }
			set 
			{ 
				if (value != m_IsValidDocumentFunctionCode)
				{
					// Ensure only one element at a time is populated
					Choice_SetElementValid(value, "DocumentFunctionCode", ref _validElement);
					DocumentFunctionCode = DESADV_XSDLib.Enumerations.DocumentFunctionCode.O;
					m_IsValidDocumentFunctionCode = value;
				}
			}
		}
		protected DESADV_XSDLib.Enumerations.DocumentFunctionCode m_DocumentFunctionCode;
		protected bool m_IsValidDocumentFunctionCode;

		#endregion

		#region Attribute - Currency
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Currency", "", "IsValidCurrency", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "3", "", "", "", "", "-1")]
		public string Currency
		{
			get 
			{ 
				if (m_IsValidCurrency == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Currency is not valid. Set CurrencyValid = true");
				return m_Currency;  
			}
			set 
			{ 
				CheckElementRestriction(19, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("Currency"); // remove selection
				m_IsValidCurrency = true;
				m_Currency = value;
			}
		}
		/// <summary>
		/// Indicates if Currency contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for Currency is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get Currency
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCurrency
		{
			get
			{
				return m_IsValidCurrency;
			}
			set 
			{ 
				if (value != m_IsValidCurrency)
				{
					Currency = "";
					m_IsValidCurrency = value;
				}
			}
		}
		protected bool m_IsValidCurrency;
		protected string m_Currency;
		#endregion

		#region Attribute - Remarks
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Remarks", "", "IsValidRemarks", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string Remarks
		{
			get 
			{ 
				if (m_IsValidRemarks == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Remarks is not valid. Set RemarksValid = true");
				return m_Remarks;  
			}
			set 
			{ 
				CheckElementRestriction(20, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("Remarks"); // remove selection
				m_IsValidRemarks = true;
				m_Remarks = value;
			}
		}
		/// <summary>
		/// Indicates if Remarks contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for Remarks is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get Remarks
		/// will raise an exception.
		/// </remarks>
		public bool IsValidRemarks
		{
			get
			{
				return m_IsValidRemarks;
			}
			set 
			{ 
				if (value != m_IsValidRemarks)
				{
					Remarks = "";
					m_IsValidRemarks = value;
				}
			}
		}
		protected bool m_IsValidRemarks;
		protected string m_Remarks;
		#endregion

		#region Attribute - TransportDetails
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TransportDetails", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.TransportDetails))]
		public DESADV_XSDLib.TransportDetails TransportDetails
		{
			get
			{ 
				return m_TransportDetails;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TransportDetails"); // remove selection
				if (value == null)
					m_TransportDetails = null;
				else
				{
					m_TransportDetails = value; 
				}
			}
		}
		protected DESADV_XSDLib.TransportDetails m_TransportDetails;
		
		#endregion

		#region Attribute - Order-Measurement
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Order-Measurement", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Order_Measurement))]
		public DESADV_XSDLib.Order_Measurement Order_Measurement
		{
			get
			{ 
				return m_Order_Measurement;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Order_Measurement"); // remove selection
				if (value == null)
					m_Order_Measurement = null;
				else
				{
					m_Order_Measurement = value; 
				}
			}
		}
		protected DESADV_XSDLib.Order_Measurement m_Order_Measurement;
		
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


