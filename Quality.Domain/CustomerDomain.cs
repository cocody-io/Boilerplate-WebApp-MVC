using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto = Quality.DataAccess;

namespace Quality.Domain
{
    public class CustomerDomain
    {
        public string Name;

        public int CustomerId { get; set; }

        public CustomerDomain(Dto.Customer customerDto)
        {
            if (customerDto == null) return;
            this.Name = customerDto.Name;
        }
    }
}
