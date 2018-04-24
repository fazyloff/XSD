<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<xsl:for-each select="ROOT/OutletOrders">
			<orders xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
				<xsl:for-each select="OutletOrder">
					<order>
						<OrderGUID>
							<xsl:value-of select="generate-id(.)" />
						</OrderGUID>
						<ParentOrderingSystem>NEON</ParentOrderingSystem>
						<numberIN>
							<xsl:value-of select="@OrderNo" />
						</numberIN>
						<numberOUT />
						<orderDate>
							<xsl:value-of select="@OLOrderDate" />
						</orderDate>
						<shipmentDate>
							<xsl:value-of select="@OrderExecutionDate" />
						</shipmentDate>
						<clientID>
							<xsl:value-of select="@PCOMP_CODE" />
						</clientID>
						<adressID>
							<xsl:value-of select="substring-after (@OL_CODE,'_')" />
						</adressID>
						<contractID />
						<companyID>110</companyID>
						<stockID>ПАРФ</stockID>
						<sectorID />
						<noteTotal>
							<xsl:value-of select="@Comments" />
						</noteTotal>
						<noteWarehouse />
						<noteTransport />
						<checkSum />
						<checkCurrency>Руб</checkCurrency>
						<delivery>Доставка</delivery>
						<noContract>false</noContract>
						<nopay>false</nopay>
						<statusVKPK>3</statusVKPK>
						<sectorIdSW>
							<xsl:value-of select="@Merch_id" />
						</sectorIdSW>
						<lines>
							<xsl:value-of select="OutletOrderDetails" />
							<xsl:for-each select="OutletOrderDetails/OutletOrderDetail">
								<line>
									<productID>
										<xsl:value-of select="@LOCALCODE" />
									</productID>
									<price>
										<xsl:value-of select="@PRICE" />
									</price>
									<count>
										<xsl:value-of select="@QTY" />
									</count>
									<unit>1</unit>
								</line>
							</xsl:for-each>
						</lines>
					</order>
				</xsl:for-each>
			</orders>
		</xsl:for-each>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="OutletOrders.xml" htmlbaseurl="" outputurl="Neon-Order.xml" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength=""
		          urlprofilexml="" commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal"
		          customvalidator="">
			<advancedProp name="sInitialMode" value=""/>
			<advancedProp name="schemaCache" value="||"/>
			<advancedProp name="bXsltOneIsOkay" value="true"/>
			<advancedProp name="bSchemaAware" value="true"/>
			<advancedProp name="bGenerateByteCode" value="true"/>
			<advancedProp name="bXml11" value="false"/>
			<advancedProp name="iValidation" value="0"/>
			<advancedProp name="bExtensions" value="true"/>
			<advancedProp name="iWhitespace" value="0"/>
			<advancedProp name="sInitialTemplate" value=""/>
			<advancedProp name="bTinyTree" value="true"/>
			<advancedProp name="xsltVersion" value="2.0"/>
			<advancedProp name="bWarnings" value="true"/>
			<advancedProp name="bUseDTD" value="false"/>
			<advancedProp name="iErrorHandling" value="fatal"/>
		</scenario>
	</scenarios>
	<MapperMetaTag>
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="NEON\Neon-Order.xml" destSchemaRoot="orders" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="OutletOrders.xml" srcSchemaRoot="ROOT" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/"></template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->