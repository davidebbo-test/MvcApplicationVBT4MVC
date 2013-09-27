'// <auto-generated />
'// This file was generated by a T4 template.
'// Don't change it directly as your change would get overwritten.  Instead, make changes
'// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

'// Make sure the compiler doesn't complain about missing Xml comments
'#pragma warning disable 1591
#region "T4MVC"

Imports System
Imports System.Diagnostics
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Web
Imports System.Web.Hosting
Imports System.Web.Mvc
Imports System.Web.Mvc.Ajax
Imports System.Web.Mvc.Html
Imports System.Web.Routing
Imports MvcApplicationVBT4MVC.T4MVC
    Public Partial Class HomeController
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Public Sub New()
		End Sub
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Protected Sub New(d as Dummy)
		End Sub

		<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Protected Overloads Function RedirectToAction(result as ActionResult) as RedirectToRouteResult
			Dim callInfo = result.GetT4MVCResult()
            Return RedirectToRoute(callInfo.RouteValueDictionary)
		End Function

		<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Protected Overloads Function RedirectToActionPermanent(result as ActionResult) as RedirectToRouteResult
			Dim callInfo = result.GetT4MVCResult()
            Return RedirectToRoutePermanent(callInfo.RouteValueDictionary)
		End Function


        <GeneratedCode("T4MVC", "2.0")>
		Public ReadOnly Property Actions As HomeController
			Get
				Return MVC.Home
			End Get
		End Property
        <GeneratedCode("T4MVC", "2.0")>
		Public ReadOnly Area As String = ""
        <GeneratedCode("T4MVC", "2.0")>
		Public ReadOnly Name As String = "Home"
        <GeneratedCode("T4MVC", "2.0")>
		Public Const NameConst As String = "Home"

		Shared ReadOnly s_actions As ActionNamesClass = new ActionNamesClass()
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Public ReadOnly Property ActionNames As ActionNamesClass
			Get
				Return s_actions
			End Get
		End Property

        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class ActionNamesClass
            Public ReadOnly Index As String = "Index"
            Public ReadOnly About As String = "About"
            Public ReadOnly Contact As String = "Contact"
        End Class

        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class ActionNameConstants
            Public Const Index As String = "Index"
            Public Const About As String = "About"
            Public Const Contact As String = "Contact"
        End Class


		Public Shared Readonly s_views as ViewsClass = new ViewsClass()
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Public ReadOnly Property Views as ViewsClass
			Get
				Return s_views
			End Get
		End Property

		<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
		Public Class ViewsClass
            Shared ReadOnly s_ViewNames as _ViewNamesClass = new _ViewNamesClass()
            Public ReadOnly Property ViewNames as _ViewNamesClass
            	Get
            		Return s_ViewNames
            	End Get
            End Property
            
            Public Class _ViewNamesClass
                Public ReadOnly About As String = "About"
                Public ReadOnly Contact As String = "Contact"
                Public ReadOnly Index As String = "Index"
            End Class
            Public ReadOnly About As String = "~/Views/Home/About.vbhtml"
            Public ReadOnly Contact As String = "~/Views/Home/Contact.vbhtml"
            Public ReadOnly Index As String = "~/Views/Home/Index.vbhtml"
        End Class
    End Class


	<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
	Public Partial Class T4MVC_HomeController
	Inherits HomeController
		Public Sub New()
			MyBase.New(Dummy.Instance)
		End Sub
		Partial Private Sub IndexOverride(callInfo As T4MVC_System_Web_Mvc_ActionResult)

		End Sub
        Public Overrides Function Index() as System.Web.Mvc.ActionResult 
            Dim callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index)
            IndexOverride(callInfo)
            Return callInfo
        End Function

		Partial Private Sub AboutOverride(callInfo As T4MVC_System_Web_Mvc_ActionResult)

		End Sub
        Public Overrides Function About() as System.Web.Mvc.ActionResult 
            Dim callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.About)
            AboutOverride(callInfo)
            Return callInfo
        End Function

		Partial Private Sub ContactOverride(callInfo As T4MVC_System_Web_Mvc_ActionResult)

		End Sub
        Public Overrides Function Contact() as System.Web.Mvc.ActionResult 
            Dim callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Contact)
            ContactOverride(callInfo)
            Return callInfo
        End Function

    End Class

#End Region
'#pragma warning restore 1591
