<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="c.aspx.cs" Inherits="IBAWeb2.c" MasterPageFile="~/IBA.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div class="page-content">
		<div class="container-fluid">
	<!--		<header class="section-header">
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
				<!-- <p>
					<h2>Please Fill Out The Important Informations.</h2> 
					</p> -->

			     <div class="row">
					</div>

				<form action="immovable_b_form.php" method="POST">

					
					
					<h3 class="m-t-lg with-border">Shares</h3>
				<div class="row">
					</div>
			
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="shares_script_description" runat="server" placeholder="Enter the title of script" value="" name="shares_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="shares_facevalue" runat="server" placeholder="Enter total face value " name="shares_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="shares_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition" name="shares_purchase_consideration">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="shares_howacquired" runat="server" placeholder="Enter total number of shares" value="" name="shares_howacquired">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="shares_relationship" runat="server" placeholder="Enter the name of declarant and relationship " name="shares_relationship">
						</fieldset>
					</div>
					<div class="row">
					</div>
                    

					<h3 class="m-t-lg with-border">Debenture</h3>
				<div class="row">
					</div>	
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="debenture_script_description" runat="server" placeholder="Enter the title of script" value="" name="debenture_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="debenture_facevalue" runat="server" placeholder="Enter total face value " name="debenture_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="debenture_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition" name="debenture_purchase_consideration">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="debenture_howacquired" runat="server" placeholder="Enter total number of shares" value="" name="debenture_howacquired">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="debenture_relationship" runat="server" placeholder="Enter the name of declarant and relationship" name=" debenture_relationship">
						</fieldset>
					</div>
					
           

					<h3 class="m-t-lg with-border">Units</h3>
				<div class="row">
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="units_script_description" runat="server" placeholder="Enter the title of script" value="" name="units_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="units_facevalue" runat="server" placeholder="Enter total face value" name="units_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="units_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition" name="units_purchase_consideration">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="units_howacquired" runat="server" placeholder="Enter total number of shares" value="" name="units_howacquired">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="units_relationship" runat="server" placeholder="Enter the name of declarant and relationship" name="units_relationship">
						</fieldset>
					</div>

					<h3 class="m-t-lg with-border">Nscs</h3>
				<div class="row">
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="nscs_script_description" runat="server" placeholder="Enter the title of script" value="" name="nscs_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="nscs_facevalue" runat="server" placeholder="Enter total face value" name="nscs_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="nscs_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition" name="nscs_purchase_consideration">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="nscs_howacquired" runat="server" placeholder="Enter total number of shares" value="" name="nscs_howacquired">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="nscs_relationship" runat="server" placeholder="Enter the name of declarant and relationship" name="nscs_relationship">
						</fieldset>
					</div>

              <h3 class="m-t-lg with-border">NSS </h3>
				<div class="row">
					</div>
						<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="nss_script_description" runat="server" placeholder="Enter the title of script" value="" name="nss_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="nss_facevalue" runat="server" placeholder="Enter total face value " name="nss_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="nss_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition" name="nss_purchase_consideration">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="nss_howacquired" runat="server" placeholder="Enter total number of shares" value="" name="nss_howacquired">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="nss_relationship" runat="server" placeholder="Enter the name of declarant and relationship" name="nss_relationship">
						</fieldset>
					</div>
					
           <h3 class="m-t-lg with-border">All Bank Deposits (Including FDRs, CTDs, PPF etc)</h3>
				<div class="row">
					</div>
			       
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="allbank_script_description" runat="server" placeholder="Enter the title of script" value="" name="allbank_script_description">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="allbank_facevalue" runat="server" placeholder="Enter total face value " name="allbank_facevalue">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="allbank_purchase_consideration" name="allbank_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="allbank_howacquired" name="allbank_howacquired" runat="server" placeholder="Enter total number of shares" value="">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="allbank_relationship" name="allbank_relationship" runat="server" placeholder="Enter the name of declarant and relationship  ">
						</fieldset>
					</div>
					

             <h3 class="m-t-lg with-border">Other securities like Bonds etc.</h3>
				<div class="row">
					</div>
			 		<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="othersecurity_script_description" name="othersecurity_script_description" runat="server" placeholder="Enter the title of script" value="">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="othersecurity_facevalue" name="othersecurity_facevalue" runat="server" placeholder="Enter total face value ">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="othersecurity_purchase_consideration" name="othersecurity_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="othersecurity_howacquired" name="othersecurity_howacquired" runat="server" placeholder="Enter total number of shares" value="">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="othersecurity_relationship" name="othersecurity_relationship" runat="server" placeholder="Enter the name of declarant and relationship  ">
						</fieldset>
					</div>
					
					<div class="row">
					</div>
                        <h3 class="m-t-lg with-border">All other movable properties including jewellery etc.</h3>
                    	<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Script or description of deposits.</label>
							<input type="text" class="form-control" id="allother_script_description" name="allother_script_description" runat="server" placeholder="Enter the title of script" value="">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Value (shares, securities, bonds or debentures)</label>
							<input type="text" class="form-control" id="allother_facevalue" name="allother_facevalue" runat="server" placeholder="Enter total face value ">
						</fieldset>
					</div>
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Purchase consideration  </label>
							<input type="text" class="form-control" id="allother_purchase_consideration" name="allother_purchase_consideration" runat="server" placeholder="Enter total cost of acquisition">
						</fieldset>
				</div>                
					<div class="col-lg-6">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">How acquired</label>
							<input type="text" class="form-control" id="allother_howacquired" name="allother_howacquired" runat="server" placeholder="Enter total number of shares" value="">
						</fieldset>
					</div>
					<div class="col-lg-12">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">In which name held, if not in the name of declarant, relationship with the latter</label>
							<input type="text" class="form-control" id="allother_relationship" name="allother_relationship" runat="server" placeholder="Enter the name of declarant and relationship  ">
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
              
             <!--
                    <div style="margin-left:15px">
                 <input type="submit" class="button btn-sm btn-primary center" value="Submit">
					</div>
				
					<h5 class="with-border m-t-lg"><a href="d.html" value="">Next</a></h5>   -->
                  
			</div><!--.box-typical-->
		</div><!--.container-fluid-->
	</div><!--.page-content-->



</asp:Content>
