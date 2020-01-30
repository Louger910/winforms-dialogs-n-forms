using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm.model
{
    public class Good
    {
        private static int currentId = 0;
        public int Id { get; } = ++currentId;
        public string Title { get; set; }
        public Decimal Price { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}: Id = {Id}, Title = {Title}, Price = {Price}";
        }
    }
}
