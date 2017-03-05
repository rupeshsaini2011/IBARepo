<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="d.aspx.cs" Inherits="IBAWeb2.d" MasterPageFile="~/IBA.Master" %>

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
				<!-- <p>
					<h2>Please Fill Out The Important Informations.</h2> 
					</p> -->

			     <div class="row">
					</div>

				<form  action="liabilities_form.php" method="POST">	
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Loans from friends and relatives (in rs.)</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text"  class="form-control" id="LoanFriends" runat="server" placeholder="Please enter amlount" name="loansfrom_friend_relative"></p>
						</div>
					</div>
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Loans against securities from banks (in rs.)</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text"  class="form-control" id="LoanSecurity" runat="server" placeholder="Please enter amount" name="loanagainst_securities_frombank"></p>
						</div>
					</div>
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Any other liability</label>
						<div class="col-sm-10">
							<p class="form-control-static"><input type="text"  class="form-control" id="OtherLiability" runat="server" placeholder="Please enter if you have any liability" name="anyother_liability"></p>
						</div>
					</div>
				
				<div class="row">
                                    
                                    <div class="col-xs-3">

                                         <asp:Button ID="btnSave" Text="Submit" runat="server" class="button btn-sm btn-primary center" OnClick="btnSave_Click" />
                                    </div>

                                    <div class="col-xs-3">

                                         <asp:Button ID="btnBack" Text="Back" runat="server" class="button btn-sm btn-primary center" OnClick="btnBack_Click" />
                                    </div>

                                </div>

			</div><!--.box-typical-->
		</div><!--.container-fluid-->
	</div><!--.page-content-->



</asp:Content>