﻿'// <auto-generated />
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
<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
Public Class MVC
    Public Shared Account As AccountController = New T4MVC_AccountController()
    Public Shared Home As HomeController = New T4MVC_HomeController()
    Public Shared [Shared] As T4MVC.SharedController = New T4MVC.SharedController()
End Class

Namespace T4MVC
End Namespace

Namespace T4MVC
    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
    Public Class Dummy
        Private Sub New()
        End Sub
        Public Shared Instance As Dummy = New Dummy()
    End Class
End Namespace

<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
Partial Friend Class T4MVC_System_Web_Mvc_ActionResult
    Inherits System.Web.Mvc.ActionResult
    Implements IT4MVCActionResult
    Public Sub New(area As String, controller As String, action As String, Optional protocol As String = Nothing)
        MyBase.New()
        Me.InitMVCT4Result(area, controller, action, protocol)
    End Sub

    Public Overrides Sub ExecuteResult(context As System.Web.Mvc.ControllerContext)
    End Sub

    Public Property Controller As String Implements IT4MVCActionResult.Controller
    Public Property Action As String Implements IT4MVCActionResult.Action
    Public Property Protocol As String Implements IT4MVCActionResult.Protocol
    Public Property RouteValueDictionary As RouteValueDictionary Implements IT4MVCActionResult.RouteValueDictionary
End Class


