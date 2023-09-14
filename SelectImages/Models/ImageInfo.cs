using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectImages.Data;

namespace SelectImages.Models
{
    public class ImageInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}
