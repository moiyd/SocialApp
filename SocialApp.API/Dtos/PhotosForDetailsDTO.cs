using System;

namespace SocialApp.API.Dtos
{
    public class PhotosForDetailsDTO
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

    }
}