Namespace Links
    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
    Public Class Scripts
        Private Const URLPATH As String = "~/Scripts"
        Public Shared Function URL() As String
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
        End Function
        Public Shared Function URL(fileName As String)
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
        End Function
        Public Shared ReadOnly _references_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/_references.min.js"), Url("_references.min.js"), Url("_references.js"))
        Public Shared ReadOnly jquery_1_8_2_intellisense_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery-1.8.2.intellisense.min.js"), Url("jquery-1.8.2.intellisense.min.js"), Url("jquery-1.8.2.intellisense.js"))
        Public Shared ReadOnly jquery_1_8_2_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery-1.8.2.min.js"), Url("jquery-1.8.2.min.js"), Url("jquery-1.8.2.js"))
        Public Shared ReadOnly jquery_1_8_2_min_js As String = Url("jquery-1.8.2.min.js")
        Public Shared ReadOnly jquery_ui_1_8_24_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.24.min.js"), Url("jquery-ui-1.8.24.min.js"), Url("jquery-ui-1.8.24.js"))
        Public Shared ReadOnly jquery_ui_1_8_24_min_js As String = Url("jquery-ui-1.8.24.min.js")
        Public Shared ReadOnly jquery_unobtrusive_ajax_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js"), Url("jquery.unobtrusive-ajax.min.js"), Url("jquery.unobtrusive-ajax.js"))
        Public Shared ReadOnly jquery_unobtrusive_ajax_min_js As String = Url("jquery.unobtrusive-ajax.min.js")
        Public Shared ReadOnly jquery_validate_vsdoc_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js"), Url("jquery.validate-vsdoc.min.js"), Url("jquery.validate-vsdoc.js"))
        Public Shared ReadOnly jquery_validate_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js"), Url("jquery.validate.min.js"), Url("jquery.validate.js"))
        Public Shared ReadOnly jquery_validate_min_js As String = Url("jquery.validate.min.js")
        Public Shared ReadOnly jquery_validate_unobtrusive_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js"), Url("jquery.validate.unobtrusive.min.js"), Url("jquery.validate.unobtrusive.js"))
        Public Shared ReadOnly jquery_validate_unobtrusive_min_js As String = Url("jquery.validate.unobtrusive.min.js")
        Public Shared ReadOnly knockout_2_2_0_debug_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/knockout-2.2.0.debug.min.js"), Url("knockout-2.2.0.debug.min.js"), Url("knockout-2.2.0.debug.js"))
        Public Shared ReadOnly knockout_2_2_0_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/knockout-2.2.0.min.js"), Url("knockout-2.2.0.min.js"), Url("knockout-2.2.0.js"))
        Public Shared ReadOnly modernizr_2_6_2_js As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js"), Url("modernizr-2.6.2.min.js"), Url("modernizr-2.6.2.js"))
    End Class

    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
    Public Class Content
        Private Const URLPATH As String = "~/Content"
        Public Shared Function URL() As String
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
        End Function
        Public Shared Function URL(fileName As String)
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
        End Function
        Public Shared ReadOnly Site_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/Site.min.css"), Url("Site.min.css"), Url("Site.css"))

        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class themes
            Private Const URLPATH As String = "~/Content/themes"
            Public Shared Function URL() As String
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
            End Function
            Public Shared Function URL(fileName As String)
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
            End Function
            <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
            Public Class base
                Private Const URLPATH As String = "~/Content/themes/base"
                Public Shared Function URL() As String
                    Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
                End Function
                Public Shared Function URL(fileName As String)
                    Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
                End Function
                <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
                Public Class images
                    Private Const URLPATH As String = "~/Content/themes/base/images"
                    Public Shared Function URL() As String
                        Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
                    End Function
                    Public Shared Function URL(fileName As String)
                        Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
                    End Function
                    Public Shared ReadOnly ui_bg_flat_0_aaaaaa_40x100_png As String = Url("ui-bg_flat_0_aaaaaa_40x100.png")
                    Public Shared ReadOnly ui_bg_flat_75_ffffff_40x100_png As String = Url("ui-bg_flat_75_ffffff_40x100.png")
                    Public Shared ReadOnly ui_bg_glass_55_fbf9ee_1x400_png As String = Url("ui-bg_glass_55_fbf9ee_1x400.png")
                    Public Shared ReadOnly ui_bg_glass_65_ffffff_1x400_png As String = Url("ui-bg_glass_65_ffffff_1x400.png")
                    Public Shared ReadOnly ui_bg_glass_75_dadada_1x400_png As String = Url("ui-bg_glass_75_dadada_1x400.png")
                    Public Shared ReadOnly ui_bg_glass_75_e6e6e6_1x400_png As String = Url("ui-bg_glass_75_e6e6e6_1x400.png")
                    Public Shared ReadOnly ui_bg_glass_95_fef1ec_1x400_png As String = Url("ui-bg_glass_95_fef1ec_1x400.png")
                    Public Shared ReadOnly ui_bg_highlight_soft_75_cccccc_1x100_png As String = Url("ui-bg_highlight-soft_75_cccccc_1x100.png")
                    Public Shared ReadOnly ui_icons_222222_256x240_png As String = Url("ui-icons_222222_256x240.png")
                    Public Shared ReadOnly ui_icons_2e83ff_256x240_png As String = Url("ui-icons_2e83ff_256x240.png")
                    Public Shared ReadOnly ui_icons_454545_256x240_png As String = Url("ui-icons_454545_256x240.png")
                    Public Shared ReadOnly ui_icons_888888_256x240_png As String = Url("ui-icons_888888_256x240.png")
                    Public Shared ReadOnly ui_icons_cd0a0a_256x240_png As String = Url("ui-icons_cd0a0a_256x240.png")
                End Class

                Public Shared ReadOnly jquery_ui_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery-ui.min.css"), Url("jquery-ui.min.css"), Url("jquery-ui.css"))

                Public Shared ReadOnly jquery_ui_accordion_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.accordion.min.css"), Url("jquery.ui.accordion.min.css"), Url("jquery.ui.accordion.css"))

                Public Shared ReadOnly jquery_ui_all_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.all.min.css"), Url("jquery.ui.all.min.css"), Url("jquery.ui.all.css"))

                Public Shared ReadOnly jquery_ui_autocomplete_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.autocomplete.min.css"), Url("jquery.ui.autocomplete.min.css"), Url("jquery.ui.autocomplete.css"))

                Public Shared ReadOnly jquery_ui_base_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.base.min.css"), Url("jquery.ui.base.min.css"), Url("jquery.ui.base.css"))

                Public Shared ReadOnly jquery_ui_button_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.button.min.css"), Url("jquery.ui.button.min.css"), Url("jquery.ui.button.css"))

                Public Shared ReadOnly jquery_ui_core_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.core.min.css"), Url("jquery.ui.core.min.css"), Url("jquery.ui.core.css"))

                Public Shared ReadOnly jquery_ui_datepicker_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.datepicker.min.css"), Url("jquery.ui.datepicker.min.css"), Url("jquery.ui.datepicker.css"))

                Public Shared ReadOnly jquery_ui_dialog_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.dialog.min.css"), Url("jquery.ui.dialog.min.css"), Url("jquery.ui.dialog.css"))

                Public Shared ReadOnly jquery_ui_progressbar_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.progressbar.min.css"), Url("jquery.ui.progressbar.min.css"), Url("jquery.ui.progressbar.css"))

                Public Shared ReadOnly jquery_ui_resizable_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.resizable.min.css"), Url("jquery.ui.resizable.min.css"), Url("jquery.ui.resizable.css"))

                Public Shared ReadOnly jquery_ui_selectable_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.selectable.min.css"), Url("jquery.ui.selectable.min.css"), Url("jquery.ui.selectable.css"))

                Public Shared ReadOnly jquery_ui_slider_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.slider.min.css"), Url("jquery.ui.slider.min.css"), Url("jquery.ui.slider.css"))

                Public Shared ReadOnly jquery_ui_tabs_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.tabs.min.css"), Url("jquery.ui.tabs.min.css"), Url("jquery.ui.tabs.css"))

                Public Shared ReadOnly jquery_ui_theme_css As String = If(T4MVCHelpers.IsProduction() And T4Extensions.FileExists(URLPATH + "/jquery.ui.theme.min.css"), Url("jquery.ui.theme.min.css"), Url("jquery.ui.theme.css"))

                <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
                Public Class minified
                    Private Const URLPATH As String = "~/Content/themes/base/minified"
                    Public Shared Function URL() As String
                        Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
                    End Function
                    Public Shared Function URL(fileName As String)
                        Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
                    End Function
                    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
                    Public Class images
                        Private Const URLPATH As String = "~/Content/themes/base/minified/images"
                        Public Shared Function URL() As String
                            Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
                        End Function
                        Public Shared Function URL(fileName As String)
                            Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
                        End Function
                        Public Shared ReadOnly ui_bg_flat_0_aaaaaa_40x100_png As String = Url("ui-bg_flat_0_aaaaaa_40x100.png")
                        Public Shared ReadOnly ui_bg_flat_75_ffffff_40x100_png As String = Url("ui-bg_flat_75_ffffff_40x100.png")
                        Public Shared ReadOnly ui_bg_glass_55_fbf9ee_1x400_png As String = Url("ui-bg_glass_55_fbf9ee_1x400.png")
                        Public Shared ReadOnly ui_bg_glass_65_ffffff_1x400_png As String = Url("ui-bg_glass_65_ffffff_1x400.png")
                        Public Shared ReadOnly ui_bg_glass_75_dadada_1x400_png As String = Url("ui-bg_glass_75_dadada_1x400.png")
                        Public Shared ReadOnly ui_bg_glass_75_e6e6e6_1x400_png As String = Url("ui-bg_glass_75_e6e6e6_1x400.png")
                        Public Shared ReadOnly ui_bg_glass_95_fef1ec_1x400_png As String = Url("ui-bg_glass_95_fef1ec_1x400.png")
                        Public Shared ReadOnly ui_bg_highlight_soft_75_cccccc_1x100_png As String = Url("ui-bg_highlight-soft_75_cccccc_1x100.png")
                        Public Shared ReadOnly ui_icons_222222_256x240_png As String = Url("ui-icons_222222_256x240.png")
                        Public Shared ReadOnly ui_icons_2e83ff_256x240_png As String = Url("ui-icons_2e83ff_256x240.png")
                        Public Shared ReadOnly ui_icons_454545_256x240_png As String = Url("ui-icons_454545_256x240.png")
                        Public Shared ReadOnly ui_icons_888888_256x240_png As String = Url("ui-icons_888888_256x240.png")
                        Public Shared ReadOnly ui_icons_cd0a0a_256x240_png As String = Url("ui-icons_cd0a0a_256x240.png")
                    End Class

                    Public Shared ReadOnly jquery_ui_min_css As String = Url("jquery-ui.min.css")
                    Public Shared ReadOnly jquery_ui_accordion_min_css As String = Url("jquery.ui.accordion.min.css")
                    Public Shared ReadOnly jquery_ui_autocomplete_min_css As String = Url("jquery.ui.autocomplete.min.css")
                    Public Shared ReadOnly jquery_ui_button_min_css As String = Url("jquery.ui.button.min.css")
                    Public Shared ReadOnly jquery_ui_core_min_css As String = Url("jquery.ui.core.min.css")
                    Public Shared ReadOnly jquery_ui_datepicker_min_css As String = Url("jquery.ui.datepicker.min.css")
                    Public Shared ReadOnly jquery_ui_dialog_min_css As String = Url("jquery.ui.dialog.min.css")
                    Public Shared ReadOnly jquery_ui_progressbar_min_css As String = Url("jquery.ui.progressbar.min.css")
                    Public Shared ReadOnly jquery_ui_resizable_min_css As String = Url("jquery.ui.resizable.min.css")
                    Public Shared ReadOnly jquery_ui_selectable_min_css As String = Url("jquery.ui.selectable.min.css")
                    Public Shared ReadOnly jquery_ui_slider_min_css As String = Url("jquery.ui.slider.min.css")
                    Public Shared ReadOnly jquery_ui_tabs_min_css As String = Url("jquery.ui.tabs.min.css")
                    Public Shared ReadOnly jquery_ui_theme_min_css As String = Url("jquery.ui.theme.min.css")
                End Class

            End Class

        End Class

    End Class

    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
    Public Class Views
        Private Const URLPATH As String = "~/Views"
        Public Shared Function URL() As String
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
        End Function
        Public Shared Function URL(fileName As String)
            Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
        End Function
        Public Shared ReadOnly _ViewStart_vbhtml As String = Url("_ViewStart.vbhtml")
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class Account
            Private Const URLPATH As String = "~/Views/Account"
            Public Shared Function URL() As String
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
            End Function
            Public Shared Function URL(fileName As String)
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
            End Function
            Public Shared ReadOnly _ChangePasswordPartial_vbhtml As String = Url("_ChangePasswordPartial.vbhtml")
            Public Shared ReadOnly _ExternalLoginsListPartial_vbhtml As String = Url("_ExternalLoginsListPartial.vbhtml")
            Public Shared ReadOnly _RemoveExternalLoginsPartial_vbhtml As String = Url("_RemoveExternalLoginsPartial.vbhtml")
            Public Shared ReadOnly _SetPasswordPartial_vbhtml As String = Url("_SetPasswordPartial.vbhtml")
            Public Shared ReadOnly ExternalLoginConfirmation_vbhtml As String = Url("ExternalLoginConfirmation.vbhtml")
            Public Shared ReadOnly ExternalLoginFailure_vbhtml As String = Url("ExternalLoginFailure.vbhtml")
            Public Shared ReadOnly Login_vbhtml As String = Url("Login.vbhtml")
            Public Shared ReadOnly Manage_vbhtml As String = Url("Manage.vbhtml")
            Public Shared ReadOnly Register_vbhtml As String = Url("Register.vbhtml")
        End Class

        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class Home
            Private Const URLPATH As String = "~/Views/Home"
            Public Shared Function URL() As String
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
            End Function
            Public Shared Function URL(fileName As String)
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
            End Function
            Public Shared ReadOnly About_vbhtml As String = Url("About.vbhtml")
            Public Shared ReadOnly Contact_vbhtml As String = Url("Contact.vbhtml")
            Public Shared ReadOnly Index_vbhtml As String = Url("Index.vbhtml")
        End Class

        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Public Class [Shared]
            Private Const URLPATH As String = "~/Views/Shared"
            Public Shared Function URL() As String
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH)
            End Function
            Public Shared Function URL(fileName As String)
                Return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName)
            End Function
            Public Shared ReadOnly _Layout_vbhtml As String = Url("_Layout.vbhtml")
            Public Shared ReadOnly _LoginPartial_vbhtml As String = Url("_LoginPartial.vbhtml")
            Public Shared ReadOnly Error_vbhtml As String = Url("Error.vbhtml")
        End Class

        Public Shared ReadOnly Web_config As String = Url("Web.config")
    End Class

    <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
    Partial Public Class Bundles
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Partial Public Class Scripts
        End Class
        <GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
        Partial Public Class Styles
        End Class
    End Class
End Namespace

<GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode()>
Friend Class T4MVCHelpers
    ' You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    ' e.g. you can prepend a domain, or append a query string:
    '      return "http://localhost" + path + "?foo=bar";
    Private Shared Function ProcessVirtualPathDefault(virtualPath As String) As String
        'The path that comes in starts with ~/ and must first be made absolute
        Dim path = VirtualPathUtility.ToAbsolute(virtualPath)

        ' Add your own modifications here before returning the path
        Return path
    End Function

    ' Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    'public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
    Public Shared ProcessVirtualPath As Func(Of String, String) = AddressOf ProcessVirtualPathDefault

    ' Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    'public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;
    Public Shared TimestampString As Func(Of String, String) = AddressOf System.Web.Mvc.T4Extensions.TimestampString

    ' Logic to determine if the app is running in production or dev environment
    Public Shared Function IsProduction() As Boolean
        Return (HttpContext.Current IsNot Nothing And Not HttpContext.Current.IsDebuggingEnabled)
    End Function
End Class






#End Region
'#pragma warning restore 1591



