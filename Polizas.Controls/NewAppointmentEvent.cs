/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System;

namespace Polizas.Controls
{
    public class NewAppointmentEventArgs : EventArgs
    {
        public NewAppointmentEventArgs( string title, DateTime start, DateTime end, Int64 idCita )
        {
            Title = title;
            _mStartDate = start;
            _mEndDate = end;
            IdCita = idCita;
        }

        public string Title { get; private set; }

        private DateTime _mStartDate;

        public DateTime StartDate
        {
            get { return _mStartDate; }
        }

        private DateTime _mEndDate;

        public DateTime EndDate
        {
            get { return _mEndDate; }
        }

        public long IdCita { get; private set; }
    }

    public delegate void NewAppointmentEventHandler( object sender, NewAppointmentEventArgs args );
}
