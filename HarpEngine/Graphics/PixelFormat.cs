namespace HarpEngine.Graphics;

public enum PixelFormat
{
	UncompressedGrayscale = 1,
	UncompressedGrayAlpha,
	UncompressedR5G6B5,
	UncompressedR8G8B8,
	UncompressedR5G5B5A1,
	UncompressedR4G4B4A4,
	UncompressedR8G8B8A8,
	UncompressedR32,
	UncompressedR32G32B32,
	UncompressedR32G32B32A32,
	UncompressedR16,
	UncompressedR16G16B16,
	UncompressedR16G16B16A16,
	CompressedDxt1Rgb,
	CompressedDxt1Rgba,
	CompressedDxt3Rgba,
	CompressedDxt5Rgba,
	CompressedEtc1Rgb,
	CompressedEtc2Rgb,
	CompressedEtc2EacRgba,
	CompressedPvrtRgb,
	CompressedPvrtRgba,
	CompressedAstc4X4Rgba,
	CompressedAstc8X8Rgba
}