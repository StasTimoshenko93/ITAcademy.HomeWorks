using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  3 примера неявного преобразования типов
            byte byteToInt = 5;
            int byteToInt1 = byteToInt;

            float floatToDouble = 2.5f;
            double floatToDouble1 = floatToDouble;

            int intToDecimal = 124567;
            decimal intToDecimal1 = intToDecimal;

            Console.WriteLine($"byteToInt1 : {byteToInt1}; floatToDouble1 : {floatToDouble1}; " +
                $"intToDecimal1 : {intToDecimal1}; ");
            #endregion

            #region 3 примера явного преобразования типов

            int intToByte = 5;
            byte intToByte1 = (byte)intToByte;

            short shortToSbyte = 231;
            sbyte shortToSbyte1 = (sbyte)shortToSbyte;

            long longToInt = 65432;
            int longToint1 = (int)longToInt;

            Console.WriteLine($"intToByte1 : {intToByte1}; shortToSbyte1 : {shortToSbyte1}; " +
               $"longToint1 : {longToint1}; ");
            #endregion

            #region 3 примера операции упаковки(boxing)
            byte byteValueBox = 5;
            object byteValueBox1 = byteValueBox;

            char charValueBox = '1';
            object charValueBox1 = charValueBox;

            int intValueBox = 22;
            object intValueBox1 = intValueBox;
            #endregion

            #region 3 примера операции распоковки(unboxing)
            byte byteValueUnBox = (byte)byteValueBox1;

            char charValueUnBox = (char)charValueBox1;

            int intValueUnBox = (int)intValueBox1;
            #endregion

            #region int to short, boolean to byte; char to int;
            //Пример с упаковкой int типа и распаковкой в ushort тип

            int value = 10;

            object value1 = value;

            ushort value2 = (ushort)(int)value1;

            //Пример с упаковкой Логического типа и распаковой в byte тип

            bool boolValue = false;

            object boolValue1 = boolValue;

            byte boolValue2 = Convert.ToByte(boolValue1);
            

            //Пример с упаковкой char типа и распаковкой в int тип

            char charValue = '4';

            string charValue1 = charValue.ToString();

            int charValue2 = Convert.ToInt32(charValue1);

            Console.WriteLine($"int to short {value2}");
            Console.WriteLine($"boolean to byte {boolValue2}");
            Console.WriteLine($"char to int {charValue2}");
            #endregion
        }
    }
}
