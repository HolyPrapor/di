﻿namespace TagsCloudVisualization.Core
{
    public class Word
    {
        public string Value;
        public int Amount;

        public Word(string value, int amount)
        {
            Value = value;
            Amount = amount;
        }
    }
}