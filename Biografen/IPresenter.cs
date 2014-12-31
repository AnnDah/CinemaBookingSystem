using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biografen
{
    public interface IPresenter
    {
        void Start();

        void CheckNumberOfSeats();
    }
}
