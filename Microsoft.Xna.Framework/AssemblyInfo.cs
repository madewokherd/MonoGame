using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("Microsoft.Xna.Framework")]
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
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.AudioChannels))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.AudioEmitter))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.AudioListener))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.InstancePlayLimitException))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.NoAudioHardwareException))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.SoundEffect))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.SoundEffectInstance))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Audio.SoundState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.BoundingBox))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.BoundingFrustum))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.BoundingSphere))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Color))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.ContainmentType))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentLoadException))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentManager))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentReader))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentSerializerAttribute))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentSerializerIgnoreAttribute))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentTypeReader))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentTypeReader<>))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Content.ContentTypeReaderManager))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Curve))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.CurveContinuity))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.CurveKey))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.CurveKeyCollection))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.CurveLoopType))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.CurveTangent))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.DisplayOrientation))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Graphics.PackedVector.IPackedVector<>))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort2))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Graphics.PackedVector.Short2))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.Buttons))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.ButtonState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePad))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadButtons))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadCapabilities))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadDeadZone))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadDPad))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadThumbSticks))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.GamePadTriggers))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.Keyboard))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.KeyboardState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.Keys))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.KeyState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.Mouse))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Input.MouseState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.MathHelper))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Matrix))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.MediaPlayer))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.MediaSourceType))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.MediaState))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.Playlist))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.PlaylistCollection))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.Song))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Media.SongCollection))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Plane))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.PlaneIntersectionType))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.PlayerIndex))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Point))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Quaternion))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Ray))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Rectangle))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.TitleContainer))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Vector2))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Vector3))]
[assembly: TypeForwardedTo(typeof(Microsoft.Xna.Framework.Vector4))]
