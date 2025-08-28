using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Font
{
	public int BaseSize;
	public int GlyphCount;
	public int GlyphPadding;
	public Texture Texture;
	public Rectangle* Recs;
	public GlyphInfo* Glyphs;
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