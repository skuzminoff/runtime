// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Data.Odbc.Tests
{
    public static class ConnectionStrings
    {
        // requires unixodbc and sqliteodbc
        public const string WorkingConnection =
            "Driver=SQLite3;" +
            "Database=smoketests.sqlite;";
    }
}
