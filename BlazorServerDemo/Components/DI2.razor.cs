using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Components
{
    public partial class DI2
    {
        [Inject]
        public MCronberg.IPersonRepository Rep { get; set; }

        [Parameter]
        public int Antal { get; set; } = 5;

        public List<MCronberg.Person> Personer
        {
            get
            {
                return Rep.GetPeople(Antal);
            }
        }
    }
}
