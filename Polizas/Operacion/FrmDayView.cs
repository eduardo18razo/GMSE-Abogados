using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Controls;
using Polizas.Entities;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmDayView : Form
    {
        BusinessCita _bcita = new BusinessCita();
        //List<Appointment> _mAppointments;

        public FrmDayView()
        {
            InitializeComponent();
            avDay.StartDate = DateTime.Now;
            avDay.Renderer = new Office12Renderer();
        }

        private void CargaCitas()
        {
            try
            {
                List<Appointment> _mAppointments = new List<Appointment>();
                List<Cita> citas = _bcita.ObtenerCitas();
                foreach (Cita cita in citas)
                {
                    Appointment app = new Appointment();
                    app.IdCita = cita.Id;
                    app.IdUsuario = cita.IdUsuario;
                    app.IdCliente = cita.IdRegistro;
                    app.StartDate = cita.StartDate;
                    app.EndDate = cita.EndDate;
                    app.BorderColor = Color.FromName(cita.BorderColor);
                    app.Title = cita.Text;
                    _mAppointments.Add(app);
                }
                avDay.DataSource = _mAppointments;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmDayView_Load(object sender, EventArgs e)
        {
            try
            {
                //_mAppointments = new List<Appointment>();
                CargaCitas();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void avDay_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (avDay.Selection == SelectionType.DateRange)
                    if (Mensajes.Confirmacion("¿Crear cita?"))
                    {
                        FrmNuevaCita frmNuevaCita = new FrmNuevaCita();
                        frmNuevaCita.Cita = new Cita();
                        frmNuevaCita.Cita.StartDate = avDay.SelectionStart;
                        frmNuevaCita.Cita.EndDate = avDay.SelectionEnd;
                        frmNuevaCita.Cita.BorderColor = Color.Red.Name;
                        frmNuevaCita.StartPosition = FormStartPosition.CenterParent;
                        if (frmNuevaCita.ShowDialog(this) == DialogResult.OK)
                        {

                            Appointment m_App = new Appointment();
                            m_App.StartDate = avDay.SelectionStart;
                            m_App.EndDate = avDay.SelectionEnd;
                            m_App.BorderColor = Color.Red;
                            m_App.IdUsuario = frmNuevaCita.Cita.IdUsuario;
                            m_App.IdCliente = frmNuevaCita.Cita.IdRegistro;
                            m_App.Title = frmNuevaCita.Cita.Text;
                            //_mAppointments.Add(m_App);
                            CargaCitas();

                            avDay.Invalidate();
                            avDay.Focus();
                        }
                    }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void avDay_ResolveAppointments(object sender, ResolveAppointmentsEventArgs args)
        {
            try
            {
                //List<Appointment> mApps = _mAppointments.Where(mApp => (mApp.StartDate >= args.StartDate) && (mApp.StartDate <= args.EndDate)).ToList();
                //List<Appointment> mApps = _mAppointments.Where(mApp => (mApp.StartDate >= args.StartDate) && (mApp.StartDate <= args.EndDate)).ToList();
                args.Appointments = avDay.DataSource;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                avDay.StartDate = monthCalendar1.SelectionStart;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

    }
}
