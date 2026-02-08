namespace SharpLeetCode.Problems.Medium;

public class Leet00535EncodeAndDecodeTinyURL
{
    private readonly System.Security.Cryptography.HashAlgorithm _hashAlgorithm = new System.Security.Cryptography.HMACSHA256();
    private readonly Dictionary<string, string> _urls = [];

    public string encode(string longUrl)
    {
        var hash = _hashAlgorithm.ComputeHash(System.Text.Encoding.UTF8.GetBytes(longUrl));
        var tinyUrl = Convert.ToBase64String(hash)[0..6];
        _urls[tinyUrl] = longUrl;
        return tinyUrl;
    }

    public string decode(string shortUrl)
    {
        return _urls[shortUrl];
    }
}