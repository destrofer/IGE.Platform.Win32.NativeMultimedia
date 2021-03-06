﻿/*
 * Author: Viacheslav Soroka
 * 
 * This file is part of IGE <https://github.com/destrofer/IGE>.
 * 
 * IGE is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * IGE is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with IGE.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace IGE.Platform.Win32 {
	/// <summary>
	/// </summary>
	public sealed partial class NativeMultimedia : IMusicDriver {
		public static class Externals {
			[DllImport("winmm.dll")]
			public static extern MMErrorCode mciSendString(string strCommand, StringBuilder strReturn, uint iReturnLength, IntPtr hwndCallback);
		}
		
		public enum MMErrorCode : uint {
			MMSYSERR_BASE = 0x00000000,
			
			MMSYSERR_NOERROR = 0,
			MMSYSERR_ERROR = MMSYSERR_BASE+1,
			MMSYSERR_BADDEVICEID,
			MMSYSERR_NOTENABLED,
			MMSYSERR_ALLOCATED,
			MMSYSERR_INVALHANDLE,
			MMSYSERR_NODRIVER,
			MMSYSERR_NOMEM,
			MMSYSERR_NOTSUPPORTED,
			MMSYSERR_BADERRNUM,
			MMSYSERR_INVALFLAG,
			MMSYSERR_INVALPARAM,
			MMSYSERR_HANDLEBUSY,
			MMSYSERR_INVALIDALIAS,
			MMSYSERR_BADDB,
			MMSYSERR_KEYNOTFOUND,
			MMSYSERR_READERROR,
			MMSYSERR_WRITEERROR,
			MMSYSERR_DELETEERROR,
			MMSYSERR_VALNOTFOUND,
			MMSYSERR_NODRIVERCB,
			MMSYSERR_LASTERROR = MMSYSERR_NODRIVERCB,
		
			WAVERR_BASE = 0x00000020,
				
			WAVERR_BADFORMAT = WAVERR_BASE,
			WAVERR_STILLPLAYING,
			WAVERR_UNPREPARED,
			WAVERR_SYNC,
			WAVERR_LASTERROR = WAVERR_SYNC,
			
			MCIERR_BASE = 0x00000100,
			
			MCIERR_INVALID_DEVICE_ID = MCIERR_BASE + 1,
			MCIERR_UNRECOGNIZED_KEYWORD = MCIERR_BASE + 3,
			MCIERR_UNRECOGNIZED_COMMAND = MCIERR_BASE + 5,
			MCIERR_HARDWARE,
			MCIERR_INVALID_DEVICE_NAME,
			MCIERR_OUT_OF_MEMORY,
			MCIERR_DEVICE_OPEN,
			MCIERR_CANNOT_LOAD_DRIVER,
			MCIERR_MISSING_COMMAND_STRING,
			MCIERR_PARAM_OVERFLOW,
			MCIERR_MISSING_STRING_ARGUMENT,
			MCIERR_BAD_INTEGER,
			MCIERR_PARSER_INTERNAL,
			MCIERR_DRIVER_INTERNAL,
			MCIERR_MISSING_PARAMETER,
			MCIERR_UNSUPPORTED_FUNCTION,
			MCIERR_FILE_NOT_FOUND,
			MCIERR_DEVICE_NOT_READY,
			MCIERR_INTERNAL,
			MCIERR_DRIVER,
			MCIERR_CANNOT_USE_ALL,
			MCIERR_MULTIPLE,
			MCIERR_EXTENSION_NOT_FOUND,
			MCIERR_OUTOFRANGE,
			MCIERR_FLAGS_NOT_COMPATIBLE = MCIERR_BASE + 28,
			MCIERR_FILE_NOT_SAVED = MCIERR_BASE + 30,
			MCIERR_DEVICE_TYPE_REQUIRED,
			MCIERR_DEVICE_LOCKED,
			MCIERR_DUPLICATE_ALIAS,
			MCIERR_BAD_CONSTANT,
			MCIERR_MUST_USE_SHAREABLE,
			MCIERR_MISSING_DEVICE_NAME,
			MCIERR_BAD_TIME_FORMAT,
			MCIERR_NO_CLOSING_QUOTE,
			MCIERR_DUPLICATE_FLAGS,
			MCIERR_INVALID_FILE,
			MCIERR_NULL_PARAMETER_BLOCK,
			MCIERR_UNNAMED_RESOURCE,
			MCIERR_NEW_REQUIRES_ALIAS,
			MCIERR_NOTIFY_ON_AUTO_OPEN,
			MCIERR_NO_ELEMENT_ALLOWED,
			MCIERR_NONAPPLICABLE_FUNCTION,
			MCIERR_ILLEGAL_FOR_AUTO_OPEN,
			MCIERR_FILENAME_REQUIRED,
			MCIERR_EXTRA_CHARACTERS,
			MCIERR_DEVICE_NOT_INSTALLED,
			MCIERR_GET_CD,
			MCIERR_SET_CD,
			MCIERR_SET_DRIVE,
			MCIERR_DEVICE_LENGTH,
			MCIERR_DEVICE_ORD_LENGTH,
			MCIERR_NO_INTEGER,
			MCIERR_WAVE_OUTPUTSINUSE = MCIERR_BASE + 64,
			MCIERR_WAVE_SETOUTPUTINUSE,
			MCIERR_WAVE_INPUTSINUSE,
			MCIERR_WAVE_SETINPUTINUSE,
			MCIERR_WAVE_OUTPUTUNSPECIFIED,
			MCIERR_WAVE_INPUTUNSPECIFIED,
			MCIERR_WAVE_OUTPUTSUNSUITABLE,
			MCIERR_WAVE_SETOUTPUTUNSUITABLE,
			MCIERR_WAVE_INPUTSUNSUITABLE,
			MCIERR_WAVE_SETINPUTUNSUITABLE,
			MCIERR_SEQ_DIV_INCOMPATIBLE = MCIERR_BASE + 80,
			MCIERR_SEQ_PORT_INUSE,
			MCIERR_SEQ_PORT_NONEXISTENT,
			MCIERR_SEQ_PORT_MAPNODEVICE,
			MCIERR_SEQ_PORT_MISCERROR,
			MCIERR_SEQ_TIMER,
			MCIERR_SEQ_PORTUNSPECIFIED,
			MCIERR_SEQ_NOMIDIPRESENT,
			MCIERR_NO_WINDOW = MCIERR_BASE + 90,
			MCIERR_CREATEWINDOW,
			MCIERR_FILE_READ,
			MCIERR_FILE_WRITE,
			MCIERR_NO_IDENTITY,
		}
	}
}
