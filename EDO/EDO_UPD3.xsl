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
			<Документ КНД="1115106" НаимДокОпр="Счет-фактура и документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)" ПоФактХЖ="Документ об отгрузке товаров (выполнении работ), передаче имущественных прав (документ об оказании услуг)" Функция="СЧФДОП" ВремИнфПр="12:00:00">
				<xsl:attribute name="ДатаИнфПр">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_DocumentDate"/>
				</xsl:attribute>
				<xsl:attribute name="КНД">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoKND"/>
				</xsl:attribute>
				<xsl:attribute name="НаимЭконСубСост">
					<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureJourHeader_RU/b:GRD_EdoCompanyName"/>
				</xsl:attribute>
				<СвСчФакт>
					<xsl:attribute name="ДатаСчФ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureDate_External"/>
					</xsl:attribute>
					<xsl:attribute name="КодОКВ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:CurrencyCode"/>
					</xsl:attribute>
					<xsl:attribute name="НомерСчФ">
						<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureExternalId"/>
					</xsl:attribute>
					<СвПрод>
						<ИдСв>
							<СвЮЛУч>
								<xsl:attribute name="ИННЮЛ">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureJourHeader_RU/b:CompanyINN"/>
								</xsl:attribute>
								<xsl:attribute name="КПП">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureJourHeader_RU/b:CompanyKPP"/>
								</xsl:attribute>
								<xsl:attribute name="НаимОрг">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:FactureJourHeader_RU/b:CompanyName"/>
								</xsl:attribute>
							</СвЮЛУч>
						</ИдСв>
						<Адрес>
							<АдрРФ>
								<xsl:attribute name="Город">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoConsignorTownId"/>
								</xsl:attribute>
								<xsl:attribute name="Индекс">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoconsignorZipCode"/>
								</xsl:attribute>
								<xsl:attribute name="КодРегион">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoConsignorState"/>
								</xsl:attribute>
								<xsl:attribute name="НаселПункт">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoConsignorEstate"/>
								</xsl:attribute>
								<xsl:attribute name="Улица">
									<xsl:value-of select="b:FactureJour_GRD/b:FactureJour_RU/b:GRD_EdoConsignorStreetId"/>
								</xsl:attribute>
							</АдрРФ>
						</Адрес>
					</СвПрод>
				</СвСчФакт>
			</Документ>
		</Файл>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="..\ax\ax_sf107.xml" htmlbaseurl="" outputurl="..\FNS\outputUPD.xml" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength=""
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
			<SourceSchema srcSchemaPath="..\ax\ax_sf107.xml" srcSchemaRoot="FactureJour_GRD" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/"></template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->