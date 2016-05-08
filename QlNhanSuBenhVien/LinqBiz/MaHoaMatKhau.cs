using System.Security.Cryptography;
using System.Text;

namespace QlNhanSuBenhVien.LinqBiz
{
    public class MaHoaMatKhau
    {
        private string MaHoaSHA512(string input)
        {
            var d_EncryptionSHA512 = new SHA512Managed();
            var ByteHasEncryption = d_EncryptionSHA512.ComputeHash(Encoding.Default.GetBytes(input));
            var sbdTemp = new StringBuilder();
            for (var i = 0; i < ByteHasEncryption.Length; i++)
            {
                sbdTemp.Append(ByteHasEncryption[i].ToString("x2"));
            }
            return sbdTemp.ToString();
        }

        private string MaHoaMD5(string input)
        {
            var x = new MD5CryptoServiceProvider();
            var bs = Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            var s = new StringBuilder();
            foreach (var b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        public string MaHoaTongHop(string input)
        {
            var strChangeSha = MaHoaSHA512(input);
            var strEncode = MaHoaMD5(strChangeSha);
            return new StringBuilder(strEncode.Substring(2, 8))
                .Append(strEncode.Substring(5, 15)).ToString();
        }
    }
}
