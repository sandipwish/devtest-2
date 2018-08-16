Imports System.Data.Common
Imports System.Data.Entity.Infrastructure.Interception
Imports System.Threading

Public Class NetworkLatencySimulationDbInterceptor
    Implements IDbCommandInterceptor

    Public Sub NonQueryExecuting(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of Integer)) Implements IDbCommandInterceptor.NonQueryExecuting
        SimulateNetworkLatency()
    End Sub

    Public Sub NonQueryExecuted(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of Integer)) Implements IDbCommandInterceptor.NonQueryExecuted
    End Sub

    Public Sub ReaderExecuting(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of DbDataReader)) Implements IDbCommandInterceptor.ReaderExecuting
        SimulateNetworkLatency()
    End Sub

    Public Sub ReaderExecuted(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of DbDataReader)) Implements IDbCommandInterceptor.ReaderExecuted
    End Sub

    Public Sub ScalarExecuting(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of Object)) Implements IDbCommandInterceptor.ScalarExecuting
        SimulateNetworkLatency()
    End Sub

    Public Sub ScalarExecuted(command As DbCommand, interceptionContext As DbCommandInterceptionContext(Of Object)) Implements IDbCommandInterceptor.ScalarExecuted
    End Sub

    Private Sub SimulateNetworkLatency()

        'Simulate network latency
        'DO NOT REMOVE!!
        Thread.Sleep(10)

    End Sub

End Class
