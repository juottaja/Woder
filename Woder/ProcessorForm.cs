using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Woder
{
    public partial class ProcessorForm : System.Windows.Forms.Form
    {
        private Dictionary<EncodingType, Decode> decoders = new Dictionary<EncodingType, Decode>();
        private Dictionary<EncodingType, Encode> encoders = new Dictionary<EncodingType, Encode>();

        public ProcessorForm()
        {
            InitializeComponent();
            this.comboBoxOutputEncoding.DataSource = System.Enum.GetValues(typeof(EncodingType));
            this.comboBoxInputEncoding.DataSource = System.Enum.GetValues(typeof(EncodingType));

            decoders.Add(EncodingType.UTF8, UTF8Decode);
            decoders.Add(EncodingType.HEX, HexDecode);
            decoders.Add(EncodingType.BASE64, Base64Decode);
            decoders.Add(EncodingType.BASE64URL, Base64UrlDecode);

            encoders.Add(EncodingType.UTF8, UTF8Encode);
            encoders.Add(EncodingType.HEX, HexEncode);
            encoders.Add(EncodingType.BASE64, Base64Encode);
            encoders.Add(EncodingType.BASE64URL, Base64UrlEncode);

        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            EncodingType inputEncodingType = (EncodingType)comboBoxInputEncoding.SelectedValue;
            EncodingType outputEncodingType = (EncodingType)comboBoxOutputEncoding.SelectedValue;

            String inputData = textBoxInputData.Text;

            Decode decode = decoders[inputEncodingType];
            Encode encode = encoders[outputEncodingType];

            try
            {
                byte[] bytes = decode(inputData);
                String outputData = encode(bytes);
                textBoxOutputData.Text = outputData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public delegate string Encode(byte[] bytes);
        public delegate byte[] Decode(string value);

        public string HexEncode(byte[] bytes)
        {
            var s = BitConverter.ToString(bytes).Replace("-", "");
            return s;
        }

        public byte[] HexDecode(string value)
        {
            var bytes = new byte[value.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(value.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        public string UTF8Encode(byte[] bytes)
        {
            var s = Encoding.UTF8.GetString(bytes);
            return s;
        }

        public byte[] UTF8Decode(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return bytes;
        }

        public string Base64Encode(byte[] bytes)
        {
            var s = Convert.ToBase64String(bytes);
            return s;
        }

        public byte[] Base64Decode(string value)
        {
            byte[] bytes = Convert.FromBase64String(value);
            return bytes;
        }

        public string Base64UrlEncode(byte[] bytes)
        {
            var s = Convert.ToBase64String(bytes); // Regular base64 encoder
            s = s.Split('=')[0]; // Remove any trailing '='s
            s = s.Replace('+', '-'); // 62nd char of encoding
            s = s.Replace('/', '_'); // 63rd char of encoding
            return s;
        }

        public byte[] Base64UrlDecode(string value)
        {
            var s = value;
            s = s.Replace('-', '+'); // 62nd char of encoding
            s = s.Replace('_', '/'); // 63rd char of encoding
            switch (s.Length % 4) // Pad with trailing '='s
            {
                case 0:
                    break; // No pad chars in this case
                case 2:
                    s += "==";
                    break; // Two pad chars
                case 3:
                    s += "=";
                    break; // One pad char
                default:
                    throw new Exception("Illegal base64 url string!");
            }

            byte[] bytes = Convert.FromBase64String(s); // Standard base64 decoder
            return bytes;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
