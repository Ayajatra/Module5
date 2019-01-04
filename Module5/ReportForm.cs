using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Module5
{
    public partial class ReportForm : CoreForm
    {
        private Session5Entities db = new Session5Entities();
        private List<AminetiesReport> reports = new List<AminetiesReport>();

        public ReportForm()
        {
            InitializeComponent();
            dtpTo.MinDate = dtpFrom.Value.AddDays(1);
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            //rv.RefreshReport();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value.AddDays(1);
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            var q = db.Schedules.Where(x =>
                x.Confirmed &&
                (x.FlightNumber == txtFlightId.Text || txtFlightId.Text == "") &&
                x.Date >= dtpFrom.Value &&
                x.Date <= dtpTo.Value
            ).SelectMany(x => x.Tickets)
            .Where(x => x.Confirmed).ToList();

            var booked = q.SelectMany(x => x.AmenitiesTickets).Select(x => new AminetiesReport
            {
                Amenities = x.Amenity.Service,
                CabinType = x.Ticket.CabinType.Name,
                Total = 1
            }).ToList();

            var included = q.SelectMany(x => x.AmenitiesTickets).Select(x => new AminetiesReport
            {
                Amenities = x.Amenity.Service,
                CabinType = x.Ticket.CabinType.Name,
                Total = 1
            }).ToList();

            reports.Clear();
            reports.AddRange(booked);
            reports.AddRange(included);
            LoadData();
        }

        private void LoadData()
        {
            if (reports.Count > 0)
            {
                rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet", reports));
                rv.RefreshReport();
            }
            else
            {
                MessageBox.Show("Cannot find any Flights between that date");
            }
        }
    }

    public class AminetiesReport
    {
        public string Amenities { get; set; }
        public string CabinType { get; set; }
        public int Total { get; set; }
    }
}