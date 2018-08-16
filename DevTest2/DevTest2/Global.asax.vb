Imports System.Data.Entity.Infrastructure.Interception
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        'Forces initialization of database on model changes.
        Using context As New AppDbContext()
            context.Database.Initialize(False)
        End Using

        'DO NOT REMOVE!!
        DbInterception.Add(New NetworkLatencySimulationDbInterceptor())

    End Sub
End Class
