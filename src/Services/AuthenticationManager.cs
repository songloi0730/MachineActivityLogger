using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MachineActivityLogger.src.Services
{
    public class AuthenticationManager
    {
        private string _secret = "Nhan";    //Thay bằng key bảo mật thực tế hoặc gen key tự động

        public bool ValidateTimeBasedKey(string inputKey, string userName)
        {
            //Generate key theo thời gian hiện tại
            string timeBasedKey = DateTime.Now.ToString("yyyyMMddHH"); //Key thay đổi mỗi giờ
            //Kết hợp với secret để tăng độ bảo mật
            string expectedKey = GenerateKey(userName, timeBasedKey);

            return inputKey == expectedKey;
        }

        private string GenerateKey(string userName, string timeBasedKey)
        {
            //Simple hash function combining username, time-based key and secret
            string combined = _secret + userName + timeBasedKey;

            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(combined));
                return BitConverter.ToString(hash).Replace("-", "").Substring(0, 8).ToLower();
            }
        }
    }
}
