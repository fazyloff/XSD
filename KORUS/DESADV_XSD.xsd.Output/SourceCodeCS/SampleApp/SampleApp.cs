using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LiquidTechnologies.Viewer.Net45;

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

namespace LiquidTechnologies.Test
{
	/// <summary>
	/// Summary description for SampleApp.
	/// </summary>
	public class SampleApp : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region btnLoad_Click - Opens the selected file - (THIS IS A GOOD PLACE TO START)
		// When an item is selected from the ListBox, this event handler is called.
		// 
		// If you specified Sample files in the Liquid XML wizard then they will be listed
		// in the switch statement.
		// If you did not specify Samples then there are 2 routes forward. You can either
		// use the "Browse for a File to Load", this will load the sample using a generic load
		// method. Alternatively you can run one of the SimpleTestXXXXX("<filename>") methods
		// This will load the file into the correct object, and display it in the viewer.
		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			switch (lstFiles.SelectedIndex)
			{
				case 0:
					if (openFileDialog.ShowDialog(this) == DialogResult.OK)
						SimpleTestLoadAnyXmlDocument(openFileDialog.FileName);
				break;
			};
			#region UNCOMMENT CODE IN THIS REGION TO LOAD YOUR SAMPLE XML FILES
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Buyer' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Buyer>
			 *     ...
			 * </Buyer>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestBuyer(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Consignor' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Consignor>
			 *     ...
			 * </Consignor>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestConsignor(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DeliveryPoint' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DeliveryPoint>
			 *     ...
			 * </DeliveryPoint>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDeliveryPoint(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Consignment' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Consignment>
			 *     ...
			 * </DespatchAdvice-Consignment>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Consignment(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Header' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Header>
			 *     ...
			 * </DespatchAdvice-Header>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Header(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Lines' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Lines>
			 *     ...
			 * </DespatchAdvice-Lines>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Lines(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Parties' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Parties>
			 *     ...
			 * </DespatchAdvice-Parties>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Parties(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Summary' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Summary>
			 *     ...
			 * </DespatchAdvice-Summary>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Summary(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'DespatchAdvice-Transport' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <DespatchAdvice-Transport>
			 *     ...
			 * </DespatchAdvice-Transport>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDespatchAdvice_Transport(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Document-DespatchAdvice' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Document-DespatchAdvice>
			 *     ...
			 * </Document-DespatchAdvice>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestDocument_DespatchAdvice(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Importer' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Importer>
			 *     ...
			 * </Importer>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestImporter(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Line' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Line>
			 *     ...
			 * </Line>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestLine(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Line-Item' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Line-Item>
			 *     ...
			 * </Line-Item>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestLine_Item(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Line-Measurements' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Line-Measurements>
			 *     ...
			 * </Line-Measurements>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestLine_Measurements(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Line-Order' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Line-Order>
			 *     ...
			 * </Line-Order>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestLine_Order(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Line-Parties' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Line-Parties>
			 *     ...
			 * </Line-Parties>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestLine_Parties(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Manufacturer' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Manufacturer>
			 *     ...
			 * </Manufacturer>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestManufacturer(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Order-Measurement' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Order-Measurement>
			 *     ...
			 * </Order-Measurement>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestOrder_Measurement(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'OrderRecipient' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <OrderRecipient>
			 *     ...
			 * </OrderRecipient>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestOrderRecipient(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Package-Reference' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Package-Reference>
			 *     ...
			 * </Package-Reference>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestPackage_Reference(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Packing-Sequence' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Packing-Sequence>
			 *     ...
			 * </Packing-Sequence>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestPacking_Sequence(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Payer' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Payer>
			 *     ...
			 * </Payer>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestPayer(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Seller' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Seller>
			 *     ...
			 * </Seller>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestSeller(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'ShipFrom' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <ShipFrom>
			 *     ...
			 * </ShipFrom>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestShipFrom(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Transport' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Transport>
			 *     ...
			 * </Transport>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestTransport(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'TransportDetails' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <TransportDetails>
			 *     ...
			 * </TransportDetails>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestTransportDetails(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'Transports' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <Transports>
			 *     ...
			 * </Transports>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestTransports(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			/* ---------------------------------------------------------------------------------
			 * This function can be used to open an XML document with a document element 
			 * (the first element in the file) named 'UltimateCustomer' 
			 * e.g. 
			 *
			 * <?xml version="1.0" encoding="UTF-8"?>
			 * <UltimateCustomer>
			 *     ...
			 * </UltimateCustomer>
			 * --------------------------------------------------------------------------------- */
			// SimpleTestUltimateCustomer(@"<UNCOMMENT & INSERT A SAMPLE XML FILENAME HERE>");
			
			#endregion
			this.Cursor = Cursors.Default;
		}
		#endregion
	
		#region Sample Functions Demonstrating Reading from an XML File
		#region SimpleTestBuyer - Demo for documents with a root <Buyer>
		// Shows a simple example of how the class Buyer
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Buyer>.
		private void SimpleTestBuyer(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Buyer elm = new DESADV_XSDLib.Buyer();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Buyer>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestConsignor - Demo for documents with a root <Consignor>
		// Shows a simple example of how the class Consignor
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Consignor>.
		private void SimpleTestConsignor(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Consignor elm = new DESADV_XSDLib.Consignor();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Consignor>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDeliveryPoint - Demo for documents with a root <DeliveryPoint>
		// Shows a simple example of how the class DeliveryPoint
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DeliveryPoint>.
		private void SimpleTestDeliveryPoint(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DeliveryPoint elm = new DESADV_XSDLib.DeliveryPoint();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DeliveryPoint>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Consignment - Demo for documents with a root <DespatchAdvice-Consignment>
		// Shows a simple example of how the class DespatchAdvice_Consignment
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Consignment>.
		private void SimpleTestDespatchAdvice_Consignment(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Consignment elm = new DESADV_XSDLib.DespatchAdvice_Consignment();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Consignment>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Header - Demo for documents with a root <DespatchAdvice-Header>
		// Shows a simple example of how the class DespatchAdvice_Header
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Header>.
		private void SimpleTestDespatchAdvice_Header(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Header elm = new DESADV_XSDLib.DespatchAdvice_Header();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Header>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Lines - Demo for documents with a root <DespatchAdvice-Lines>
		// Shows a simple example of how the class DespatchAdvice_Lines
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Lines>.
		private void SimpleTestDespatchAdvice_Lines(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Lines elm = new DESADV_XSDLib.DespatchAdvice_Lines();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Lines>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Parties - Demo for documents with a root <DespatchAdvice-Parties>
		// Shows a simple example of how the class DespatchAdvice_Parties
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Parties>.
		private void SimpleTestDespatchAdvice_Parties(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Parties elm = new DESADV_XSDLib.DespatchAdvice_Parties();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Parties>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Summary - Demo for documents with a root <DespatchAdvice-Summary>
		// Shows a simple example of how the class DespatchAdvice_Summary
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Summary>.
		private void SimpleTestDespatchAdvice_Summary(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Summary elm = new DESADV_XSDLib.DespatchAdvice_Summary();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Summary>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDespatchAdvice_Transport - Demo for documents with a root <DespatchAdvice-Transport>
		// Shows a simple example of how the class DespatchAdvice_Transport
		// can be used. This class can be used to load documents whose 
		// root (document) element is <DespatchAdvice-Transport>.
		private void SimpleTestDespatchAdvice_Transport(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.DespatchAdvice_Transport elm = new DESADV_XSDLib.DespatchAdvice_Transport();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <DespatchAdvice-Transport>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestDocument_DespatchAdvice - Demo for documents with a root <Document-DespatchAdvice>
		// Shows a simple example of how the class Document_DespatchAdvice
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Document-DespatchAdvice>.
		private void SimpleTestDocument_DespatchAdvice(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Document_DespatchAdvice elm = new DESADV_XSDLib.Document_DespatchAdvice();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Document-DespatchAdvice>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestImporter - Demo for documents with a root <Importer>
		// Shows a simple example of how the class Importer
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Importer>.
		private void SimpleTestImporter(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Importer elm = new DESADV_XSDLib.Importer();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Importer>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestLine - Demo for documents with a root <Line>
		// Shows a simple example of how the class Line
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Line>.
		private void SimpleTestLine(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Line elm = new DESADV_XSDLib.Line();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Line>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestLine_Item - Demo for documents with a root <Line-Item>
		// Shows a simple example of how the class Line_Item
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Line-Item>.
		private void SimpleTestLine_Item(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Line_Item elm = new DESADV_XSDLib.Line_Item();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Line-Item>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestLine_Measurements - Demo for documents with a root <Line-Measurements>
		// Shows a simple example of how the class Line_Measurements
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Line-Measurements>.
		private void SimpleTestLine_Measurements(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Line_Measurements elm = new DESADV_XSDLib.Line_Measurements();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Line-Measurements>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestLine_Order - Demo for documents with a root <Line-Order>
		// Shows a simple example of how the class Line_Order
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Line-Order>.
		private void SimpleTestLine_Order(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Line_Order elm = new DESADV_XSDLib.Line_Order();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Line-Order>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestLine_Parties - Demo for documents with a root <Line-Parties>
		// Shows a simple example of how the class Line_Parties
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Line-Parties>.
		private void SimpleTestLine_Parties(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Line_Parties elm = new DESADV_XSDLib.Line_Parties();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Line-Parties>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestManufacturer - Demo for documents with a root <Manufacturer>
		// Shows a simple example of how the class Manufacturer
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Manufacturer>.
		private void SimpleTestManufacturer(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Manufacturer elm = new DESADV_XSDLib.Manufacturer();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Manufacturer>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestOrder_Measurement - Demo for documents with a root <Order-Measurement>
		// Shows a simple example of how the class Order_Measurement
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Order-Measurement>.
		private void SimpleTestOrder_Measurement(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Order_Measurement elm = new DESADV_XSDLib.Order_Measurement();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Order-Measurement>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestOrderRecipient - Demo for documents with a root <OrderRecipient>
		// Shows a simple example of how the class OrderRecipient
		// can be used. This class can be used to load documents whose 
		// root (document) element is <OrderRecipient>.
		private void SimpleTestOrderRecipient(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.OrderRecipient elm = new DESADV_XSDLib.OrderRecipient();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <OrderRecipient>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestPackage_Reference - Demo for documents with a root <Package-Reference>
		// Shows a simple example of how the class Package_Reference
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Package-Reference>.
		private void SimpleTestPackage_Reference(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Package_Reference elm = new DESADV_XSDLib.Package_Reference();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Package-Reference>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestPacking_Sequence - Demo for documents with a root <Packing-Sequence>
		// Shows a simple example of how the class Packing_Sequence
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Packing-Sequence>.
		private void SimpleTestPacking_Sequence(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Packing_Sequence elm = new DESADV_XSDLib.Packing_Sequence();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Packing-Sequence>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestPayer - Demo for documents with a root <Payer>
		// Shows a simple example of how the class Payer
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Payer>.
		private void SimpleTestPayer(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Payer elm = new DESADV_XSDLib.Payer();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Payer>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestSeller - Demo for documents with a root <Seller>
		// Shows a simple example of how the class Seller
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Seller>.
		private void SimpleTestSeller(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Seller elm = new DESADV_XSDLib.Seller();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Seller>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestShipFrom - Demo for documents with a root <ShipFrom>
		// Shows a simple example of how the class ShipFrom
		// can be used. This class can be used to load documents whose 
		// root (document) element is <ShipFrom>.
		private void SimpleTestShipFrom(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.ShipFrom elm = new DESADV_XSDLib.ShipFrom();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <ShipFrom>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestTransport - Demo for documents with a root <Transport>
		// Shows a simple example of how the class Transport
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Transport>.
		private void SimpleTestTransport(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Transport elm = new DESADV_XSDLib.Transport();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Transport>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestTransportDetails - Demo for documents with a root <TransportDetails>
		// Shows a simple example of how the class TransportDetails
		// can be used. This class can be used to load documents whose 
		// root (document) element is <TransportDetails>.
		private void SimpleTestTransportDetails(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.TransportDetails elm = new DESADV_XSDLib.TransportDetails();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <TransportDetails>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestTransports - Demo for documents with a root <Transports>
		// Shows a simple example of how the class Transports
		// can be used. This class can be used to load documents whose 
		// root (document) element is <Transports>.
		private void SimpleTestTransports(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.Transports elm = new DESADV_XSDLib.Transports();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <Transports>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#region SimpleTestUltimateCustomer - Demo for documents with a root <UltimateCustomer>
		// Shows a simple example of how the class UltimateCustomer
		// can be used. This class can be used to load documents whose 
		// root (document) element is <UltimateCustomer>.
		private void SimpleTestUltimateCustomer(string filename)
		{
			try
			{
				// create an instance of the class to load the XML file into
				DESADV_XSDLib.UltimateCustomer elm = new DESADV_XSDLib.UltimateCustomer();
				
				// load the xml from a file into the object (the root element in the
				// xml document must be <UltimateCustomer>.
				elm.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion

		#region SimpleTestLoadAnyXmlDocument
		// Shows a generic way to load up an XML document.
		private void SimpleTestLoadAnyXmlDocument(string filename)
		{
			try
			{
				// load the xml from a file into the object (the root element in the
				// xml document must be a valid root Element for the schema).
				LiquidTechnologies.Runtime.Net45.XmlObjectBase elm = DESADV_XSDLib.ClassFactory.FromXmlFile(filename);

				// This will open up a viewer, allowing you to navigate the classes
				// that have been generated. 
				// Note the viewer can be used to modify properties, and provides a listing of
				// the code required to create the document it is displaying.
				SimpleViewer sv = new SimpleViewer(elm);
				sv.ShowDialog();

				// You can then add code to navigate the data held in the class.
				// When navigating this object model you should refer to the documentation
				// generated in the directory:
				// C:\BTS\XSD\KORUS\DESADV_XSD.xsd.Output\DocumentationCS\.
				// The help should be compiled into a chm before being used, (use build.bat)
				//- HTML Help Workshop is required to perform this,
				// and can be downloaded from Microsoft. The path to the help compiler (hhc.exe) 
				// may need adjusting in build.bat
				
				// ...

				////////////////////////////////////////////////////////////////////				
				// The Xml can be extracted from the class using one of 3 methods //
				////////////////////////////////////////////////////////////////////
				
				// This method will extract the xml into a string. The string is always encoded 
				// using Unicode, there a number of options allowing the headers, 
				// end of line & indenting to be set.
				string strXml = elm.ToXml();
				Console.WriteLine(strXml);
				
				// This method will extract the xml into a file. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				elm.ToXmlFile(filename + ".testouput.xml");
				
				// This method will extract the xml into a stream. This method provides options
				// for changing the encoding (UTF-8, UTF-16) as well as headers, 
				// end of line and indenting.
				// This method is useful when a specific encoding is required (typically
				// UTF-8), in order to transmit it over an 8-bit connection, smtp etc
				// without the need to write the xml to file first.
				System.IO.Stream stmXml = elm.ToXmlStream();

			}
			catch (Exception e)
			{
				DisplayError(e);
			}
		}
		#endregion
		#endregion

		#region Error Handler
		private void DisplayError(Exception ex)
		{
			string errText = "Error - \n";
			// Note : exceptions are likely to contain inner exceptions
			// that provide further detail about the error.
			while (ex != null)
			{
				errText += ex.Message + "\n";
				ex = ex.InnerException;
			}
			MessageBox.Show(this,  errText, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error); 
		}
		#endregion

		#region Basic Form Plumbing
		#region SampleApp - Constructor
		public SampleApp()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            MessageBox.Show(this, "This Sample Application shows the basic serialization mechanism for reading and writing xml documents using Liquid XML Data Binding.\n\n" +
                                "A good place to start examining the code is in SampleApp.cs. If you place a breakpoint in the method btnLoad_Click, then you will be able to step through the code looking at the methods that are called.\n\n" +
                                "After the document loads, a dialog will show the details of what has been loaded. Clicking on nodes in the tree will show the XML data it represents along with example source code (in the code tab) that will help you to understand how to write your real client application.\n\n" +
                                "NOTE: If you are loading a large XML document, although the serialization will be quick the display in the dialog may be slow as it reflects on the whole object model to display the tree.", "Sample Application Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion 

		#region Dispose
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		#endregion

		#region Main
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SampleApp());
		}
		#endregion 
	
		#region SampleApp_Load - Populates the list box
		private void SampleApp_Load(object sender, System.EventArgs e)
		{
			lblInfo.Text = "All Sample XML Files that you specified in the Wizard will be shown here, see btnLoad_Click(...) method in SampleApp.cs.\n\nSelect the file you want to load into the simple viewer and click the 'Load Selected XML File' button:";
			lstFiles.Items.AddRange(new object[] {
													"Browse for a File to Load"
													});
            lstFiles.SelectedIndex = 0;
		}
		#endregion

		#region btnClose_Click
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.lstFiles = new System.Windows.Forms.ListBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(344, 96);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(96, 48);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load Selected XML File";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(344, 216);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(96, 24);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(16, 16);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(424, 72);
			this.lblInfo.TabIndex = 0;
			// 
			// lstFiles
			// 
			this.lstFiles.HorizontalScrollbar = true;
			this.lstFiles.Location = new System.Drawing.Point(8, 96);
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new System.Drawing.Size(328, 134);
			this.lstFiles.TabIndex = 1;
			this.lstFiles.DoubleClick += new System.EventHandler(this.btnLoad_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "xml";
			this.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// SampleApp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 246);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lstFiles,
																		  this.lblInfo,
																		  this.btnClose,
																		  this.btnLoad});
			this.Name = "SampleApp";
			this.Text = "Liquid XML Sample";
			this.Load += new System.EventHandler(this.SampleApp_Load);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

