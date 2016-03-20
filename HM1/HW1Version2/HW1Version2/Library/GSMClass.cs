namespace HW1Version2.Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSMClass
    {
        #region Fields

        private static GSMClass iPhone4S;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        #endregion

        # region Constructor

        static GSMClass()
        {
            iPhone4S = new GSMClass ("IPhone 4 S", "Apple", 1450.56m, "Evstati", new Battery (), new Display ());
        }
        
      //public GSMClass(string model,string manufacturer,decimal? price = null, string owner = null, Battery battery = null, Display display = null)
      //    :this (model, manufacturer)
      //{
      //        
      //}

        public GSMClass(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSMClass(string model, string manufacturer, decimal? price)
            : this (model, manufacturer)
        {
            this.Price = price;
        }

        public GSMClass(string model, string manufacturer, string owner)
            : this (model,manufacturer)
        {
            this.Owner = owner;
        }
        public GSMClass(string model, string manufacturer, decimal? price, string owner)
            : this (model, manufacturer, owner)
        {
            this.Price = price;
        }
        public GSMClass(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
            :this (model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }
        #endregion

        #region Properties

        public static GSMClass IPhone4S { get { return iPhone4S; } }

        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }

            set 
            {
                if (this.callHistory== null)
                {
                    this.callHistory = new List<Call>();
                }
                this.callHistory.Clear();

                this.callHistory = value;
            }
        }
        public Display Display 
        {
            get {return display ;} 
          set
          {
              if (value==null)
              {
                  throw new ArgumentException();
              }

              this.display = value;
          }
        }

        public Battery Battery 
        {
            get {return battery ;} 
          
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }

                this.battery = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Insert name's owner.");
                }
                this.owner = value; 
                }
        }
        

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentException("Please, insert price.");
                }

                this.price = value; 
                }
        }
        

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please, insert who is manufacture on this phone.");
                } 

                this.manufacturer = value; 
                }
        }
        

        public string Model
        {
            get { return this.model; 
                }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please, insert who model is this phone.");
                }

                this.model = value; 
                }
        }
        #endregion

        #region Metods

        public void AddCall(Call call)

        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)

        {
            this.CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalCost(decimal fixedPrice)

        {
            ulong totalDuration=0;

            foreach (Call call in this.CallHistory)
            {
                totalDuration += (ulong)call.Duration;
            }

            return fixedPrice * (decimal)(totalDuration / 60);
        }

        public override string ToString()
        {
            StringBuilder add = new StringBuilder();

            add.AppendLine(string.Format("Model: {0}", this.model));
            add.AppendLine(string.Format("Manufacturer: {0}", this.manufacturer));
            add.AppendLine(string.Format("Price: {0}", this.price));
            add.AppendLine(string.Format("Owner: {0}", this.owner));
            add.AppendLine(string.Format("Battery: {0}", this.battery));
            add.AppendLine(string.Format("Display: {0}", this.display));

            return add.ToString();
        }


        #endregion

    }
}
