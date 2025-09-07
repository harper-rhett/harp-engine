using System;
using System.Collections.Generic;
using System.Linq;
namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Font : IDisposable
{
	public int BaseSize;
	public int GlyphCount;
	public int GlyphPadding;
	public Texture Texture;
	public Rectangle* Recs;
	public GlyphInfo* Glyphs;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Font GetFontDefault();
	public static Font Default => GetFontDefault();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Font LoadFont(string fileName);
	public static Font Load(string fileName) => LoadFont(fileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Font LoadFontFromImage(Image image, Color key, int firstCharacter);
	public static Font Load(Image image, Color key, int firstCharacter) => LoadFontFromImage(image, key, firstCharacter);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadFont(Font font);

	public void Dispose()
	{
		UnloadFont(this);
	}
}

[StructLayout(LayoutKind.Sequential)]
public struct GlyphInfo
{
	public int Value;
	public int OffsetX;
	public int OffsetY;
	public int AdvanceX;
	public Image Image;
}