namespace SAMLClientAD
{
    public class RsaPkCs1Sha1SignatureDescription : System.Security.Cryptography.SignatureDescription
    {
        public RsaPkCs1Sha1SignatureDescription()
        {
            KeyAlgorithm = "System.Security.Cryptography.RSACryptoServiceProvider";
            DigestAlgorithm = "System.Security.Cryptography.SHA1Managed";
            FormatterAlgorithm = "System.Security.Cryptography.RSAPKCS1SignatureFormatter";
            DeformatterAlgorithm = "System.Security.Cryptography.RSAPKCS1SignatureDeformatter";
        }
        public override System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key)
        {
            var asymmetricSignatureDeformatter = (System.Security.Cryptography.AsymmetricSignatureDeformatter)System.Security.Cryptography.CryptoConfig.CreateFromName(DeformatterAlgorithm);
            asymmetricSignatureDeformatter.SetKey(key);
            asymmetricSignatureDeformatter.SetHashAlgorithm("SHA1");
            return asymmetricSignatureDeformatter;
        }
    }
}
