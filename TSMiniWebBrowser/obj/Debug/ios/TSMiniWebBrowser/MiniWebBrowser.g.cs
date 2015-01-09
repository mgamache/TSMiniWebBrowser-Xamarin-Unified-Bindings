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
	[Register("TSMiniWebBrowser", true)]
	public unsafe partial class MiniWebBrowser : global::UIKit.UIViewController {
		[CompilerGenerated]
		const string selBarStyle = "barStyle";
		[CompilerGenerated]
		const string selBarTintColor = "barTintColor";
		[CompilerGenerated]
		const string selCurrentURL = "currentURL";
		[CompilerGenerated]
		const string selDelegate = "delegate";
		[CompilerGenerated]
		const string selDomainLockList = "domainLockList";
		[CompilerGenerated]
		const string selInitWithUrl_ = "initWithUrl:";
		[CompilerGenerated]
		const string selLoadURL_ = "loadURL:";
		[CompilerGenerated]
		const string selModalDismissButtonTitle = "modalDismissButtonTitle";
		[CompilerGenerated]
		const string selMode = "mode";
		[CompilerGenerated]
		const string selSetBarStyle_ = "setBarStyle:";
		[CompilerGenerated]
		const string selSetBarTintColor_ = "setBarTintColor:";
		[CompilerGenerated]
		const string selSetCurrentURL_ = "setCurrentURL:";
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		[CompilerGenerated]
		const string selSetDomainLockList_ = "setDomainLockList:";
		[CompilerGenerated]
		const string selSetFixedTitleBarText_ = "setFixedTitleBarText:";
		[CompilerGenerated]
		const string selSetModalDismissButtonTitle_ = "setModalDismissButtonTitle:";
		[CompilerGenerated]
		const string selSetMode_ = "setMode:";
		[CompilerGenerated]
		const string selSetShowActionButton_ = "setShowActionButton:";
		[CompilerGenerated]
		const string selSetShowPageTitleOnTitleBar_ = "setShowPageTitleOnTitleBar:";
		[CompilerGenerated]
		const string selSetShowReloadButton_ = "setShowReloadButton:";
		[CompilerGenerated]
		const string selSetShowURLStringOnActionSheetTitle_ = "setShowURLStringOnActionSheetTitle:";
		[CompilerGenerated]
		const string selShowActionButton = "showActionButton";
		[CompilerGenerated]
		const string selShowPageTitleOnTitleBar = "showPageTitleOnTitleBar";
		[CompilerGenerated]
		const string selShowReloadButton = "showReloadButton";
		[CompilerGenerated]
		const string selShowURLStringOnActionSheetTitle = "showURLStringOnActionSheetTitle";
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TSMiniWebBrowser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MiniWebBrowser () : base (NSObjectFlag.Empty)
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
		[Export ("initWithCoder:")]
		public MiniWebBrowser (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MiniWebBrowser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MiniWebBrowser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUrl:")]
		[CompilerGenerated]
		public MiniWebBrowser (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithUrl:"), url.Handle), "initWithUrl:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithUrl:"), url.Handle), "initWithUrl:");
			}
		}
		
		[Export ("loadURL:")]
		[CompilerGenerated]
		public virtual void LoadUrl (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadURL:"), url.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadURL:"), url.Handle);
			}
		}
		
		[Export ("setFixedTitleBarText:")]
		[CompilerGenerated]
		public virtual void SetFixedTitleBarText (string newTitleBarText)
		{
			if (newTitleBarText == null)
				throw new ArgumentNullException ("newTitleBarText");
			var nsnewTitleBarText = NSString.CreateNative (newTitleBarText);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFixedTitleBarText:"), nsnewTitleBarText);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFixedTitleBarText:"), nsnewTitleBarText);
			}
			NSString.ReleaseNative (nsnewTitleBarText);
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIBarStyle BarStyle {
			[Export ("barStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBarStyle) ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
					} else {
						ret = (global::UIKit.UIBarStyle) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("barStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIBarStyle) ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
					} else {
						ret = (global::UIKit.UIBarStyle) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setBarStyle:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (Int64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BarTintColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor BarTintColor {
			[Export ("barTintColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("barTintColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barTintColor")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = ret;
				return ret;
			}
			
			[Export ("setBarTintColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarTintColor:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarTintColor:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BarTintColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string CurrentURL {
			[Export ("currentURL", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentURL")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentURL")));
				}
			}
			
			[Export ("setCurrentURL:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCurrentURL:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCurrentURL:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public MiniWebBrowserDelegate Delegate {
			get {
				return WeakDelegate as MiniWebBrowserDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string DomainLockList {
			[Export ("domainLockList", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("domainLockList")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("domainLockList")));
				}
			}
			
			[Export ("setDomainLockList:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDomainLockList:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDomainLockList:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ModalDismissButtonTitle {
			[Export ("modalDismissButtonTitle", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("modalDismissButtonTitle")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("modalDismissButtonTitle")));
				}
			}
			
			[Export ("setModalDismissButtonTitle:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setModalDismissButtonTitle:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setModalDismissButtonTitle:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual MiniWebBrowserMode Mode {
			[Export ("mode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MiniWebBrowserMode) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("mode"));
				} else {
					return (MiniWebBrowserMode) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mode"));
				}
			}
			
			[Export ("setMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMode:"), (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMode:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowActionButton {
			[Export ("showActionButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showActionButton"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showActionButton"));
				}
			}
			
			[Export ("setShowActionButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowActionButton:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowActionButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowPageTitleOnTitleBar {
			[Export ("showPageTitleOnTitleBar", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showPageTitleOnTitleBar"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPageTitleOnTitleBar"));
				}
			}
			
			[Export ("setShowPageTitleOnTitleBar:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowPageTitleOnTitleBar:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowPageTitleOnTitleBar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowReloadButton {
			[Export ("showReloadButton", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showReloadButton"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showReloadButton"));
				}
			}
			
			[Export ("setShowReloadButton:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowReloadButton:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowReloadButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowUrlstringOnActionSheetTitle {
			[Export ("showURLStringOnActionSheetTitle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showURLStringOnActionSheetTitle"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showURLStringOnActionSheetTitle"));
				}
			}
			
			[Export ("setShowURLStringOnActionSheetTitle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowURLStringOnActionSheetTitle:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowURLStringOnActionSheetTitle:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BarTintColor_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MiniWebBrowser */
}
