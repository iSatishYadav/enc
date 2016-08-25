using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enc.Models
{
    public class Encrypto
    {
        public string PublicKey
        {
            get
            {
                return "<RSAKeyValue><Modulus>luQ2n5PgsCg0t3o5R8KM9ObdesGQaH+sYijf0P6cV8QgGEszPp6OUf7+7+vy/B9lRU3DXIWBt5+4sKg92FrBlVBXpLNtw03uG7it5r3AWyJ8DjVyeRRaINRkF5Dpxy6csC2rIm1PN7ZioTBezAGob0e1zGk68fsuZpC63bY4ZnTJK1CtxmwVryiaEVkMvfz0iwdXWCacWEJO952ANK70L4sHuZQHA1NVMZCfKI2RgkR55B58iT6ez0mgqVsnj9QZqLT7a+WJbFpj5ZzNW66ttyO7s196uc9F0VC8eWSobikPXvfyvEs7Zu6/XTR5oX1B/gEnSuox7m3lKPleHBcDujLLNYRK2nDCoECtoKOSOxCvnDtYhovsTWKSvD+q0WRMvfGLMS8PC6vmFlv9nYAukp92bbanZ157YX0ZKw7sVJ+Vbfhd+/+UEJGui2Hp2WmKDkTBIvIEsZs0jToSqiQMtDzKREKuMW2q2KXsyWMRGlH51QjgWH4UWCeoEApV5LgHmM7vnZpTCw5xRH/xAe+HnRJpzZz9AWwLPNAndL/XgRFwtwaoSB9GGIXn0YUdnLbxNgHcDAay2rll12r/cDw+5NgMvFEgdMwGQmXXcm5LFFsseRD3ZtSQncbpGWgjUX303550i8VzE3ruV+yP62qDI08fvvT1hj5KmEkinEqFlIk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            }
        }

        public string PrivateKey
        {
            get
            {
                return "<RSAKeyValue><Modulus>luQ2n5PgsCg0t3o5R8KM9ObdesGQaH+sYijf0P6cV8QgGEszPp6OUf7+7+vy/B9lRU3DXIWBt5+4sKg92FrBlVBXpLNtw03uG7it5r3AWyJ8DjVyeRRaINRkF5Dpxy6csC2rIm1PN7ZioTBezAGob0e1zGk68fsuZpC63bY4ZnTJK1CtxmwVryiaEVkMvfz0iwdXWCacWEJO952ANK70L4sHuZQHA1NVMZCfKI2RgkR55B58iT6ez0mgqVsnj9QZqLT7a+WJbFpj5ZzNW66ttyO7s196uc9F0VC8eWSobikPXvfyvEs7Zu6/XTR5oX1B/gEnSuox7m3lKPleHBcDujLLNYRK2nDCoECtoKOSOxCvnDtYhovsTWKSvD+q0WRMvfGLMS8PC6vmFlv9nYAukp92bbanZ157YX0ZKw7sVJ+Vbfhd+/+UEJGui2Hp2WmKDkTBIvIEsZs0jToSqiQMtDzKREKuMW2q2KXsyWMRGlH51QjgWH4UWCeoEApV5LgHmM7vnZpTCw5xRH/xAe+HnRJpzZz9AWwLPNAndL/XgRFwtwaoSB9GGIXn0YUdnLbxNgHcDAay2rll12r/cDw+5NgMvFEgdMwGQmXXcm5LFFsseRD3ZtSQncbpGWgjUX303550i8VzE3ruV+yP62qDI08fvvT1hj5KmEkinEqFlIk=</Modulus><Exponent>AQAB</Exponent><P>uEY8vemGYICG7/vez6UKFb6ZHVGRU9DohT/e+9zdXPameRv9oD2dlWn6h4N6UiGrAWs5cQOinwFH21OhzECPQ+xA/zX3Kz8m0kIb0NBjPjIWU3g3O42o4nSRPMRgqNR/AAIQAfoBrZcul0YgGgbsJXZ+Km+bGqupSueTFUDUjCqC2IHWCxpgPIOkDNTWnBDYgBorJrxIOeAqKKD2SlbJhZLtZSWO0lIJTjcCY2LDHzdXKUKQo8od9KH0OnSCwxyt50tDvY9ldN3cZH/7yrSIlPI/3gryhKcqyNwF+3eACC91ORreNO4/Ad55XicUSHC/iNkbhMyUHe3HyaksUZetjw==</P><Q>0Z+VN3c8uBCcZUp1t6eA5uxSyaJygQTLcdbah1LfEtqY4y8DfdHlYA0diIatXnEe2P8Yhm47kVqDcZUs4vKWo4hIW3sUejXM+bNuivNPr553J4LyvZHEDMuJomeNz/YX7jC/mZKP7EuCEBv1VGDuXgE+GwxWDXhaqUesPdUYAGHCE6GYKrHQmtkGY4XLYvRjyWhX3Ow/tHuo/VTKV9c7POtsDQp7kBiOun/E2vaLLXvIId6lH109BnUr83IqRZx3/NpvUEjEWEjroBI4sJLwIQcvk+LpvXjB+fbKnabm5wc7kk86/gGDlmZ7GUzw3Qz37AvX53rKz1IREcFuW7VAZw==</Q><DP>iV8S+SCVpGssLMs/FtyZ4AvuaQTdqfYa4Pr0aB4Gh77362EKeeJ1D2Wp9kv1bDTdHnmooK9tE8wInWCDRZj7NE9zRM4eLIcvkZ7mzYwL79m2+xKrWiIIvIjZnMtoo3OGGaNv+4k8pwQFH5CPbderQ2JKO6hnoEJIOibYZwela7hlQrHHtw86nuIj8czZEA8e1qCrenzx+vM5eoBEGrcIFCOsBbMx/What4wao6yEeUjwGToeSXvrSOtS/iDNOlau7bYWEcJMiAq8uc8PDdX329Gb+xN+J5XXN1WOwCAdufxnDuMQs7TIE8SeBapsXHRw1LvE4AMCiC0yuwr6lvjT0Q==</DP><DQ>Wy/9fERdYICxWAq9DKhMFahGFzqYbvGEAsCBDY8KRSxch69i6G/PRSpPZ52We1fgIGtP4uK+/OsP9O/8t7jpuLfHKixvav5ObW0VsFJJns7jbIe1SqvHSf2coM5FTWrzXAVOw+KSwyrRqGpRHWSRLMmDl8aVBIUPg0YPclJpf3kHMP0BscjqQwIXmmGQaTqA0hOW7R7EU6HbkGA7KV0SgtyygzXFLJjSNeTw4IORZbbMB5fP4sXvjwiXlu5Z3zBCrfbjp1wQNYt7HIXwrTcuSF/U3ZM/NNH8J92opE3/cg6eZnYa5nYIJPvtnsLuoGpMyx0XzbWH1goQLNYlSLWfDw==</DQ><InverseQ>BTQazxSCnnoCISyqK6ZE7D+qNGc1a/k5h4wZBrdTG1w5lSUZmfHI8NMFmLnHkhjvFssRTjvv55kF1L8K9mdkqrB9+GCv7JdMvLZYCB01VUTPI5j2kRxbV+mw3LuB82BI0qdv/8vonF1sQZka1WAZciGbRyOxyQ4wOCaOKr+AslXquw7AdVAPIfXSmqU0vjrx+mZEcHmdCf3VG1LysCWBsteb68BMs+lxnN1OZ0fxj8cH07aKRDvhDQxW0WzDkPbD8I/ZzbrOszUQg8ss+T7w1VuZlWvdLjs8ijemftk5pw/LA2qvvOcHdio78mdbIqhjpLo+L4yoDVsND5xiO7xpNg==</InverseQ><D>MwOTCB6Jz2S4dfOnnABFgaLv7Em21e2cTU9+Y/1AxFd1dmEuQRSAD27DqD/AVccTiPvCeexVL8ybN3aZ+iSs4Btalj9nc6lMQCkO+jza5LTi9jbRrefYlNLZyDHhJ8s1hEbcXfZQ2wgZjl95HUXOOVkoOKS3HgqK5Hg4BS9PICyJutA7ACOYrTBv7j+KFE2KK9reh9n978TzR7oDF0yzF8PMZ8yJFnG9EtXPSXmbYUxfXWWFOy1lqbU90SQVWwYdarFNc2wWKwDgV0fNEhsbdhhppDo6lslh1GOUZQJIA350SOpRMaHJwoIjRpKwMI3Vmteu/h/xo6eZ22F7lMmfI3ZOn3s4342cpZw8vzmrwdzyvN67YIof5Ny2/4HTpwEFI4W4PsfwbLspCWaKOCFpjNY5wsPBiNCEM1W1c/WU+RudW02Ho3cEn8ilRJhcm5Qm4kjVWthjQvVT3rmm2noLDzd78x9yOcPzHrprEG4+LmlWCKM+tcUTTJReW0opIXEp7/F0kO1OvkXy/Cca8vKwUaJ6t/jg23ZHsNSumzOQEovqWwMQJ+dK2sT4qH3GbrByr2E2B6ysZBLmMANC9PPdWvLBAJuzvE8xJQHv1ALuDFgsyirvod7ipKY6FoGPKvH5kIEfPh8UsGsBU7PLK+3X6F/OkvNx1a8LkC67ECikd4U=</D></RSAKeyValue>";
            }
        }
        public string Encrypt(string plainText, string publicKey, bool padding)
        {
            var plainBytes = System.Text.Encoding.ASCII.GetBytes(plainText);
            using (var rsa = new System.Security.Cryptography.RSACryptoServiceProvider(4096))
            {
                rsa.FromXmlString(publicKey);
                var cipherBytes = rsa.Encrypt(plainBytes, padding);
                var cipherText = Convert.ToBase64String(cipherBytes);
                return cipherText;
            }
        }

        public string Decrypt(string cipherText, string privateKey, bool padding)
        {
            var cipherBytes = Convert.FromBase64String(cipherText);
            using (var rsa = new System.Security.Cryptography.RSACryptoServiceProvider(4096))
            {
                rsa.FromXmlString(privateKey);
                var plainBytes = rsa.Decrypt(cipherBytes, padding);
                var plainText = System.Text.Encoding.ASCII.GetString(plainBytes);
                return plainText;
            }
        }
    }
}