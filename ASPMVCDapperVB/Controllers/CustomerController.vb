Imports System.Web.Mvc

Namespace Controllers
    Public Class CustomerController
        Inherits Controller

        Dim _service As CustomerService

        Public Sub New()
            _service = New CustomerService()
        End Sub

        ' GET: Customer
        Function Index() As ActionResult
            Dim model = _service.GetAll()
            Return View(model)
        End Function

        ' GET: Customer/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Customer/Create
        <HttpPost()>
        Function Create(customer As Customer) As ActionResult
            Try
                _service.AddCustomer(customer)
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Customer/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Dim model = _service.FindById(id)
            Return View(model)
        End Function

        ' POST: Customer/Edit/5
        <HttpPost()>
        Function Edit(customer As Customer) As ActionResult
            Try
                _service.UpdateCustomer(customer)
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Customer/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Dim model = _service.FindById(id)
            Return View(model)
        End Function

        ' POST: Customer/Delete/5
        <HttpPost()>
        Function Delete(customer As Customer) As ActionResult
            Try
                _service.DeleteCustomer(customer.CustomerID)
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace