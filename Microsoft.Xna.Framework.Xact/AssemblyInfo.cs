using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Microsoft.Xna.Framework.Xact")]
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
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.Cue))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.AudioStopOptions))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.SoundBank))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.WaveBank))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.AudioEngine))]