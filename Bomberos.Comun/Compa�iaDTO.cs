using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberos.Comun
{
    public class CompañiaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PictureSizeComp { get; set; }
        public string PictureNameComp { get; set; }
        public byte[] PictureFileComp { get; set; }
    }
}
