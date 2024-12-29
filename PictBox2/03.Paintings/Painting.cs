using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.Paintings
{
    public class Painting
    {
        private string authorName;
        private string paintingName;
        private Image picture;

       

        public string AuthorName { get => authorName; set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                authorName = value;
            }
        }

        public string PaintingName { get => paintingName; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                paintingName = value;
            }
        }

        public Image Picture { get => picture; set => picture = value; }
    }
}
