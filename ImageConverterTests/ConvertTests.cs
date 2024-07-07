namespace ImageConverter.Tests;

[TestClass()]
public class ConvertTests
{
    [DataTestMethod()]
    [DataRow("C:\\Users\\palas\\OneDrive\\Pictures\\Test\\1.webp", "C:\\Users\\palas\\OneDrive\\Pictures\\Test\\1.png")]
    public void ToPngTest(string inputPath, string outputPath)
    {
        Convert.To(inputPath, outputPath);
        Assert.IsTrue(File.Exists(outputPath));
        var fi = new FileInfo(outputPath);
        Console.WriteLine(fi.Length);
        Assert.IsTrue(fi.Length > 1);
    }
    [DataTestMethod()]
    [DataRow("C:\\Users\\palas\\OneDrive\\Pictures\\Test\\1.png", "C:\\Users\\palas\\OneDrive\\Pictures\\Test\\2.webp")]
    public void ToWebpTest(string inputPath, string outputPath)
    {
        Convert.To(inputPath, outputPath, ImageMagick.MagickFormat.WebP);
        Assert.IsTrue(File.Exists(outputPath));
        var fi = new FileInfo(outputPath);
        Console.WriteLine(fi.Length);
        Assert.IsTrue(fi.Length > 1);
    }
}