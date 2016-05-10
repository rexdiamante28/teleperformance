Imports System.Globalization
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports Owin
Public Class HomeController
    Inherits Controller

    'Home Page
    Public Function Index() As ActionResult
        If Not Request.IsAuthenticated Then
            Return RedirectToAction("Login", "Account")
        End If


        Return RedirectToAction("Home", "User")

        'Return RedirectToAction
    End Function

    ' About Page
    Public Function About() As ActionResult
        Return View()
    End Function

    ' Contact Page
    Public Function Contact() As ActionResult
        Return View()
    End Function

End Class
