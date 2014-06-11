﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.MainDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class MainDataSource { }
#else

	public class MainDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MainDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("/Sesion3;component/SampleData/MainDataSource/MainDataSource.xaml", UriKind.RelativeOrAbsolute);
				System.Windows.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Jugadores _Jugadores = new Jugadores();

		public Jugadores Jugadores
		{
			get
			{
				return this._Jugadores;
			}
		}

		private JugadorSeleccionado _JugadorSeleccionado = new JugadorSeleccionado();

		public JugadorSeleccionado JugadorSeleccionado
		{
			get
			{
				return this._JugadorSeleccionado;
			}

			set
			{
				if (this._JugadorSeleccionado != value)
				{
					this._JugadorSeleccionado = value;
					this.OnPropertyChanged("JugadorSeleccionado");
				}
			}
		}
	}

	public class Jugadores : System.Collections.ObjectModel.ObservableCollection<JugadoresItem>
	{ 
	}

	public class JugadoresItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Nombre = string.Empty;

		public string Nombre
		{
			get
			{
				return this._Nombre;
			}

			set
			{
				if (this._Nombre != value)
				{
					this._Nombre = value;
					this.OnPropertyChanged("Nombre");
				}
			}
		}

		private System.Windows.Media.ImageSource _Foto = null;

		public System.Windows.Media.ImageSource Foto
		{
			get
			{
				return this._Foto;
			}

			set
			{
				if (this._Foto != value)
				{
					this._Foto = value;
					this.OnPropertyChanged("Foto");
				}
			}
		}

		private bool _Descubierto = false;

		public bool Descubierto
		{
			get
			{
				return this._Descubierto;
			}

			set
			{
				if (this._Descubierto != value)
				{
					this._Descubierto = value;
					this.OnPropertyChanged("Descubierto");
				}
			}
		}

		private string _Respuesta = string.Empty;

		public string Respuesta
		{
			get
			{
				return this._Respuesta;
			}

			set
			{
				if (this._Respuesta != value)
				{
					this._Respuesta = value;
					this.OnPropertyChanged("Respuesta");
				}
			}
		}
	}

	public class JugadorSeleccionado : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private Pistas _Pistas = new Pistas();

		public Pistas Pistas
		{
			get
			{
				return this._Pistas;
			}
		}

		private string _Respuesta = string.Empty;

		public string Respuesta
		{
			get
			{
				return this._Respuesta;
			}

			set
			{
				if (this._Respuesta != value)
				{
					this._Respuesta = value;
					this.OnPropertyChanged("Respuesta");
				}
			}
		}

		private System.Windows.Media.ImageSource _Foto = null;

		public System.Windows.Media.ImageSource Foto
		{
			get
			{
				return this._Foto;
			}

			set
			{
				if (this._Foto != value)
				{
					this._Foto = value;
					this.OnPropertyChanged("Foto");
				}
			}
		}
	}

	public class Pistas : System.Collections.ObjectModel.ObservableCollection<PistasItem>
	{ 
	}

	public class PistasItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Descripcion = string.Empty;

		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}

			set
			{
				if (this._Descripcion != value)
				{
					this._Descripcion = value;
					this.OnPropertyChanged("Descripcion");
				}
			}
		}

		private string _Valor = string.Empty;

		public string Valor
		{
			get
			{
				return this._Valor;
			}

			set
			{
				if (this._Valor != value)
				{
					this._Valor = value;
					this.OnPropertyChanged("Valor");
				}
			}
		}
	}
#endif
}
