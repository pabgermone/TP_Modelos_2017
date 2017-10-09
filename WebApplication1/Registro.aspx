<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <html>
    <head> 
		<meta name="viewport" content="width=device-width, initial-scale=1">


		<!-- Website CSS style -->
		<link href="css/bootstrap.min.css" rel="stylesheet">

		<!-- Website Font style -->
	    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css">
		<link rel="stylesheet" href="css/RegistroEstilo.css">
		<!-- Google Fonts -->
		<link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
		<link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'>

		<title>Admin</title>
	</head>
	<body>
		<div class="container">
			<div class="row main">
				<div class="main-login main-center">
				<h5>Ingrese sus datos para el registro</h5>
					<form class="" method="post" action="#">
						
						<div class="form-group">
							<label for="name" class="cols-sm-2 control-label">Usuario</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
									<input type="text" runat="server" class="form-control" name="name" id="name"  placeholder="Usuario"/>
								</div>
                                 <asp:RequiredFieldValidator 
                            ID="rfvUser" 
                            ControlToValidate="name" 
                            runat="server" 
                            Display="Dynamic" 
                            SetFocusOnError="true" 
                            ErrorMessage="El campo Usuario es requerido." 
                            CssClass="text-danger"
                            ValidationGroup="gLogin" />
							</div>
						</div>


						<div class="form-group">
							<label for="password" class="cols-sm-2 control-label">Contraseña</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
									<input type="password" runat="server" class="form-control" name="password" id="password"  placeholder="Contraseña"/>
								</div>
                                 <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1" 
                            ControlToValidate="password" 
                            runat="server" 
                            Display="Dynamic" 
                            SetFocusOnError="true" 
                            ErrorMessage="El campo password es requerido." 
                            CssClass="text-danger"
                            ValidationGroup="gLogin" />
							</div>
						</div>

						<div class="form-group">
							<label for="confirm" class="cols-sm-2 control-label">Confirmar Contraseña</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
									<input type="password" runat="server" class="form-control"  name="confirm" id="confirm"  placeholder="Confirmar Contraseña"/>
								</div>
                             <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator2" 
                            ControlToValidate="confirm" 
                            runat="server" 
                            Display="Dynamic" 
                            SetFocusOnError="true" 
                            ErrorMessage="El campo confirm es requerido." 
                            CssClass="text-danger"
                            ValidationGroup="gLogin" />
							</div>
						</div>

						<div class="form-group ">
                       
							<asp:Button runat="server" ID="btnRegistrar" ValidationGroup="gLogin" CausesValidation="true" Text="Aceptar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click"/>
                            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
						</div>
						
					</form>
				</div>
			</div>
		</div>

		 <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
	</body>
</html>

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">

</asp:Content>
