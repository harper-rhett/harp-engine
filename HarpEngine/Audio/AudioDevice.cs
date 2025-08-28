using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct AudioStream
{
	public IntPtr Buffer;
	public IntPtr Processor;
	public uint SampleRate;
	public uint SampleSize;
	public uint Channels;
}

public class AudioDevice
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void InitAudioDevice();
	public static void Initialize() => InitAudioDevice();
}
