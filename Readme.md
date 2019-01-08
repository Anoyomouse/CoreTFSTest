# Simple TFS Connector
This is a simple example of how to connect to TFS using the SOAP connector

# Results
Well, in an ideal world this will just output that it's working

# Actual result
Error: System.TypeLoadException: Could not load type 'Microsoft.TeamFoundation.Framework.Common.LocationServiceConstants' from assembly 'Microsoft.TeamFoundation.Common, Version=16.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'.
   at Microsoft.TeamFoundation.Client.TfsTeamProjectCollection..ctor(Uri uri, VssCredentials credentials)
   at CoreTFSTest.Program.Main(String[] args) in \CoreTFSTest\CoreTFSTest\Program.cs:line 12

# Other notes
I have tried:
Microsoft.TeamFoundationServer.ExtendedClient (and services):
- 16.144.1-preview
- 16.143.0-preview
- 16.141.1-preview
