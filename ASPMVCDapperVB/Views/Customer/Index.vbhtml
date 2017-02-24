@ModelType IEnumerable(Of ASPMVCDapperVB.Customer)
@Code
ViewData("Title") = "Index"
End Code

<br />
<p>
    @Html.ActionLink("Create New", "Create", Nothing, New With {.class = "btn btn-primary"})
</p>
<table id="tblCustomerInformation" class="table table-bordered table-condensed table-striped">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.IntroDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CreditLimit)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CompanyName)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Address)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.City)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.State)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.IntroDate)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.CreditLimit)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.CustomerID}, New With {.class = "btn btn-info"}) 
                @Html.ActionLink("Delete", "Delete", New With {.id = item.CustomerID}, New With {.class = "btn btn-warning"})
            </td>
        </tr>
    Next

</table>
