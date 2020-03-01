﻿using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чтение файла по пути:
            //2. Запись файла в переменную типа string textReaderResult;
            //3. Создания массива типа string arrayOfTextResult путем дробления текста по пробелам;
            //4. Создания массива типа byte imageBytes  длиной равной массива типа string
            //5. Перебор массива типа string в цикле;
            //    5.1 Конвертирование переменной по индексу типа string в byte и запись в переменную  типа byte binary;
            //    5.2 Запись переменных типа byte binary в массив типа byte imageBytes;
            //6. Запись массива типа byte imageBytes в файл image.png;
            //7. Использование метода dispose();


            StreamReader textReader = new StreamReader(@"C:\image\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\image\image.png", imageBytes);
        }
    }
}
