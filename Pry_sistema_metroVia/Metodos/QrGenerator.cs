using QRCoder;
using System;
using System.Drawing;

namespace Pry_sistema_metroVia.Metodos
{
    public class QrGenerator
    {
        /// <summary>
        /// Genera un código QR como una imagen de tipo Bitmap.
        /// </summary>
        /// <param name="content">El contenido que se codificará en el QR.</param>
        /// <returns>Una imagen Bitmap con el código QR.</returns>
        public Bitmap GenerateQRCode(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("El contenido no puede estar vacío.", nameof(content));
            }

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    return qrCode.GetGraphic(10); // Tamaño de los píxeles
                }
            }
        }
    }
}

