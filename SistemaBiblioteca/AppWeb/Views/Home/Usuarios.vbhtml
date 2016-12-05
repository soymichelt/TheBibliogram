@ModelType IEnumerable(Of AppWeb.LoginModel)

@Code
    ViewData("Title") = "Usuarios"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Usuarios</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RememberMe)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.UserName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.RememberMe)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
