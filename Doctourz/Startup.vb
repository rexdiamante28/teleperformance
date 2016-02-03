Imports Owin
Imports Microsoft.Owin

<Assembly: OwinStartupAttribute(GetType(Startup))>

Partial Public Class Startup
    Public Sub Configuration(app As IAppBuilder)
        ConfigureAuth(app)

        app.MapSignalR()
    End Sub
End Class
