﻿using System;
using System.IO;
using Console = System.Console;

namespace TagsCloudVisualization.Text
{
    public class PosTagger : IPosTagger
    {
        private readonly string pathToModel;

        public PosTagger(string pathToModel)
        {
            this.pathToModel = pathToModel;
        }

        public void GetPartOfSpeech(string word)
        {
        }
    }
}