using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomiyuq
{
   public interface IPerson
    {
        public string FulName { get; set; }
        public int Id { get; set; }
        public void Olish()
        {
            FulName = this.FulName;
            Id = this.Id;
        }
    }
}
