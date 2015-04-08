//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace TSMiniWebBrowser {
	[Protocol (Name = "TSMiniWebBrowserDelegate", WrapperType = typeof (MiniWebBrowserDelegateWrapper))]
	public interface IMiniWebBrowserDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MiniWebBrowserDelegate_Extensions {
		[CompilerGenerated]
		public static void DidDismiss (this IMiniWebBrowserDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("tsMiniWebBrowserDidDismiss"));
		}
		
	}
	
	internal sealed class MiniWebBrowserDelegateWrapper : BaseWrapper, IMiniWebBrowserDelegate {
		public MiniWebBrowserDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MiniWebBrowserDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace TSMiniWebBrowser {
	[Protocol]
	[Register("TSMiniWebBrowserDelegate", true)]
	[Model]
	public unsafe partial class MiniWebBrowserDelegate : NSObject, IMiniWebBrowserDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MiniWebBrowserDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MiniWebBrowserDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MiniWebBrowserDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("tsMiniWebBrowserDidDismiss")]
		[CompilerGenerated]
		public virtual void DidDismiss ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MiniWebBrowserDelegate */
}
