﻿namespace BlazorPokedexCourse.Models
{
    public class PaginationButton
    {
        public string Text { get; set; } = null!;
        public int Page { get; set; }
        public bool Enabled { get; set; }
        public bool Active { get; set; }

        public PaginationButton(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }
    }
}
