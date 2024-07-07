using ImageMagick;

namespace ImageConverter;

/// <summary>A simple image converter</summary>
/// <example>
///   <para>Usage as follows:</para>
///   <code>
/// public void ToWebpTest(string inputPath, string outputPath)
/// {
///     Convert.To(inputPath, outputPath, ImageMagick.MagickFormat.WebP);
///     Assert.IsTrue(File.Exists(outputPath));
///     var fi = new FileInfo(outputPath);
///     Console.WriteLine(fi.Length);
///     Assert.IsTrue(fi.Length &gt; 1);
/// }
/// </code>
/// </example>
/// <remarks>
/// For supported formats refer to 
/// <see cref="MagickFormat"/>
/// </remarks>
/// <seealso cref="MagickFormat"/>
/// <seealso cref="ImageMagick"/>
public class Convert
{
    /// <summary>
    /// Convert an image data of any popular format to another format data
    /// </summary>
    /// <param name="input">The input.</param>
    /// <param name="format">The format.</param>
    /// <param name="quality">The quality. Default 90. It can be 0 - 100.</param>
    /// <returns>converted image data</returns>
    /// <seealso cref="To(Stream, Stream, MagickFormat, int)"/>
    /// <seealso cref="To(string, string, MagickFormat, int)"/>
    public static byte[] To(byte[] input, MagickFormat format = MagickFormat.Png, int quality = 90)
    {
        using var inputStream = new MemoryStream(input);
        // Convert the WebP image to a JPG image
        using var outputStream = new MemoryStream();
        To(inputStream, outputStream, format, quality);
        return outputStream.ToArray();
    }
    /// <summary>
    /// Convert an image stream of any popular format to another format stream
    /// </summary>
    /// <param name="inputStream">The input stream.</param>
    /// <param name="outputStream">The output stream.</param>
    /// <param name="format">The format.</param>
    /// <param name="quality">The quality. Default 90. It can be 0 - 100.</param>
    /// <seealso cref="To(byte[], MagickFormat, int)"/>
    /// <seealso cref="To(string, string, MagickFormat, int)"/>
    public static void To(Stream inputStream, Stream outputStream, MagickFormat format = MagickFormat.Png, int quality = 90)
    {
        using var image = new MagickImage(inputStream);
        image.Format = format;
        image.Quality = quality;
        image.Write(outputStream);
    }
    /// <summary>
    /// Convert an input image from a specified path to any popular format and save to another specified path
    /// </summary>
    /// <param name="inputPath">The input path.</param>
    /// <param name="outputPath">The output path.</param>
    /// <param name="format">The format.</param>
    /// <param name="quality">The quality. Default 90. It can be 0 - 100.</param>
    /// <seealso cref="To(Stream, Stream, MagickFormat, int)"/>
    /// <seealso cref="To(byte[], MagickFormat, int)"/>
    public static void To(string inputPath, string outputPath, MagickFormat format = MagickFormat.Png, int quality = 90)
    {
        using var inputStream = File.OpenRead(inputPath);
        using var outputStream = File.OpenWrite(outputPath);
        To(inputStream, outputStream, format, quality);
    }
}