using System.Collections.Generic;

namespace DefaultModelBinderForN00bs.Models.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person Friend { get; set; }
        public Address[] Addresses { get; set; }
    }
}
