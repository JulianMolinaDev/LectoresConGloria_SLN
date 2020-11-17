using System.IO;

namespace LectoresConGloria_NET_MVC_ADM.Utilidades
{
    public static class Converter
    {
        internal static byte[] StreamToByteArray(this Stream sourceStream)
        {
            using (var memoryStream = new MemoryStream())
            {
                sourceStream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}