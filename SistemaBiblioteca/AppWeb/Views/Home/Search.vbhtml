@Code
    ViewData("Title") = "Search"
    Layout = "~/Views/Shared/_PageLayout.vbhtml"
End Code
@Using Html.BeginForm("Busqueda", "Home", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Get)
    
End Using

<div class="row">
    <div class="col s7">
        <div class="card">
            <div class="card-image">
                <img src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg">
                <span class="card-title">La programación orientada a objetos es una forma de programar con una tecnica pulcra y que hace mejores a los programadores que son malos de por si.</span>
            </div>
            <div class="card-content">
                <span class="card-title activator grey-text text-darken-4">Card Title<i class="material-icons right">more_vert</i></span>
                <p><a href="#">This is a link</a></p>
                <p>
                    I am a very simple card. I am good at containing small bits of information.
            I am convenient because I require little markup to use effectively.
                </p>
            </div>
            <div class="card-reveal">
                <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                <p>Here is some more information about this product that is only revealed once clicked on.</p>
            </div>
            <div class="card-action">
                <a href="#">This is a link</a>
            </div>
        </div>
    </div>
    <div class="col s7">
        <div class="card">
            <div class="card-image">
                <img src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg">
                <span class="card-title">La programación orientada a objetos es una forma de programar con una tecnica pulcra y que hace mejores a los programadores que son malos de por si.</span>
            </div>
            <div class="card-content">
                <span class="card-title activator grey-text text-darken-4">Card Title<i class="material-icons right">more_vert</i></span>
                <p><a href="#">This is a link</a></p>
                <p>
                    I am a very simple card. I am good at containing small bits of information.
            I am convenient because I require little markup to use effectively.
                </p>
            </div>
            <div class="card-reveal">
                <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                <p>Here is some more information about this product that is only revealed once clicked on.</p>
            </div>
            <div class="card-action">
                <a href="#">This is a link</a>
            </div>
        </div>
    </div>
    <div class="col s7">
        <div class="card">
            <div class="card-image">
                <img src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg">
                <span class="card-title">La programación orientada a objetos es una forma de programar con una tecnica pulcra y que hace mejores a los programadores que son malos de por si.</span>
            </div>
            <div class="card-content">
                <span class="card-title activator grey-text text-darken-4">Card Title<i class="material-icons right">more_vert</i></span>
                <p><a href="#">This is a link</a></p>
                <p>
                    I am a very simple card. I am good at containing small bits of information.
            I am convenient because I require little markup to use effectively.
                </p>
            </div>
            <div class="card-reveal">
                <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                <p>Here is some more information about this product that is only revealed once clicked on.</p>
            </div>
            <div class="card-action">
                <a href="#">This is a link</a>
            </div>
        </div>
    </div>
</div>

<div class="row">
    <div class="col s8">
        <div class="row">
            <div class="col s3">
                <img class="circle responsive-img" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg">
            </div>
        </div>
    </div>
</div>
