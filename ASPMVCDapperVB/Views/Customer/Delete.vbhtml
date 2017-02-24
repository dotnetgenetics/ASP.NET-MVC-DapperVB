@ModelType ASPMVCDapperVB.Customer
@Code
    ViewData("Title") = "Delete"
End Code


<h3>Are you sure you want to delete this record?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CompanyName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CompanyName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.State)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.State)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.IntroDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.IntroDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreditLimit)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreditLimit)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @Html.HiddenFor(Function(model) model.CustomerID)
        @<div class="form-actions no-color">
             @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-primary"})
             <input type="submit" value="Delete" class="btn btn-danger" />
        </div>
    End Using
</div>
