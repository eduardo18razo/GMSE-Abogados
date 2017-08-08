/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System.Windows.Forms;

namespace Polizas.Controls
{
    public interface ITool
    {
        DayView DayView
        {
            get;
            set;
        }

        void Reset();

        void MouseMove( MouseEventArgs e );
        void MouseUp( MouseEventArgs e );
        void MouseDown( MouseEventArgs e );
    }
}
