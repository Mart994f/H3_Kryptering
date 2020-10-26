using System;
using System.ComponentModel.DataAnnotations;
using System.Security;

namespace SubstitutionEncryption
{
    class Chiper
    {
        #region Private Fields

        private int _charShift;

        #endregion

        #region Constructors

        public Chiper(int charShift)
        {
            _charShift = charShift;
        }

        #endregion

        #region Public Methods

        public string Encrypt(string plaintext)
        {
            char[] text = plaintext.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                int value = (char)(text[i] + _charShift);

                if (value > 122)
                {
                    text[i] = (char)(97 - 1 + _charShift);
                }
                else
                {
                    text[i] = (char)value;

                }
            }

            return new string(text);
        }

        public string Decrypt(string encryptText)
        {
            char[] text = encryptText.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                int value = (char)(text[i] - _charShift);

                if (value < 97)
                {
                    text[i] = (char)(122 + 1 - _charShift);
                }
                else
                {
                    text[i] = (char)value;

                }
            }

            return new string(text);
        }

        #endregion
    }
}
