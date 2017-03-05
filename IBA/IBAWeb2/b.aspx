﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="b.aspx.cs" Inherits="IBAWeb2.b" MasterPageFile="~/IBA.Master" %>

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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="shares_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="shares_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="shares_lastyear_costofacquisition">
						</fieldset>
				</div>                
					<h5>As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="shares_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="shares_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="shares_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
                      <div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year </label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="shares_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="shares_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="debenture_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="debenture_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="debenture_lastyear_costofacquisition">
						</fieldset>	
				</div>
					<h5>As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="debenture_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="debenture_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="debenture_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="debenture_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="debenture_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="units_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter face value" name="units_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="units_lastyear_costofacquisition">
						</fieldset>
				</div>
				<h5>As on 1st april of current year</h5>
				<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="units_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="units_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="units_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
							<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="units_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="units_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="nscs_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="nscs_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="nscs_lastyear_costofacquisition">
						</fieldset>
				</div>
					<h5>As on 1st april of current year</h5>
				<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="nscs_currentyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="nscs_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="nscs_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="nscs_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="nscs_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value=""  name="nss_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="nss_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="nss_lastyear_costofacquisition">
						</fieldset>
				</div>
					<h5>As on 1st april of current year</h5>
				<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="nss_current_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="nss_current_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
						<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="nss_current_Costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="nss_Costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="nss_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="allbank_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="allbank_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="allbank_lastyear_costofacquisition"
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="allbank_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label> 
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="allbank_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="allbank_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="allbank_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="exampleInputEmail1" placeholder="Enter source of funding." value="" name="allbank_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" value="" name="othersecurity_lastyear_totalno">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value" name="othersecurity_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="othersecurity_lastyear_costofacquisition">
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="othersecurity_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="othersecurity_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="othersecurity_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="othersecurity_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="othersecurity_sourceof_funding">
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
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="allother_lastyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="allother_lastyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter total cost of acquisition" name="allother_lastyear_costofacquisition">
						</fieldset>
				</div>
				
					<h5 class="">As on 1st april of current year</h5>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Total number</label>
							<input type="text" class="form-control" id="" placeholder="Enter total number of shares" name="allother_currentyear_totalno" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Total face value (in rs)</label>
							<input type="text" class="form-control" id="" placeholder="Enter total face value " name="allother_currentyear_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Cost of acquisition (in rs) </label>
							<input type="text" class="form-control" id="" placeholder="Enter cost of acquisition" name="allother_currentyear_costofacquisition">
						</fieldset>
				</div>	
						<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Cost of acquisition this year.</label>
						<input type="text" class="form-control" id="" placeholder="Enter calculated acquisition ." value="" name="allother_costofacquisition_thisyear">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
						<label class="form-label semibold" for=" ">Sources of funding </label>
						<input type="text" class="form-control" id="" placeholder="Enter source of funding." value="" name="allother_sourceof_funding">
						</fieldset>
					</div>				
					<div class="row">
					</div>
               
                    	<h5 class="with-border m-t-lg">
					<input type="submit" value="Next" >
              
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