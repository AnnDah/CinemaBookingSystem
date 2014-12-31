using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biografen
{
    public interface IView
    {
        Model Model { get; set; }

        void AttachPresenter(IPresenter presenter);
    }
}