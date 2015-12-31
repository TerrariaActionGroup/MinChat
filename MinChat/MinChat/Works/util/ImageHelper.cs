using MinChat.Communications.bean;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Works.utils
{
    class ImageHelper
    {
        /// <summary>
        /// 从文件获取Image对象
        /// </summary>
        /// <param name="file">文件路径</param>
        /// <returns></returns>
        public Image getImg(string file)
        {
            return Image.FromFile(file);
        }


        /// <summary>
        /// 从文件获取Bitmap对象
        /// </summary>
        /// <param name="file">文件路径</param>
        /// <returns></returns>
        public Bitmap getBitmap(string file)
        {
            return new Bitmap(file);
        }


        /// <summary>
        /// Convert Image to Byte[]
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static byte[] ImageToBytes(Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }


        /// <summary>
        /// Convert Byte[] to Image
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

 
        /// <summary>
        /// Convert Byte[] to a picture and Store it in file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string CreateImageFromBytes(string fileName, byte[] buffer)
        {
            string file = fileName;
            Image image = BytesToImage(buffer);
            ImageFormat format = image.RawFormat;
            if (format.Equals(ImageFormat.Jpeg))
            {
                file += ".jpeg";
            }
            else if (format.Equals(ImageFormat.Png))
            {
                file += ".png";
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                file += ".bmp";
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                file += ".gif";
            }
            else if (format.Equals(ImageFormat.Icon))
            {
                file += ".icon";
            }
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            System.IO.Directory.CreateDirectory(info.Directory.FullName);
            File.WriteAllBytes(file, buffer);
            return file;
        }


        /// <summary>
        /// Store image in file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string CreateImageFromBytes(string fileName, Image image)
        {
            string file = fileName;
            ImageFormat format = image.RawFormat;
            if (format.Equals(ImageFormat.Jpeg))
            {
                file += ".jpeg";
            }
            else if (format.Equals(ImageFormat.Png))
            {
                file += ".png";
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                file += ".bmp";
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                file += ".gif";
            }
            else if (format.Equals(ImageFormat.Icon))
            {
                file += ".icon";
            }
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            System.IO.Directory.CreateDirectory(info.Directory.FullName);

            File.WriteAllBytes(file, ImageToBytes(image));
            return file;
        }


        /// <summary>
        /// 根据id与图片对象生成byte数组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns>拼装后字节数组大小</returns>
        public static byte[] customizeImg(string id, Image img)
        {
            byte[] idBytes = System.Text.Encoding.UTF8.GetBytes(id);
            byte[] imgBytes = ImageToBytes(img);

            byte[] result = new byte[idBytes.Length + imgBytes.Length];
            idBytes.CopyTo(result, 0);
            imgBytes.CopyTo(result, idBytes.Length);
            
            return result;
        }

        /// <summary>
        /// 图片字节数组得到图片id和图片对象
        /// </summary>
        /// <param name="mImg"></param>
        /// <returns></returns>
        public static MsgImg bytesToIdImg(byte[] mImg)
        {
            //解析id
            byte[] id = new byte[11];
            Array.Copy(mImg, 0, id, 0, 11);
            string idStr = System.Text.Encoding.UTF8.GetString(id);

            //解析图片
            byte[] img = new byte[mImg.Length - 11];
            Array.Copy(mImg, 11, img, 0, mImg.Length - 11);
            Image image = BytesToImage(img);

            MsgImg msgImg = new MsgImg();
            msgImg.Id = idStr;
            msgImg.Img = image;

            return msgImg;
        }

    }
}
