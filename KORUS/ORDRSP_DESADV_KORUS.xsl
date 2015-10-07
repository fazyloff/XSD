<?xml version='1.0' ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<Document-DespatchAdvice>
			<DespatchAdvice-Header>
				<DespatchAdviceNumber>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/OrderResponseNumber"/>
				</DespatchAdviceNumber>
				<DespatchAdviceDate>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/OrderResponseDate"/>
				</DespatchAdviceDate>
				<DespatchAdviceTime>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/DespatchTime"/>
				</DespatchAdviceTime>
				<EstimatedDeliveryDate>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/ExpectedDeliveryDate"/>
				</EstimatedDeliveryDate>
				<EstimatedDeliveryTime>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/ExpectedDeliveryTime"/>
				</EstimatedDeliveryTime>
				<DeliveryDate>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/DespatchDate"/>
				</DeliveryDate>
				<BuyerOrderNumber>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/OrderNumber"/>
				</BuyerOrderNumber>
				<BuyerOrderDate>
					<xsl:value-of select="Document-OrderResponse/OrderResponse-Header/OrderDate"/>
				</BuyerOrderDate>
				<Remarks>
					<xsl:value-of select="concat('Создан из ORDRSP:',Document-OrderResponse/OrderResponse-Header/OrderResponseNumber)"/>
				</Remarks>
			</DespatchAdvice-Header>
			
			<DespatchAdvice-Parties>
				<Buyer>
					<ILN>
						<xsl:value-of select="Document-OrderResponse/OrderResponse-Parties/Buyer/ILN"/>
					</ILN>
				</Buyer>
				<Seller>
					<ILN>
						<xsl:value-of select="Document-OrderResponse/OrderResponse-Parties/Seller/ILN"/>
					</ILN>
				</Seller>
				<DeliveryPoint>
					<ILN>
						<xsl:value-of select="Document-OrderResponse/OrderResponse-Parties/DeliveryPoint/ILN"/>
					</ILN>
				</DeliveryPoint>
			</DespatchAdvice-Parties>
			<DespatchAdvice-Lines>
					<xsl:for-each select="Document-OrderResponse/OrderResponse-Lines/Line">
					<Line>
						<Line-Item>
							<LineNumber>
								<xsl:value-of select="Line-Item/LineNumber"/>
							</LineNumber>
							<EAN>
								<xsl:value-of select="Line-Item/EAN"/>
							</EAN>
							<SupplierItemCode>
								<xsl:value-of select="Line-Item/SupplierItemCode"/>
							</SupplierItemCode>
							<DespatchedQuantity>
								<xsl:value-of select="Line-Item/QuantityToBeDelivered"/>
							</DespatchedQuantity>
							<OrderedQuantity>
								<xsl:value-of select="Line-Item/OrderedQuantity"/>
							</OrderedQuantity>
							<UnitOfMeasure>
								<xsl:value-of select="Line-Item/UnitOfMeasure"/>
							</UnitOfMeasure>
							<ItemDescription>
								<xsl:value-of select="Line-Item/ItemDescription"/>
							</ItemDescription>
							<UnitNetPrice>
								<xsl:value-of select="Line-Item/OrderedUnitNetPrice"/>
							</UnitNetPrice>
							<UnitGrossPrice>
								<xsl:value-of select="Line-Item/OrderedUnitGrossPrice"/>
							</UnitGrossPrice>
							<TaxRate>
								<xsl:value-of select="Line-Item/TaxRate"/>
							</TaxRate>
						</Line-Item>
					</Line>
				</xsl:for-each>
			</DespatchAdvice-Lines>
		</Document-DespatchAdvice>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="..\..\ORDRSP_DESADV\ORDRSP.xml" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength=""
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
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="DESADV_XSD.xsd" destSchemaRoot="Document-DespatchAdvice" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="..\..\ORDRSP_DESADV\ORDRSP.xml" srcSchemaRoot="Document-OrderResponse" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/">
				<block path="Document-DespatchAdvice/DespatchAdvice-Header/Remarks/xsl:value-of" x="169" y="241"/>
				<block path="Document-DespatchAdvice/DespatchAdvice-Lines/xsl:for-each" x="188" y="134"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->