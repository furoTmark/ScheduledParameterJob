using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ScheduledParameterJob")]
[assembly: AssemblyDescription("This package adds the possibility to put any type of input control on the EPiServer (v.11) scheduled job interface, store the value and then use it while running the scheduled job. Values are persisted in the EPiServer DynmicDataStore and controls are inserted via an attribute and a definitions class. Example job is available through the GitHub link on the Project Information page. This package uses Episerver version 11 with .NET Framework 4.8")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Furó Tamás-Márk")]
[assembly: AssemblyProduct("ScheduledParameterJob")]
[assembly: AssemblyCopyright("Copyright Furó Tamás-Márk©  2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("02ca8f3c-8a3b-43d1-9de1-230382c04155")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.2.0.0")]
[assembly: AssemblyFileVersion("1.2.0.0")]
