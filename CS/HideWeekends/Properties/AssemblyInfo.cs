// Developer Express Code Central Example:
// How to hide weekends in the Timeline view
// 
// This example illustrates the use of a custom scale to hide the weekends in the
// Timeline view. The Saturday and Sunday are considered weekend. The Friday column
// actually contains three days - Friday, Saturday and Sunday. So it is painted
// with the color specified for the non-working days. To correct this, the
// CustomDrawTimeCell event can be handled and the time cell can be painted
// manually. The Paint Correction check box is used for switching the event
// handling on and off.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1214

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WindowsApplication1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("-")]
[assembly: AssemblyProduct("WindowsApplication1")]
[assembly: AssemblyCopyright("Copyright © - 2007")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("5c313c10-5a1f-4266-a540-e6f445dc8c39")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
