﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı");
        }
    }
}