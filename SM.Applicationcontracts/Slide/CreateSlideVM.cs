﻿using System;

namespace SM.Applicationcontracts.Slide
{
    public class CreateSlideVM
    {
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string BtnText { get; set; }
        public string Link { get; set; }
        public DateTime CreationDate{ get; set; }

    }
}
