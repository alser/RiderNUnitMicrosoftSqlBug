Check connection string in RiderNUnitMicrosoftSqlBug/ConnectionTest.cs prior to running test.

.NET Core SDK 3.1.302

Running test using Rider 2020.2 EAP8 from `Unit tests -> Explorer`

```
RiderNUnitMicrosoftSqlBug.ConnectionTest.CreateConnection

System.TypeInitializationException : The type initializer for 'Microsoft.Data.SqlClient.TdsParser' threw an exception.
  ----> System.TypeInitializationException : The type initializer for 'Microsoft.Data.SqlClient.SNILoadHandle' threw an exception.
  ----> System.DllNotFoundException : Unable to load DLL 'Microsoft.Data.SqlClient.SNI.dll' or one of its dependencies: The specified module could not be found. (0x8007007E)
   at Microsoft.Data.SqlClient.TdsParser..ctor(Boolean MARS, Boolean fAsynchronous)
   at Microsoft.Data.SqlClient.SqlInternalConnectionTds.LoginNoFailover(ServerInfo serverInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString connectionOptions, SqlCredential credential, TimeoutTimer timeout)
   at Microsoft.Data.SqlClient.SqlInternalConnectionTds.OpenLoginEnlist(TimeoutTimer timeout, SqlConnectionString connectionOptions, SqlCredential credential, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance)
   at Microsoft.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, Boolean applyTransientFaultHandling, String accessToken, DbConnectionPool pool)
   at Microsoft.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions)
   at Microsoft.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions)
   at Microsoft.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at Microsoft.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at Microsoft.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at Microsoft.Data.ProviderBase.DbConnectionPool.WaitForPendingOpen()
--- End of stack trace from previous location where exception was thrown ---
   at RiderNUnitMicrosoftSqlBug.ConnectionTest.CreateConnection() in C:\Users\User\RiderProjects\ConsoleApp1\RiderNUnitMicrosoftSqlBug\ConnectionTest.cs:line 17
   at RiderNUnitMicrosoftSqlBug.ConnectionTest.CreateConnection() in C:\Users\User\RiderProjects\ConsoleApp1\RiderNUnitMicrosoftSqlBug\ConnectionTest.cs:line 23
   at NUnit.Framework.Internal.TaskAwaitAdapter.GenericAdapter`1.BlockUntilCompleted()
   at NUnit.Framework.Internal.AsyncToSyncAdapter.Await(Func`1 invoke)
   at NUnit.Framework.Internal.Commands.TestMethodCommand.Execute(TestExecutionContext context)
   at NUnit.Framework.Internal.Execution.SimpleWorkItem.PerformWork()
--TypeInitializationException
   at Microsoft.Data.SqlClient.TdsParserStateObjectFactory.get_EncryptionOptions()
   at Microsoft.Data.SqlClient.TdsParser..cctor()
--DllNotFoundException
   at Microsoft.Data.SqlClient.SNINativeMethodWrapper.SNIInitialize(IntPtr pmo)
   at Microsoft.Data.SqlClient.SNILoadHandle..ctor()
   at Microsoft.Data.SqlClient.SNILoadHandle..cctor()
```

Running test in command line from solution folder:

```
dotnet test

Test run for C:\Projects\RiderNUnitMicrosoftSqlBug\RiderNUnitMicrosoftSqlBug\bin\Debug\netcoreapp3.1\RiderNUnitMicrosoftSqlBug.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.6.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 1,1210 Seconds
```
