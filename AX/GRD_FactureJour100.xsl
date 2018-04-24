<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:n="http://schemas.microsoft.com/dynamics/2008/01/documents/FactureJour_GRD" xmlns:xs="http://www.w3.org/2001/XMLSchema" exclude-result-prefixes="n xs xsi xsl">
	<xsl:output method="xml" encoding="UTF-8" indent="yes"/>
	<xsl:template match="/n:FactureJour_GRD">
		<Файл>
			<xsl:attribute name="xsi:noNamespaceSchemaLocation">
				<xsl:value-of select="'C:/Users/d.botin/Desktop/AD44~1/ON_SFAKT_1_897_01_05_01_03.xsd'"/>
			</xsl:attribute>
			<xsl:for-each select="n:FactureJour_RU">
				<xsl:for-each select="n:GRD_EdoFileName">
					<xsl:variable name="Vvar684_GRD_EdoFileName_string" select="string(.)"/>
					<xsl:attribute name="ИдФайл">
						<xsl:value-of select="$Vvar684_GRD_EdoFileName_string"/>
					</xsl:attribute>
				</xsl:for-each>
			</xsl:for-each>
			<xsl:for-each select="n:FactureJour_RU">
				<xsl:for-each select="n:GRD_EdoProgramVersion">
					<xsl:variable name="Vvar691_GRD_EdoProgramVersion_string" select="string(.)"/>
					<xsl:attribute name="ВерсПрог">
						<xsl:value-of select="$Vvar691_GRD_EdoProgramVersion_string"/>
					</xsl:attribute>
				</xsl:for-each>
			</xsl:for-each>
			<xsl:for-each select="n:FactureJour_RU">
				<xsl:for-each select="n:GRD_EdoFormatVersion">
					<xsl:variable name="Vvar698_GRD_EdoFormatVersion_string" select="string(.)"/>
					<xsl:attribute name="ВерсФорм">
						<xsl:value-of select="$Vvar698_GRD_EdoFormatVersion_string"/>
					</xsl:attribute>
				</xsl:for-each>
			</xsl:for-each>
			<СвУчДокОбор>
				<xsl:for-each select="n:FactureJour_RU">
					<xsl:for-each select="n:GRD_EdoSenderId">
						<xsl:variable name="Vvar705_GRD_EdoSenderId_string" select="string(.)"/>
						<xsl:attribute name="ИдОтпр">
							<xsl:value-of select="$Vvar705_GRD_EdoSenderId_string"/>
						</xsl:attribute>
					</xsl:for-each>
				</xsl:for-each>
				<xsl:for-each select="n:FactureJour_RU">
					<xsl:for-each select="n:GRD_EdoBuyerId">
						<xsl:variable name="Vvar712_GRD_EdoBuyerId_string" select="string(.)"/>
						<xsl:attribute name="ИдПок">
							<xsl:value-of select="$Vvar712_GRD_EdoBuyerId_string"/>
						</xsl:attribute>
					</xsl:for-each>
				</xsl:for-each>
				<СвОЭДОтпр  НаимОрг='Общество с Ограниченной Ответственностью "Градиент Дистрибьюция"' ИННЮЛ="7705442145">													
					<xsl:for-each select="n:FactureJour_RU">
						<xsl:for-each select="n:GRD_EdoId">
							<xsl:variable name="Vvar733_GRD_EdoId_string" select="string(.)"/>
							<xsl:attribute name="ИдЭДО">
								<xsl:value-of select="$Vvar733_GRD_EdoId_string"/>
							</xsl:attribute>
						</xsl:for-each>
					</xsl:for-each>
				</СвОЭДОтпр>
			</СвУчДокОбор>
			<Документ>
				<xsl:for-each select="n:FactureJour_RU">
					<xsl:for-each select="n:GRD_EdoKND">
						<xsl:variable name="Vvar740_GRD_EdoKND_string" select="string(.)"/>
						<xsl:attribute name="КНД">
							<xsl:value-of select="$Vvar740_GRD_EdoKND_string"/>
						</xsl:attribute>
					</xsl:for-each>
				</xsl:for-each>
				<СвСчФакт>
					<xsl:for-each select="n:FactureJour_RU">
						<xsl:for-each select="n:FactureExternalId">
							<xsl:variable name="Vvar747_FactureExternalId_string" select="string(.)"/>
							<xsl:attribute name="НомерСчФ">
								<xsl:value-of select="$Vvar747_FactureExternalId_string"/>
							</xsl:attribute>
						</xsl:for-each>
					</xsl:for-each>
					<xsl:for-each select="n:FactureJour_RU">
						<xsl:for-each select="n:GRD_EdoFactureDate_External">
							<xsl:variable name="Vvar754_GRD_EdoFactureDate_External_string" select="string(.)"/>
							<xsl:attribute name="ДатаСчФ">
								<xsl:value-of select="$Vvar754_GRD_EdoFactureDate_External_string"/>
							</xsl:attribute>
						</xsl:for-each>
					</xsl:for-each>
					<xsl:for-each select="n:FactureJour_RU">
						<xsl:for-each select="n:GRD_EdoCurrecyCode">
							<xsl:variable name="Vvar761_GRD_EdoCurrecyCode_string" select="string(.)"/>
							<xsl:attribute name="КодОКВ">
								<xsl:value-of select="$Vvar761_GRD_EdoCurrecyCode_string"/>
							</xsl:attribute>
						</xsl:for-each>
					</xsl:for-each>
					<СвПрод>
						<ИдСв>
							<СвЮЛ НаимОрг='Общество с Ограниченной Ответственностью "Градиент Дистрибьюция"' ИННЮЛ="7705442145" КПП="502101001"/>
						</ИдСв>
						<Адрес>
							<АдрРФ Индекс="142180" КодРегион="50" Город="Климовск г" Улица="Коммунальная ул" Дом="д. 23"/>
						</Адрес>
					</СвПрод>
					<ГрузОт>
						<ГрузОтпр>
							<НаимГОП>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:FactureJourHeader_RU">
										<xsl:for-each select="n:ConsignorName">
											<xsl:variable name="Vvar860_ConsignorName_string" select="string(.)"/>
											<НаимОрг>
												<xsl:value-of select="$Vvar860_ConsignorName_string"/>
											</НаимОрг>
										</xsl:for-each>
									</xsl:for-each>
								</xsl:for-each>
							</НаимГОП>
							<Адрес>
								<АдрРФ Индекс="142180" КодРегион="50" Город="Климовск г" Улица="Коммунальная ул" Дом="д. 23"/>
							</Адрес>
						</ГрузОтпр>
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:GRD_EdoTheSame">
								<xsl:variable name="Vvar930_GRD_EdoTheSame_string" select="string(.)"/>
								<ОнЖе>
									<xsl:value-of select="$Vvar930_GRD_EdoTheSame_string"/>
								</ОнЖе>
							</xsl:for-each>
						</xsl:for-each>
					</ГрузОт>
					<ГрузПолуч>
						<НаимГОП>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:GRD_EdoOrgName">
									<xsl:variable name="Vvar937_GRD_EdoOrgName_string" select="string(.)"/>
									<НаимОрг>
										<xsl:value-of select="$Vvar937_GRD_EdoOrgName_string"/>
									</НаимОрг>
								</xsl:for-each>
							</xsl:for-each>
						</НаимГОП>
						<Адрес>
							<АдрРФ>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoconsigneeZipCode">
										<xsl:variable name="Vvar944_GRD_EdoConsigneeZipCode_string" select="string(.)"/>
										<xsl:attribute name="Индекс">
											<xsl:value-of select="$Vvar944_GRD_EdoConsigneeZipCode_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeState">
										<xsl:variable name="Vvar951_GRD_EdoConsigneeState_string" select="string(.)"/>
										<xsl:attribute name="КодРегион">
											<xsl:value-of select="$Vvar951_GRD_EdoConsigneeState_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeCounty">
										<xsl:variable name="Vvar958_GRD_EdoConsigneeCounty_string" select="string(.)"/>
										<xsl:attribute name="Район">
											<xsl:value-of select="$Vvar958_GRD_EdoConsigneeCounty_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeTownId">
										<xsl:variable name="Vvar965_GRD_EdoConsigneeTownId_string" select="string(.)"/>
										<xsl:attribute name="Город">
											<xsl:value-of select="$Vvar965_GRD_EdoConsigneeTownId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeSettlementId">
										<xsl:variable name="Vvar972_GRD_EdoConsigneeSettlementId_string" select="string(.)"/>
										<xsl:attribute name="НаселПункт">
											<xsl:value-of select="$Vvar972_GRD_EdoConsigneeSettlementId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeStreetId">
										<xsl:variable name="Vvar979_GRD_EdoConsigneeStreetId_string" select="string(.)"/>
										<xsl:attribute name="Улица">
											<xsl:value-of select="$Vvar979_GRD_EdoConsigneeStreetId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeEstate">
										<xsl:variable name="Vvar986_GRD_EdoConsigneeEstate_string" select="string(.)"/>
										<xsl:attribute name="Дом">
											<xsl:value-of select="$Vvar986_GRD_EdoConsigneeEstate_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeBuilding">
										<xsl:variable name="Vvar993_GRD_EdoConsigneeBuilding_string" select="string(.)"/>
										<xsl:attribute name="Корпус">
											<xsl:value-of select="$Vvar993_GRD_EdoConsigneeBuilding_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoConsigneeFlat">
										<xsl:variable name="Vvar1000_GRD_EdoConsigneeFlat_string" select="string(.)"/>
										<xsl:attribute name="Кварт">
											<xsl:value-of select="$Vvar1000_GRD_EdoConsigneeFlat_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
							</АдрРФ>
						</Адрес>
					</ГрузПолуч>
					<xsl:variable name="varPaymentOrderNum">
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:PaymentOrderNum">
								<xsl:value-of select="string(.)"/>
							</xsl:for-each>
						</xsl:for-each>
					</xsl:variable>
					<xsl:if test="$varPaymentOrderNum != '' ">
						<СвПРД>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:PaymentOrderNum">
									<xsl:variable name="Vvar1009_PaymentOrderNum_string" select="string(.)"/>
									<xsl:attribute name="НомерПРД">
										<xsl:value-of select="$Vvar1009_PaymentOrderNum_string"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:GRD_EdoPaymentTransDate">
									<xsl:variable name="Vvar1016_GRD_EdoPaymentTransDate_string" select="string(.)"/>
									<xsl:attribute name="ДатаПРД">
										<xsl:value-of select="$Vvar1016_GRD_EdoPaymentTransDate_string"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
						</СвПРД>
					</xsl:if>
					<СвПокуп>
						<ИдСв>
							<СвЮЛ>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:FactureJourHeader_RU">
										<xsl:for-each select="n:ContragentName">
											<xsl:variable name="Vvar1023_ContragentName_string" select="string(.)"/>
											<xsl:attribute name="НаимОрг">
												<xsl:value-of select="$Vvar1023_ContragentName_string"/>
											</xsl:attribute>
										</xsl:for-each>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:FactureJourHeader_RU">
										<xsl:for-each select="n:ContragentINN">
											<xsl:variable name="Vvar1032_ContragentINN_string" select="string(.)"/>
											<xsl:attribute name="ИННЮЛ">
												<xsl:value-of select="$Vvar1032_ContragentINN_string"/>
											</xsl:attribute>
										</xsl:for-each>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:FactureJourHeader_RU">
										<xsl:for-each select="n:ContragentKPP">
											<xsl:variable name="Vvar1041_ContragentKPP_string" select="string(.)"/>
											<xsl:attribute name="КПП">
												<xsl:value-of select="$Vvar1041_ContragentKPP_string"/>
											</xsl:attribute>
										</xsl:for-each>
									</xsl:for-each>
								</xsl:for-each>
							</СвЮЛ>
						</ИдСв>
						<Адрес>
							<АдрРФ>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustZipCode">
										<xsl:variable name="Vvar1048_GRD_EdoCustZipCode_string" select="string(.)"/>
										<xsl:attribute name="Индекс">
											<xsl:value-of select="$Vvar1048_GRD_EdoCustZipCode_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustState">
										<xsl:variable name="Vvar1055_GRD_EdoCustState_string" select="string(.)"/>
										<xsl:attribute name="КодРегион">
											<xsl:value-of select="$Vvar1055_GRD_EdoCustState_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustCounty">
										<xsl:variable name="Vvar1062_GRD_EdoCustCounty_string" select="string(.)"/>
										<xsl:attribute name="Район">
											<xsl:value-of select="$Vvar1062_GRD_EdoCustCounty_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustTownId">
										<xsl:variable name="Vvar1069_GRD_EdoCustTownId_string" select="string(.)"/>
										<xsl:attribute name="Город">
											<xsl:value-of select="$Vvar1069_GRD_EdoCustTownId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustSettlementId">
										<xsl:variable name="Vvar1076_GRD_EdoCustSettlementId_string" select="string(.)"/>
										<xsl:attribute name="НаселПункт">
											<xsl:value-of select="$Vvar1076_GRD_EdoCustSettlementId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustStreetId">
										<xsl:variable name="Vvar1083_GRD_EdoCustStreetId_string" select="string(.)"/>
										<xsl:attribute name="Улица">
											<xsl:value-of select="$Vvar1083_GRD_EdoCustStreetId_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustEstate">
										<xsl:variable name="Vvar1090_GRD_EdoCustEstate_string" select="string(.)"/>
										<xsl:attribute name="Дом">
											<xsl:value-of select="$Vvar1090_GRD_EdoCustEstate_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustBuilding">
										<xsl:variable name="Vvar1097_GRD_EdoCustBuilding_string" select="string(.)"/>
										<xsl:attribute name="Корпус">
											<xsl:value-of select="$Vvar1097_GRD_EdoCustBuilding_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
								<xsl:for-each select="n:FactureJour_RU">
									<xsl:for-each select="n:GRD_EdoCustFlat">
										<xsl:variable name="Vvar1104_GRD_EdoCustFlat_string" select="string(.)"/>
										<xsl:attribute name="Кварт">
											<xsl:value-of select="$Vvar1104_GRD_EdoCustFlat_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</xsl:for-each>
							</АдрРФ>
						</Адрес>
					</СвПокуп>
				</СвСчФакт>
				<ТаблСчФакт>
					<xsl:for-each select="n:FactureJour_RU">
						<xsl:for-each select="n:FactureTrans_RU">
							<СведТов>
								<xsl:for-each select="n:LineNum_GRD">
									<xsl:variable name="Vvar1111_LineNum_GRD_int" select="number(.)"/>
									<xsl:attribute name="НомСтр">
										<xsl:value-of select="number($Vvar1111_LineNum_GRD_int)"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:ItemName">
									<xsl:variable name="Vvar1117_ItemName_string" select="string(.)"/>
									<xsl:attribute name="НаимТов">
										<xsl:value-of select="$Vvar1117_ItemName_string"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:GRD_CodeOKEI">
									<xsl:variable name="Vvar1121_GRD_CodeOKEI_string" select="string(.)"/>
									<xsl:attribute name="ОКЕИ_Тов">
										<xsl:value-of select="$Vvar1121_GRD_CodeOKEI_string"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:Qty">
									<xsl:variable name="Vvar1125_Qty_decimal" select="number(.)"/>
									<xsl:attribute name="КолТов">
										<xsl:value-of select="$Vvar1125_Qty_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:Price">
									<xsl:variable name="Vvar1129_Price_decimal" select="number(.)"/>
									<xsl:attribute name="ЦенаТов">
										<xsl:value-of select="$Vvar1129_Price_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:LineAmount">
									<xsl:variable name="Vvar1133_LineAmount_decimal" select="number(.)"/>
									<xsl:attribute name="СтТовБезНДС">
										<xsl:value-of select="$Vvar1133_LineAmount_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:GRD_LineAmountInclTax">
									<xsl:variable name="Vvar1137_GRD_LineAmountInclTax_decimal" select="number(.)"/>
									<xsl:attribute name="СтТовУчНал">
										<xsl:value-of select="$Vvar1137_GRD_LineAmountInclTax_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:GRD_LineAmountInclTax">
									<xsl:variable name="Vvar1137_GRD_LineAmountInclTax_decimal" select="number(.)"/>
									<xsl:attribute name="СтТовУчНал">
										<xsl:value-of select="$Vvar1137_GRD_LineAmountInclTax_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<xsl:for-each select="n:GRD_LineInfo">
									<xsl:variable name="Vvar1137_GRD_LineInfo_decimal" select="string(.)"/>
									<xsl:attribute name="ИнфПолСтр">
										<xsl:value-of select="$Vvar1137_GRD_LineInfo_decimal"/>
									</xsl:attribute>
								</xsl:for-each>
								<Акциз>
									<xsl:for-each select="n:GRD_Excise">
										<xsl:variable name="Vvar1141_GRD_Excise_string" select="string(.)"/>
										<xsl:attribute name="СумАкциз">
											<xsl:value-of select="$Vvar1141_GRD_Excise_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</Акциз>
								<НалСт>
									<xsl:for-each select="n:VATValue">
										<xsl:variable name="Vvar1143_VATValue_decimal" select="number(.)"/>
										<xsl:attribute name="НалСтВел">
											<xsl:value-of select="string($Vvar1143_VATValue_decimal)"/>
										</xsl:attribute>
									</xsl:for-each>
									<xsl:for-each select="n:GRD_TaxRateType">
										<xsl:variable name="Vvar1149_GRD_TaxRateType_string" select="string(.)"/>
										<xsl:attribute name="НалСтТип">
											<xsl:value-of select="$Vvar1149_GRD_TaxRateType_string"/>
										</xsl:attribute>
									</xsl:for-each>
								</НалСт>
								<СумНал>
									<xsl:for-each select="n:TaxAmount">
										<xsl:variable name="Vvar1151_TaxAmount_decimal" select="number(.)"/>
										<xsl:attribute name="СумНДС">
											<xsl:value-of select="string($Vvar1151_TaxAmount_decimal)"/>
										</xsl:attribute>
									</xsl:for-each>
								</СумНал>
								<xsl:for-each select="n:GRD_OKSMCode">
									<xsl:variable name="Vvar1157_GRD_OKSMCode_string" select="string(.)"/>
									<КодПроисх>
										<xsl:value-of select="$Vvar1157_GRD_OKSMCode_string"/>
									</КодПроисх>
								</xsl:for-each>
								<xsl:for-each select="n:InventGTDId">
									<xsl:variable name="Vvar1161_InventGTDId_string" select="string(.)"/>
									<НомерТД>
										<xsl:value-of select="$Vvar1161_InventGTDId_string"/>
									</НомерТД>
								</xsl:for-each>
							</СведТов>
						</xsl:for-each>
					</xsl:for-each>
					<ВсегоОпл>
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:FactureAmount">
								<xsl:variable name="Vvar1168_FactureAmount_decimal" select="number(.)"/>
								<xsl:attribute name="СтТовБезНДСВсего">
									<xsl:value-of select="$Vvar1168_FactureAmount_decimal"/>
								</xsl:attribute>
							</xsl:for-each>
						</xsl:for-each>
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:GRD_FactureAmountInclTax">
								<xsl:variable name="Vvar1175_GRD_FactureAmountInclTax_decimal" select="number(.)"/>
								<xsl:attribute name="СтТовУчНалВсего">
									<xsl:value-of select="$Vvar1175_GRD_FactureAmountInclTax_decimal"/>
								</xsl:attribute>
							</xsl:for-each>
						</xsl:for-each>
						<СумНалВсего>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:FactureTax">
									<xsl:variable name="Vvar1180_FactureTax_decimal" select="number(.)"/>
									<xsl:attribute name="СумНДС">
										<xsl:value-of select="string($Vvar1180_FactureTax_decimal)"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
						</СумНалВсего>
					</ВсегоОпл>
				</ТаблСчФакт>
				<Подписант>
					<ЮЛ>
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:GRD_EdoSigningPayINN_RU">
								<xsl:variable name="Vvar1189_GRD_EdoSigningPayINN_RU_string" select="string(.)"/>
								<xsl:attribute name="ИННЮЛ">
									<xsl:value-of select="$Vvar1189_GRD_EdoSigningPayINN_RU_string"/>
								</xsl:attribute>
							</xsl:for-each>
						</xsl:for-each>
						<xsl:for-each select="n:FactureJour_RU">
							<xsl:for-each select="n:GRD_EdoSigningTitle">
								<xsl:variable name="Vvar1196_GRD_EdoSigningTitle_string" select="string(.)"/>
								<xsl:attribute name="Должн">
									<xsl:value-of select="$Vvar1196_GRD_EdoSigningTitle_string"/>
								</xsl:attribute>
							</xsl:for-each>
						</xsl:for-each>
						<ФИО>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:GRD_EdoSigningLastName">
									<xsl:variable name="Vvar1203_GRD_EdoSigningLastName_string" select="string(.)"/>
									<xsl:attribute name="Фамилия">
										<xsl:value-of select="$Vvar1203_GRD_EdoSigningLastName_string"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:GRD_EdoSigningFirstName">
									<xsl:variable name="Vvar1210_GRD_EdoSigningFirstName_string" select="string(.)"/>
									<xsl:attribute name="Имя">
										<xsl:value-of select="$Vvar1210_GRD_EdoSigningFirstName_string"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
							<xsl:for-each select="n:FactureJour_RU">
								<xsl:for-each select="n:GRD_EdoSigningMiddleName">
									<xsl:variable name="Vvar1217_GRD_EdoSigningMiddleName_string" select="string(.)"/>
									<xsl:attribute name="Отчество">
										<xsl:value-of select="$Vvar1217_GRD_EdoSigningMiddleName_string"/>
									</xsl:attribute>
								</xsl:for-each>
							</xsl:for-each>
						</ФИО>
					</ЮЛ>
				</Подписант>
			</Документ>
		</Файл>
	</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="ZxFactJour.xml" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength="" urlprofilexml=""
		          commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal" customvalidator="">
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
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="" destSchemaRoot="" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="ZxFactJour.xml" srcSchemaRoot="FactureJour_GRD" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/n:FactureJour_GRD">
				<block path="Файл/xsl:attribute/xsl:value-of" x="278" y="36"/>
				<block path="Файл/xsl:for-each" x="168" y="24"/>
				<block path="Файл/xsl:for-each/xsl:for-each" x="238" y="54"/>
				<block path="Файл/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="318" y="54"/>
				<block path="Файл/xsl:for-each[1]" x="128" y="42"/>
				<block path="Файл/xsl:for-each[1]/xsl:for-each" x="198" y="72"/>
				<block path="Файл/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="72"/>
				<block path="Файл/xsl:for-each[2]" x="88" y="60"/>
				<block path="Файл/xsl:for-each[2]/xsl:for-each" x="238" y="90"/>
				<block path="Файл/xsl:for-each[2]/xsl:for-each/xsl:attribute/xsl:value-of" x="318" y="90"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each" x="128" y="96"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each/xsl:for-each" x="318" y="126"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="126"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each[1]" x="88" y="114"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each[1]/xsl:for-each" x="198" y="144"/>
				<block path="Файл/СвУчДокОбор/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="238" y="144"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:for-each" x="311" y="183"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:for-each/xsl:for-each" x="164" y="28"/>
				<block path="Файл/СвУчДокОбор/СвОЭДОтпр/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="124" y="68"/>
				<block path="Файл/Документ/xsl:for-each" x="168" y="110"/>
				<block path="Файл/Документ/xsl:for-each/xsl:for-each" x="38" y="60"/>
				<block path="Файл/Документ/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="38" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[2]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[2]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:for-each[2]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/ГрузОтпр/НаимГОП/xsl:for-each" x="218" y="40"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/ГрузОтпр/НаимГОП/xsl:for-each/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/ГрузОтпр/НаимГОП/xsl:for-each/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/ГрузОтпр/НаимГОП/xsl:for-each/xsl:for-each/xsl:for-each/НаимОрг/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузОт/xsl:for-each/xsl:for-each/ОнЖе/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/НаимГОП/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/НаимГОП/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/НаимГОП/xsl:for-each/xsl:for-each/НаимОрг/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[2]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[2]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[2]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[3]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[3]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[3]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[4]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[4]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[4]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[5]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[5]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[5]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[6]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[6]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[6]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[7]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[7]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[7]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[8]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[8]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/ГрузПолуч/Адрес/АдрРФ/xsl:for-each[8]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/!=[0]" x="232" y="98"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/xsl:if/СвПРД/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each" x="218" y="40"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[1]" x="218" y="40"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[1]/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[1]/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[1]/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[2]" x="218" y="40"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[2]/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[2]/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/ИдСв/СвЮЛ/xsl:for-each[2]/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[2]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[2]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[2]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[3]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[3]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[3]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[4]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[4]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[4]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[5]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[5]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[5]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[6]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[6]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[6]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[7]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[7]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[7]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[8]" x="248" y="70"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[8]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/СвСчФакт/СвПокуп/Адрес/АдрРФ/xsl:for-each[8]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[1]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[1]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[2]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[2]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[3]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[3]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[4]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[4]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[5]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[5]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[6]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[6]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[7]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[8]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[8]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/Акциз/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/Акциз/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/НалСт/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/НалСт/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/НалСт/xsl:for-each[1]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/НалСт/xsl:for-each[1]/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/СумНал/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/СумНал/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[9]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[9]/КодПроисх/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[10]" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/xsl:for-each/xsl:for-each/СведТов/xsl:for-each[10]/НомерТД/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/СумНалВсего/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/СумНалВсего/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/ТаблСчФакт/ВсегоОпл/СумНалВсего/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each" x="248" y="70"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[1]" x="248" y="70"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[1]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[1]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[2]" x="248" y="70"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[2]/xsl:for-each" x="278" y="100"/>
				<block path="Файл/Документ/Подписант/ЮЛ/ФИО/xsl:for-each[2]/xsl:for-each/xsl:attribute/xsl:value-of" x="278" y="100"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext>
			<template match="/n:FactureJour_GRD" mode="" srcContextPath="/FactureJour_GRD/FactureJour_RU" srcContextFile="file:///c:/BTS/XSD/AX/ZxFactJour.xml" targetContextPath="" targetContextFile=""/>
		</TemplateContext>
		<MapperFilter side="target">
			<Fragment url="" path="" action=""/>
		</MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->