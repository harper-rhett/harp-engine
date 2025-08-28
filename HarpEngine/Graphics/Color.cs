namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct Color
{
	public byte R;
	public byte G;
	public byte B;
	public byte A;

	public static readonly Color LightGray = new Color(200, 200, 200, 255);
	public static readonly Color Gray = new Color(130, 130, 130, 255);
	public static readonly Color DarkGray = new Color(80, 80, 80, 255);
	public static readonly Color Yellow = new Color(253, 249, 0, 255);
	public static readonly Color Gold = new Color(255, 203, 0, 255);
	public static readonly Color Orange = new Color(255, 161, 0, 255);
	public static readonly Color Pink = new Color(255, 109, 194, 255);
	public static readonly Color Red = new Color(230, 41, 55, 255);
	public static readonly Color Maroon = new Color(190, 33, 55, 255);
	public static readonly Color Green = new Color(0, 228, 48, 255);
	public static readonly Color Lime = new Color(0, 158, 47, 255);
	public static readonly Color DarkGreen = new Color(0, 117, 44, 255);
	public static readonly Color SkyBlue = new Color(102, 191, 255, 255);
	public static readonly Color Blue = new Color(0, 121, 241, 255);
	public static readonly Color DarkBlue = new Color(0, 82, 172, 255);
	public static readonly Color Purple = new Color(200, 122, 255, 255);
	public static readonly Color Violet = new Color(135, 60, 190, 255);
	public static readonly Color DarkPurple = new Color(112, 31, 126, 255);
	public static readonly Color Beige = new Color(211, 176, 131, 255);
	public static readonly Color Brown = new Color(127, 106, 79, 255);
	public static readonly Color DarkBrown = new Color(76, 63, 47, 255);
	public static readonly Color White = new Color(255, 255, 255, 255);
	public static readonly Color Black = new Color(0, 0, 0, 255);
	public static readonly Color Clear = new Color(0, 0, 0, 0);
	public static readonly Color Magenta = new Color(255, 0, 255, 255);

	public Color(byte r, byte g, byte b, byte a)
	{
		R = r;
		G = g;
		B = b;
		A = a;
	}

	public Color(byte r, byte g, byte b)
	{
		R = r;
		G = g;
		B = b;
		A = 255;
	}

	public Color(int r, int g, int b, int a)
	{
		R = Convert.ToByte(r);
		G = Convert.ToByte(g);
		B = Convert.ToByte(b);
		A = Convert.ToByte(a);
	}

	public Color(int r, int g, int b)
	{
		R = Convert.ToByte(r);
		G = Convert.ToByte(g);
		B = Convert.ToByte(b);
		A = 255;
	}

	public Color(float r, float g, float b, float a)
	{
		R = (byte)(float.Clamp(r, 0f, 1f) * 255f + 0.5f);
		G = (byte)(float.Clamp(g, 0f, 1f) * 255f + 0.5f);
		B = (byte)(float.Clamp(b, 0f, 1f) * 255f + 0.5f);
		A = (byte)(float.Clamp(a, 0f, 1f) * 255f + 0.5f);
	}

	public Color(float r, float g, float b)
	{
		R = (byte)(float.Clamp(r, 0f, 1f) * 255f + 0.5f);
		G = (byte)(float.Clamp(g, 0f, 1f) * 255f + 0.5f);
		B = (byte)(float.Clamp(b, 0f, 1f) * 255f + 0.5f);
		A = 255;
	}

	public static Color Lerp(Color from, Color to, float amount)
	{
		Color color = new();
		color.R = (byte)(float.Lerp(from.R, to.R, amount) + 0.5f);
		color.G = (byte)(float.Lerp(from.G, to.G, amount) + 0.5f);
		color.B = (byte)(float.Lerp(from.B, to.B, amount) + 0.5f);
		color.A = (byte)(float.Lerp(from.A, to.A, amount) + 0.5f);
		return color;
	}

	public override string ToString()
	{
		return $"({R}, {G}, {B}, {A})";
	}
}