using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biografen
{
    public class Presenter : IPresenter
    {
        private readonly IView iView;

        public Presenter(IView view)
        {
            this.iView = view;
        }

        public void Start()
        {
            iView.AttachPresenter(this);
        }

        public void CheckNumberOfSeats()
        {
            var model = iView.Model;

            // Kod för att göra diverse saker...

        }
    }
} 
