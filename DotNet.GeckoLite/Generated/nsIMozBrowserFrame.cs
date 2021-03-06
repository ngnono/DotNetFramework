// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIMozBrowserFrame.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("076AD76C-2DF6-4760-B914-21D554F0A2B6")]
	public interface nsIMozBrowserFrame : nsIDOMMozBrowserFrame
	{
		
		/// <summary>
        /// <iframe> and <frame> elements may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> or <frame>
        /// element is contained in a document privileged to create browser frames.
        ///
        /// An <iframe> or <frame> element in a privileged document with the
        /// mozbrowser attribute emits mozBrowserPropertyChange events when various
        /// things happen inside the frame.
        ///
        /// The mozBrowserPropertyChangeEvent object has two properties:
        ///
        /// property: The property which changed
        /// value:    The property's new value
        ///
        /// Currently, the |property| field may take on the following values:
        ///
        /// 'location': The content window's location changed. |value| gives the new
        /// URI.
        ///
        /// 'loading':  The content window started loading a new page (|value| ==
        /// 'start') or finished loading (|value| == 'stop').
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozbrowserAttribute();
		
		/// <summary>
        /// <iframe> and <frame> elements may have the mozbrowser attribute.
        ///
        /// The mozbrowser attribute has no effect unless the <iframe> or <frame>
        /// element is contained in a document privileged to create browser frames.
        ///
        /// An <iframe> or <frame> element in a privileged document with the
        /// mozbrowser attribute emits mozBrowserPropertyChange events when various
        /// things happen inside the frame.
        ///
        /// The mozBrowserPropertyChangeEvent object has two properties:
        ///
        /// property: The property which changed
        /// value:    The property's new value
        ///
        /// Currently, the |property| field may take on the following values:
        ///
        /// 'location': The content window's location changed. |value| gives the new
        /// URI.
        ///
        /// 'loading':  The content window started loading a new page (|value| ==
        /// 'start') or finished loading (|value| == 'stop').
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetMozbrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aMozbrowser);
		
		/// <summary>
        /// Gets whether this frame really is a browser frame.
        ///
        /// In order to really be a browser frame, this frame's
        /// nsIDOMMozBrowserFrame::mozbrowser attribute must be true, and the frame
        /// may have to pass various security checks.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReallyIsBrowserAttribute();
	}
}
