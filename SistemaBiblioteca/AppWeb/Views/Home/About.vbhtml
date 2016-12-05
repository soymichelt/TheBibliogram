@Code
    ViewData("Title") = "Información"
    Layout = "~/Views/Shared/_LandingPageLayout.vbhtml"
End Code
@Styles.Render("~/Content/tab")
<div class="photo-front jumbotron">
    <div class="container-fluid">
        <img class="pull-right" width="30px" src="~/Images/LogoUNAN.png" />
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-1 visible-md visible-lg">

            </div>
            <div class="col-md-3 visible-md visible-lg">
                <img class="img-responsive" src="~/Images/photo-smartphone2.png" alt="Alternate Text" />
            </div>
            <div class="col-md-7 text-center">
                <h1>Bienvenido!</h1>
                <p>Biblioteca "Alejandro Sequeira Hernández". Obtén información de nuestros servicios y usa nuestro Sistema de Biblioteca Online.</p>
                <p>
                    <a class="btn btn-default btn-lg btn-flat-default" href="#" role="button">Regístrate</a>
                    <a class="btn btn-default btn-lg btn-flat-default" href="#" role="button">Iniciar Sesión</a>
                </p>
            </div>
        </div>
    </div>
</div>
<div class="band-theme">
    <div class="col-xs-3 b">

    </div>
    <div class="col-xs-3 r">

    </div>
    <div class="col-xs-3 y">

    </div>
    <div class="col-xs-3 g">

    </div>
</div>
@*<div class="jumbotron">
    <div class="container-fluid">
        <h1 class="text-center title">Biblioteca "Alejandro Sequeria Hernández"</h1>
    </div>
</div>*@
@*<div class="container">
    <div class="row tabs">
        <div class="tab col-xs-4 text-center" data-tab="tab-acercade">
            Acerca de
        </div>
        <div class="tab col-xs-4 text-center" data-tab="tab-mision">
            Misión
        </div>
        <div class="tab col-xs-4 text-center" data-tab="tab-vision">
            Visión
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
            <div class="indicador">

            </div>
        </div>
    </div>
    <div class="tab-content">
        <div class="tab-section tab-active" id="tab-acercade">
            Tab 1
        </div>
        <div class="tab-section" id="tab-mision">
            Tab 2
        </div>
        <div class="tab-section" id="tab-vision">
            Tab 3
        </div>
    </div>
</div>*@
<div class="container">
    <div class="row">
        <br />
        <h1 class="text-center">Conoce nuestros servicios.</h1>
        <h2 class="text-center subtitle">Contamos con mas de 10, 000 unidades bibliográficas</h2>
        <img class="img-responsive img-center px20" src="~/Images/SistemaOnline.png" />
        <div class="text-center">
            <a class="btn btn-default btn-md btn-flat-green" href="#" role="button">Regístrate</a>
            <a class="btn btn-default btn-md btn-flat-green" href="#" role="button">Iniciar Sesión</a>
        </div>
        <br />
        <br />
    </div>
</div>
<div class="jumbotron" style="margin-bottom:0px;">
    <div class="container">
        <div class="row">
            <h1 class="text-center">Sobre la Biblioteca</h1>
            <br />
            <div class="col-xs-12">
                <div class="media">
                    <div class="media-left">
                        <a href="#">
                            <img src="~/Images/uno.png" />
                        </a>
                    </div>
                    <div class="media-body">
                        <h3 class="media-heading">
                            Acerca de la Biblioteca
                        </h3>
                        Nuestra principal función consiste en mantener un buen fondo bibliográfico actualizado y facilitar, mediante los servicios eficientes del personal, el uso de los documentos necesarios para satisfacer las necesidades de información de los usuarios, de investigación y de educación.
                        <br />
                        Dentro de sus funciones, la biblioteca es el centro de actividades de más importancia en la vida académica de la universidad en la que se realizan diversos tipos de investigaciones, mediante sus recursos y servicios.
                        <br />
                        La Dirección de la Biblioteca Central Salomón de la Selva promueve y difunde las pautas culturales que han conformado nuestra universidad, la investigación y la información como recursos valiosos para la toma de decisiones, por esto trabaja con un amplio compromiso social para mejorar y brindar un servicio de calidad a la comunidad de usuarios de forma rápida y eficaz .
                    </div>
                </div>
                <br />
                <div class="media">
                    <div class="media-left">
                        <a href="#">
                            <img src="~/Images/dos.png" />
                        </a>
                    </div>
                    <div class="media-body">
                        <h3 class="media-heading">
                            Misión de la Biblioteca
                        </h3>
                        Somos una unidad de información que identifica, selecciona, organiza y garantiza el acceso a la información científica, integral y de calidad a la comunidad universitaria y apoya la formación continua, en el contexto de los principios de identidad institucional y de los lineamientos de la eficiencia, con personal comprometido y calificado.
                    </div>
                </div>
                <br />
                <div class="media">
                    <div class="media-left">
                        <a href="#">
                            <img src="~/Images/tres.png" />
                        </a>
                    </div>
                    <div class="media-body">
                        <h3 class="media-heading">
                            Visión de la Biblioteca
                        </h3>
                        Un sistema bibliotecario integrado que gestiona la información y responde eficientemente a las actividades académicas y de investigación de la UNAN-Managua, de acuerdo a las exigencias del medio; con servicios orientados en las diferentes áreas del conocimiento, en un ambiente de tranquilidad y bienestar, con espacios disponibles para recrear la imaginación y el talento, haciendo uso de tecnología de punta como mecanismo para la construcción del aprendizaje, y aplicando los estándares nacionales e internacionales de calidad.
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/tab")
End Section