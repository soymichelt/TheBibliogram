@*<footer class="footer">
    <div class="container">
        <div class="row">
            <div class="foot">
                <div class="text-right">
                    <a href="#">Acerca de</a>
                    &nbsp;&nbsp;
                    <a href="#">Contactenos</a>
                    &nbsp;&nbsp;
                    <a href="#">Ayuda</a>
                    &nbsp;&nbsp;
                    © The Bibliogram @DateTime.Now.ToString("yyyy") - <a href="http://www.chontales.unan.edu.ni" target="_blank">UNAN FAREM Chontales</a>
                </div>
            </div>
        </div>
    </div>
</footer>*@
<nav class="footer navbar navbar-default navbar-fixed-bottom exp-footer">
    <div class="container-fluid">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2" aria-expanded="false">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
             <a class="navbar-brand footer-text" href="@Url.Action("Index","Home")">© The Bibliogram @DateTime.Now.ToString("yyyy")</a>
        </div>
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
            <div class="navbar-text navbar-right">
                <a href="#">Acerca de</a>
                &nbsp;&nbsp;
                <a href="#">Contactenos</a>
                &nbsp;&nbsp;
                <a href="#">Ayuda</a>
                &nbsp;&nbsp;
                <a href="http://www.chontales.unan.edu.ni" target="_blank">UNAN FAREM Chontales</a>
            </div>
        </div>
    </div>
</nav>