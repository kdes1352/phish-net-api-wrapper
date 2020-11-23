namespace Phish.Wrapper.Core
{
    using System.Security.Cryptography;
    using System.Text;

    public class ProjectSettings
    {
        private string _uniqueHash;

        public string ApiKey { get; set; }

        public int UserId { get; set; }

        public string Salt { get; set; }

        public string UniqueHash
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_uniqueHash))
                {
                    return _uniqueHash;
                }

                var md5 = MD5.Create();
                var inputBytes = Encoding.ASCII.GetBytes(Salt + ApiKey + UserId);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }

                _uniqueHash = sb.ToString().ToLower();
                return _uniqueHash;
            }
        }
    }
}
