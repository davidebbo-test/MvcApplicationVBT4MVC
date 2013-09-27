Partial Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Overridable Function Index() As ActionResult
        ViewData("Message") = "Modify this template to jump-start your ASP.NET MVC application."

        Return View()
    End Function

    Overridable Function About() As ActionResult
        ViewData("Message") = "Your app description page."

        Return View()
    End Function

    Overridable Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
