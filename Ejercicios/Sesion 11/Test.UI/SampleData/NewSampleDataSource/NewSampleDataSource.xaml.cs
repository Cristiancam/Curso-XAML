﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.NewSampleDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class NewSampleDataSource { }
#else

	public class NewSampleDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public NewSampleDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("/Test.UI;component/SampleData/NewSampleDataSource/NewSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
				System.Windows.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Events _Events = new Events();

		public Events Events
		{
			get
			{
				return this._Events;
			}
		}

		private string _TotalPoints = string.Empty;

		public string TotalPoints
		{
			get
			{
				return this._TotalPoints;
			}

			set
			{
				if (this._TotalPoints != value)
				{
					this._TotalPoints = value;
					this.OnPropertyChanged("TotalPoints");
				}
			}
		}

		private NewEvent _NewEvent = new NewEvent();

		public NewEvent NewEvent
		{
			get
			{
				return this._NewEvent;
			}

			set
			{
				if (this._NewEvent != value)
				{
					this._NewEvent = value;
					this.OnPropertyChanged("NewEvent");
				}
			}
		}

		private string _ClearCommand = string.Empty;

		public string ClearCommand
		{
			get
			{
				return this._ClearCommand;
			}

			set
			{
				if (this._ClearCommand != value)
				{
					this._ClearCommand = value;
					this.OnPropertyChanged("ClearCommand");
				}
			}
		}
	}

	public class EventsItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private bool _Points = false;

		public bool Points
		{
			get
			{
				return this._Points;
			}

			set
			{
				if (this._Points != value)
				{
					this._Points = value;
					this.OnPropertyChanged("Points");
				}
			}
		}
	}

	public class Events : System.Collections.ObjectModel.ObservableCollection<EventsItem>
	{ 
	}

	public class NewEvent : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Points = string.Empty;

		public string Points
		{
			get
			{
				return this._Points;
			}

			set
			{
				if (this._Points != value)
				{
					this._Points = value;
					this.OnPropertyChanged("Points");
				}
			}
		}

		private string _Description = string.Empty;

		public string Description
		{
			get
			{
				return this._Description;
			}

			set
			{
				if (this._Description != value)
				{
					this._Description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}

		private string _SaveCommand = string.Empty;

		public string SaveCommand
		{
			get
			{
				return this._SaveCommand;
			}

			set
			{
				if (this._SaveCommand != value)
				{
					this._SaveCommand = value;
					this.OnPropertyChanged("SaveCommand");
				}
			}
		}
	}
#endif
}
