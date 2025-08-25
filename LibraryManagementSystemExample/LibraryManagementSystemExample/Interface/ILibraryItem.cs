using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemExample.Interface
{
    public interface ILibraryItem
    {
        string GetInfo();
        void Borrow(int days = 14);
        void Return();

    }
}
