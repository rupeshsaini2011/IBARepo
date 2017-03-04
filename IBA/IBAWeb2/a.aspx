<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="a.aspx.cs" Inherits="IBAWeb2.a" MasterPageFile="~/IBA.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

				<form action="immovable_form.php" method="POST">

					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Name</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text" class="form-control" id="inputPassword" name="name" placeholder="Please enter your name "></p>
						</div>
					</div>
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Designation</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text"  class="form-control" id="inputPassword" name="designation"  placeholder="Please enter your profile "></p>
						</div>
					</div>
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Institution</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text"  class="form-control" id="inputPassword" name="institute"  placeholder="Please enter institution to which you have connected "></p>
						</div>
					</div>
				
			</div>

			<section class="box-typical">
				<header class="box-typical-header">
					<div class="tbl-row">
						<div class="tbl-cell tbl-cell-title">
							<!-- <h3>23 Reports</h3> -->
						</div>
					
						<!-- <div class="tbl-cell tbl-cell-action-bordered">
							<button type="button" class="action-btn"><i class="font-icon font-icon-re"></i></button>
						</div>
						<div class="tbl-cell tbl-cell-action-bordered">
							<button type="button" class="action-btn"><i class="font-icon font-icon-trash"></i></button>
						</div> -->
					</div>
				

				
			
					
				
		


 
      <div class="modal-body">
        <h3 style="padding-top: 0; margin-top: 0;" class="m-t-lg with-border">Address</h3>

				<div class="row">
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=" ">Village name</label>
							<input type="text" class="form-control" id="exampleInputEmail1" name="villagename" placeholder="Please enter Village" value="">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Tehsil name</label>
							<input type="text" class="form-control" id="exampleInputPassword1" name="tehsilname" placeholder=" Please enter Tehsil ">
						</fieldset>
					</div>
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">City name </label>
							<input type="text" class="form-control" id="exampleInput" name="cityname" placeholder="Please enter city name">
						</fieldset>
					
				</div>
				  
					<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=""> District name</label>
							<input type="text" class="form-control" id="exampleInput" name="districtname" placeholder="Please enter district name">
						</fieldset>
						</div>
						<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=""> Pin code</label>
							<input type="text" class="form-control" id="exampleInput" name="pincode" placeholder="Please enter pin code">
						</fieldset>
						</div>
						<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for=""> State name</label>
							<input type="text" class="form-control" id="exampleInput" name="statename" placeholder="Please enter state name">
						</fieldset>
						</div>

						<div class="row">
					</div>
						<h3 class="m-t-lg with-border">Description</h3>
						<div class="row">
					</div>
					
					<div class="form-group row">
						<label for="exampleSelect" class="col-sm-4 form-control-label semibold">Other details of property, Housing and land other buildings</label>
						<div class="col-sm-8">
							<textarea rows="4" class="form-control" name="description" placeholder="Other details describe "></textarea>
						</div>
						<div class="row">
						</div>
						
						<div class="row">
						</div>
					</div>
					<h3 class="m-t-lg with-border">Present Time Value</h3>
					<div class="form-group row"></div>
						<label class="col-sm-2 form-control-label semibold">Present value</label>
					<div class="col-md-4 col-sm-6">
						<div class="form-group">
							<div class="input-group">
								<div class="input-group-addon">Rs</div>
								<input type="text" class="form-control" id="exampleInputAmount" name="presentvalue" placeholder="Amount">
								<div class="input-group-addon">.00</div>
							</div>
						</div>
					</div>
					
					<div class="row">
					</div>					
					<h3 class="m-t-lg with-border">If Not In Own Name</h3>
					   <div class="form-group row"></div>
					   <label class="col-sm-2 form-control-label semibold">If not in own name </label>
					   <input type="hidden" name="if_notown_name" value="NO" />
					   <input type="checkbox" name="if_notown_name" value="Yes" > Yes<br>
                       <input type="checkbox" name="if_notown_name" value="NO"> No<br>
						<div>
						
					<div class="row">
					</div>	
					   <div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Whose name </label>
							<input type="text" class="form-control" id="exampleInput" name="whosename" placeholder="Please enter name">
						</fieldset>
				         </div>
						<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Relationship to the declarant </label>
							<input type="text" class="form-control" id="exampleInput" name="relationship" placeholder="Please enter relationship">
						</fieldset>
				        </div>
				
					<div class="row">
					</div>
					<h3 class="m-t-lg with-border">Purchase Lease Details</h3>				
					 <div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">How acquired whether by </label>
						<select class="form-control" id="exampleInputPassword1" placeholder="Enter Name " name="purchasedetails">
						<option>Select</option>
						<option>Gift</option>
						<option>Lease</option>
						<option>Mortage</option>
						<option>Purchase</option>
						<option>Otherwise</option>
						</select>
							</fieldset>
					</div>
					
						
				<div class="col-lg-4">
						<fieldset class="form-group">
							<label class="form-label semibold" for="">Person from whom acquired </label>
							<input type="text" class="form-control" id="exampleInput" placeholder="Please enter person name" name="person_whom_acquired">
						</fieldset>
				</div>
				
				<div class="col-md-4">
							<div class="form-group">
										<label class="form-label semibold" for="">Date </label>
								<div class="input-group date">

									<input id="daterange3" type="text" value="10/24/1984" class="form-control" name="date">
									<span class="input-group-addon">
										<i class="font-icon font-icon-calend"></i>
									</span>
								</div>
							</div>
						</div>
				
					<div class="row">
					</div>
					<h3 class="m-t-lg with-border">Funding Details</h3>
					   <div class="form-group row"></div>
						<label class="col-sm-2 form-control-label semibold">Source of funding)</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text" class="form-control" id="inputPassword" name="funding_details" placeholder="Enter source of funding details"></p>
						</div>
						
					
					<div class="row">
					</div>
					
					  <h3 class="m-t-lg with-border">Annual Income From Property</h3>
					   <div class="form-group row"></div>
						<label class="col-sm-2 form-control-label semibold">Annual income</label>
						<div class="col-md-4 col-sm-6">
						<div class="form-group">
							<div class="input-group">
								<div class="input-group-addon">Rs</div>
								<input type="text" class="form-control" id="exampleInputAmount" name="annual_income" placeholder="Amount">
								<div class="input-group-addon">.00</div>
							</div>
						</div></div>
			
                <div class="row">
					</div>
				<h3 class="m-t-lg with-border">Remarks</h3>
				<div class="row">
					<div class="col-xs-12">
						<textarea rows="4" class="form-control" placeholder="Message type here someting you have to remember" name="remarks"></textarea>
					</div>
					</div>

          					
					<h5 class="with-border m-t-lg">
					<input type="submit" value="Next" >
						
							
	</div><!--.page-content--> 
		<div style="margin:15px">
                 <!-- <input type="submit" class="button btn-sm btn-primary center" value="Submit"> -->
                
					</div>
      </div>
    
    </div>

  </div>
</div>

</asp:Content>