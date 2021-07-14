using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace ImageResizer
{
    /// <summary>
    /// Provides various image untilities, such as high quality resizing and the ability to save a JPEG.
    /// </summary>
    public static class ImageUtilities
    {
        /// <summary>
        /// A quick lookup for getting image encoders
        /// </summary>
        private static Dictionary<string, ImageCodecInfo> encoders = null;
        /// <summary>
        /// A quick lookup for getting image encoders
        /// </summary>
        public static Dictionary<string, ImageCodecInfo> Encoders
        {
            //get accessor that creates the dictionary on demand
            get
            {
                //if the quick lookup isn't initialised, initialise it
                if (encoders == null)
                {
                    encoders = new Dictionary<string, ImageCodecInfo>();
                }

                //if there are no codecs, try loading them
                if (encoders.Count == 0)
                {
                    //get all the codecs
                    foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders())
                    {
                        //add each codec to the quick lookup
                        encoders.Add(codec.MimeType.ToLower(), codec);
                    }
                }

                //return the lookup
                return encoders;
            }
        }
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static System.Drawing.Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }
        /// <summary> 
        /// Saves an image as a jpeg image, with the given quality 
        /// </summary> 
        /// <param name="path">Path to which the image would be saved.</param> 
        /// <param name="quality">An integer from 0 to 100, with 100 being the 
        /// highest quality</param> 
        /// <exception cref="ArgumentOutOfRangeException">
        /// An invalid value was entered for image quality.
        /// </exception>
        public static void SaveJpeg(string path, Image image, int quality)
        {
            //ensure the quality is within the correct range
            if ((quality < 0) || (quality > 100))
            {
                //create the error message
                string error = string.Format("Jpeg image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
                //throw a helpful exception
                throw new ArgumentOutOfRangeException(error);
            }

            //create an encoder parameter for the image quality
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
             //get the jpeg codec
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

            //create a collection of all parameters that we will pass to the encoder
            EncoderParameters encoderParams = new EncoderParameters(1);
            //set the quality parameter for the codec
            encoderParams.Param[0] = qualityParam;

            //save the image using the codec and the parameters
            image.Save(path, jpegCodec, encoderParams);
        }
        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            //do a case insensitive search for the mime type
            string lookupKey = mimeType.ToLower();

            //the codec to return, default to null
            ImageCodecInfo foundCodec = null;

            //if we have the encoder, get it to return
            if (Encoders.ContainsKey(lookupKey))
            {
                //pull the codec from the lookup
                foundCodec = Encoders[lookupKey];
            }

            return foundCodec;
        }

        //from msdn
        public static string GetSupportedParameters(ImageFormat fmt)
        {
            Bitmap bitmap1 = new Bitmap(1, 1);
            ImageCodecInfo jpgEncoder = GetEncoder(fmt);
            EncoderParameters paramList = bitmap1.GetEncoderParameterList(jpgEncoder.Clsid);
            
            EncoderParameter[] encParams = paramList.Param;
            StringBuilder paramInfo = new StringBuilder();

            for (int i = 0; i < encParams.Length; i++)
            {
                paramInfo.Append("Param " + i + " holds " + encParams[i].NumberOfValues +
                    " items of type " +
                    encParams[i].ValueType + "\r\n" + "Guid category: " + encParams[i].Encoder.Guid + "\r\n");

            }
            return paramInfo.ToString();
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        //custom code
        public static void ResizeAndSaveImage(Image FullsizeImage, string NewFile, string mimeType, int MaxWidth, int MaxHeight, bool OnlyResizeIfBigger, bool maintainAspect, ImageFormat fmt, int quality, int dpi, long depth)
        {
            
            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            int NewHeight, NewWidth;
            Double NewAspect = Convert.ToDouble(MaxHeight) / Convert.ToDouble(MaxWidth);
            Double OriginalAspect = Convert.ToDouble(FullsizeImage.Height) / Convert.ToDouble(FullsizeImage.Width);

            if (OriginalAspect > NewAspect)
            {
                NewHeight = MaxHeight;
                NewWidth = (MaxHeight * FullsizeImage.Width) / FullsizeImage.Height;
            }
            else
            {
                NewWidth = MaxWidth;
                NewHeight = (MaxWidth * FullsizeImage.Height) / FullsizeImage.Width;
            }
            if (!maintainAspect)
            {
                NewWidth = MaxWidth;
                NewHeight = MaxHeight;
            }
            if (OnlyResizeIfBigger)
            {
                if (FullsizeImage.Width <= MaxWidth && FullsizeImage.Height <= MaxHeight)
                {
                    NewWidth = FullsizeImage.Width;
                    NewHeight = FullsizeImage.Height;
                }
            }

            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            FullsizeImage.Dispose();

            //set some codec parameters.
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            EncoderParameter depthParam = new EncoderParameter(System.Drawing.Imaging.Encoder.ColorDepth, depth);
            //get a codec for the given image type
            ImageCodecInfo codecInfo = GetEncoderInfo(mimeType);

            //create a collection of all parameters that we will pass to the encoder
            EncoderParameters encoderParams = new EncoderParameters(1);

            if (fmt == ImageFormat.Jpeg)
                encoderParams.Param[0] = qualityParam;
            else
                encoderParams.Param[0] = depthParam;

            //save the image using the codec and the parameters
            if (dpi > 0 && fmt != ImageFormat.Gif)
            {
                NewImage.Save(NewFile + ".tmp", codecInfo, encoderParams);
                NewImage.Dispose();
                setResolution(NewFile, dpi, fmt);//doesn't work on gifs for some reason...
            }
            else
            {
                NewImage.Save(NewFile, codecInfo, encoderParams);
                NewImage.Dispose();
            }
        }
        private static void setResolution(string NewFile, int resolution, ImageFormat fmt)
        {
            System.Drawing.Bitmap bmp = (Bitmap)System.Drawing.Bitmap.FromFile(NewFile + ".tmp");

            int numerator, denominator;
            if (fmt == ImageFormat.Tiff)
            {
                // obtain the XResolution and YResolution TIFFTAG values
                PropertyItem piXRes = bmp.GetPropertyItem(282);
                PropertyItem piYRes = bmp.GetPropertyItem(283);

                // values are stored as a rational number - numerator/denominator pair
                numerator = BitConverter.ToInt32(piXRes.Value, 0);
                denominator = BitConverter.ToInt32(piXRes.Value, 4);
                float xRes = numerator / denominator;

                numerator = BitConverter.ToInt32(piYRes.Value, 0);
                denominator = BitConverter.ToInt32(piYRes.Value, 4);
                float yRes = numerator / denominator;

                // now set the values
                byte[] numeratorBytes = new byte[4];
                byte[] denominatorBytes = new byte[4];

                numeratorBytes = BitConverter.GetBytes(resolution); // specify resolution in numerator
                denominatorBytes = BitConverter.GetBytes(1);

                Array.Copy(numeratorBytes, 0, piXRes.Value, 0, 4); // set the XResolution value
                Array.Copy(denominatorBytes, 0, piXRes.Value, 4, 4);

                Array.Copy(numeratorBytes, 0, piYRes.Value, 0, 4); // set the YResolution value
                Array.Copy(denominatorBytes, 0, piYRes.Value, 4, 4);

                bmp.SetPropertyItem(piXRes); // finally set the image property resolution
                bmp.SetPropertyItem(piYRes);
            }
            bmp.SetResolution(resolution, resolution); // now set the bitmap resolution
            bmp.Save(NewFile, fmt);
            bmp.Dispose();
            System.IO.FileInfo f = new System.IO.FileInfo(NewFile + ".tmp");
            f.Delete();
        }


    }
}