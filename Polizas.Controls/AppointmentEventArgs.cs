/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System;

namespace Polizas.Controls
{
    public class AppointmentEventArgs : EventArgs
    {
        public AppointmentEventArgs( Appointment appointment )
        {
            m_Appointment = appointment;
        }

        private Appointment m_Appointment;

        public Appointment Appointment
        {
            get { return m_Appointment; }
        }

    }
}
