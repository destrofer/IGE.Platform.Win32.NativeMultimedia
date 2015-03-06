/*
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
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

using IGE.Platform;

namespace IGE.Platform.Win32 {
	/// <summary>
	/// </summary>
	public sealed partial class NativeMultimedia : IMusicDriver {
		public string DriverName { get { return "Native Win32 MCI"; } }
		public Version DriverVersion { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
		public bool IsSupported { get { return true; } }

		internal static NativeMultimedia Instance = null;
		public static NativeMultimedia GetInstance() {
			if( Instance != null )
				return Instance;
			return Instance = new NativeMultimedia();
		}

		private NativeMultimedia() {
		}
		
		public bool Initialize() {
			return true;
		}
		
		public bool Test() {
			return true;
		}
		
		public bool PlayMusic(string filePath) {
			// WaveAudio - for WAV files
			// MPEGVideo - for other files
			
			// string driverType = "mciqtz32";
			// string devName = String.Format("music", Utils.ExtRnd.NextUInt32());
			
			// if( Regex.IsMatch(filePath, "\\.wav$", RegexOptions.IgnoreCase) )
			//	driverType = "waveaudio";
			
			filePath = IGE.Platform.Win32.API.GetShortPathName(filePath.Replace('/', '\\').ToAbsolutePath());
			
			// string cmd = string.Format("open {1} type {0} alias {2}", driverType, filePath, devName);
			// GameDebugger.Log("Trying to play: {0}", cmd);

			// MMErrorCode openCode = NativeMultimedia.Externals.mciSendString(cmd, null, 0, ((Win32NativeWindow)Application.MainWindow).Handle);
			// GameDebugger.Log("Open code: {0}", openCode);
			
			// MMErrorCode playCode = NativeMultimedia.Externals.mciSendString(String.Format("play {0}", devName), null, 0, IntPtr.Zero);
			// GameDebugger.Log("Play code: {0}", playCode);
			

			MMErrorCode playCode = NativeMultimedia.Externals.mciSendString(String.Format("play {0}", filePath), null, 0, IntPtr.Zero);
			// GameDebugger.Log("Play code: {0}", playCode);
			
			return playCode == MMErrorCode.MMSYSERR_NOERROR;
		}
	}
}
