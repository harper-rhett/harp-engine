namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct Color
{
	public byte R;
	public byte G;
	public byte B;
	public byte A;

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

	public Color DropAlpha()
	{
		Color color = this;
		color.A = 0;
		return color;
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