using System;
using System.Collections.Generic;
using Shop.Services.Interfaces;

namespace Shop.Services.Implementation
{
    public class SmartPhraseGenerator : ISmartPhraseGenerator
    {
        private static readonly List<string> Phrases = new List<string>
        {
            "Сила в знаниях.",
            "Мудрость приходит с опытом.",
            "Искусство управления временем.",
            "Учиться никогда не поздно.",
            "Будущее зависит от того, что вы делаете сегодня."
        };

        private readonly Random _random;

        public SmartPhraseGenerator()
        {
            _random = new Random();
        }

        public string GetSmartPhrase()
        {
            int index = _random.Next(Phrases.Count);
            return Phrases[index];
        }
    }
}
