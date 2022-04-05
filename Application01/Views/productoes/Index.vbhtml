@ModelType IEnumerable(Of Application01.producto)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.producto1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.descripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.estado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.precio)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.producto1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.descripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.estado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.precio)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
