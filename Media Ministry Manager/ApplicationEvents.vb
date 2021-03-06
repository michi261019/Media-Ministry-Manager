﻿Option Strict On

Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports NeoSmart.Utils

Namespace My

    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        'Found this code at https://stackoverflow.com/questions/8993685/winform-splash-screen-vb-net-timer to increae
        'the time that the splash screen is on screen to 5000 ms (5 seconds)
        Protected Overrides Function OnInitialize(commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 5000
            Dim stuff1 As Byte() = Text.Encoding.Unicode.GetBytes("954086404571-qf8mk56uatvgijtkcp633ieik0nf22rb.apps.googleusercontent.com")
            Dim stuff2 As Byte() = Text.Encoding.Unicode.GetBytes("RW5XtkIcK8GvJRaMZPXObv-c")
            Environment.SetEnvironmentVariable("stuff1", UrlBase64.Encode(stuff1))
            Environment.SetEnvironmentVariable("stuff2", UrlBase64.Encode(stuff2))
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

    End Class

End Namespace