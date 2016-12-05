@ModelType AppWeb.AccountServicio.DUsuario

@Code
    ViewData("Title") = "Register"
    Layout = "~/Views/Shared/_AccountLayout.vbhtml"
End Code
@Styles.Render("~/Content/icheckcolor")
@If Not ViewData("Mensaje") Is Nothing Then
    @<div class="alert alert-danger" role="alert">
        @ViewData("Mensaje")
        <a href="#" class="alert-link">Inicio</a>
    </div>
End If
<div id="Login">
    <img id="Logo" src="~/Images/Logo.png" class="img-responsive">
    <div class="form-signin">
        @Using Html.BeginForm("Register", "AccountSecurity", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Post, New With {.Id = "_Register"})
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(true)
            
            @<label for="Name" class="sr-only">Nombres</label>
            @<div id="c-Name" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-asterisk"></i>
                @Html.TextBoxFor(Function(m) m.Nombres, New With {.class = "fc form-control input-theme", .placeholder = "Nombres", .required = "required", .autofocus = ""})
            </div>
            
            
            @<label for="LastName" class="sr-only">Apellidos</label>
            @<div  id="c-LastName" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-asterisk"></i>
                @Html.TextBoxFor(Function(m) m.Apellidos, New With {.class = "form-control input-theme", .placeholder = "Apellidos", .required = "required"})
            </div>
            
            @<br />
            @<br />
            @Html.RadioButtonFor(Function(m) m.Sexo, True, New With {.class= "iCheck", .checked = ""})
            @<label for="Hombre" class="">Hombre</label>
            @Html.RadioButtonFor(Function(m) m.Sexo, False, New With {.class= "iCheck"})
            @<label for="Mujer" class="">Mujer</label>
            
            @<br />
            @<br />
            @<label for="FechaNacimiento" class="sr-only">Fecha de Nacimiento</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-time"></i>
                @Html.TextBoxFor(Function(m) m.FechaNacimiento, New With {.class = "form-control input-theme", .placeholder = "Fecha de Nacimiento", .required = "required", .type = "Date"})
            </div>
            
            @<br />
            
            @<label for="Email" class="sr-only">Correo Electrónico</label>
            @<div id="c-Email" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-user"></i>
                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control input-theme", .placeholder = "Correo Electrónico", .required = "required", .type = "Email"})
            </div>
            
            @<br />
            
            @<label for="Password" class="sr-only">Contraseña</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-lock"></i>
                @Html.TextBoxFor(Function(m) m.Password, New With {.class = "form-control input-theme", .placeholder = "Contraseña", .required = "required", .type = "Password"})
            </div>
            
            @<br />
            
            @<button id="BtnSesion" class="btn btn-lg btn-success btn-block btn-theme" type="submit">Registrarte</button>
        End Using
    </div>

</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/bundles/icheck")
    @Scripts.Render("~/bundles/jspersonal")
    <script type="text/javascript">
        $(document).ready(function () {
            $("#_Register").removeAttr("novalidate");
        });
    </script>
End Section