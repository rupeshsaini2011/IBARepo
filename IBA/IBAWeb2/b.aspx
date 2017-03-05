<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="b.aspx.cs" Inherits="IBAWeb2.b" MasterPageFile="~/IBA.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-content">
		<div class="container-fluid">
		<!--	<header class="section-header">
				<div class="tbl">
					<div class="tbl-row">
						<div class="tbl-cell">

						
							<ol class="breadcrumb breadcrumb-simple">
								<li><a href="#">Home</a></li>
								<li><a href="#">Forms</a></li>
								<li class="active">Immovable Properties</li>
							</ol>
						</div>
					</div>
				</div>
			</header>  -->


			
			

	
	
	

					
			<div class="box-typical box-typical-padding">
				

				<form action="movable_form.php" method="POST" >  
					
									
					<h3 class="m-t-lg with-border">Shares </h3>
				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearSharesNo" runat="server" 
                                placeholder="Enter total number of shares" value="" name="shares_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearSharesValue" runat="server" 
                                placeholder="Enter total face value " name="shares_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearSharesCostofacquisition"  runat="server" placeholder="Enter total cost of acquisition" name="shares_lastyear_costofacquisition">
						</fieldset>
				</div>                
					<h5>As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearSharesNo"  runat="server" placeholder="Enter total number of shares" name="shares_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearSharesValue"  runat="server" placeholder="Enter total face value " name="shares_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearSharesCostofacquisition"  runat="server" placeholder="Enter cost of acquisition" name="shares_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
                      <div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year </label>
						<input type="text" class="form-control" id="ThisyearSharesCostofacquisition"  runat="server" placeholder="Enter calculated acquisition ." value="" name="shares_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="SharesFundingSource"  runat="server" placeholder="Enter source of funding." value="" name="shares_sourceof_funding">
						</fieldset>
					</div>
					<div class="row">
					</div>


					<h3 class="m-t-lg with-border">Debenture</h3>
				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearDebenturesNo"  runat="server" placeholder="Enter total number of shares" value="" name="debenture_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearDebenturesValue"  runat="server" placeholder="Enter total face value " name="debenture_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearDebenturesCostofacquisition"  runat="server" placeholder="Enter total cost of acquisition" name="debenture_lastyear_costofacquisition">
						</fieldset>	
				</div>
					<h5>As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearDebenturesNo"  runat="server" placeholder="Enter total number of shares" value="" name="debenture_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearDebenturesValue"  runat="server"  placeholder="Enter total face value " name="debenture_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearDebenturesCostofacquisition"  runat="server" placeholder="Enter cost of acquisition" name="debenture_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearDebenturesCostofacquisition"  runat="server" placeholder="Enter calculated acquisition ." value="" name="debenture_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="DebenturesFundingSource"  runat="server" placeholder="Enter source of funding." value="" name="debenture_sourceof_funding">
						</fieldset>
					</div>
                       <div class="row">
					</div>
              

					<h3 class="m-t-lg with-border">Units</h3>
				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearUnitsNo"  runat="server" placeholder="Enter total number of shares" value="" name="units_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearUnitsValue"  runat="server" placeholder="Enter face value" name="units_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearUnitsCostofacquisition"  runat="server" placeholder="Enter total cost of acquisition" name="units_lastyear_costofacquisition">
						</fieldset>
				</div>
				<h5>As on 1st april of current year</h5>
				<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearUnitsNo"  runat="server" placeholder="Enter total number of shares" value="" name="units_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearUnitsValue"  runat="server" placeholder="Enter total face value " name="units_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearUnitsCostofacquisition"  runat="server" placeholder="Enter cost of acquisition" name="units_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
							<input type="text" class="form-control" id="ThisyearUnitsCostofacquisition"  runat="server" placeholder="Enter calculated acquisition ." value="" name="units_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="UnitsFundingSource"  runat="server" placeholder="Enter source of funding." value="" name="units_sourceof_funding">
						</fieldset>
					</div>
                       <div class="row">
					</div>


                       <h3 class="m-t-lg with-border">NSCs</h3>
				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearNSCNo"  runat="server" placeholder="Enter total number of shares" value="" name="nscs_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearNSCValue" runat="server" placeholder="Enter total face value " name="nscs_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearNSCCostofacquisition" runat="server" placeholder="Enter total cost of acquisition" name="nscs_lastyear_costofacquisition">
						</fieldset>
				</div>
					<h5>As on 1st april of current year</h5>
				<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearNSCNo" runat="server" placeholder="Enter total number of shares" value="" name="nscs_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearNSCValue" runat="server" placeholder="Enter total face value " name="nscs_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearNSCCostofacquisition" runat="server" placeholder="Enter cost of acquisition" name="nscs_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearNSCCostofacquisition" runat="server" placeholder="Enter calculated acquisition ." value="" name="nscs_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="NSCFundingSource" runat="server" placeholder="Enter source of funding." value="" name="nscs_sourceof_funding">
						</fieldset>
					</div>
                       <div class="row">
					</div>


              <h3 class="m-t-lg with-border">NSS </h3>
				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearNSSNo" runat="server" placeholder="Enter total number of shares" value=""  name="nss_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearNSSValue" runat="server" placeholder="Enter total face value " name="nss_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearNSSCostofacquisition" runat="server" placeholder="Enter total cost of acquisition" name="nss_lastyear_costofacquisition">
						</fieldset>
				</div>
					<h5>As on 1st april of current year</h5>
				<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearNSSNo" runat="server" placeholder="Enter total number of shares" name="nss_current_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearNSSValue" runat="server" placeholder="Enter total face value " name="nss_current_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
						<input type="text" class="form-control" id="CurrentyearNSSCostofacquisition" runat="server" placeholder="Enter cost of acquisition" name="nss_current_Costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearNSSCostofacquisition" runat="server" placeholder="Enter calculated acquisition ." value="" name="nss_Costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="NSSFundingSource" runat="server" placeholder="Enter source of funding." value="" name="nss_sourceof_funding">
						</fieldset>
					</div>
                       <div class="row">
					</div>


           <h3 class="m-t-lg with-border">All Bank Deposits (Including FDRs, CTDs, PPF etc)</h3>

				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearDepositsNo" runat="server" placeholder="Enter total number of shares" value="" name="allbank_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearDepositsValue" runat="server" placeholder="Enter total face value " name="allbank_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastYearDepositsCostofacquisition" runat="server" 
                                placeholder="Enter total cost of acquisition" name="allbank_lastyear_costofacquisition" />
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearDepositsNo" runat="server" placeholder="Enter total number of shares" name="allbank_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label> 
							<input type="text" class="form-control" id="CurrentYearDepositsValue" runat="server" placeholder="Enter total face value " name="allbank_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearDepositsCostofacquisition" runat="server" placeholder="Enter cost of acquisition" name="allbank_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearDepositsCostofacquisition" runat="server" placeholder="Enter calculated acquisition ." value="" name="allbank_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="DepositsFundingSource" runat="server" placeholder="Enter source of funding." value="" name="allbank_sourceof_funding">
						</fieldset>
					</div>
                       <div class="row">
					</div>

             <h3 class="m-t-lg with-border">Other Securities Like Bonds Etc.</h3>

				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearBondsNo" runat="server" placeholder="Enter total number of shares" value="" name="othersecurity_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearBondsValue" runat="server" placeholder="Enter total face value" name="othersecurity_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearBondsCostofacquisition" runat="server" placeholder="Enter total cost of acquisition" name="othersecurity_lastyear_costofacquisition">
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearBondsNo" runat="server" placeholder="Enter total number of shares" name="othersecurity_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearBondsValue" runat="server" placeholder="Enter total face value " name="othersecurity_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearBondsCostofacquisition" runat="server" placeholder="Enter cost of acquisition" name="othersecurity_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearBondsCostofacquisition" runat="server" placeholder="Enter calculated acquisition ." value="" name="othersecurity_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="BondsFundingSource" runat="server" placeholder="Enter source of funding." value="" name="othersecurity_sourceof_funding">
						</fieldset>
					</div>

                       <div class="row">
					</div>


                        <h3 class="m-t-lg with-border">All Other Movable Properties Including Jewellery Etc.</h3>

				<div class="row">
					</div>
					<h5>As on 1st april of last year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total no.</label>
							<input type="text" class="form-control" id="LastYearOthersNo" runat="server" placeholder="Enter total number of shares" name="allother_lastyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="LastYearOthersValue" runat="server" placeholder="Enter total face value " name="allother_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="LastyearOthersCostofacquisition" runat="server" placeholder="Enter total cost of acquisition" name="allother_lastyear_costofacquisition">
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="CurrentYearOthersNo" runat="server" placeholder="Enter total number of shares" name="allother_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="CurrentYearOthersValue" runat="server" placeholder="Enter total face value " name="allother_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="CurrentyearOthersCostofacquisition" runat="server" placeholder="Enter cost of acquisition" name="allother_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="ThisyearOthersCostofacquisition" runat="server" placeholder="Enter calculated acquisition ." value="" name="allother_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="OthersFundingSource" runat="server" placeholder="Enter source of funding." value="" name="allother_sourceof_funding">
						</fieldset>
					</div>				
					<div class="row">
					</div>
               
                    	<h5 class="with-border m-t-lg">
					<div class="row">
                                    <div class="col-xs-3">

                                        <asp:Button ID="btnNext" Text="Next" runat="server" class="button btn-sm btn-primary center" OnClick="btnNext_Click" />
                                    </div>

                                    <div class="col-xs-3">

                                         <asp:Button ID="btnSave" Text="Save" runat="server" class="button btn-sm btn-primary center" OnClick="btnSave_Click" />
                                    </div>

                                    <div class="col-xs-3">

                                         <asp:Button ID="btnBack" Text="Back" runat="server" class="button btn-sm btn-primary center" OnClick="btnBack_Click" />
                                    </div>

                                </div>
              
               <!--	    <div style="margin-left:15px">
                 <input type="submit" class="button btn-sm btn-primary center" value="Submit">
					</div>
                  
				<h5 class="with-border m-t-lg"><a href="c.html" value="">Next</a></h5>  
					<input type="submit" value="Next" >           -->
                    <h5 class="with-border m-t-lg">


			</div><!--.box-typical-->
		</div><!--.container-fluid-->
	</div><!--.page-content-->

</asp:Content>