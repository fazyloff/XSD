<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:variable name="firstLineAmount" select="/Document-Order/Order-Lines/Line[1]/Line-Item/GrossAmount"/>
	<xsl:template match="DeliveryPoint/ILN">
<ILN>		
		<xsl:choose>
			<xsl:when test="$firstLineAmount > 0">				
					<xsl:value-of select="/Document-Order/Order-Parties/UltimateCustomer/ILN"/>																						
			</xsl:when>
			<xsl:otherwise>				
					<xsl:value-of select="/Document-Order/Order-Parties/DeliveryPoint/ILN"/>																*
			</xsl:otherwise>
		</xsl:choose>
		</ILN>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="Заказ_РивГош_АР-000233489_обычный.xml" htmlbaseurl="" outputurl="Заказ_РивГош_АР-000233489_РЕзультат.xml" processortype="saxon8" useresolver="yes"
		          profilemode="0" profiledepth="" profilelength="" urlprofilexml="" commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext=""
		          validateoutput="no" validator="internal" customvalidator="">
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
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="Заказ_РивГош_АР-000233489_РЕзультат.xml" destSchemaRoot="Document-Order" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="Заказ_РивГош_АР-000233489_обычный.xml" srcSchemaRoot="Document-Order" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/"></template>
			<template match="@*|node()"></template>
			<template match="DeliveryPoint/ILN">
				<block path="ILN/xsl:choose" x="278" y="90"/>
				<block path="ILN/xsl:choose/&gt;[0]" x="232" y="84"/>
				<block path="" x="61" y="90"/>
				<block path="ILN/xsl:choose/xsl:when/xsl:value-of[1]" x="221" y="90"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->