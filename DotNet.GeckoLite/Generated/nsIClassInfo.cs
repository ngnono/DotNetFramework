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
// Generated by IDLImporter from file nsIClassInfo.idl
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
    /// Provides information about a specific implementation class.  If you want
    /// your class to implement nsIClassInfo, see nsIClassInfo.h for instructions --
    /// you most likely do not want to inherit from nsIClassInfo.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("986c11d0-f340-11d4-9075-0010a4e73d9a")]
	public interface nsIClassInfo
	{
		
		/// <summary>
        /// Get an ordered list of the interface ids that instances of the class
        /// promise to implement. Note that nsISupports is an implicit member
        /// of any such list and need not be included.
        ///
        /// Should set *count = 0 and *array = null and return NS_OK if getting the
        /// list is not supported.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInterfaces(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.Guid[] array);
		
		/// <summary>
        /// Get a language mapping specific helper object that may assist in using
        /// objects of this class in a specific lanaguage. For instance, if asked
        /// for the helper for nsIProgrammingLanguage::JAVASCRIPT this might return
        /// an object that can be QI'd into the nsIXPCScriptable interface to assist
        /// XPConnect in supplying JavaScript specific behavior to callers of the
        /// instance object.
        ///
        /// see: nsIProgrammingLanguage.idl
        ///
        /// Should return null if no helper available for given language.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetHelperForLanguage(uint language);
		
		/// <summary>
        /// A contract ID through which an instance of this class can be created
        /// (or accessed as a service, if |flags & SINGLETON|), or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetContractIDAttribute();
		
		/// <summary>
        /// A human readable string naming the class, or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetClassDescriptionAttribute();
		
		/// <summary>
        /// A class ID through which an instance of this class can be created
        /// (or accessed as a service, if |flags & SINGLETON|), or null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassIDAttribute();
		
		/// <summary>
        /// Return language type from list in nsIProgrammingLanguage
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetImplementationLanguageAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlagsAttribute();
		
		/// <summary>
        /// Also a class ID through which an instance of this class can be created
        /// (or accessed as a service, if |flags & SINGLETON|).  If the class does
        /// not have a CID, it should return NS_ERROR_NOT_AVAILABLE.  This attribute
        /// exists so C++ callers can avoid allocating and freeing a CID, as would
        /// happen if they used classID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClassIDNoAllocAttribute();
	}
	
	/// <summary>nsIClassInfoConsts </summary>
	public class nsIClassInfoConsts
	{
		
		// <summary>
        // Bitflags for 'flags' attribute.
        // </summary>
		public const long SINGLETON = 1<<0;
		
		// 
		public const long THREADSAFE = 1<<1;
		
		// 
		public const long MAIN_THREAD_ONLY = 1<<2;
		
		// 
		public const long DOM_OBJECT = 1<<3;
		
		// 
		public const long PLUGIN_OBJECT = 1<<4;
		
		// <summary>
        // 'flags' attribute bitflag: whether objects of this type implement
        // nsIContent.
        // </summary>
		public const long CONTENT_NODE = 1<<6;
		
		// <summary>
        // with this bit set.
        // </summary>
		public const long RESERVED = 1<<31;
	}
}