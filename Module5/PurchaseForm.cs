using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5
{
    public partial class PurchaseForm : CoreForm
    {
        // The datetime is supposed to be today
        // But because the flight is only on 2017 10 04 - 2017 10 27
        // the datetime will be set to 2017 10 05
        private DateTime datetime = new DateTime(2017, 10, 5);

        private Session5Entities db = new Session5Entities();
        private List<FlightList> f = new List<FlightList>();
        private List<Ticket> tickets = new List<Ticket>();
        private Ticket ticket = new Ticket();
        private Timer timer = new Timer();
        private decimal lastPay = 0;

        public PurchaseForm()
        {
            InitializeComponent();
            LoadAmenities();
            timer.Start();
            timer.Tick += timer_Tick;
        }

        // Uses timer_Tick because ItemCheck is not reliable
        private void timer_Tick(object sender, EventArgs e)
        {
            decimal value = 0;
            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clb.GetItemChecked(clb.Items.IndexOf(clb.Items[i].ToString())) && clb.Items[i].ToString() != "Soft Drinks (Free)" && clb.Items[i].ToString() != "Wi-Fi 50 mb (Free)")
                {
                    int startIndex = clb.Items[i].ToString().IndexOf('$');
                    int endIndex = clb.Items[i].ToString().IndexOf(')');
                    string data = clb.Items[i].ToString().Substring(startIndex, endIndex - startIndex);
                    value += int.Parse(data.TrimStart('$'));
                }

                if (clb.Items[i].ToString() == "Soft Drinks (Free)" || clb.Items[i].ToString() == "Wi-Fi 50 mb (Free)")
                {
                    clb.SetItemChecked(clb.Items.IndexOf(clb.Items[i]), true);
                }
            }

            if (lastPay == 0)
            {
                labelItems.Text = value.ToString("C2");
                labelDuties.Text = (value * 5 / 100).ToString("C2");
                labelTotal.Text = (value + value * 5 / 100).ToString("C2");
            }
            else
            {
                labelItems.Text = (value - lastPay).ToString("C2");
                labelDuties.Text = ((value * 5 / 100) - (lastPay * 5 / 100)).ToString("C2");
                labelTotal.Text = ((value + value * 5 / 100) - (lastPay + lastPay * 5 / 100)).ToString("C2");
            }
        }

        private void LoadAmenities()
        {
            var q = db.Amenities.ToList();
            foreach (var i in q)
            {
                clb.Items.Add($"{i.Service} ({SetPrice((int)i.Price)})");
            }
        }

        private string SetPrice(int value)
        {
            return value == 0 ? "Free" : $"${value}";
        }

        private void txtBookingReference_TextChanged(object sender, EventArgs e)
        {
            if (txtBookingReference.Text != "")
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }

        private void Reset()
        {
            gbxFlightList.Enabled = false;
            gbxAmenities.Enabled = false;
            btnSave.Enabled = false;
            cbChoose.DataSource = null;

            labelFullName.Text = "[xxxx xxxx]";
            labelCabinClass.Text = "[xxxx xxxx]";
            labelPassportNumber.Text = "[xxxx xxxx]";
            labelItems.Text = "[$xx]";
            labelDuties.Text = "[$xx]";
            labelTotal.Text = "[$xx]";
            f.Clear();

            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(clb.Items.IndexOf(clb.Items[i]), false);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tickets = db.Tickets
                .Where(x => x.BookingReference == txtBookingReference.Text)
                .ToList()
                .Where(x => x.Schedule.Date.Add(x.Schedule.Time).Subtract(datetime) >= new TimeSpan(24, 0, 0))
                .ToList();

            Reset();

            if (tickets.Count > 0)
            {
                f = tickets.Select(x => new FlightList
                {
                    ID = x.ID,
                    FlightNumber = x.Schedule.FlightNumber,
                    Departure = x.Schedule.Route.Airport.IATACode,
                    Arrival = x.Schedule.Route.Airport1.IATACode,
                    Date = x.Schedule.Date,
                    Time = x.Schedule.Time,
                    Confirmed = x.Confirmed
                }).ToList();

                cbChoose.ValueMember = "ID";
                cbChoose.DisplayMember = "Data";
                cbChoose.DataSource = f;
                gbxFlightList.Enabled = true;
            }
            else
            {
                MessageBox.Show("Booking reference not found or maybe had already expired!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ticket = tickets.First(x => x.ID == int.Parse(cbChoose.SelectedValue.ToString()));
            if (ticket.Confirmed)
            {
                labelFullName.Text = $"{ticket.User.FirstName} {ticket.User.LastName}";
                labelCabinClass.Text = ticket.CabinType.Name;
                labelPassportNumber.Text = ticket.PassportNumber;

                gbxAmenities.Enabled = true;
                btnSave.Enabled = true;

                var amenities = db.AmenitiesTickets
                    .Where(x => x.TicketID == ticket.ID)
                    .Select(x => new {
                        x.Amenity.Service,
                        x.Price
                    }).ToList();

                lastPay = amenities.Count > 0 ? amenities.Sum(x => x.Price) : 0;

                for (int i = 0; i < clb.Items.Count; i++)
                {
                    foreach (var a in amenities)
                    {
                        string[] data = clb.Items[i].ToString().Split(' ');
                        string service = "";
                        for (int j = 0; j < data.Count(); j++)
                        {
                            if (j == data.Count() - 1)
                            {
                                service = service.TrimEnd();
                                continue;
                            }

                            service += data[j] + " ";
                        }
                        if (service == a.Service)
                        {
                            clb.SetItemChecked(clb.Items.IndexOf(clb.Items[i]), true);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Flight is still not confirmed");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var services = new List<string>();
            for (int i = 0; i < clb.CheckedItems.Count; i++)
            {
                if (clb.CheckedItems[i].ToString() == "Soft Drinks (Free)")
                {
                    services.Add("Soft Drinks");
                    continue;
                }

                if (clb.CheckedItems[i].ToString() == "Wi-Fi 50 mb (Free)")
                {
                    services.Add("Wi-Fi 50 mb");
                    continue;
                }

                string[] data = clb.CheckedItems[i].ToString().Split(' ');
                string service = "";
                for (int j = 0; j < data.Count(); j++)
                {
                    if (j == data.Count() - 1)
                    {
                        service = service.TrimEnd();
                        continue;
                    }

                    service += data[j] + " ";
                }

                services.Add(service);
            }

            var s = db.AmenitiesTickets.Where(x => x.TicketID == ticket.ID).ToList();
            foreach (var item in s)
            {
                db.AmenitiesTickets.Remove(item);
                db.SaveChanges();
            }

            foreach (string service in services)
            {
                db.AmenitiesTickets.Add(new AmenitiesTicket
                {
                    AmenityID = db.Amenities.FirstOrDefault(x => x.Service == service).ID,
                    TicketID = ticket.ID,
                    Price = db.Amenities.FirstOrDefault(x => x.Service == service).Price
                });

                db.SaveChanges();
            }

            MessageBox.Show("Success!");
            btnShow_Click(sender, e);
        }
    }

    public class FlightList
    {
        public int ID { get; set; }
        public string FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public bool Confirmed { get; set; }

        public string Data
        {
            get
            {
                return $"{FlightNumber}, {Departure}-{Arrival}, {Date}, {Time}";
            }
        }
    }
}