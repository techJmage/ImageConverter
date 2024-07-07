#### [ImageConverter](index.md 'index')

## ImageConverter Assembly
### Namespaces

<a name='ImageConverter'></a>

## ImageConverter Namespace
### Classes

<a name='ImageConverter.Convert'></a>

## Convert Class

A simple image converter

```csharp
public class Convert
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Convert

### Example
  
Usage as follows:  
  
```csharp  
public void ToWebpTest(string inputPath, string outputPath)  
{  
    Convert.To(inputPath, outputPath, ImageMagick.MagickFormat.WebP);  
    Assert.IsTrue(File.Exists(outputPath));  
    var fi = new FileInfo(outputPath);  
    Console.WriteLine(fi.Length);  
    Assert.IsTrue(fi.Length > 1);  
}  
```

### Remarks
For supported formats refer to   
[ImageMagick.MagickFormat](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick.MagickFormat 'ImageMagick.MagickFormat')

### See Also
- [ImageMagick.MagickFormat](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick.MagickFormat 'ImageMagick.MagickFormat')
- [ImageMagick](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick 'ImageMagick')
### Methods

<a name='ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int)'></a>

## Convert.To(byte[], MagickFormat, int) Method

Convert an image data of any popular format to another format data

```csharp
public static byte[] To(byte[] input, ImageMagick.MagickFormat format=ImageMagick.MagickFormat.Png, int quality=90);
```
#### Parameters

<a name='ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int).input'></a>

`input` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The input.

<a name='ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int).format'></a>

`format` [ImageMagick.MagickFormat](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick.MagickFormat 'ImageMagick.MagickFormat')

The format.

<a name='ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int).quality'></a>

`quality` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The quality. Default 90. It can be 0 - 100.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
converted image data

### See Also
- [To(Stream, Stream, MagickFormat, int)](index.md#ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(System.IO.Stream, System.IO.Stream, ImageMagick.MagickFormat, int)')
- [To(string, string, MagickFormat, int)](index.md#ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(string, string, ImageMagick.MagickFormat, int)')

<a name='ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int)'></a>

## Convert.To(string, string, MagickFormat, int) Method

Convert an input image from a specified path to any popular format and save to another specified path

```csharp
public static void To(string inputPath, string outputPath, ImageMagick.MagickFormat format=ImageMagick.MagickFormat.Png, int quality=90);
```
#### Parameters

<a name='ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int).inputPath'></a>

`inputPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The input path.

<a name='ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int).outputPath'></a>

`outputPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The output path.

<a name='ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int).format'></a>

`format` [ImageMagick.MagickFormat](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick.MagickFormat 'ImageMagick.MagickFormat')

The format.

<a name='ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int).quality'></a>

`quality` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The quality. Default 90. It can be 0 - 100.

### See Also
- [To(Stream, Stream, MagickFormat, int)](index.md#ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(System.IO.Stream, System.IO.Stream, ImageMagick.MagickFormat, int)')
- [To(byte[], MagickFormat, int)](index.md#ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(byte[], ImageMagick.MagickFormat, int)')

<a name='ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int)'></a>

## Convert.To(Stream, Stream, MagickFormat, int) Method

Convert an image stream of any popular format to another format stream

```csharp
public static void To(System.IO.Stream inputStream, System.IO.Stream outputStream, ImageMagick.MagickFormat format=ImageMagick.MagickFormat.Png, int quality=90);
```
#### Parameters

<a name='ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int).inputStream'></a>

`inputStream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The input stream.

<a name='ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int).outputStream'></a>

`outputStream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The output stream.

<a name='ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int).format'></a>

`format` [ImageMagick.MagickFormat](https://docs.microsoft.com/en-us/dotnet/api/ImageMagick.MagickFormat 'ImageMagick.MagickFormat')

The format.

<a name='ImageConverter.Convert.To(System.IO.Stream,System.IO.Stream,ImageMagick.MagickFormat,int).quality'></a>

`quality` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The quality. Default 90. It can be 0 - 100.

### See Also
- [To(byte[], MagickFormat, int)](index.md#ImageConverter.Convert.To(byte[],ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(byte[], ImageMagick.MagickFormat, int)')
- [To(string, string, MagickFormat, int)](index.md#ImageConverter.Convert.To(string,string,ImageMagick.MagickFormat,int) 'ImageConverter.Convert.To(string, string, ImageMagick.MagickFormat, int)')