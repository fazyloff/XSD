<?xml version='1.0' ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:b="http://schemas.microsoft.com/dynamics/2008/01/documents/FactureJour_GRD">
	<xsl:template match="/">
		<Файл>
			<xsl:attribute name="ВерсПрог">
				<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoProgramVersion"/>
			</xsl:attribute>
			<xsl:attribute name="ВерсФорм">
				<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoFormatVersion"/>
			</xsl:attribute>
			<xsl:attribute name="ИдФайл">
				<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoFileName"/>
			</xsl:attribute>
			<СвУчДокОбор>
				<xsl:attribute name="ИдОтпр">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoSenderId"/>
				</xsl:attribute>
				<xsl:attribute name="ИдПол">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoBuyerId"/>
				</xsl:attribute>
				<СвОЭДОтпр>
					<xsl:attribute name="ИННЮЛ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoCompanyINN"/>
					</xsl:attribute>
					<xsl:attribute name="ИдЭДО">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoId"/>
					</xsl:attribute>
					<xsl:attribute name="НаимОрг">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoCompanyName"/>
					</xsl:attribute>
				</СвОЭДОтпр>
			</СвУчДокОбор>
			<Документ КНД="1115106" НаимДокОпр="Счет-фактура и документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)" ПоФактХЖ="Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)" Функция="СЧФДОП">
				<xsl:attribute name="ВремИнфПр">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoDocTime"/>
				</xsl:attribute>
				<xsl:attribute name="ДатаИнфПр">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoDocDate"/>
				</xsl:attribute>
				<xsl:attribute name="КНД">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoKND"/>
				</xsl:attribute>
				<xsl:attribute name="НаимЭконСубСост">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoCompanyName"/>
				</xsl:attribute>
				<СвСчФакт>
					<xsl:attribute name="ДатаСчФ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:DocumentDate"/>
					</xsl:attribute>
					<xsl:attribute name="КодОКВ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:CurrencyCode"/>
					</xsl:attribute>
					<xsl:attribute name="НомерСчФ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:InvoiceId"/>
					</xsl:attribute>
					<СвПрод>
						<xsl:attribute name="ОКПО">
							<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoSupplierOKPO"/>
						</xsl:attribute>
						<ИдСв>
							<СвЮЛУч>
								<xsl:attribute name="ИННЮЛ">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoSupplierINN"/>
								</xsl:attribute>
								<xsl:attribute name="КПП">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoSupplierKPP"/>
								</xsl:attribute>
								<xsl:attribute name="НаимОрг">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoSupplierName"/>
								</xsl:attribute>
							</СвЮЛУч>
						</ИдСв>
					</СвПрод>
				</СвСчФакт>
			</Документ>
		</Файл>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="..\AX\AX_SF.xml" htmlbaseurl="" outputurl="..\AX\UPD_FNS.xml" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength=""
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
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="..\FNS\ON_SCHFDOPPR_1_995_01_05_01_02.xsd" destSchemaRoot="Файл" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="..\AX\AXCustInvoiceJour.xml" srcSchemaRoot="CustInvoiceJour_GRD" AssociatedInstance="file:///c:/BTS/XSD/AX/AXCustInvoiceJour.xml" loaderFunction="document" loaderFunctionUsesURI="no"/>
			<SourceSchema srcSchemaPath="..\AX\AX_SF.xml" srcSchemaRoot="FactureJour_GRD" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/">
				<block path="Файл/xsl:attribute/xsl:value-of" x="353" y="36"/>
				<block path="Файл/xsl:attribute[1]/xsl:value-of" x="393" y="54"/>
				<block path="Файл/xsl:attribute[2]/xsl:value-of" x="353" y="72"/>
				<block path="Файл/СвУчДокОбор/xsl:attribute/xsl:value-of" x="353" y="108"/>
				<block path="Файл/СвУчДокОбор/xsl:attribute[1]/xsl:value-of" x="393" y="126"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:attribute/xsl:value-of" x="353" y="162"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:attribute[1]/xsl:value-of" x="393" y="180"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:attribute[2]/xsl:value-of" x="353" y="198"/>
				<block path="Файл/Документ/xsl:attribute/xsl:value-of" x="353" y="234"/>
				<block path="Файл/Документ/xsl:attribute[1]/xsl:value-of" x="393" y="252"/>
				<block path="Файл/Документ/xsl:attribute[2]/xsl:value-of" x="353" y="270"/>
				<block path="Файл/Документ/xsl:attribute[3]/xsl:value-of" x="353" y="306"/>
				<block path="Файл/Документ/СвСчФакт/xsl:attribute/xsl:value-of" x="353" y="396"/>
				<block path="Файл/Документ/СвСчФакт/xsl:attribute[1]/xsl:value-of" x="393" y="414"/>
				<block path="Файл/Документ/СвСчФакт/xsl:attribute[2]/xsl:value-of" x="353" y="432"/>
				<block path="Файл/Документ/СвСчФакт/СвПрод/xsl:attribute/xsl:value-of" x="353" y="504"/>
				<block path="Файл/Документ/СвСчФакт/СвПрод/ИдСв/СвЮЛУч/xsl:attribute/xsl:value-of" x="393" y="290"/>
				<block path="Файл/Документ/СвСчФакт/СвПрод/ИдСв/СвЮЛУч/xsl:attribute[1]/xsl:value-of" x="313" y="290"/>
				<block path="Файл/Документ/СвСчФакт/СвПрод/ИдСв/СвЮЛУч/xsl:attribute[2]/xsl:value-of" x="273" y="290"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->