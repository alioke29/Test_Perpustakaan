using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;
using System.Text;



namespace TestPerpustakaan_VS2019.Library.Utilities
{

    public class PasswordGeneratorV2
    {



        static char[] SYMBOLS = (new String("^$*.[]{}()?-\"!@#%&/\\,><':;|_~`")).ToCharArray();
        static char[] LOWERCASE = (new String("abcdefghijklmnopqrstuvwxyz")).ToCharArray();
        static char[] UPPERCASE = (new String("ABCDEFGHIJKLMNOPQRSTUVWXYZ")).ToCharArray();
        static char[] NUMBERS = (new String("0123456789")).ToCharArray();
        static char[] ALL_CHARS = (new String("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789^$*.[]{}()?-\"!@#%&/\\,><':;|_~`")).ToCharArray();
        static Random rand = new Random();

        public static String getPassword(int length)
        {
            //assset Length >= 8;
            char[] password = new char[length];

            //get the requirements out of the way
            password[0] = LOWERCASE[rand.Next(1, 3)];
            password[1] = UPPERCASE[rand.Next(1, 1)];
            password[2] = NUMBERS[rand.Next(1, 3)];
            password[3] = SYMBOLS[rand.Next(1, 1)];

            //populate rest of the password with random chars
            for (int i = 4; i < length; i++)
            {
                password[i] = ALL_CHARS[rand.Next(ALL_CHARS.Length)];
            }

            //shuffle it up
            for (int i = 0; i < password.Length; i++)
            {
                int randomPosition = rand.Next(password.Length);
                char temp = password[i];
                password[i] = password[randomPosition];
                password[randomPosition] = temp;
            }



            return new String(password);
        }



    }

}
