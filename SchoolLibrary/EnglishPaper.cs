﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class EnglishPaper
    {
            public string Title { get; set; }
            public int MinimumWordCount { get; set; }
            public string paperText { get; set; }
            public int WordCount
            {
                get { return paperText.WordCount(); }

            }
        
    }
}
