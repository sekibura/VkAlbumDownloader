using System;
using System.Collections.Generic;
using System.Text;
using VkNet.Enums.SafetyEnums;

namespace VkAlbumDownloader
{
    class AlbumAddress
    {
        public Int64 OwnerId { get; set; }
        public string AlbumId { get; set; }


        public PhotoAlbumType GetPhotoAlbum
        {
            get 
            {
                switch (AlbumId)
                {
                    case "0": return PhotoAlbumType.Profile;
                    case "00": return PhotoAlbumType.Wall;
                    case "000": return PhotoAlbumType.Saved;
                }

                return PhotoAlbumType.Id(Convert.ToInt64(AlbumId)); 
            }
        }

        public bool isDefaultAlbum()
        {
            return AlbumId != "0" && AlbumId != "00" && AlbumId != "000";
        }

        public string GetAlbumName()
        {
            string name = "";
            switch (AlbumId)
            {
                case "0": name = "Фотографии со страницы";
                    break;
                case "00": name = "Фотографии на стене";
                    break;
                case "000": name = "Сохраненные фотографии";
                    break;
            }
            return name;
        }

    }
}
