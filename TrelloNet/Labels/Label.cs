using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloNet.Labels
{
    public class Label: ILabelId
    {
        public string Id { get; set; }
        public string IdBoard { get; set; }

        public string Name { get; set; }
        public Color? Color { get; set; }
        public int Uses { get; set; }
        
        public string GetLabelId()
        {
            return Id;
        }
    }
}
