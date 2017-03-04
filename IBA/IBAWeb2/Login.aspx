<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IBAWeb2.Login"  %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">
     <title>Indian Bank's Assocations</title>
    <link href="img/favicon.144x144.html" rel="apple-touch-icon" type="image/png" sizes="144x144">
	<link href="img/favicon.114x114.html" rel="apple-touch-icon" type="image/png" sizes="114x114">
	<link href="img/favicon.72x72.html" rel="apple-touch-icon" type="image/png" sizes="72x72">
	<link href="img/favicon.57x57.html" rel="apple-touch-icon" type="image/png">
	<link href="img/favicon.html" rel="icon" type="image/png">
	<link href="img/favicon-2.html" rel="shortcut icon">


	<link rel="stylesheet" href="css/lib/font-awesome/font-awesome.min.css">
    <link rel="stylesheet" href="css/lib/font-awesome/font-awesome.min.css">
    <link rel="stylesheet" href="css/main.css">


</head>
<body class="with-side-menu">

    <header class="site-header">
	    <div class="container-fluid">
	        <a href="#" class="site-logo">                <!-- Logo code -->
	           <img class="hidden-md-down" src="img/logo-2.png" alt="">
	        </a>


	    </div><!--.container-fluid-->
        </header>

	<div style="margin: 200px 30%; ">
		<div class="container-fluid">
			<header class="section-header">
				<div class="tbl">
					<div class="tbl-row">
						<div class="tbl-cell">
					</div>
				</div>

			</header>

        			<div class="box-typical box-typical-padding" style="padding: 50px;">
				<p>
					<h2>Please Login Here</h2>
					</p>
			     <div class="row">
					</div>

<form runat="server">



<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold" >User Name</label>
						<div class="col-sm-10">
							<p class="form-control-static">
							<input type="text" class="form-control" id="txtUsername" 
                                placeholder="Please enter user name" name="username" runat="server" ></p>
						</div>
					</div>
					<div class="form-group row">
						<label class="col-sm-2 form-control-label semibold">Password</label>
						<div class="col-sm-10">
							<p class="form-control-static">
							<input type="password"  class="form-control" id="txtPassword" 
                                placeholder="Please enter password" name="password" runat="server" ></p>
						</div>
					</div>

					<div class="row">
					</div>
					<div style="margin-left:15px">



   <td><asp:Button  runat="server" class="button btn-sm btn-primary center" id="btnLogin" onClick="btnLogin_Click" Text="Login" /></td></div>
  </tr>








			</div><!--.box-typical-->
		</div><!--.container-fluid-->
	</div><!--.page-content-->

    </form>
</body>
    </html>