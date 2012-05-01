using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Microsoft.Xna.Framework.Game")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("4.0.0.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile("../xna4.pub")]

/* Breaking MonoGame into independent assemblies is hard, so for now we forward the types to one monolithic assembly. */
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.DrawableGameComponent))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Game))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameComponent))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameComponentCollection))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameComponentCollectionEventArgs))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GamerServices.GamerServicesComponent))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameServiceContainer))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameTime))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GameWindow))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GraphicsDeviceInformation))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.GraphicsDeviceManager))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.IDrawable))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.IGameComponent))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.IUpdateable))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.LaunchParameters))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.PreparingDeviceSettingsEventArgs))]
