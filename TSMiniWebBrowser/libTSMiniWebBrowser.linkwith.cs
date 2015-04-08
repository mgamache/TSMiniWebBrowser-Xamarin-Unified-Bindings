using System;
using ObjCRuntime;

[assembly: LinkWith ("libTSMiniWebBrowser.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator| LinkTarget.Simulator64,SmartLink = false, ForceLoad = true)]