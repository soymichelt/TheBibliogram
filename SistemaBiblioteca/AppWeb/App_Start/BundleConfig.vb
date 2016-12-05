Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryui").Include(
                    "~/Scripts/jquery-ui-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include("~/Content/bootstrap/js/bootstrap.js"))

        bundles.Add(New ScriptBundle("~/bundles/bsswitch").Include("~/Content/bootstrap-switch/js/bootstrapswitch.js"))

        bundles.Add(New ScriptBundle("~/bundles/icheck").Include("~/Content/icheck1x/icheckmin.js"))

        bundles.Add(New ScriptBundle("~/bundles/selectbs").Include("~/Content/bootstrapselect/js/bootstrap-selectmin.js"))

        bundles.Add(New ScriptBundle("~/bundles/jspersonal").Include("~/Scripts/jspersonal.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.unobtrusive*",
                    "~/Scripts/jquery.validate*"))

        'js administrator
        bundles.Add(New ScriptBundle("~/bundles/administrator").Include("~/Content/Administrator/js/app-min.js"))
        bundles.Add(New ScriptBundle("~/bundles/ChartJS").Include("~/Content/ChartJS/Chartmin.js"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
        ' preparado para la producción y podrá utilizar la herramienta de creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/Site.css"))

        bundles.Add(New StyleBundle("~/Content/bsswitch").Include("~/Content/bootstrap-switch/css/bootstrapswitchmin.css"))

        bundles.Add(New StyleBundle("~/Content/general").Include("~/Content/bootstrap/css/bootstrapmin.css", "~/Content/IconsInputText.css"))

        bundles.Add(New StyleBundle("~/Content/bs").Include("~/Content/bootstrap/css/bootstrapmin.css"))

        bundles.Add(New StyleBundle("~/Content/account").Include("~/Content/Signin.css"))

        bundles.Add(New StyleBundle("~/Content/icheckcolor").Include("~/Content/icheck1x/skins/square/green.css"))

        bundles.Add(New StyleBundle("~/Content/selectbscss").Include("~/Content/bootstrapselect/css/bootstrap-select.css"))

        bundles.Add(New StyleBundle("~/Content/landingpage").Include("~/Content/LandingPage.css"))

        bundles.Add(New StyleBundle("~/Content/search").Include("~/Content/Search.css"))

        bundles.Add(New StyleBundle("~/Content/themes/base/css").Include(
                    "~/Content/themes/base/jquery.ui.core.css",
                    "~/Content/themes/base/jquery.ui.resizable.css",
                    "~/Content/themes/base/jquery.ui.selectable.css",
                    "~/Content/themes/base/jquery.ui.accordion.css",
                    "~/Content/themes/base/jquery.ui.autocomplete.css",
                    "~/Content/themes/base/jquery.ui.button.css",
                    "~/Content/themes/base/jquery.ui.dialog.css",
                    "~/Content/themes/base/jquery.ui.slider.css",
                    "~/Content/themes/base/jquery.ui.tabs.css",
                    "~/Content/themes/base/jquery.ui.datepicker.css",
                    "~/Content/themes/base/jquery.ui.progressbar.css",
                    "~/Content/themes/base/jquery.ui.theme.css"))

        'cssadministrator
        bundles.Add(New StyleBundle("~/Content/administrator").Include("~/Content/Administrator/css/AdminLTEmin.css").Include("~/Content/Administrator/css/AdminPersonalizeStyle.css"))
        bundles.Add(New StyleBundle("~/Content/skin").Include("~/Content/Administrator/css/skins/skin-green-min.css"))




        'material design
        'version completa
        bundles.Add(New StyleBundle("~/Content/mdc").Include("~/Content/materialize/css/materialize.css"))
        bundles.Add(New ScriptBundle("~/bundles/mdc").Include("~/Content/materialize/js/materialize.js"))
        'version min
        bundles.Add(New StyleBundle("~/Content/md").Include("~/Content/materialize/css/materializemin.css"))
        bundles.Add(New ScriptBundle("~/bundles/md").Include("~/Content/materialize/js/materializemin.js"))


        'Controles personales
        'tab
        bundles.Add(New StyleBundle("~/Content/tab").Include("~/Content/Controles/tab/tab.css"))
        bundles.Add(New ScriptBundle("~/bundles/tab").Include("~/Content/Controles/tab/tab.js"))
    End Sub
End Class